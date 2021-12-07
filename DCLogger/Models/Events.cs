using System;

namespace DCLogger.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public string Event { get; set; }
        public int AppId { get; set; }
        public string AppName { get; set; }
        public DateTime OccuranceDateTime { get; set; }
        public bool IsException { get; set; }

        public object AdditionalInfo { get; set; }
        
    }
}
