using App.Enums;

namespace App.Interfaces
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
        DateTime NextPaymentDate { get; }
        TradeCategory Category { get; }
    }
}
