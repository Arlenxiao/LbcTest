using Lbc.WebApi.Modes;
using Xamarin.Forms;

namespace Lbc {
    public class TokenHelper {
        public static Token GetToken() {
            Token token = null;
            if (Application.Current.Properties.ContainsKey("Token")) {
                token = (Token)Application.Current.Properties["Token"];
            }

            return token ?? new Token();
        }

        public async static void Save(Token token) {

            if (Application.Current.Properties.ContainsKey("Token"))
                Application.Current.Properties["Token"] = token;
            else
                Application.Current.Properties.Add("Token", token);

            await Application.Current.SavePropertiesAsync();
        }
    }
}
