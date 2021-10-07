using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class Country
    {
        public long? Id { get; set; }
        public string CountryEn { get; set; }
        public string CountryAr { get; set; }
        public string CountryCode { get; set; }
    }
}
