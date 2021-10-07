using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class ReplaseChar
    {
        public int Id { get; set; }
        public string Chars { get; set; }
        public string CharReplase { get; set; }
        public string Location { get; set; }
        public int? Ascii { get; set; }
    }
}
