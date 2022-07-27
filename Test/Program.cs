using SideShiftClient;
class Program
{
     static async Task Main(string[] args) {
        SideShift shift = new SideShift();
        var data = await shift.GetShifts("0c1f53a2718c5a48eb77");
        Console.WriteLine(data);
    }
}