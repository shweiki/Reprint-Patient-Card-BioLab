using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Reprint_Patient_Card_BioLab.Models;

namespace Reprint_Patient_Card_BioLab.Controllers
{
    public class CrossingPortalController : Controller
    {
        private readonly PortOfAqabaContext DB;

        public CrossingPortalController(PortOfAqabaContext context)
        {
            DB = context;
        }
        [HttpGet]
        [Route("CrossingPortal/GetCrossingPortal")]
        public IActionResult GetCrossingPortal()
        {
            var CrossingPortals = DB.CrossingPortals.ToList();

            return Ok(CrossingPortals);
        }

        [HttpGet]
        [Route("CrossingPortal/GetCrossingPortalByAny")]
        public IActionResult GetCrossingPortalByAny(string Any)
        {
            Any.ToLower();
            var CrossingPortals = DB.CrossingPortals.Where(m => m.VisitJoQr.ToString().Contains(Any) || m.PatName.ToLower().Contains(Any) || m.PatArName.ToLower().Contains(Any) || m.MobileNo.Replace("0", "").Replace(" ", "").Contains(Any.Replace("0", "").Replace(" ", "")) )
                .ToList();

            return Ok(CrossingPortals);
        }
        
        [HttpPost]
        [Route("CrossingPortal/GetByListQ")]
        public IActionResult GetByListQ(int Limit, string Sort, int Page,  string Any)
        {
            
            var CrossingPortals = DB.CrossingPortals.Where(s => (Any != null ? s.VisitJoQr.ToString().Contains(Any) || s.PatName.Contains(Any) ||  s.PatArName.ToLower().Contains(Any) || s.MobileNo.Replace("0", "").Replace(" ", "").Contains(Any.Replace("0", "").Replace(" ", "")) : true)
          ).ToList();
            CrossingPortals = (Sort == "+id" ? CrossingPortals.OrderBy(s => s.Id).ToList() : CrossingPortals.OrderByDescending(s => s.Id).ToList());
            return Ok(new
            {
                items = CrossingPortals.Skip((Page - 1) * Limit).Take(Limit).ToList(),
                Totals = new
                {
                    Rows = CrossingPortals.Count(),
                    
                }
            });
        }

