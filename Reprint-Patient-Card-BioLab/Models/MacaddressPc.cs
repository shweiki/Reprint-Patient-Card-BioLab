using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class MacaddressPc
    {
        public int IdAuto { get; set; }
        public string Macaddress { get; set; }
        public string BranchCode { get; set; }
        public string BranchCodeR { get; set; }
        public int? IdLab { get; set; }
        public string UserName { get; set; }
        public string ProductKey { get; set; }
        public string ActiveKey { get; set; }
        public string Notess { get; set; }
        public bool? AccountingPatients { get; set; }
        public DateTime? LastV { get; set; }
        public int? ReferralPc { get; set; }
        public string PaidAccount { get; set; }
        public int? Department { get; set; }
        public int? Location { get; set; }
        public string FilterEnable { get; set; }
        public int? Machine { get; set; }
        public int? Trackingbranch { get; set; }
        public int? ReceptionVersion { get; set; }
        public int? DepartmentVersion { get; set; }
        public int? AllowPrintReferralResult { get; set; }
        public int? TrackingLocation { get; set; }
        public int? Pcgroup { get; set; }
        public int? Paperless { get; set; }
        public int? Covid { get; set; }
        public string Ipaddress { get; set; }
        public int IdLocal { get; set; }
    }
}
