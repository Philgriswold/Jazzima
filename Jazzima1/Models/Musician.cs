using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jazzima1.Models
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instrument { get; set; }
        public int InstrumentTypeId { get; set; }
        public InstrumentType InstrumentType { get; set; }
    }
}
