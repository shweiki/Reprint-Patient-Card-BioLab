using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class Barcodeprint
    {
        public long Id { get; set; }
        public string Computername { get; set; }
        public string Paths { get; set; }
        public string MacAddress { get; set; }
        public string Barcode { get; set; }
        public string PatientCard { get; set; }
        public string Envelope { get; set; }
        public string Result { get; set; }
        public string WorkSheet { get; set; }
        public string Invoice { get; set; }
        public string Fax { get; set; }
        public DateTime? LastRead { get; set; }
        public int IdLocal { get; set; }
    }
}
