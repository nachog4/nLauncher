using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nLauncher
{
    public static class ShortcutsController
    {
        public static ShortcutInfo GetShortcutInfo(string full_name)
        {
            ShortcutInfo result = new ShortcutInfo();

            try
            {
                if (System.IO.File.Exists(full_name))
                {
                    // WshShellClass shell = new WshShellClass();
                    WshShell shellx = new WshShell(); //Create a new WshShell Interface
                    IWshShortcut link = (IWshShortcut)shellx.CreateShortcut(full_name); //Link the interface to our shortcut
                }

                // Make a Shell object.
                Shell32.Shell shell = new Shell32.Shell();

                // Get the shortcut's folder and name.
                string shortcut_path = full_name.Substring(0, full_name.LastIndexOf("\\"));
                string shortcut_name = full_name.Substring(full_name.LastIndexOf("\\") + 1);
                if (!shortcut_name.EndsWith(".lnk")) shortcut_name += ".lnk";

                // Get the shortcut's folder.
                Shell32.Folder shortcut_folder = shell.NameSpace(shortcut_path);

                // Get the shortcut's file.
                Shell32.FolderItem folder_item = shortcut_folder.Items().Item(shortcut_name);

                if (folder_item == null)
                {
                    result.isError = true;
                    result.ErrorMessage = "Cannot find shortcut file '" + full_name + "'";
                }
                if (!folder_item.IsLink)
                {
                    result.isError = true;
                    result.ErrorMessage = "File '" + full_name + "' isn't a shortcut.";
                }

                // Display the shortcut's information.
                Shell32.ShellLinkObject lnk = (Shell32.ShellLinkObject)folder_item.GetLink;

                result.Name = folder_item.Name;
                result.Description = lnk.Description;
                result.Path = lnk.Path;
                result.WorkingDirectory = lnk.WorkingDirectory;
                result.Args = lnk.Arguments;
                return result;
            }
            catch (Exception ex)
            {
                result.isError = true;
                result.ErrorMessage = ex.Message;
                return result;
            }
        }

        public static void RefreshFolders()
        {
            List<string> folders = new List<string>();
            folders.Add(@"C:\Users\nachog4\Desktop\Gamez\");
            folders.Add(@"C:\Users\nachog4\Desktop\VR Gamez\");

            foreach (var folder in folders)
            {
                string[] filePaths = Directory.GetFiles(folder, "*.lnk",  SearchOption.AllDirectories);

                foreach (var item in filePaths)
                {
                    ShortcutInfo sInfo = GetShortcutInfo(item);
                    if (sInfo != null && !sInfo.isError && !String.IsNullOrEmpty(sInfo.Path))
                    {
                        if (DbController.GetEntries(sInfo.Path).Count() == 0)
                        {
                            var results = ImagesProvider.googleSearch(sInfo.Name + " cover");

                            AppEntry newEntry = new AppEntry();
                            newEntry.Name = sInfo.Name;
                            newEntry.Path = sInfo.Path;
                            newEntry.Image2 = Tools.GetByteFromUrl(results[0].Link);

                            DbController.AddEntry(newEntry);
                        }
                    }
                }
            }

        }
    }

    public class ShortcutInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public string WorkingDirectory { get; set; }
        public string Args { get; set; }
        public bool isError { get; set; }
        public string ErrorMessage { get; set; }
    }

}
