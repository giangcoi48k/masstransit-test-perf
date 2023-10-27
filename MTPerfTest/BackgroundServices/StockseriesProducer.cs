using MassTransit;
using MTPerfTest.Models;

namespace MTPerfTest.BackgroundServices
{
    public class StockseriesProducer : BackgroundService
    {
        private readonly IBus _bus;

        public StockseriesProducer(IBus bus)
        {
            _bus = bus;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Run(async () =>
            {
                while (true)
                {
                    var tasks = new List<Task>();
                    var seriesItem = new StockSeries
                    {
                        CeilingPrice = Random.Shared.Next(10000, 20000),
                        FloorPrice = Random.Shared.Next(10000, 20000),
                        ReferencePrice = Random.Shared.Next(10000, 20000),
                        OpenPrice = Random.Shared.Next(10000, 20000),
                        ClosePrice = Random.Shared.Next(10000, 20000),
                        MatchPrice = Random.Shared.Next(10000, 20000),
                        PriceChange = Random.Shared.Next(10000, 20000),
                        HighestPrice = Random.Shared.Next(10000, 20000),
                        LowestPrice = Random.Shared.Next(10000, 20000),
                        AveragePrice = Random.Shared.Next(10000, 20000),
                        MatchVolume = Random.Shared.Next(10000, 20000),
                        MatchValue = Random.Shared.Next(10000, 20000),
                        TotalMatchVolume = Random.Shared.Next(10000, 20000),
                        TotalMatchValue = Random.Shared.Next(10000, 20000),
                        TotalDealVolume = Random.Shared.Next(10000, 20000),
                        TotalDealValue = Random.Shared.Next(10000, 20000),
                        TotalVolume = Random.Shared.Next(10000, 20000),
                        TotalValue = Random.Shared.Next(10000, 20000),
                        ForeignBuyValueTotal = Random.Shared.Next(10000, 20000),
                        ForeignBuyVolumeTotal = Random.Shared.Next(10000, 20000),
                        ForeignSellValueTotal = Random.Shared.Next(10000, 20000),
                        ForeignSellVolumeTotal = Random.Shared.Next(10000, 20000),
                    };
                    if (tasks.Count < 1000)
                    {
                        tasks.Add(_bus.Publish(seriesItem, stoppingToken));
                    }
                    else
                    {
                        await Task.WhenAll(tasks);
                        tasks.Clear();
                    }
                }
            }, stoppingToken);
        }
    }
}
