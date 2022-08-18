using App.Enums;
using App.Interfaces;

namespace App.Models
{
    public class TradeMediumRisk : ITrade
    {
        public double Value { set; get; }

        public string ClientSector { set; get; } = Sector.PUBLIC.ToString();

        public DateTime NextPaymentDate { set; get; }

        public TradeCategory Category { private set; get; } = TradeCategory.MEDIUMRISK;
    }
}
