using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class ReadingModel
    {
        public int Id { get; set; }
        public int Id_leitor { get; set; }
        public int Id_livro { get; set; }
        public ReadingStatus Status { get; set; } = ReadingStatus.Iniciada;
        public int PagesRead { get; set; }
        public DateTime PlannedEndDate { get; set; }
    }
}
