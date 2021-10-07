using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class EnglishTranslateName
    {
        public long IdAuto { get; set; }
        public string EnglishName { get; set; }
        public string ArabicName { get; set; }
        public int? Flag { get; set; }
    }
}
