using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class TransCrossing
    {
        public int Id { get; set; }
        public string Patname { get; set; }
        public string PatarName { get; set; }
        public string Gender { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Age { get; set; }
        public string Days { get; set; }
        public string Refnumber { get; set; }
        public string Passportno { get; set; }
        public DateTime? Datetimeinsert { get; set; }
        public int? PatRegBiolab { get; set; }
        public decimal? Transno { get; set; }
        public long? Patnumber { get; set; }
        public decimal? PatMobile { get; set; }
        public string Userid { get; set; }
        public string Ocr { get; set; }
        public string Visa { get; set; }
        public string Refno { get; set; }
        public string Refno2 { get; set; }
        public string PatientAddress { get; set; }
        public string EmpName { get; set; }
        public string ReferenceNumber { get; set; }
        public string Nationality { get; set; }
        public string PassportIdno { get; set; }
        public string PatEmail { get; set; }
        public decimal? CopyFromTransno { get; set; }
        public int? CovidReason { get; set; }
        public int? PrintIdnumber { get; set; }
        public int? PrintPassportno { get; set; }
        public int? Vaccinated { get; set; }
        public int? CountryCode { get; set; }
        public string FlightNumber { get; set; }
        public string VisitJoQr { get; set; }
        public string Macaddress { get; set; }
        public long? FlightNumberId { get; set; }
        public string BranchCode { get; set; }
    }
}
