using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingTrackerMVC.Models
{
    public class UIBookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublicationYear { get; set; }
        public string PublishyCompany { get; set; }
        public int AmountOfPages { get; set; }
    }
}