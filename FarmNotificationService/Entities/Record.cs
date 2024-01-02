namespace FarmNotificationService.Entities
{
    public class Record : BaseEntity
    {
        public string? Type { get; set; }
        public DateTime TrackingDate { get; set; }
        public IEnumerable<TrackingItem> TrackingItems { get; set; } = Enumerable.Empty<TrackingItem>();
    }

    public class TrackingItem
    {
        public DateTime EventTime { get; set; }
        public string? Value { get; set; }
    }
}
