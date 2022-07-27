using SideShiftClient;
class Program
{
     static async Task Main(string[] args) {
        SideShift shift = new SideShift();
        var data = await shift.GetPairs("btc-mainnet,usdc-bsc,bch,bch-smartbch");
        Console.WriteLine(data);
    }
}