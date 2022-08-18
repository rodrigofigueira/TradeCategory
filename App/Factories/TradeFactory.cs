using App.Interfaces;
using App.Models;

namespace App
{
    public static class TradeFactory
    {
        public static ITrade Create(double Value, string clientSector, DateTime nextPaymentDate, DateTime referenceDate)
        {
            if ((referenceDate - nextPaymentDate).Days > 30)
                return new TradeExpired();

            if (Value > 1000000 && "PRIVATE".Contains(clientSector.ToUpper()))
                return new TradeHighRisk();

            if (Value > 1000000 && "PUBLIC".Contains(clientSector.ToUpper()))
                return new TradeMediumRisk();

            return null;
        }
    }
}
