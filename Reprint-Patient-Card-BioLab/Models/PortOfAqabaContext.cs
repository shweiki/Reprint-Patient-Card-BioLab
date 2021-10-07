using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Reprint_Patient_Card_BioLab.Models
{
    public partial class PortOfAqabaContext : DbContext
    {
        public PortOfAqabaContext()
        {
        }

        public PortOfAqabaContext(DbContextOptions<PortOfAqabaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Barcodeprint> Barcodeprints { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<CoDetailsPathsDirectory> CoDetailsPathsDirectories { get; set; }
        public virtual DbSet<CoMasterPathsDirectory> CoMasterPathsDirectories { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossingFlight> CrossingFlights { get; set; }
        public virtual DbSet<CrossingFlightTrace> CrossingFlightTraces { get; set; }
        public virtual DbSet<CrossingPortal> CrossingPortals { get; set; }
        public virtual DbSet<EnglishTranslateName> EnglishTranslateNames { get; set; }
        public virtual DbSet<LabInfo> LabInfos { get; set; }
        public virtual DbSet<LabelsTable> LabelsTables { get; set; }
        public virtual DbSet<MacaddressPc> MacaddressPcs { get; set; }
        public virtual DbSet<PassengerNote> PassengerNotes { get; set; }
        public virtual DbSet<ReplaseChar> ReplaseChars { get; set; }
        public virtual DbSet<SystemMessage> SystemMessages { get; set; }
        public virtual DbSet<TemplateTransactionforCopy> TemplateTransactionforCopies { get; set; }
        public virtual DbSet<TransCrossing> TransCrossings { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PortOfAqaba;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Barcodeprint>(entity =>
            {
                entity.HasKey(e => e.IdLocal)
                    .HasName("PK__barcodep__3213E83F43E7921E");

                entity.ToTable("barcodeprint");

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.Computername)
                    .HasMaxLength(50)
                    .HasColumnName("computername");

                entity.Property(e => e.Fax).HasColumnName("fax");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastRead).HasColumnType("datetime");

                entity.Property(e => e.Paths)
                    .HasMaxLength(50)
                    .HasColumnName("paths");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.IdLocal);

                entity.ToTable("branch");

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.AbilityToNotify).HasDefaultValueSql("((1))");

                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .HasColumnName("accountNO");

                entity.Property(e => e.AllowPrintWorksheetWithoutPaid).HasDefaultValueSql("((1))");

                entity.Property(e => e.Area).HasMaxLength(50);

                entity.Property(e => e.AutoFill).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("branch_code");

                entity.Property(e => e.BranchCodeHouse)
                    .HasMaxLength(5)
                    .HasColumnName("branch_code_House");

                entity.Property(e => e.BranchCodeRef)
                    .HasMaxLength(50)
                    .HasColumnName("branch_code_ref");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("branch_name");

                entity.Property(e => e.BranchRef)
                    .HasColumnName("branch_ref")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchnoHr).HasColumnName("branchno_hr");

                entity.Property(e => e.ChartGroup)
                    .HasColumnName("chart_group")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClimesNmber)
                    .HasColumnName("Climes_nmber")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Closecash)
                    .HasColumnName("closecash")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiscountLimit).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.EmailAccount).HasMaxLength(50);

                entity.Property(e => e.EmailHost).HasMaxLength(50);

                entity.Property(e => e.EmailPass).HasMaxLength(50);

                entity.Property(e => e.GmailApiClientId).HasColumnName("GmailAPI_ClientID");

                entity.Property(e => e.GmailApiClientSecret).HasColumnName("GmailAPI_ClientSecret");

                entity.Property(e => e.Header).HasMaxLength(100);

                entity.Property(e => e.Hide)
                    .HasColumnName("hide")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdAuto).HasColumnName("id_auto");

                entity.Property(e => e.InvStart)
                    .HasColumnName("inv_start")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsBranchService).HasDefaultValueSql("((0))");

                entity.Property(e => e.LabDirectorId).HasColumnName("labDirectorID");

                entity.Property(e => e.Logincheck).HasColumnName("logincheck");

                entity.Property(e => e.Minpaidpresent).HasDefaultValueSql("((100))");

                entity.Property(e => e.NoCopyInvoice).HasDefaultValueSql("((2))");

                entity.Property(e => e.OldbranchCode).HasMaxLength(150);

                entity.Property(e => e.Oldbranchname).HasMaxLength(150);

                entity.Property(e => e.ParentBranchId).HasColumnName("ParentBranchID");

                entity.Property(e => e.PhoneExt)
                    .HasMaxLength(50)
                    .HasColumnName("phoneExt");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(150)
                    .HasColumnName("phone_number");

                entity.Property(e => e.PrintWmustCreditNo)
                    .HasColumnName("PrintWMustCreditNo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Printpaidonly).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.ReceptionVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.RptHeader).HasColumnType("image");

                entity.Property(e => e.RptInvHeader).HasColumnType("image");

                entity.Property(e => e.RptSignature).HasColumnType("image");

                entity.Property(e => e.RptStamp).HasColumnType("image");

                entity.Property(e => e.Showacc)
                    .HasColumnName("showacc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Sign).HasMaxLength(100);

                entity.Property(e => e.Stamp).HasMaxLength(100);

                entity.Property(e => e.StartPatientLocal).HasColumnName("startPatientLocal");

                entity.Property(e => e.StartTranslocal).HasColumnName("startTranslocal");

                entity.Property(e => e.TestsNeedLocation).HasDefaultValueSql("((0))");

                entity.Property(e => e.VauNumber)
                    .HasColumnName("vau_number")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ViewAnotherBranch).HasDefaultValueSql("((1))");

                entity.Property(e => e.WithoutSi)
                    .HasColumnName("withoutSI")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<CoDetailsPathsDirectory>(entity =>
            {
                entity.ToTable("CO_Details_PathsDirectory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MasterPathId).HasColumnName("MasterPathID");

                entity.Property(e => e.Path).HasMaxLength(200);
            });

            modelBuilder.Entity<CoMasterPathsDirectory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CO_Master_PathsDirectory");

                entity.Property(e => e.DefaultPath).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CountryAr)
                    .HasMaxLength(50)
                    .HasColumnName("countryAR");

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.CountryEn)
                    .HasMaxLength(50)
                    .HasColumnName("countryEN");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CrossingFlight>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crossing_Flight");

                entity.Property(e => e.Actual).HasColumnType("datetime");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(500)
                    .HasColumnName("Airline_Name");

                entity.Property(e => e.AirlineNameAr)
                    .HasMaxLength(500)
                    .HasColumnName("Airline_name_ar");

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FlightNumber).HasMaxLength(500);

                entity.Property(e => e.FromCity).HasMaxLength(500);

                entity.Property(e => e.FromCityAr)
                    .HasMaxLength(500)
                    .HasColumnName("FromCity_ar");

                entity.Property(e => e.FromCountry).HasMaxLength(500);

                entity.Property(e => e.FromCountryAr)
                    .HasMaxLength(500)
                    .HasColumnName("FromCountry_ar");

                entity.Property(e => e.Gate)
                    .HasMaxLength(500)
                    .HasColumnName("GATE");

                entity.Property(e => e.IdLocal)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_local");

                entity.Property(e => e.Scheduled).HasColumnType("datetime");

                entity.Property(e => e.UnUsedAt).HasColumnType("datetime");

                entity.Property(e => e.UsedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrossingFlightTrace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Crossing_Flight_Trace");

                entity.Property(e => e.Actual).HasColumnType("datetime");

                entity.Property(e => e.AirlineName)
                    .HasMaxLength(500)
                    .HasColumnName("Airline_Name");

                entity.Property(e => e.AirlineNameAr)
                    .HasMaxLength(500)
                    .HasColumnName("Airline_name_ar");

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DateInsert)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlightNumber).HasMaxLength(500);

                entity.Property(e => e.FromCity).HasMaxLength(500);

                entity.Property(e => e.FromCityAr)
                    .HasMaxLength(500)
                    .HasColumnName("FromCity_ar");

                entity.Property(e => e.FromCountry).HasMaxLength(500);

                entity.Property(e => e.Gate)
                    .HasMaxLength(500)
                    .HasColumnName("GATE");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Scheduled).HasColumnType("datetime");

                entity.Property(e => e.UnUsedAt).HasColumnType("datetime");

                entity.Property(e => e.UsedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<CrossingPortal>(entity =>
            {
                entity.HasKey(e => e.IdLocal);

                entity.ToTable("Crossing_Portal");

                entity.HasIndex(e => e.Id, "IX_Crossing_Portal");

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.Accstatus).HasColumnName("accstatus");

                entity.Property(e => e.AgeDay).HasMaxLength(50);

                entity.Property(e => e.Apichecked).HasColumnName("APIChecked");

                entity.Property(e => e.CheckStatusDate).HasColumnType("datetime");

                entity.Property(e => e.CheckStatusDateV2).HasColumnType("datetime");

                entity.Property(e => e.CheckStatusNotes).HasMaxLength(250);

                entity.Property(e => e.CheckStatusUser).HasMaxLength(50);

                entity.Property(e => e.CheckStatusUserV2).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasMaxLength(10);

                entity.Property(e => e.DateDeleted).HasColumnType("datetime");

                entity.Property(e => e.DateEdited).HasColumnType("datetime");

                entity.Property(e => e.DateInsert).HasColumnType("datetime");

                entity.Property(e => e.DateInsertEmail).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateRefund).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .HasColumnName("EmailID");

                entity.Property(e => e.EmailStatus).HasMaxLength(50);

                entity.Property(e => e.FlightDate).HasColumnType("datetime");

                entity.Property(e => e.FlightNum).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IdNum).HasMaxLength(50);

                entity.Property(e => e.LastDateUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Last_DateUpdate");

                entity.Property(e => e.LockDate).HasColumnType("datetime");

                entity.Property(e => e.LockDateV2)
                    .HasColumnType("datetime")
                    .HasColumnName("lockDateV2");

                entity.Property(e => e.LockUser).HasMaxLength(50);

                entity.Property(e => e.LockUserV2)
                    .HasMaxLength(50)
                    .HasColumnName("lockUserV2");

                entity.Property(e => e.MerchantTransactionId)
                    .HasMaxLength(250)
                    .HasColumnName("merchantTransactionId");

                entity.Property(e => e.MerchantTransactionIdNew)
                    .HasMaxLength(250)
                    .HasColumnName("merchantTransactionIdNew");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.PassportImagePath)
                    .HasMaxLength(500)
                    .HasColumnName("PassportImage_Path");

                entity.Property(e => e.PassportNum).HasMaxLength(50);

                entity.Property(e => e.PatArName).HasMaxLength(250);

                entity.Property(e => e.PatName).HasMaxLength(50);

                entity.Property(e => e.PatNationality).HasMaxLength(50);

                entity.Property(e => e.PaymentStatus).HasMaxLength(250);

                entity.Property(e => e.PcrPath)
                    .HasMaxLength(500)
                    .HasColumnName("PCR_Path");

                entity.Property(e => e.QrcodePath)
                    .HasMaxLength(500)
                    .HasColumnName("QRCode_Path");

                entity.Property(e => e.ReasonDeleted).HasMaxLength(250);

                entity.Property(e => e.ReferenceNo).HasMaxLength(50);

                entity.Property(e => e.Residency).HasMaxLength(50);

                entity.Property(e => e.TraDate).HasColumnType("datetime");

                entity.Property(e => e.Useddate).HasColumnType("datetime");

                entity.Property(e => e.UserDaleted).HasMaxLength(50);

                entity.Property(e => e.VaccineCertificatePath)
                    .HasMaxLength(500)
                    .HasColumnName("VaccineCertificate_Path");

                entity.Property(e => e.VaccineCountry).HasMaxLength(50);

                entity.Property(e => e.VaccineDose).HasColumnName("vaccineDose");

                entity.Property(e => e.VaccineQrlink)
                    .HasMaxLength(500)
                    .HasColumnName("VaccineQRLink");

                entity.Property(e => e.VisaNum).HasMaxLength(10);

                entity.Property(e => e.VisitJoId).HasColumnName("VisitJoID");

                entity.Property(e => e.VisitJoQr).HasColumnName("VisitJoQR");
            });

            modelBuilder.Entity<EnglishTranslateName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("English_Translate_Name");

                entity.Property(e => e.ArabicName)
                    .HasMaxLength(50)
                    .HasColumnName("Arabic_name");

                entity.Property(e => e.EnglishName)
                    .HasMaxLength(50)
                    .HasColumnName("English_name");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.IdAuto)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_auto");
            });

            modelBuilder.Entity<LabInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LabInfo");

                entity.Property(e => e.AAddress)
                    .HasMaxLength(350)
                    .HasColumnName("a_address");

                entity.Property(e => e.ADetails1)
                    .HasMaxLength(150)
                    .HasColumnName("a_details1");

                entity.Property(e => e.ADetails2)
                    .HasMaxLength(150)
                    .HasColumnName("a_details2");

                entity.Property(e => e.ADetails3)
                    .HasMaxLength(150)
                    .HasColumnName("a_details3");

                entity.Property(e => e.ALabname)
                    .HasMaxLength(150)
                    .HasColumnName("a_labname");

                entity.Property(e => e.AllowHideRefOne).HasColumnName("allow_hide_ref_one");

                entity.Property(e => e.AllowHideRefTow).HasColumnName("allow_hide_ref_tow");

                entity.Property(e => e.AllowViewPdfresult).HasColumnName("AllowViewPDFResult");

                entity.Property(e => e.Allowemptypatnamear).HasColumnName("allowemptypatnamear");

                entity.Property(e => e.ArMsgresultready)
                    .HasMaxLength(140)
                    .HasColumnName("ArMSGResultready");

                entity.Property(e => e.ArResultready).HasDefaultValueSql("((0))");

                entity.Property(e => e.BackupPath)
                    .HasMaxLength(3000)
                    .HasColumnName("backup_path");

                entity.Property(e => e.Barcode).HasColumnName("barcode");

                entity.Property(e => e.Being).HasMaxLength(350);

                entity.Property(e => e.BranchPrefix).HasMaxLength(10);

                entity.Property(e => e.Buttommargin).HasColumnName("buttommargin");

                entity.Property(e => e.Cbcrpt).HasColumnName("cbcrpt");

                entity.Property(e => e.ConnectAcc).HasColumnName("connectAcc");

                entity.Property(e => e.ConnectInv).HasColumnName("connectInv");

                entity.Property(e => e.ConnectWithHr).HasColumnName("ConnectWithHR");

                entity.Property(e => e.Connectionacc)
                    .HasColumnName("connectionacc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Connectionhr)
                    .HasColumnName("connectionhr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Connectionpsm)
                    .HasColumnName("connectionpsm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CrresRpt).HasColumnName("CRresRpt");

                entity.Property(e => e.CurrancyId).HasColumnName("currancyID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .HasColumnName("currency");

                entity.Property(e => e.DInvoice).HasColumnName("D_invoice");

                entity.Property(e => e.DefaultLangId).HasColumnName("DefaultLangID");

                entity.Property(e => e.Dend)
                    .HasColumnType("datetime")
                    .HasColumnName("dend");

                entity.Property(e => e.DotnetVersion).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EAddress)
                    .HasMaxLength(350)
                    .HasColumnName("e_address");

                entity.Property(e => e.EDetails1)
                    .HasMaxLength(150)
                    .HasColumnName("e_details1");

                entity.Property(e => e.EDetails2)
                    .HasMaxLength(150)
                    .HasColumnName("e_details2");

                entity.Property(e => e.EDetails3)
                    .HasMaxLength(150)
                    .HasColumnName("e_details3");

                entity.Property(e => e.ELabname)
                    .HasMaxLength(150)
                    .HasColumnName("e_labname");

                entity.Property(e => e.EnMsgresultready)
                    .HasColumnName("EnMSGResultready")
                    .HasDefaultValueSql("((320))");

                entity.Property(e => e.EnResultready).HasDefaultValueSql("((0))");

                entity.Property(e => e.Enablelogoff).HasColumnName("enablelogoff");

                entity.Property(e => e.Enachk)
                    .HasColumnName("ENAchk")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fieldsname).HasColumnName("fieldsname");

                entity.Property(e => e.FlutterVersion).HasColumnName("flutterVersion");

                entity.Property(e => e.FontSize).HasColumnName("font_size");

                entity.Property(e => e.FooterEmail).HasColumnName("footerEmail");

                entity.Property(e => e.FooterResult)
                    .HasMaxLength(200)
                    .HasColumnName("footerResult");

                entity.Property(e => e.FooterResultWeb).HasColumnName("footerResultWeb");

                entity.Property(e => e.HInvoice).HasColumnName("H_invoice");

                entity.Property(e => e.HWorksheetSize).HasColumnName("H_worksheet_size");

                entity.Property(e => e.HideLogo).HasDefaultValueSql("((0))");

                entity.Property(e => e.IncomePsm).HasColumnName("income_psm");

                entity.Property(e => e.InvPeriod).HasMaxLength(50);

                entity.Property(e => e.InvResDate).HasMaxLength(50);

                entity.Property(e => e.InvStart).HasMaxLength(50);

                entity.Property(e => e.InvType).HasMaxLength(50);

                entity.Property(e => e.InvoiceArchive).HasMaxLength(500);

                entity.Property(e => e.InvserDate).HasMaxLength(50);

                entity.Property(e => e.IpserverConnection)
                    .HasMaxLength(20)
                    .HasColumnName("IPserverConnection");

                entity.Property(e => e.LabAddress).HasMaxLength(500);

                entity.Property(e => e.LabEmail).HasMaxLength(50);

                entity.Property(e => e.LabFax).HasMaxLength(50);

                entity.Property(e => e.LabName).HasMaxLength(50);

                entity.Property(e => e.LabTelephone)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.LabUrl)
                    .HasMaxLength(50)
                    .HasColumnName("LabURL");

                entity.Property(e => e.Labpass)
                    .HasMaxLength(50)
                    .HasColumnName("labpass");

                entity.Property(e => e.Labpclass).HasColumnName("labpclass");

                entity.Property(e => e.Labsubtitel)
                    .HasMaxLength(250)
                    .HasColumnName("labsubtitel");

                entity.Property(e => e.Logofftime).HasColumnName("logofftime");

                entity.Property(e => e.Microbiologyrpt).HasColumnName("MICROBIOLOGYRpt");

                entity.Property(e => e.Msg)
                    .HasMaxLength(4000)
                    .HasColumnName("msg");

                entity.Property(e => e.MsgType).HasColumnName("msg_type");

                entity.Property(e => e.Munit).HasMaxLength(50);

                entity.Property(e => e.NotificationSms).HasColumnName("NotificationSMS");

                entity.Property(e => e.NotificationSmspre)
                    .HasMaxLength(25)
                    .HasColumnName("NotificationSMSPre");

                entity.Property(e => e.NotificationSmssuf).HasColumnName("NotificationSMSSuf");

                entity.Property(e => e.OutputPsm).HasColumnName("output_psm");

                entity.Property(e => e.PasswordSendpassword).HasMaxLength(50);

                entity.Property(e => e.PathOfVersionUpdate).HasMaxLength(280);

                entity.Property(e => e.Pdfpsmresult)
                    .HasMaxLength(250)
                    .HasColumnName("PDFPSMResult");

                entity.Property(e => e.Qc)
                    .HasMaxLength(250)
                    .HasColumnName("qc");

                entity.Property(e => e.ReplaceNr)
                    .HasColumnName("ReplaceNR")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReplaceNrword)
                    .HasMaxLength(250)
                    .HasColumnName("ReplaceNRWord");

                entity.Property(e => e.Reportcolor).HasColumnName("reportcolor");

                entity.Property(e => e.Rpttype).HasColumnName("rpttype");

                entity.Property(e => e.Seminrpt).HasColumnName("seminrpt");

                entity.Property(e => e.SendSmswhenReady)
                    .HasColumnName("SendSMSwhenReady")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Separetedsheet).HasColumnName("separetedsheet");

                entity.Property(e => e.Setbarcode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("setbarcode");

                entity.Property(e => e.ShowLabName).HasColumnName("showLabName");

                entity.Property(e => e.ShowLine).HasColumnName("show_line");

                entity.Property(e => e.Showcheckedby).HasColumnName("showcheckedby");

                entity.Property(e => e.Sign).HasColumnName("sign");

                entity.Property(e => e.Smsprovider).HasColumnName("SMSProvider");

                entity.Property(e => e.Spec)
                    .HasMaxLength(250)
                    .HasColumnName("spec");

                entity.Property(e => e.Stoolrpt).HasColumnName("stoolrpt");

                entity.Property(e => e.Svoucher).HasColumnName("svoucher");

                entity.Property(e => e.TMax).HasColumnName("tMAX");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .HasColumnName("title");

                entity.Property(e => e.Topmargin).HasColumnName("topmargin");

                entity.Property(e => e.TranPen).HasColumnName("tran_pen");

                entity.Property(e => e.TypeLine).HasColumnName("type_line");

                entity.Property(e => e.UpdateDb)
                    .HasMaxLength(3)
                    .HasColumnName("UpdateDB");

                entity.Property(e => e.Urinerpt).HasColumnName("urinerpt");

                entity.Property(e => e.UserNameSendpassword).HasMaxLength(50);

                entity.Property(e => e.Workdays).HasColumnName("workdays");

                entity.Property(e => e.WsheetFontSize)
                    .HasMaxLength(10)
                    .HasColumnName("WSheetFont_size")
                    .HasDefaultValueSql("((11))");
            });

            modelBuilder.Entity<LabelsTable>(entity =>
            {
                entity.HasKey(e => e.IdLocal)
                    .HasName("PK_LabelsTable_1");

                entity.ToTable("LabelsTable");

                entity.Property(e => e.IdLocal)
                    .HasColumnType("decimal(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_local");

                entity.Property(e => e.FormName).HasMaxLength(250);

                entity.Property(e => e.Id).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Label).HasMaxLength(250);

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<MacaddressPc>(entity =>
            {
                entity.HasKey(e => e.IdLocal)
                    .HasName("PK_macaddress_pc_1");

                entity.ToTable("macaddress_pc");

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.AccountingPatients).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActiveKey)
                    .HasMaxLength(50)
                    .HasColumnName("active_key");

                entity.Property(e => e.AllowPrintReferralResult)
                    .HasColumnName("allowPrintReferralResult")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("branch_code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BranchCodeR)
                    .HasMaxLength(10)
                    .HasColumnName("branch_code_r")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Covid).HasColumnName("COVID");

                entity.Property(e => e.Department).HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.FilterEnable).HasMaxLength(150);

                entity.Property(e => e.IdAuto).HasColumnName("id_auto");

                entity.Property(e => e.IdLab).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(50)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.LastV).HasColumnType("datetime");

                entity.Property(e => e.Location).HasDefaultValueSql("((0))");

                entity.Property(e => e.Macaddress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("macaddress");

                entity.Property(e => e.Machine).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notess).HasColumnName("notess");

                entity.Property(e => e.PaidAccount)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paperless)
                    .HasColumnName("paperless")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Pcgroup)
                    .HasColumnName("PCGroup")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductKey)
                    .HasMaxLength(50)
                    .HasColumnName("product_key");

                entity.Property(e => e.ReceptionVersion).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReferralPc)
                    .HasColumnName("ReferralPC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Trackingbranch).HasColumnName("trackingbranch");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PassengerNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PassengerNote");

                entity.Property(e => e.DateInsert)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.PassportNum).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<ReplaseChar>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReplaseChar");

                entity.Property(e => e.Ascii).HasColumnName("ascii");

                entity.Property(e => e.CharReplase).HasMaxLength(10);

                entity.Property(e => e.Chars).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Location)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<SystemMessage>(entity =>
            {
                entity.HasKey(e => e.IdLocal);

                entity.HasIndex(e => e.MsgCode, "UQ__SystemMe__0AAF161D23A47623")
                    .IsUnique();

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MsgCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MsgHeadPart1).HasMaxLength(50);

                entity.Property(e => e.MsgHeadPart2).HasMaxLength(50);

                entity.Property(e => e.MsgbodyPart1).HasMaxLength(200);

                entity.Property(e => e.MsgbodyPart2).HasMaxLength(200);

                entity.Property(e => e.MsgbodyPart3).HasMaxLength(200);

                entity.Property(e => e.MsgbodyPart4).HasMaxLength(200);

                entity.Property(e => e.MsgbodyPart5).HasMaxLength(200);
            });

            modelBuilder.Entity<TemplateTransactionforCopy>(entity =>
            {
                entity.HasKey(e => e.IdLocal);

                entity.ToTable("TemplateTransactionforCopy");

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.BranchCode).HasMaxLength(50);

                entity.Property(e => e.DateInsert).HasColumnType("datetime");

                entity.Property(e => e.Disc).HasMaxLength(50);
            });

            modelBuilder.Entity<TransCrossing>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trans_crossings");

                entity.Property(e => e.Age)
                    .HasMaxLength(50)
                    .HasColumnName("age");

                entity.Property(e => e.BranchCode).HasMaxLength(10);

                entity.Property(e => e.CopyFromTransno).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnType("date")
                    .HasColumnName("dateofbirth");

                entity.Property(e => e.Datetimeinsert)
                    .HasColumnType("datetime")
                    .HasColumnName("datetimeinsert");

                entity.Property(e => e.Days)
                    .HasMaxLength(50)
                    .HasColumnName("days");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.FlightNumber).HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Macaddress)
                    .HasMaxLength(50)
                    .HasColumnName("macaddress");

                entity.Property(e => e.Ocr).HasColumnName("OCR");

                entity.Property(e => e.PassportIdno).HasColumnName("PassportIDNO");

                entity.Property(e => e.Passportno)
                    .HasMaxLength(50)
                    .HasColumnName("passportno");

                entity.Property(e => e.PatMobile).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PatRegBiolab).HasColumnName("pat_reg_biolab");

                entity.Property(e => e.PatarName).HasMaxLength(250);

                entity.Property(e => e.Patname)
                    .HasMaxLength(250)
                    .HasColumnName("patname");

                entity.Property(e => e.PrintIdnumber).HasColumnName("PrintIDnumber");

                entity.Property(e => e.Refno)
                    .HasMaxLength(50)
                    .HasColumnName("refno");

                entity.Property(e => e.Refno2)
                    .HasMaxLength(50)
                    .HasColumnName("refno2");

                entity.Property(e => e.Refnumber)
                    .HasMaxLength(50)
                    .HasColumnName("refnumber");

                entity.Property(e => e.Transno)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("transno");

                entity.Property(e => e.Userid)
                    .HasMaxLength(150)
                    .HasColumnName("userid");

                entity.Property(e => e.Visa)
                    .HasMaxLength(50)
                    .HasColumnName("visa");

                entity.Property(e => e.VisitJoQr)
                    .HasMaxLength(120)
                    .HasColumnName("VisitJoQR");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdLocal);

                entity.Property(e => e.IdLocal).HasColumnName("id_local");

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(50)
                    .HasColumnName("branch_Code");

                entity.Property(e => e.BranchId)
                    .HasMaxLength(4)
                    .HasColumnName("branch_id");

                entity.Property(e => e.BranchNo).HasColumnType("decimal(2, 0)");

                entity.Property(e => e.Checkuser1)
                    .HasColumnName("checkuser1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DateLastmodify)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Empno).HasColumnName("empno");

                entity.Property(e => e.Give)
                    .HasMaxLength(100)
                    .HasColumnName("give");

                entity.Property(e => e.GroupName).HasMaxLength(100);

                entity.Property(e => e.Have).HasColumnName("have");

                entity.Property(e => e.Have3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("have3");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("id");

                entity.Property(e => e.LastPermissionsModify)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastmodify)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Loged)
                    .HasColumnName("loged")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NewName).HasMaxLength(100);

                entity.Property(e => e.OldPass).HasMaxLength(20);

                entity.Property(e => e.Statuss)
                    .HasMaxLength(50)
                    .HasColumnName("statuss");

                entity.Property(e => e.Text1)
                    .HasColumnName("text1")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.Text2).HasColumnName("text2");

                entity.Property(e => e.Text3).HasColumnName("text3");

                entity.Property(e => e.Text4).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Text5).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Text6).HasDefaultValueSql("((0))");

                entity.Property(e => e.Text7).HasDefaultValueSql("((0))");

                entity.Property(e => e.Uid)
                    .HasMaxLength(50)
                    .HasColumnName("uid");

                entity.Property(e => e.Ulevel).HasColumnName("ulevel");

                entity.Property(e => e.Uname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("uname");

                entity.Property(e => e.Upass).HasColumnName("upass");

                entity.Property(e => e.UserEmail).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
