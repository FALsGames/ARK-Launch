using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace Ark_Launch_API
{
    public class API
    {
        public static void LaunchARK()
        {
            Process ark = new Process();
            ark.StartInfo.FileName = "steam://rungameid/346110";
            ark.StartInfo.Arguments = "";
            ark.Start();
        }       
        public static string[] LoadProfile(ref int currentSelection)
        {
            if (File.Exists("profiles.txt"))
            {
                List<string> r = new List<string>();
                string[] sr = File.ReadAllLines("profiles.txt");
                bool profiles = false;
                foreach (string item in sr)
                {
                    if (item == "EndProfilesCode")
                    {
                        if (r.Count == 0)
                        {
                            r.Add("default");
                        }
                        profiles = false;
                    }
 
                    if (profiles)
                    {
                        r.Add(item);
                    }
                    if (item == "ProfilesCode")
                    {
                        profiles = true;
                    }
                    int ze = 0;
                    if (int.TryParse(item, out ze))
                    {
                        currentSelection = ze;
                    }

                }
                return r.ToArray();
            }
            else
            {
                SaveData(new string[0], 0);
                return new string[1] {"default"};
            }
           
        }
        public static void SaveData(string[] items, int current)
        {
                string path = "profiles.txt";
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("ProfilesCode");
                    for (int i = 0; i < items.Length; i++)
                    {
                        sw.WriteLine(items[i]);
                    }
                    if (items.Length == 0)
                    {
                        sw.WriteLine("default");
                    }
                    sw.WriteLine("EndProfilesCode");
                    sw.WriteLine(current);

                } 
        }
        public static void LoadARKProfile(string id)
        {
            CheckIfProfileExist(id);
            CleanupGame("C:/Program Files (x86)/Steam/steamapps/common/ARK/ShooterGame/Saved");
            DirectoryCopy("profiles/" + id ,"C:/Program Files (x86)/Steam/steamapps/common/ARK/ShooterGame/Saved", true);

        }
        public static void CheckIfProfileExist(string id)
        {
            if (!Directory.Exists("profiles/"))
            {
                Directory.CreateDirectory("profiles/");
            }
            if(!Directory.Exists("profiles/" + id))
            {
                Directory.CreateDirectory("profiles/" + id);
                if (id == "default")
                {
                    DirectoryCopy("C:/Program Files (x86)/Steam/steamapps/common/ARK/ShooterGame/Saved", "profiles/default", true);                }
                else
                {
                    
                }
            }
        }
        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "ARK was not found"
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        public static bool ProgrammIsRunning()
        {
            
            Process[] pList = Process.GetProcessesByName("ShooterGame");
            if (pList.Length > 0)
                return true;
            return false;
        }
        public static void BackupSaveGame(string id)
        {
            //Cleanup data
            CleanupBackup(id);
            //Copy data
            DirectoryCopy("C:/Program Files (x86)/Steam/steamapps/common/ARK/ShooterGame/Saved", "profiles/" + id, true);
        }
        static void CleanupBackup(string id)
        {
            DirectoryInfo di = new DirectoryInfo("profiles/" + id);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        static void CleanupGame(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
        public static void DeleteProfile(string id)
        {
            CleanupBackup(id);
            Directory.Delete("profiles/" + id);
        }
        public static bool AppRunning()
        {
            Process[] pList = Process.GetProcessesByName("Ark Launch");
            if (pList.Length > 1)
                return true;
            return false;
        }
   }
    
}
