using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class SystemMessage
    {
        public int Id { get; set; }
        public string MsgCode { get; set; }
        public string MsgbodyPart1 { get; set; }
        public string MsgbodyPart2 { get; set; }
        public string MsgbodyPart3 { get; set; }
        public string MsgbodyPart4 { get; set; }
        public string MsgbodyPart5 { get; set; }
        public string MsgHeadPart1 { get; set; }
        public string MsgHeadPart2 { get; set; }
        public int MsgCategory { get; set; }
        public string FormName { get; set; }
        public int IdLocal { get; set; }
    }
}
