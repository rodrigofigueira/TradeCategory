using App.Enums;
using App.Interfaces;

namespace App.Models
{
    public class TradeExpired : ITrade
    {

        public TradeExpired(string sector)
        {
            ClientSector = sector;
        }

        public double Value { set; get; }

        public string ClientSector { set; get; } = "";

        public DateTime NextPaymentDate { set; get; }

        public TradeCategory Category { private set; get; } = TradeCategory.EXPIRED;
    }
}
