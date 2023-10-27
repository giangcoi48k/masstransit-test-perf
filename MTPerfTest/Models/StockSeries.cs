namespace MTPerfTest.Models
{
    public class StockSeries
    {
        public long CeilingPrice { get; set; }
        public long FloorPrice { get; set; }
        public long ReferencePrice { get; set; }
        public long OpenPrice { get; set; }
        public long ClosePrice { get; set; }
        public long MatchPrice { get; set; }
        public long PriceChange { get; set; }
        public long HighestPrice { get; set; }
        public long LowestPrice { get; set; }
        public long AveragePrice { get; set; }
        public long MatchVolume { get; set; }
        public long MatchValue { get; set; }
        public long TotalMatchVolume { get; set; }
        public long TotalMatchValue { get; set; }
        public long TotalDealVolume { get; set; }
        public long TotalDealValue { get; set; }
        public long TotalVolume { get; set; }
        public long TotalValue { get; set; }
        public long ForeignBuyValueTotal { get; set; }
        public long ForeignBuyVolumeTotal { get; set; }
        public long ForeignSellValueTotal { get; set; }
        public long ForeignSellVolumeTotal { get; set; }
    }
}
