using MassTransit;
using MTPerfTest.Models;

namespace MTPerfTest.BackgroundServices
{
    public class StockSeriesConsumer : IConsumer<StockSeries>
    {
        static long count;
        public async Task Consume(ConsumeContext<StockSeries> context)
        {
            Interlocked.Increment(ref count);
            await Console.Out.WriteLineAsync(count.ToString());
        }
    }
}
