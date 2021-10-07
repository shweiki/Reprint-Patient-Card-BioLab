using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class TemplateTransactionforCopy
    {
        public int Id { get; set; }
        public long? Trano { get; set; }
        public string Disc { get; set; }
        public DateTime? DateInsert { get; set; }
        public string BranchCode { get; set; }
        public int IdLocal { get; set; }
    }
}
