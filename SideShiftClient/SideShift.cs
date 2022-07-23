using Httwrap.Interface;
using Httwrap;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Reflection;

namespace SideShiftClient
{
    public class SideShift
    {
        private static IHttwrapConfiguration configuration = new HttwrapConfiguration("https://sideshift.ai/api/v2/");
        private static IHttwrapClient client = new HttwrapClient(configuration);
        private string? sideShiftSecret = null;
        public SideShift([Optional] string sideShiftSecret)
        {
            if (sideShiftSecret != null)
            {
                this.sideShiftSecret = sideShiftSecret;
            }
        }
        public static async Task<List<dynamic>> GetCoins()
        {
            var res = await client.GetAsync("coins");
            var parsedData = ParseArrayData(res.Body);
            return parsedData;
        }
        public static async Task<bool> RequestsAllowed() {
            var res = await client.GetAsync("permissions");
            var parsedData = JsonConvert.DeserializeObject<Permissions>(res.Body);
            return parsedData.createShift;
        }
        /*  
         public JObject GetPair() { }
         public JObject GetPairs() { }
         public JObject GetBulkShifts() { }
         public JObject RequestQuote() { }
         public JObject CreateFixedShift() { }
         public JObject CreateVariableShift() { }
         public JObject GetShift() { }
         public JObject SetRefundAddress() { }
         public JObject GetXAIStats() { }
         public JObject GetAccount() { }
         public JObject ListRecentShifts() { }*/

        private static List<dynamic> ParseArrayData(string responseBody)
        {
            var parsedData = JsonConvert.DeserializeObject<List<dynamic>>(responseBody);
            return parsedData;
        }

        private bool CanDoRequest()
        {
            return true;
        }
        public void SetSideShiftSecret(string sideShiftSecret)
        {
            this.sideShiftSecret = sideShiftSecret;
        }
    }
}