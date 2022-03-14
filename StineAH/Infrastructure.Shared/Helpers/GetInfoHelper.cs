using System;
using System.Net;

namespace Infrastructure.Shared.Helpers
{
    public class GetInfoHelper
    {
        public static string GetInfo()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"https://mocki.io/v1/0077e191-c3ae-47f6-bbbd-3b3b905e4a60");
            return json;
        }
    }
}
