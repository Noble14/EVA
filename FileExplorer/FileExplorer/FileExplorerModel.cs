using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileExplorer
{
    class FileExplorerModel
    {
        Dictionary<string, DirectoryInfo> listedDirectories = new Dictionary<string, DirectoryInfo>();
        public void ListDrives()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                string rootPath = drive.RootDirectory.FullName;
                listedDirectories.Add(rootPath,drive.RootDirectory);
                // TODO: esemény kiváltása, amellyel a modell jelzi a nézetnek, hogy az állapota megváltozott

            }
        }
    }
}
