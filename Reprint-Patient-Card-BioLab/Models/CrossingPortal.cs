using System;
using System.Collections.Generic;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class CrossingPortal
    {
        public int IdLocal { get; set; }
        public long Id { get; set; }
        public string PatName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public string AgeDay { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public string MobileNo { get; set; }
        public string PassportImagePath { get; set; }
        public string QrcodePath { get; set; }
        public string PcrPath { get; set; }
        public string VisaNum { get; set; }
        public string PatNationality { get; set; }
        public string PassportNum { get; set; }
        public string IdNum { get; set; }
        public string Residency { get; set; }
        public int? Vaccinated { get; set; }
        public int? Crossing { get; set; }
        public int? PatLang { get; set; }
        public string VaccineQrlink { get; set; }
        public string VaccineCountry { get; set; }
        public string VaccineCertificatePath { get; set; }
        public string FlightNum { get; set; }
        public DateTime? FlightDate { get; set; }
        public int? CheckStatus { get; set; }
        public string CheckStatusUser { get; set; }
        public DateTime? CheckStatusDate { get; set; }
        public string CheckStatusNotes { get; set; }
        public long? Trano { get; set; }
        public DateTime? TraDate { get; set; }
        public int? Deleted { get; set; }
        public DateTime? DateDeleted { get; set; }
        public string UserDaleted { get; set; }
        public string ReasonDeleted { get; set; }
        public DateTime? DateInsert { get; set; }
        public DateTime? LastDateUpdate { get; set; }
        public bool? Apichecked { get; set; }
        public int? VaccineDose { get; set; }
        public string PatArName { get; set; }
        public string LockUser { get; set; }
        public DateTime? LockDate { get; set; }
        public string ReferenceNo { get; set; }
        public long? VisitJoId { get; set; }
        public long? VisitJoQr { get; set; }
        public int? Used { get; set; }
        public DateTime? Useddate { get; set; }
        public DateTime? DateEdited { get; set; }
        public int? UserEdit { get; set; }
        public int? IsRefund { get; set; }
        public int? UserRefund { get; set; }
        public DateTime? DateRefund { get; set; }
        public string EmailId { get; set; }
        public DateTime? DateInsertEmail { get; set; }
        public string EmailStatus { get; set; }
        public int? Accstatus { get; set; }
        public string PaymentStatus { get; set; }
        public string MerchantTransactionId { get; set; }
        public string MerchantTransactionIdNew { get; set; }
        public bool? CheckStatusV2 { get; set; }
        public string CheckStatusUserV2 { get; set; }
        public DateTime? CheckStatusDateV2 { get; set; }
        public string LockUserV2 { get; set; }
        public DateTime? LockDateV2 { get; set; }
        public int? MultiUsed { get; set; }
    }
}
