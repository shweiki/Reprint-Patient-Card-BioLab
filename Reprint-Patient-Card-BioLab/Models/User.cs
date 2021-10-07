using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class User
    {
        public decimal Id { get; set; }
        public string Uid { get; set; }
        public string Uname { get; set; }
        public string Upass { get; set; }
        public string Have { get; set; }
        public string Give { get; set; }
        public double Text1 { get; set; }
        public double? Text2 { get; set; }
        public double? Text3 { get; set; }
        public short? Ulevel { get; set; }
        public bool? Loged { get; set; }
        public string GroupName { get; set; }
        public string BranchCode { get; set; }
        public string BranchId { get; set; }
        public bool? Checkuser1 { get; set; }
        public decimal? Text4 { get; set; }
        public string Statuss { get; set; }
        public DateTime? Lastmodify { get; set; }
        public decimal? Text5 { get; set; }
        public string NewName { get; set; }
        public DateTime? DateLastmodify { get; set; }
        public string LastPermissionsModify { get; set; }
        public decimal? BranchNo { get; set; }
        public string Have3 { get; set; }
        public string OldPass { get; set; }
        public int? WorkBranch { get; set; }
        public string UserEmail { get; set; }
        public int? Empno { get; set; }
        public int? GroupId { get; set; }
        public double? Text6 { get; set; }
        public double? Text7 { get; set; }
        public int IdLocal { get; set; }
    }
}
