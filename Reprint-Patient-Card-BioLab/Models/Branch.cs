using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class Branch
    {
        public int IdAuto { get; set; }
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public int? InvStart { get; set; }
        public int? VauNumber { get; set; }
        public string PhoneNumber { get; set; }
        public int? ClimesNmber { get; set; }
        public string AccountNo { get; set; }
        public string BranchCodeRef { get; set; }
        public int? BranchRef { get; set; }
        public long? StartPatientLocal { get; set; }
        public long? StartTranslocal { get; set; }
        public string Sign { get; set; }
        public string Header { get; set; }
        public int? NoCopyInvoice { get; set; }
        public int? Minpaidpresent { get; set; }
        public int? PrintWmustCreditNo { get; set; }
        public decimal? Printpaidonly { get; set; }
        public decimal? AutoFill { get; set; }
        public int? Eeportresult { get; set; }
        public int? PriceClass { get; set; }
        public int? Logincheck { get; set; }
        public int? Hide { get; set; }
        public int? BranchnoHr { get; set; }
        public int? Closecash { get; set; }
        public int? ChartGroup { get; set; }
        public int? ReceptionVersion { get; set; }
        public int? DepartmentVersion { get; set; }
        public int? ViewAnotherBranch { get; set; }
        public int? WithoutSi { get; set; }
        public string BranchCodeHouse { get; set; }
        public int? IsBranchService { get; set; }
        public int? TestsNeedLocation { get; set; }
        public int? ParentBranchId { get; set; }
        public int? AllowPrintWorksheetWithoutPaid { get; set; }
        public int? AbilityToNotify { get; set; }
        public decimal? DiscountLimit { get; set; }
        public int? ContractDiscPerc { get; set; }
        public string EmailAccount { get; set; }
        public int? LabDirectorId { get; set; }
        public int? Showacc { get; set; }
        public string Oldbranchname { get; set; }
        public string OldbranchCode { get; set; }
        public string Stamp { get; set; }
        public string PhoneExt { get; set; }
        public byte[] RptHeader { get; set; }
        public byte[] RptSignature { get; set; }
        public byte[] RptStamp { get; set; }
        public byte[] RptInvHeader { get; set; }
        public string EmailPass { get; set; }
        public string EmailHost { get; set; }
        public int? EmailPort { get; set; }
        public string GmailApiClientId { get; set; }
        public string GmailApiClientSecret { get; set; }
        public string Area { get; set; }
        public int? PrintResultheader { get; set; }
        public int IdLocal { get; set; }
    }
}
