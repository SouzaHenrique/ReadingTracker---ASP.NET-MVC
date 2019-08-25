using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadingTrackerMVC.Models
{
    public class UIReadingModel
    {
        public int Id { get; set; }
        public int Id_leitor { get; set; }
        public int Id_livro { get; set; }
        public string Status { get; set; }
        public int PagesRead { get; set; }
        public DateTime PlannedEndDate { get; set; }
    }
}