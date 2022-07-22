using Httwrap.Interface;
using Httwrap;

namespace SideShiftClient
{
    public class SideShift
    {
        IHttwrapConfiguration? configuration = null;
        IHttwrapClient? client = null;
        public SideShift()
        {
            this.configuration = new HttwrapConfiguration("https://sideshift.ai/api/v2/");
            this.client = new HttwrapClient(this.configuration);
        }
        public void Test()
        {
            Console.WriteLine("HELLOW WORLD!");
        }
    }
}