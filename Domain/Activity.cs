using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public DateTime Date { get; set; }
        public string Description {get; set;} = String.Empty;
        public string Category {get; set;} = String.Empty;
        public string City { get; set; } = String.Empty;
        public string Venue { get; set; } = String.Empty;
    }
    
}