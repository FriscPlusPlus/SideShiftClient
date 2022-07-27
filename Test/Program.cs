using SideShiftClient;
class Program
{
     static async Task Main(string[] args) {
        SideShift shift = new SideShift();
        var data = await shift.GetPair();
        Console.WriteLine(data);
    }
}