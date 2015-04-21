using Lbc.Services;
using Lbc.WebApi.Modes;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lbc {
    public class PropertiesHelper {
        public static Token GetToken() {
            //Token token = null;
            //if (Application.Current.Properties.ContainsKey("Token")) {
            //    token = (Token)Application.Current.Properties["Token"];
            //}

            var token = PropertiesHelper.Get<Token>("Token");
            return token ?? new Token();
        }

        public static void SaveToken(Token token) {
            //if (Application.Current.Properties.ContainsKey("Token"))
            //    Application.Current.Properties["Token"] = token;
            //else
            //    Application.Current.Properties.Add("Token", token);

            //await Application.Current.SavePropertiesAsync();

            PropertiesHelper.Set<Token>("Token", token);
        }

        public static T Get<T>(string key) {
            if (Application.Current.Properties.ContainsKey(key)) {
                return (T)Application.Current.Properties[key];
            }
            return default(T);
        }

        public static void Set<T>(string key, T value) {
            if (Application.Current.Properties.ContainsKey(key))
                Application.Current.Properties[key] = value;
            else
                Application.Current.Properties.Add(key, value);
        }

        public async static Task Save() {
            await Application.Current.SavePropertiesAsync();
        }

        public static bool HasKey(string key) {
            return Application.Current.Properties.ContainsKey(key);
        }
    }
}
