using App;
using App.Extensions;
using App.Interfaces;

Console.WriteLine("Trade Category.");
Console.Write("Input reference date (mm/dd/yyyy): ");
DateTime referenceDate = Console.ReadLine().ConvertStringToDate() ;

Console.Write("Number of trades: ");
int numberOfTrades = int.Parse(Console.ReadLine());

List<ITrade> trades = new List<ITrade>();

for (int i = 1; i <= numberOfTrades; i++)
{
    Console.WriteLine($"Enter trade #{i}");
    string[] _values = Console.ReadLine().Split(" ");
    trades.Add(TradeFactory.Create(Double.Parse(_values[0]), _values[1], _values[2].ConvertStringToDate(), referenceDate));
}

foreach (var trade in trades)
{
    Console.WriteLine(trade.Category);
}

Console.ReadKey();