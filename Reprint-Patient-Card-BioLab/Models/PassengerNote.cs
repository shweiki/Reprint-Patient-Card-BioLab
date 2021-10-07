using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class PassengerNote
    {
        public long Id { get; set; }
        public string PassportNum { get; set; }
        public string Note { get; set; }
        public DateTime? DateInsert { get; set; }
        public string Username { get; set; }
    }
}
