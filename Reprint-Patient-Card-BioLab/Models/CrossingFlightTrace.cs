using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class CrossingFlightTrace
    {
        public long Id { get; set; }
        public string BranchCode { get; set; }
        public string FlightNumber { get; set; }
        public string AirlineName { get; set; }
        public string AirlineNameAr { get; set; }
        public DateTime? Scheduled { get; set; }
        public DateTime? Actual { get; set; }
        public string FromCountry { get; set; }
        public string FromCity { get; set; }
        public string FromCityAr { get; set; }
        public string Gate { get; set; }
        public int? Createdby { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Used { get; set; }
        public int? UsedBy { get; set; }
        public DateTime? UsedAt { get; set; }
        public DateTime? UnUsedAt { get; set; }
        public int? UnUsedBy { get; set; }
        public DateTime? DateInsert { get; set; }
    }
}
