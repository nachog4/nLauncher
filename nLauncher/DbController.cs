using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace nLauncher
{
    public static class DbController
    {
        public static DbModel model = new DbModel();

        public static AppEntry AddEntry (string name, string path, string image1)
        {
            AppEntry newEntry = new AppEntry();
            //newEntry.Id = 1;
            newEntry.Name = name;
            newEntry.Path = path;
            newEntry.Image1 = image1;
            if (!String.IsNullOrEmpty(image1)) {
                var webClient = new WebClient();
                byte[] imageBytes = webClient.DownloadData(image1);
                newEntry.Image2 = imageBytes;
                }

            newEntry = model.AppEntries.Add(newEntry);
            model.SaveChanges();

            return newEntry;
        }

        public static List<AppEntry> GetEntries ()
        {
            return model.AppEntries.ToList();
        }

        public static AppEntry GetEntry(int id)
        {
            return model.AppEntries.Single(x => x.Id == id);
        }

        public static AppEntry ModifyEntry(AppEntry modifiedEntry)
        {
            AppEntry entry = model.AppEntries.Single(x => x.Id == modifiedEntry.Id);
            entry.Image1 = modifiedEntry.Image1;
            entry.Image2 = modifiedEntry.Image2;
            entry.Name = modifiedEntry.Name;
            entry.Path = modifiedEntry.Path;
            model.SaveChanges();

            return modifiedEntry;
        }

        public static void DeleteEntries ()
        {
            foreach (var item in model.AppEntries)
            {
                model.AppEntries.Remove(item);
            }

            model.SaveChanges();
        }
    }
}
