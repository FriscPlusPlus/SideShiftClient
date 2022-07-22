using Httwrap.Interface;
using Httwrap;
using System.Runtime.InteropServices;

namespace SideShiftClient
{
    public class SideShift
    {
        IHttwrapConfiguration? configuration = null;
        IHttwrapClient? client = null;
        string? sideShiftSecret = null;
        public SideShift([Optional] string sideShiftSecret)
        {
            this.configuration = new HttwrapConfiguration("https://sideshift.ai/api/v2/");
            this.client = new HttwrapClient(this.configuration);
            if (sideShiftSecret != null)
            {
                this.sideShiftSecret = sideShiftSecret;
            }
        }
        public void GetCoins() { }
        public void GetPermissions() { }
        public void GetPair() { }
        public void GetPairs() { }
        public void GetBulkShifts() { }
        public void RequestQuote() { }
        public void CreateFixedShift() { }
        public void CreateVariableShift() { }
        public void GetShift() { }
        public void SetRefundAddress() { }
        public void GetXAIStats() { }
        public void GetAccount() { }
        public void ListRecentShifts() { }

        private Boolean CanDoRequest()
        {
            return true;
        }
        public void SetSideShiftSecret(string sideShiftSecret)
        {
            this.sideShiftSecret = sideShiftSecret;
        }
    }
}