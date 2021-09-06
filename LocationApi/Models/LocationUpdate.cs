using System;

namespace LocationApi.Models
{
    public class LocationUpdate
    {
        public int UserId { get; set; }
        public DateTime UpdateTime { get; set; }
        public (decimal, decimal) Location { get; set; }

        public User User { get; set; }
    }
}