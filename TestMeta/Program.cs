using com.facebook.ads.sdk;
using System.Text.Json;
using System.Threading.Tasks;

namespace TestMeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accessToken = "EAALuih0ZCysEBP70kOrLesZA5H4D8a873K2WrHAsB3pK3aGIGb88x9olpDYZA9BnSslarzQ7X4y2m2LKNc97xNEUlIVgPXKxLrZCBAdSKHdyiVbZBaZAV7fcLRabutC6Mrac2sgWkChWFyZA3Y8MUBj6kJ6OYHKVonX1Gz2myDNKs6YvGOggjal7JjOPGyPadCpoXX8N8g6ZCGAeXwcB0DLobmikDZCrpkSz6kVYkU6NrPDZAf5rUCksIDAPbyBjKd0p43QFp2MZAdeYX7t";
            var appSecret = "4737648220f588a85eb875c8d11f8995";
            var addAccount = "249358639";

            var context = new APIContext(accessToken, appSecret);

            var account = new AdAccount($"act_{addAccount}", context);

            var ads = account.getAds().execute();

            var campaigns = account.getCampaigns().requestAllFields().execute();
        }
    }
}
