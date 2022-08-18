using System;
using Xunit;
using App.Models;
using App;
using App.Enums;

namespace Test
{
    public class FactoryTests
    {

        [Fact]
        public void ShouldCreateTradeExpired()
        {
            var trade = TradeFactory.Create(10000001, "PRIVATE", new DateTime(2000,10,10), DateTime.Now);
            Assert.IsType<TradeExpired>(trade);
        }

        [Fact]
        public void ShouldCreateExpiredCategory()
        {
            var trade = TradeFactory.Create(10000001, "PRIVATE", new DateTime(2000, 10, 10), DateTime.Now);
            Assert.True(trade.Category == TradeCategory.EXPIRED);
        }

        [Fact]
        public void ShouldCreateTradeHighRisk()
        {
            var trade = TradeFactory.Create(10000001, "PRIVATE", new DateTime(2023,10,10), DateTime.Now);
            Assert.IsType<TradeHighRisk>(trade);
        }

        [Fact]
        public void ShouldCreateHighRiskCategory()
        {
            var trade = TradeFactory.Create(10000001, "PRIVATE", new DateTime(2023, 10, 10), DateTime.Now);
            Assert.True(trade.Category == TradeCategory.HIGHRISK);
        }

        [Fact]
        public void ShouldCreateTradeMediumRisk()
        {
            var trade = TradeFactory.Create(10000001, "PUBLIC", new DateTime(2023,10,10), DateTime.Now);
            Assert.IsType<TradeMediumRisk>(trade);
        }

        [Fact]
        public void ShouldCreateMediumRiskCategory()
        {
            var trade = TradeFactory.Create(10000001, "PUBLIC", new DateTime(2023, 10, 10), DateTime.Now);
            Assert.True(trade.Category == TradeCategory.MEDIUMRISK);
        }

    }
}