        [HttpGet]
        [Route("CrossingPortal/CheckIsExist")]
        public IActionResult CheckIsExist(string Name,  long VisitJoQr)
        {
            var CrossingPortal = DB.CrossingPortals.Where(m => (Name != null ? m.PatName == Name : false) || (VisitJoQr != null ? m.VisitJoQr == VisitJoQr : false) ).ToList();

            return Ok(CrossingPortal.Count() > 0 ? true : false);
        }
        [Route("CrossingPortal/Create")]
        [HttpPost]
        public IActionResult Create(CrossingPortal collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
               
                    DB.CrossingPortals.Add(collection);
                    DB.SaveChanges();
                    return Ok(collection.Id);

                }
                catch
                {
                    //Console.WriteLine(collection);
                    return Ok(false);
                }
            }
            return Ok(false);
        }

        [HttpGet]
        [Route("CrossingPortal/GetById")]
        public IActionResult GetById(long? Id)
        {
            var CrossingPortal = DB.CrossingPortals.Where(m => m.Id == Id).SingleOrDefault();
            return Ok(CrossingPortal);
        }

        [HttpPost]
        [Route("CrossingPortal/Edit")]
        public IActionResult Edit(CrossingPortal collection)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    CrossingPortal CrossingPortal = DB.CrossingPortals.Where(x => x.Id == collection.Id).SingleOrDefault();
                    CrossingPortal.PatName = collection.PatName;
                    CrossingPortal.DateOfBirth = collection.DateOfBirth;
                    CrossingPortal.Age = collection.Age;
                    CrossingPortal.AgeDay = collection.AgeDay;
                    CrossingPortal.Gender = collection.Gender;
                    CrossingPortal.Email = collection.Email;
                    CrossingPortal.CountryCode = collection.CountryCode;
                    CrossingPortal.MobileNo = collection.MobileNo;
                    CrossingPortal.PassportImagePath = collection.PassportImagePath;
                    CrossingPortal.QrcodePath = collection.QrcodePath;
                    CrossingPortal.PcrPath = collection.PcrPath;
                    CrossingPortal.VisaNum = collection.VisaNum;
                    CrossingPortal.PatNationality = collection.PatNationality;
                    CrossingPortal.PassportNum = collection.PassportNum;
                    CrossingPortal.IdNum = collection.IdNum;
                    CrossingPortal.Residency = collection.Residency;
                    CrossingPortal.VaccineQrlink = collection.VaccineQrlink;
                    CrossingPortal.VaccineCountry = collection.VaccineCountry;
                    CrossingPortal.VaccineCertificatePath = collection.VaccineCertificatePath;
                    CrossingPortal.FlightNum = collection.FlightNum;
                    CrossingPortal.FlightDate = collection.FlightDate;
                    CrossingPortal.CheckStatus = collection.CheckStatus;
                    CrossingPortal.CheckStatusUser = collection.CheckStatusUser;
                    CrossingPortal.CheckStatusDate = collection.CheckStatusDate;
                    CrossingPortal.CheckStatusNotes = collection.CheckStatusNotes;
                    CrossingPortal.Trano = collection.Trano;
                    CrossingPortal.TraDate = collection.TraDate;
                    CrossingPortal.Deleted = collection.Deleted;
                    CrossingPortal.DateDeleted = collection.DateDeleted;
                    CrossingPortal.UserDaleted = collection.UserDaleted;
                    CrossingPortal.ReasonDeleted = collection.ReasonDeleted;
                    CrossingPortal.DateInsert = collection.DateInsert;
                    CrossingPortal.LastDateUpdate = collection.LastDateUpdate;
                    CrossingPortal.Apichecked = collection.Apichecked;
                    CrossingPortal.VaccineDose = collection.VaccineDose;
                    CrossingPortal.PatArName = collection.PatArName;
                    CrossingPortal.LockUser = collection.LockUser;
                    CrossingPortal.LockDate = collection.LockDate;
                    CrossingPortal.ReferenceNo = collection.ReferenceNo;
                    CrossingPortal.VisitJoId = collection.VisitJoId;
                    CrossingPortal.VisitJoQr = collection.VisitJoQr;
                    CrossingPortal.Used = collection.Used;
                    CrossingPortal.Useddate = collection.Useddate;
                    CrossingPortal.DateEdited = collection.DateEdited;
                    CrossingPortal.UserEdit = collection.UserEdit;
                    CrossingPortal.IsRefund = collection.IsRefund;
                    CrossingPortal.UserRefund = collection.UserRefund;
                    CrossingPortal.DateRefund = collection.DateRefund;
                    CrossingPortal.EmailId = collection.EmailId;
                    CrossingPortal.DateInsertEmail = collection.DateInsertEmail;
                    CrossingPortal.EmailStatus = collection.EmailStatus;
                    CrossingPortal.Accstatus = collection.Accstatus;
                    CrossingPortal.PaymentStatus = collection.PaymentStatus;
                    CrossingPortal.MerchantTransactionId = collection.MerchantTransactionId;
                    CrossingPortal.MerchantTransactionIdNew = collection.MerchantTransactionIdNew;
                    CrossingPortal.CheckStatusV2 = collection.CheckStatusV2;
                    CrossingPortal.CheckStatusUserV2 = collection.CheckStatusUserV2;
                    CrossingPortal.CheckStatusDateV2 = collection.CheckStatusDateV2;
                    CrossingPortal.LockUserV2 = collection.LockUserV2;
                    CrossingPortal.LockDateV2 = collection.LockDateV2;
                    CrossingPortal.MultiUsed = collection.MultiUsed;
                   

                    DB.SaveChanges();
                    return Ok(true);
                }
                catch
                {
                    //Console.WriteLine(collection);
                    return Ok(false);
                }
            }
            return Ok(false);
        }
 

    }
}
