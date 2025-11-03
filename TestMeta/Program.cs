using com.facebook.ads.sdk;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestMeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accessToken = "";
            var appSecret = "";
            var addAccount = "";

            var context = new APIContext(accessToken, appSecret);

            var account = new AdAccount($"act_{addAccount}", context);

            var ads = account.getAds().execute();

            var campaigns = account.getCampaigns().requestAllFields().execute();
        }
    }
}
