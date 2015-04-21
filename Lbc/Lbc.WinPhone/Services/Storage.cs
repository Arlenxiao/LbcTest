using Lbc.Services;
using Lbc.WinPhone.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Storage))]
namespace Lbc.WinPhone.Services {
    public class Storage : IStorage {
        public string LoadText(string filename) {
            var task = LoadTextAsync(filename);
            task.Wait(); // HACK: to keep Interface return types simple (sorry!) 
            return task.Result;
        }
        async Task<string> LoadTextAsync(string filename) {
            StorageFolder local = Windows.Storage.ApplicationData.Current.LocalFolder;
            if (local != null) {
                var file = await local.GetItemAsync(filename);
                using (StreamReader streamReader = new StreamReader(file.Path)) {
                    var text = streamReader.ReadToEnd();
                    return text;
                }
            }
            return "";
        } 

        public void SaveText(string filename, string text) {
            throw new NotImplementedException();
        }
    }
}
