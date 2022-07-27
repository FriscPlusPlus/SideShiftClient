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
        private  IHttwrapClient client = new HttwrapClient(configuration);
        private Dictionary<string, string> sideShiftSecret = new Dictionary<string, string>();
        public SideShift([Optional] string sideShiftSecret)
        {
            if (sideShiftSecret != null)
            {
                this.sideShiftSecret.Add("x-sideshift-secret", sideShiftSecret);

            }
        }
        public  async Task<List<dynamic>> GetCoins()
        {
            var res = await client.GetAsync("coins");
            var parsedData = ParseArrayData(res.Body);
            return parsedData;
        }
        public  async Task<bool> RequestsAllowed() {
            var res = await client.GetAsync("permissions");
            var parsedData = JsonConvert.DeserializeObject<Permissions>(res.Body);
            return parsedData.createShift;
        }
         
         public  async Task<Pair> GetPair() {
            var res = await client.GetAsync("permissions");
            var parsedData = JsonConvert.DeserializeObject<Pair>(res.Body);
            return parsedData;
        }
       /*  public  async Task GetPairs() { }
         public  async Task GetBulkShifts() { }
         public  async Task RequestQuote() { }
         public  async Task CreateFixedShift() { }
         public  async Task CreateVariableShift() { }
         public  async Task GetShift() { }
         public  async Task SetRefundAddress() { }
         public  async Task GetXAIStats() { }
         public  async Task GetAccount() { }
         public  async Task ListRecentShifts() { }*/

        private  List<dynamic> ParseArrayData(string responseBody)
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
            this.sideShiftSecret.Add("x-sideshift-secret", sideShiftSecret);
        }
    }
}