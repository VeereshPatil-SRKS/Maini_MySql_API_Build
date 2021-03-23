using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IFacilityMaini.DBModels.ToolPulse
{
    public partial class i_facility_tsalContext : DbContext
    {
        public i_facility_tsalContext()
        {
        }

        public i_facility_tsalContext(DbContextOptions<i_facility_tsalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlarmHistoryMaster> AlarmHistoryMaster { get; set; }
        public virtual DbSet<AlarmMaster> AlarmMaster { get; set; }
        public virtual DbSet<AlarmReport> AlarmReport { get; set; }
        public virtual DbSet<Automaticjobcard> Automaticjobcard { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<CodeMaster> CodeMaster { get; set; }
        public virtual DbSet<CuttingTimeReport> CuttingTimeReport { get; set; }
        public virtual DbSet<CuttingTimeReportPdf> CuttingTimeReportPdf { get; set; }
        public virtual DbSet<DayStEndTime> DayStEndTime { get; set; }
        public virtual DbSet<Frommail> Frommail { get; set; }
        public virtual DbSet<HandleNoPing> HandleNoPing { get; set; }
        public virtual DbSet<JobcardDetails> JobcardDetails { get; set; }
        public virtual DbSet<LoginTrackerDetails> LoginTrackerDetails { get; set; }
        public virtual DbSet<MachineDetailsWimerasys> MachineDetailsWimerasys { get; set; }
        public virtual DbSet<MachineMaster> MachineMaster { get; set; }
        public virtual DbSet<Mailmaster> Mailmaster { get; set; }
        public virtual DbSet<Mailmasterprogesc> Mailmasterprogesc { get; set; }
        public virtual DbSet<MainTimeRep> MainTimeRep { get; set; }
        public virtual DbSet<MessageCodeMaster> MessageCodeMaster { get; set; }
        public virtual DbSet<MessageHistoryMaster> MessageHistoryMaster { get; set; }
        public virtual DbSet<Opcuttimereport> Opcuttimereport { get; set; }
        public virtual DbSet<OpcuttimereportPdf> OpcuttimereportPdf { get; set; }
        public virtual DbSet<OperatingTimeReport> OperatingTimeReport { get; set; }
        public virtual DbSet<OperatingTimeReportPdf> OperatingTimeReportPdf { get; set; }
        public virtual DbSet<Operationlog> Operationlog { get; set; }
        public virtual DbSet<ParameterSendorData> ParameterSendorData { get; set; }
        public virtual DbSet<ParameterSensorDataCurrent> ParameterSensorDataCurrent { get; set; }
        public virtual DbSet<ParameterSensorDataLevel> ParameterSensorDataLevel { get; set; }
        public virtual DbSet<ParameterSensorDataPressure> ParameterSensorDataPressure { get; set; }
        public virtual DbSet<ParameterSensorDataTemperature> ParameterSensorDataTemperature { get; set; }
        public virtual DbSet<ParameterToolData> ParameterToolData { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<ParametersMaster> ParametersMaster { get; set; }
        public virtual DbSet<Pcb> Pcb { get; set; }
        public virtual DbSet<PcbDetails> PcbDetails { get; set; }
        public virtual DbSet<PcbParameters> PcbParameters { get; set; }
        public virtual DbSet<Pcbdaq> Pcbdaq { get; set; }
        public virtual DbSet<PcbdaqinTbl> PcbdaqinTbl { get; set; }
        public virtual DbSet<PcbdpsMaster> PcbdpsMaster { get; set; }
        public virtual DbSet<ProgramExecutionMaster> ProgramExecutionMaster { get; set; }
        public virtual DbSet<ProgramMaster> ProgramMaster { get; set; }
        public virtual DbSet<ProgramTemp> ProgramTemp { get; set; }
        public virtual DbSet<Recipientmailid> Recipientmailid { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<SapFileGeneratedDetails> SapFileGeneratedDetails { get; set; }
        public virtual DbSet<ShiftMaster> ShiftMaster { get; set; }
        public virtual DbSet<TblAutoreportLog> TblAutoreportLog { get; set; }
        public virtual DbSet<TblAutoreportbasedon> TblAutoreportbasedon { get; set; }
        public virtual DbSet<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual DbSet<TblAutoreporttime> TblAutoreporttime { get; set; }
        public virtual DbSet<TblAxisdetails1> TblAxisdetails1 { get; set; }
        public virtual DbSet<TblAxisdetails2> TblAxisdetails2 { get; set; }
        public virtual DbSet<TblBookStock> TblBookStock { get; set; }
        public virtual DbSet<TblCellFinalMaster> TblCellFinalMaster { get; set; }
        public virtual DbSet<TblClassMaster> TblClassMaster { get; set; }
        public virtual DbSet<TblDefectCodeMaster> TblDefectCodeMaster { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblFgAndCellAllocation> TblFgAndCellAllocation { get; set; }
        public virtual DbSet<TblFgPartNoDet> TblFgPartNoDet { get; set; }
        public virtual DbSet<TblIpAddress> TblIpAddress { get; set; }
        public virtual DbSet<TblIssuedReceived> TblIssuedReceived { get; set; }
        public virtual DbSet<TblMaterialMaster> TblMaterialMaster { get; set; }
        public virtual DbSet<TblMultiwoselection> TblMultiwoselection { get; set; }
        public virtual DbSet<TblOperatorDetails> TblOperatorDetails { get; set; }
        public virtual DbSet<TblProductWiseDefectCode> TblProductWiseDefectCode { get; set; }
        public virtual DbSet<TblRaisedTicket> TblRaisedTicket { get; set; }
        public virtual DbSet<TblRejectionDetails> TblRejectionDetails { get; set; }
        public virtual DbSet<TblReportmaster> TblReportmaster { get; set; }
        public virtual DbSet<TblReworkDetails> TblReworkDetails { get; set; }
        public virtual DbSet<TblSourceMaster> TblSourceMaster { get; set; }
        public virtual DbSet<TblStatusMaster> TblStatusMaster { get; set; }
        public virtual DbSet<TblStoppage> TblStoppage { get; set; }
        public virtual DbSet<TblSubCellFinalMaster> TblSubCellFinalMaster { get; set; }
        public virtual DbSet<TblSystemConfig> TblSystemConfig { get; set; }
        public virtual DbSet<TblTicketRaisedDet> TblTicketRaisedDet { get; set; }
        public virtual DbSet<TblToolBrDnReasonLvl1> TblToolBrDnReasonLvl1 { get; set; }
        public virtual DbSet<TblToolBrkDnReason> TblToolBrkDnReason { get; set; }
        public virtual DbSet<TblTools> TblTools { get; set; }
        public virtual DbSet<TblWorkCenter> TblWorkCenter { get; set; }
        public virtual DbSet<Tblactivitylog> Tblactivitylog { get; set; }
        public virtual DbSet<TblappPaths> TblappPaths { get; set; }
        public virtual DbSet<Tblbreakdown> Tblbreakdown { get; set; }
        public virtual DbSet<Tblbreakdowncodes> Tblbreakdowncodes { get; set; }
        public virtual DbSet<Tblcell> Tblcell { get; set; }
        public virtual DbSet<Tblcustomer> Tblcustomer { get; set; }
        public virtual DbSet<Tbldailyprodstatus> Tbldailyprodstatus { get; set; }
        public virtual DbSet<Tbldailyprodstatushis> Tbldailyprodstatushis { get; set; }
        public virtual DbSet<Tbldaytiming> Tbldaytiming { get; set; }
        public virtual DbSet<Tblddl> Tblddl { get; set; }
        public virtual DbSet<Tbldowntimecategory> Tbldowntimecategory { get; set; }
        public virtual DbSet<Tbldowntimedetails> Tbldowntimedetails { get; set; }
        public virtual DbSet<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual DbSet<Tblemailreporttype> Tblemailreporttype { get; set; }
        public virtual DbSet<Tblendcodes> Tblendcodes { get; set; }
        public virtual DbSet<Tblescalationlog> Tblescalationlog { get; set; }
        public virtual DbSet<Tblgenericworkcodes> Tblgenericworkcodes { get; set; }
        public virtual DbSet<Tblgenericworkentry> Tblgenericworkentry { get; set; }
        public virtual DbSet<Tblhmiscreen> Tblhmiscreen { get; set; }
        public virtual DbSet<Tblholdcodes> Tblholdcodes { get; set; }
        public virtual DbSet<Tbllivedailyprodstatus> Tbllivedailyprodstatus { get; set; }
        public virtual DbSet<Tbllivehmiscreen> Tbllivehmiscreen { get; set; }
        public virtual DbSet<Tbllivehmiscreenrep> Tbllivehmiscreenrep { get; set; }
        public virtual DbSet<Tbllivelossofentry> Tbllivelossofentry { get; set; }
        public virtual DbSet<Tbllivelossofentryrep> Tbllivelossofentryrep { get; set; }
        public virtual DbSet<Tbllivemanuallossofentry> Tbllivemanuallossofentry { get; set; }
        public virtual DbSet<Tbllivemanuallossofentryrep> Tbllivemanuallossofentryrep { get; set; }
        public virtual DbSet<Tbllivemode> Tbllivemode { get; set; }
        public virtual DbSet<Tbllivemodedb> Tbllivemodedb { get; set; }
        public virtual DbSet<Tbllivemultiwoselection> Tbllivemultiwoselection { get; set; }
        public virtual DbSet<Tbllossescodes> Tbllossescodes { get; set; }
        public virtual DbSet<Tbllossofentry> Tbllossofentry { get; set; }
        public virtual DbSet<TblmachineMaster> TblmachineMaster { get; set; }
        public virtual DbSet<Tblmachineallocation> Tblmachineallocation { get; set; }
        public virtual DbSet<Tblmachinecategory> Tblmachinecategory { get; set; }
        public virtual DbSet<Tblmachinedetails> Tblmachinedetails { get; set; }
        public virtual DbSet<Tblmachinedetailsnew> Tblmachinedetailsnew { get; set; }
        public virtual DbSet<Tblmailids> Tblmailids { get; set; }
        public virtual DbSet<Tblmanuallossofentry> Tblmanuallossofentry { get; set; }
        public virtual DbSet<TblmasterpartsStSw> TblmasterpartsStSw { get; set; }
        public virtual DbSet<Tblmimics> Tblmimics { get; set; }
        public virtual DbSet<Tblmode> Tblmode { get; set; }
        public virtual DbSet<Tblmodulehelper> Tblmodulehelper { get; set; }
        public virtual DbSet<Tblmodulemaster> Tblmodulemaster { get; set; }
        public virtual DbSet<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual DbSet<Tblnetworkdetailsforddl> Tblnetworkdetailsforddl { get; set; }
        public virtual DbSet<Tbloeedashboardfinalvariables> Tbloeedashboardfinalvariables { get; set; }
        public virtual DbSet<Tbloeedashboardvariables> Tbloeedashboardvariables { get; set; }
        public virtual DbSet<Tbloeedashboardvariablestoday> Tbloeedashboardvariablestoday { get; set; }
        public virtual DbSet<Tblparts> Tblparts { get; set; }
        public virtual DbSet<Tblpartwisesp> Tblpartwisesp { get; set; }
        public virtual DbSet<Tblpartwiseworkcenter> Tblpartwiseworkcenter { get; set; }
        public virtual DbSet<Tblplannedbreak> Tblplannedbreak { get; set; }
        public virtual DbSet<Tblplant> Tblplant { get; set; }
        public virtual DbSet<Tblpriorityalarms> Tblpriorityalarms { get; set; }
        public virtual DbSet<Tblreportholder> Tblreportholder { get; set; }
        public virtual DbSet<Tblroleplaymaster> Tblroleplaymaster { get; set; }
        public virtual DbSet<Tblroles> Tblroles { get; set; }
        public virtual DbSet<Tblsendermailid> Tblsendermailid { get; set; }
        public virtual DbSet<TblshiftBreaks> TblshiftBreaks { get; set; }
        public virtual DbSet<TblshiftMstr> TblshiftMstr { get; set; }
        public virtual DbSet<Tblshiftdetails> Tblshiftdetails { get; set; }
        public virtual DbSet<TblshiftdetailsMachinewise> TblshiftdetailsMachinewise { get; set; }
        public virtual DbSet<Tblshiftmethod> Tblshiftmethod { get; set; }
        public virtual DbSet<Tblshiftplanner> Tblshiftplanner { get; set; }
        public virtual DbSet<Tblshop> Tblshop { get; set; }
        public virtual DbSet<Tbltosapfilepath> Tbltosapfilepath { get; set; }
        public virtual DbSet<Tbltosapshopnames> Tbltosapshopnames { get; set; }
        public virtual DbSet<Tblunit> Tblunit { get; set; }
        public virtual DbSet<Tblusers> Tblusers { get; set; }
        public virtual DbSet<Tblwolossess> Tblwolossess { get; set; }
        public virtual DbSet<Tblworeport> Tblworeport { get; set; }
        public virtual DbSet<UserMaster> UserMaster { get; set; }

        // Unable to generate entity type for table 'dbo.parametermaster_view'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.main_time_view'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.person'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=EC2AMAZ-L5INV42\\SQLEXPRESS;Database=i_facility_tsal;user id=sa;password=srks4$;");
                //optionsBuilder.UseSqlServer("Server=TCP:172.16.8.5,1433;Database=i_facility_tsal;user id=sa;password=srks4$maini;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AlarmHistoryMaster>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("PK__alarm_hi__43E5EB15ECD1AF72");

                entity.ToTable("alarm_history_master");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AbsPos)
                    .HasColumnName("Abs_Pos")
                    .HasMaxLength(45);

                entity.Property(e => e.AlarmDate).HasColumnType("date");

                entity.Property(e => e.AlarmDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.AlarmMessage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.AlarmNo).HasMaxLength(45);

                entity.Property(e => e.AlarmTime).HasColumnType("time(0)");

                entity.Property(e => e.AxisNo)
                    .HasColumnName("Axis_No")
                    .HasMaxLength(45);

                entity.Property(e => e.AxisNum)
                    .HasColumnName("Axis_Num")
                    .HasMaxLength(45);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.DetailCode1)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DetailCode2)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DetailCode3)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorNum)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.InterferedPart)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Shift)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SystemHead)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlarmMaster>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("PK__alarm_ma__43E5EB15D4BF88EE");

                entity.ToTable("alarm_master");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AlarmNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AlarmReport>(entity =>
            {
                entity.HasKey(e => e.Reportid)
                    .HasName("PK__alarm_re__1C9A4255AB1F4C4D");

                entity.ToTable("alarm_report");

                entity.Property(e => e.Reportid).HasColumnName("reportid");

                entity.Property(e => e.Alarmdatetime)
                    .HasColumnName("alarmdatetime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Alarmdescn)
                    .HasColumnName("alarmdescn")
                    .IsUnicode(false);

                entity.Property(e => e.Alarmno)
                    .HasColumnName("alarmno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Slno).HasColumnName("slno");
            });

            modelBuilder.Entity<Automaticjobcard>(entity =>
            {
                entity.HasKey(e => e.JobcardId)
                    .HasName("PK__automati__486B76F99F403E8E");

                entity.ToTable("automaticjobcard");

                entity.Property(e => e.JobcardId).HasColumnName("JobcardID");

                entity.Property(e => e.Compcode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fromdatetime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Fromtime).HasColumnType("time(0)");

                entity.Property(e => e.JobCardDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineInvNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OpnIdleCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Slno).HasColumnName("slno");

                entity.Property(e => e.Totalhours)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Totime).HasColumnType("time(0)");

                entity.Property(e => e.Workorderno)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Books>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__books__C6DE0D211B9249CF");

                entity.ToTable("books");

                entity.Property(e => e.Bid).HasColumnName("BID");

                entity.Property(e => e.BookName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CodeMaster>(entity =>
            {
                entity.HasKey(e => e.CodeId)
                    .HasName("PK__code_mas__C6DE2C35D4EA356A");

                entity.ToTable("code_master");

                entity.Property(e => e.CodeId).HasColumnName("CodeID");

                entity.Property(e => e.CodeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Mcode)
                    .HasColumnName("MCode")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<CuttingTimeReport>(entity =>
            {
                entity.HasKey(e => e.CuttingId)
                    .HasName("PK__cutting___565E851FCE26062C");

                entity.ToTable("cutting_time_report");

                entity.Property(e => e.CuttingId).HasColumnName("CuttingID");

                entity.Property(e => e.CuttingDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuttingtimeinserted).HasColumnType("time(0)");
            });

            modelBuilder.Entity<CuttingTimeReportPdf>(entity =>
            {
                entity.HasKey(e => e.CuttingId)
                    .HasName("PK__cutting___565E851FB2E96E28");

                entity.ToTable("cutting_time_report_pdf");

                entity.Property(e => e.CuttingId).HasColumnName("CuttingID");

                entity.Property(e => e.CuttingDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cuttingtimeinserted).HasColumnType("time(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");
            });

            modelBuilder.Entity<DayStEndTime>(entity =>
            {
                entity.HasKey(e => e.DayId)
                    .HasName("PK__day_st_e__BF3DD8258EF0C075");

                entity.ToTable("day_st_end_time");

                entity.Property(e => e.DayId).HasColumnName("DayID");

                entity.Property(e => e.DayEnd).HasColumnType("time(0)");

                entity.Property(e => e.DayStart).HasColumnType("time(0)");
            });

            modelBuilder.Entity<Frommail>(entity =>
            {
                entity.ToTable("frommail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FromEmailAdd)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HandleNoPing>(entity =>
            {
                entity.HasKey(e => e.NoPingId)
                    .HasName("PK__handle_n__BD968057FBD07A93");

                entity.ToTable("handle_no_ping");

                entity.Property(e => e.NoPingId).HasColumnName("NoPingID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<JobcardDetails>(entity =>
            {
                entity.HasKey(e => e.JobcardId)
                    .HasName("PK__jobcard___486B76F99D09BF0C");

                entity.ToTable("jobcard_details");

                entity.Property(e => e.JobcardId).HasColumnName("JobcardID");

                entity.Property(e => e.Compcode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fromdatetime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Fromtime).HasColumnType("time(0)");

                entity.Property(e => e.JobCardDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineInvNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OpnIdleCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Slno).HasColumnName("slno");

                entity.Property(e => e.Totalhours)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Totime).HasColumnType("time(0)");

                entity.Property(e => e.Workorderno)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LoginTrackerDetails>(entity =>
            {
                entity.ToTable("loginTrackerDetails");

                entity.Property(e => e.LoginTrackerDetailsId).HasColumnName("loginTrackerDetailsId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentFgpart).HasColumnName("currentFGPart");

                entity.Property(e => e.CurrentTicketRaisedId).HasColumnName("currentTicketRaisedId");

                entity.Property(e => e.InsertedOn)
                    .HasColumnName("insertedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLoggedIn).HasColumnName("isLoggedIn");

                entity.Property(e => e.LoginDateTime)
                    .HasColumnName("loginDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogoutDateTime)
                    .HasColumnName("logoutDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MachineDetailsWimerasys>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("machineDetailsWimerasys");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LoggerType)
                    .HasColumnName("loggerType")
                    .HasMaxLength(500);

                entity.Property(e => e.MachineIp)
                    .HasColumnName("machineIp")
                    .HasMaxLength(500);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machineName")
                    .HasMaxLength(500);

                entity.Property(e => e.MachinePort).HasColumnName("machinePort");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumOfAxis).HasColumnName("numOfAxis");

                entity.Property(e => e.NumberOfCurrent).HasColumnName("numberOfCurrent");

                entity.Property(e => e.NumberOfLevel).HasColumnName("numberOfLevel");

                entity.Property(e => e.NumberOfPresure).HasColumnName("numberOfPresure");

                entity.Property(e => e.NumberOfTemperature).HasColumnName("numberOfTemperature");

                entity.Property(e => e.ToolGroupNum).HasColumnName("toolGroupNum");

                entity.Property(e => e.TransmissionFrequency).HasColumnName("transmissionFrequency");
            });

            modelBuilder.Entity<MachineMaster>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK__machine___44EE5B58A43839DD");

                entity.ToTable("machine_master");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ControllerType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsParameters).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineDispName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineInvNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineMake)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineModel)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModelType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Mailmaster>(entity =>
            {
                entity.ToTable("mailmaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bccadd)
                    .HasColumnName("BCCAdd")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Ccadd)
                    .HasColumnName("CCAdd")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Toadd)
                    .HasColumnName("TOAdd")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<Mailmasterprogesc>(entity =>
            {
                entity.ToTable("mailmasterprogesc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bccadd)
                    .HasColumnName("BCCAdd")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Ccadd)
                    .HasColumnName("CCAdd")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Toadd)
                    .HasColumnName("TOAdd")
                    .HasDefaultValueSql("('1')");
            });

            modelBuilder.Entity<MainTimeRep>(entity =>
            {
                entity.ToTable("main_time_rep");

                entity.Property(e => e.MainTimeRepId).HasColumnName("MainTimeRepID");

                entity.Property(e => e.CorrectedDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MonthName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeekRange)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MessageCodeMaster>(entity =>
            {
                entity.HasKey(e => e.MessageCodeId)
                    .HasName("PK__message___5AAB69F9844AC872");

                entity.ToTable("message_code_master");

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.ColourCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MessageCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDescription)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.MessageMcode)
                    .IsRequired()
                    .HasColumnName("MessageMCode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ReportDispName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MessageHistoryMaster>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK__message___C87C037CDCB9F795");

                entity.ToTable("message_history_master");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Meassage)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDate).HasColumnType("date");

                entity.Property(e => e.MessageDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.MessageNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageShift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTime).HasColumnType("time(0)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Opcuttimereport>(entity =>
            {
                entity.HasKey(e => e.IdOpCutTimeReport)
                    .HasName("PK__opcuttim__DE767BD8D2150E6A");

                entity.ToTable("opcuttimereport");

                entity.Property(e => e.IdOpCutTimeReport).HasColumnName("idOpCutTimeReport");

                entity.Property(e => e.ReportDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Timeinserted).HasColumnType("time(0)");
            });

            modelBuilder.Entity<OpcuttimereportPdf>(entity =>
            {
                entity.HasKey(e => e.IdOpCutTimeReportPdf)
                    .HasName("PK__opcuttim__8BF44144228D5C9C");

                entity.ToTable("opcuttimereport_pdf");

                entity.Property(e => e.IdOpCutTimeReportPdf).HasColumnName("idOpCutTimeReport_pdf");

                entity.Property(e => e.ReportDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperatingTimeReport>(entity =>
            {
                entity.HasKey(e => e.OperatingId)
                    .HasName("PK__operatin__407BCF4F8E66D80B");

                entity.ToTable("operating_time_report");

                entity.Property(e => e.OperatingId).HasColumnName("OperatingID");

                entity.Property(e => e.OperatingDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Operatingtimeinserted).HasColumnType("time(0)");
            });

            modelBuilder.Entity<OperatingTimeReportPdf>(entity =>
            {
                entity.HasKey(e => e.OperatingId)
                    .HasName("PK__operatin__407BCF4F492D628E");

                entity.ToTable("operating_time_report_pdf");

                entity.Property(e => e.OperatingId).HasColumnName("OperatingID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperatingDate)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Operatingtimeinserted).HasColumnType("time(0)");
            });

            modelBuilder.Entity<Operationlog>(entity =>
            {
                entity.HasKey(e => e.Idoperationlog)
                    .HasName("PK__operatio__FD72368E6BF0F33E");

                entity.ToTable("operationlog");

                entity.Property(e => e.Idoperationlog).HasColumnName("idoperationlog");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OpDate).HasColumnType("date");

                entity.Property(e => e.OpDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.OpMsg).IsUnicode(false);

                entity.Property(e => e.OpReason)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.OpTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<ParameterSendorData>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataId);

                entity.ToTable("parameter_sendor_data");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.SensorDataCapturedTime)
                    .HasColumnName("sensorDataCapturedTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ParameterSensorDataCurrent>(entity =>
            {
                entity.ToTable("parameter_sensor_data_current");

                entity.Property(e => e.ParameterSensorDataCurrentId).HasColumnName("parameterSensorDataCurrentId");

                entity.Property(e => e.CurrentValue)
                    .HasColumnName("currentValue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");
            });

            modelBuilder.Entity<ParameterSensorDataLevel>(entity =>
            {
                entity.ToTable("parameter_sensor_data_level");

                entity.Property(e => e.ParameterSensorDataLevelId).HasColumnName("parameterSensorDataLevelId");

                entity.Property(e => e.LevelValue)
                    .HasColumnName("levelValue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");
            });

            modelBuilder.Entity<ParameterSensorDataPressure>(entity =>
            {
                entity.ToTable("parameter_sensor_data_pressure");

                entity.Property(e => e.ParameterSensorDataPressureId).HasColumnName("parameterSensorDataPressureId");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");

                entity.Property(e => e.PressureValue)
                    .HasColumnName("pressureValue")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ParameterSensorDataTemperature>(entity =>
            {
                entity.ToTable("parameter_sensor_data_temperature");

                entity.Property(e => e.ParameterSensorDataTemperatureId).HasColumnName("parameterSensorDataTemperatureId");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");

                entity.Property(e => e.TemperatureValue)
                    .HasColumnName("temperatureValue")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ParameterToolData>(entity =>
            {
                entity.ToTable("parameter_tool_data");

                entity.Property(e => e.ParameterToolDataId).HasColumnName("parameterToolDataId");

                entity.Property(e => e.Capacity).HasColumnName("capacity");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ParameterToolDataCapturedDate)
                    .HasColumnName("parameterToolDataCapturedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Partsproduced).HasColumnName("partsproduced");

                entity.Property(e => e.ToolGroupName)
                    .HasColumnName("toolGroupName")
                    .HasMaxLength(50);

                entity.Property(e => e.ToolNumber)
                    .HasColumnName("toolNumber")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK__paramete__F80C62972417E977");

                entity.ToTable("parameters");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ParameterType)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ParametersMaster>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK__paramete__F80C629711163826");

                entity.ToTable("parameters_master");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.AutoCutTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CuttingTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.TotalCutTime)
                    .HasColumnName("Total_CutTime")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pcb>(entity =>
            {
                entity.ToTable("pcb");

                entity.Property(e => e.Pcbid).HasColumnName("PCBID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Pcbipaddress)
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbmacaddress)
                    .HasColumnName("PCBMACAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbno).HasColumnName("PCBNo");
            });

            modelBuilder.Entity<PcbDetails>(entity =>
            {
                entity.HasKey(e => e.Pcbid)
                    .HasName("PK__pcb_deta__71A14547197FF022");

                entity.ToTable("pcb_details");

                entity.Property(e => e.Pcbid).HasColumnName("PCBID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbmacaddress)
                    .HasColumnName("PCBMACAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbno).HasColumnName("PCBNo");
            });

            modelBuilder.Entity<PcbParameters>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK__pcb_para__F80C62974BA266EF");

                entity.ToTable("pcb_parameters");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HighValue).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsPulse).HasDefaultValueSql("('0')");

                entity.Property(e => e.LogFile)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ParameterType)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Pcbdaq>(entity =>
            {
                entity.ToTable("pcbdaq");

                entity.Property(e => e.Pcbdaqid).HasColumnName("PCBDAQID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PcbdateTime)
                    .HasColumnName("PCBDateTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcbdaqinTbl>(entity =>
            {
                entity.HasKey(e => e.Daqinid)
                    .HasName("PK__pcbdaqin__94D17D8073D57FCA");

                entity.ToTable("pcbdaqin_tbl");

                entity.Property(e => e.Daqinid)
                    .HasColumnName("DAQINID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ParamPin).HasColumnName("ParamPIN");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PcbdpsMaster>(entity =>
            {
                entity.ToTable("pcbdps_master");

                entity.Property(e => e.PcbDpsMasterId).HasColumnName("PcbDpsMasterID");

                entity.Property(e => e.ColorValue)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");
            });

            modelBuilder.Entity<ProgramExecutionMaster>(entity =>
            {
                entity.HasKey(e => e.ProgramExecutionId);

                entity.ToTable("program_execution_master");

                entity.Property(e => e.ProgramExecutionId).HasColumnName("programExecutionId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgramEndDateTime)
                    .HasColumnName("programEndDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgramExcutedDateTime)
                    .HasColumnName("programExcutedDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgramName)
                    .HasColumnName("programName")
                    .HasMaxLength(500);

                entity.Property(e => e.ProgramStartDateTime)
                    .HasColumnName("programStartDateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ProgramMaster>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PK__program___75256038FD598E1A");

                entity.ToTable("program_master");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ComponentCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperationDescription)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpnCode1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpnCode2)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.OpnCode3)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramDate).HasColumnType("date");

                entity.Property(e => e.ProgramDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.ProgramTime).HasColumnType("time(0)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderNo1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderNo2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderNo3)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramTemp>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PK__program___752560382DE060BE");

                entity.ToTable("program_temp");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ProgramData)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProgramDateTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Recipientmailid>(entity =>
            {
                entity.HasKey(e => e.ReId)
                    .HasName("PK__recipien__40979C58A376C04B");

                entity.ToTable("recipientmailid");

                entity.Property(e => e.ReId).HasColumnName("RE_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MailId)
                    .IsRequired()
                    .HasColumnName("MailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.RecipientType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AutoEmailTypeNavigation)
                    .WithMany(p => p.Recipientmailid)
                    .HasForeignKey(d => d.AutoEmailType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AutoEmailType");
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__role_mas__8AFACE3A7943D8A3");

                entity.ToTable("role_master");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleDescription)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SapFileGeneratedDetails>(entity =>
            {
                entity.HasKey(e => e.SapFileGeneratedId);

                entity.ToTable("sapFileGeneratedDetails");

                entity.Property(e => e.SapFileGeneratedId).HasColumnName("sapFileGeneratedId");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.SapFileGeneratedDate)
                    .HasColumnName("sapFileGeneratedDate")
                    .HasColumnType("date");

                entity.Property(e => e.SapFileGeneratedHour).HasColumnName("sapFileGeneratedHour");

                entity.Property(e => e.SapFileNameGenerated)
                    .HasColumnName("sapFileNameGenerated")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ShiftMaster>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK__shift_ma__C0A838E1AB9BECD0");

                entity.ToTable("shift_master");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<TblAutoreportLog>(entity =>
            {
                entity.HasKey(e => e.AutoReportLogId)
                    .HasName("PK__tbl_auto__DBCA34EAD25171C1");

                entity.ToTable("tbl_autoreport_log");

                entity.Property(e => e.AutoReportLogId).HasColumnName("AutoReportLogID");

                entity.Property(e => e.AutoReportId).HasColumnName("AutoReportID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.ExcelCreated).HasDefaultValueSql("('0')");

                entity.Property(e => e.ExcelCreatedTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MailSent).HasDefaultValueSql("('0')");

                entity.HasOne(d => d.AutoReport)
                    .WithMany(p => p.TblAutoreportLog)
                    .HasForeignKey(d => d.AutoReportId)
                    .HasConstraintName("AutoReportID");
            });

            modelBuilder.Entity<TblAutoreportbasedon>(entity =>
            {
                entity.HasKey(e => e.BasedOnId)
                    .HasName("PK__tbl_auto__A38BE57CC6C3EE1C");

                entity.ToTable("tbl_autoreportbasedon");

                entity.Property(e => e.BasedOnId).HasColumnName("BasedOnID");

                entity.Property(e => e.BasedOn)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Desc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblAutoreportsetting>(entity =>
            {
                entity.HasKey(e => e.AutoReportId)
                    .HasName("PK__tbl_auto__FBE9F1AE1BD64ED7");

                entity.ToTable("tbl_autoreportsetting");

                entity.Property(e => e.AutoReportId).HasColumnName("AutoReportID");

                entity.Property(e => e.AutoReportTimeId).HasColumnName("AutoReportTimeID");

                entity.Property(e => e.CcmailList)
                    .HasColumnName("CCMailList")
                    .IsUnicode(false);

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.NextRunDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ToMailList).IsUnicode(false);

                entity.HasOne(d => d.AutoReportTime)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.AutoReportTimeId)
                    .HasConstraintName("ReportTimeID");

                entity.HasOne(d => d.BasedOnNavigation)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.BasedOn)
                    .HasConstraintName("BasedOnID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("ReportCellID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("ReportWorkCentreID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("ReportPlantID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("ReportID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ReportShopID");
            });

            modelBuilder.Entity<TblAutoreporttime>(entity =>
            {
                entity.HasKey(e => e.AutoReportTimeId)
                    .HasName("PK__tbl_auto__FED6B23A2B7C0F8C");

                entity.ToTable("tbl_autoreporttime");

                entity.Property(e => e.AutoReportTimeId).HasColumnName("AutoReportTimeID");

                entity.Property(e => e.AutoReportTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblAxisdetails1>(entity =>
            {
                entity.HasKey(e => e.Adid);

                entity.ToTable("tbl_axisdetails1");

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AbsPos).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Axis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistPos).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MacPos).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.RelPos).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAxisdetails2>(entity =>
            {
                entity.HasKey(e => e.Ad2id)
                    .HasName("PK_tbl_axisdetails2_AD2ID");

                entity.ToTable("tbl_axisdetails2");

                entity.Property(e => e.Ad2id).HasColumnName("AD2ID");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.FeedRate).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.FeedRatePercentage).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.SpindleLoad).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SpindleSpeed).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblBookStock>(entity =>
            {
                entity.HasKey(e => e.BookStockId);

                entity.ToTable("tblBookStock");

                entity.Property(e => e.BookStockId).HasColumnName("bookStockId");

                entity.Property(e => e.BookStockDesc)
                    .HasColumnName("bookStockDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.BookStockName)
                    .HasColumnName("bookStockName")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SapBatch)
                    .HasColumnName("sapBatch")
                    .HasMaxLength(50);

                entity.Property(e => e.SapLoaction)
                    .HasColumnName("sapLoaction")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolSapCode)
                    .HasColumnName("toolSapCode")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblCellFinalMaster>(entity =>
            {
                entity.HasKey(e => e.CellFinalId);

                entity.ToTable("tblCellFinalMaster");

                entity.Property(e => e.CellFinalId).HasColumnName("cellFinalId");

                entity.Property(e => e.CellFinalDesc)
                    .HasColumnName("cellFinalDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.CellFinalName)
                    .HasColumnName("cellFinalName")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("plantId");
            });

            modelBuilder.Entity<TblClassMaster>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("tblClassMaster");

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.ClassDesc)
                    .HasColumnName("classDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.ClassName)
                    .HasColumnName("className")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDefectCodeMaster>(entity =>
            {
                entity.HasKey(e => e.DefectCodeId);

                entity.ToTable("tblDefectCodeMaster");

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCodeDesc)
                    .HasColumnName("defectCodeDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.DefectCodeName)
                    .HasColumnName("defectCodeName")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.ToTable("tblDepartment");

                entity.Property(e => e.DeptId).HasColumnName("deptId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentDesc)
                    .HasColumnName("departmentDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("departmentName")
                    .HasMaxLength(200);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFgAndCellAllocation>(entity =>
            {
                entity.HasKey(e => e.FgAndCellAllocationId);

                entity.ToTable("tblFgAndCellAllocation");

                entity.Property(e => e.FgAndCellAllocationId).HasColumnName("fgAndCellAllocationId");

                entity.Property(e => e.CellFinalId).HasColumnName("cellFinalId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartId).HasColumnName("partId");

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.SubCellFinalId).HasColumnName("subCellFinalId");
            });

            modelBuilder.Entity<TblFgPartNoDet>(entity =>
            {
                entity.HasKey(e => e.FgPartId);

                entity.ToTable("tblFgPartNoDet");

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsClosed).HasColumnName("isClosed");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoOfPartsPerCycle)
                    .HasColumnName("noOfPartsPerCycle")
                    .HasMaxLength(500);

                entity.Property(e => e.OperationNo).HasColumnName("operationNo");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.PartCountMethod)
                    .HasColumnName("partCountMethod")
                    .HasMaxLength(500);

                entity.Property(e => e.PartId).HasColumnName("partId");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("workOrderNo")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblIpAddress>(entity =>
            {
                entity.HasKey(e => e.IpAddressId);

                entity.ToTable("tblIpAddress");

                entity.Property(e => e.IpAddressId).HasColumnName("ipAddressId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.HostName)
                    .HasColumnName("hostName")
                    .HasMaxLength(500);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ipAddress")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MacAddress)
                    .HasColumnName("macAddress")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblIssuedReceived>(entity =>
            {
                entity.ToTable("tblIssuedReceived");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.BarCodeNo)
                    .HasColumnName("barCodeNo")
                    .HasMaxLength(200);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("batchNumber")
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrnNo)
                    .HasColumnName("grnNo")
                    .HasMaxLength(500);

                entity.Property(e => e.InspLotNo)
                    .HasColumnName("inspLotNo")
                    .HasMaxLength(200);

                entity.Property(e => e.IsCheck).HasColumnName("isCheck");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsReDisplay)
                    .HasColumnName("isReDisplay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReturn).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSapgenerated)
                    .HasColumnName("isSAPGenerated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpAcceptanceFlag)
                    .HasColumnName("opAcceptanceFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OpId).HasColumnName("opId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReasonId).HasColumnName("reasonId");

                entity.Property(e => e.ReasonLvl1Id).HasColumnName("reasonLvl1Id");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnName("receiptDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500);

                entity.Property(e => e.ReturnedOpId).HasColumnName("returnedOpId");

                entity.Property(e => e.SapCode)
                    .HasColumnName("sapCode")
                    .HasMaxLength(500);

                entity.Property(e => e.SapGeneratedDate)
                    .HasColumnName("sapGeneratedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SapRefDate)
                    .HasColumnName("sapRefDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SapReferenceNo)
                    .HasColumnName("sapReferenceNo")
                    .HasMaxLength(200);

                entity.Property(e => e.ShiftId).HasColumnName("shiftId");

                entity.Property(e => e.SlipNo)
                    .HasColumnName("slipNo")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolBatchNo)
                    .HasColumnName("toolBatchNo")
                    .HasMaxLength(200);

                entity.Property(e => e.ToolGribUserFlag)
                    .HasColumnName("toolGribUserFlag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ToolGribUserId).HasColumnName("toolGribUserId");

                entity.Property(e => e.ToolLifeActual)
                    .HasColumnName("toolLifeActual")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolName)
                    .HasColumnName("toolName")
                    .HasMaxLength(200);

                entity.Property(e => e.UniqueBatchNo)
                    .HasColumnName("uniqueBatchNo")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblMaterialMaster>(entity =>
            {
                entity.HasKey(e => e.MaterialmasterId);

                entity.ToTable("tblMaterialMaster");

                entity.Property(e => e.MaterialmasterId).HasColumnName("materialmasterId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaterialDescription)
                    .HasColumnName("materialDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.MaterialName)
                    .HasColumnName("materialName")
                    .HasMaxLength(500);

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartCode)
                    .HasColumnName("partCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblMultiwoselection>(entity =>
            {
                entity.HasKey(e => e.MultiWoid)
                    .HasName("PK__tbl_mult__22EB3C7E18F7F6D4");

                entity.ToTable("tbl_multiwoselection");

                entity.Property(e => e.MultiWoid).HasColumnName("MultiWOID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DdlworkCentre)
                    .HasColumnName("DDLWorkCentre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsSubmit).HasDefaultValueSql("('0')");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WorkOrder)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hmi)
                    .WithMany(p => p.TblMultiwoselection)
                    .HasForeignKey(d => d.Hmiid)
                    .HasConstraintName("fkHMIID");
            });

            modelBuilder.Entity<TblOperatorDetails>(entity =>
            {
                entity.HasKey(e => e.OpId);

                entity.ToTable("tblOperatorDetails");

                entity.Property(e => e.OpId).HasColumnName("opId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("departmentId");

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(100);

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpNo).HasColumnName("opNo");

                entity.Property(e => e.OperatorEmailId)
                    .HasColumnName("operatorEmailId")
                    .HasMaxLength(200);

                entity.Property(e => e.OperatorMobileNo)
                    .HasColumnName("operatorMobileNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasColumnName("operatorName")
                    .HasMaxLength(200);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblProductWiseDefectCode>(entity =>
            {
                entity.HasKey(e => e.ProductWiseDefectCodeId);

                entity.ToTable("tblProductWiseDefectCode");

                entity.Property(e => e.ProductWiseDefectCodeId).HasColumnName("productWiseDefectCodeId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartId).HasColumnName("partId");

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Trim).HasColumnName("trim");
            });

            modelBuilder.Entity<TblRaisedTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK_tblTicketMaster");

                entity.ToTable("tblRaisedTicket");

                entity.Property(e => e.TicketId).HasColumnName("ticketId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.ClassId).HasColumnName("classId");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500);

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.PartId).HasColumnName("partId");

                entity.Property(e => e.ReasonId).HasColumnName("reasonId");

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.TicketNo)
                    .HasColumnName("ticketNo")
                    .HasMaxLength(500);

                entity.Property(e => e.TicketOpenDate)
                    .HasColumnName("ticketOpenDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblRejectionDetails>(entity =>
            {
                entity.HasKey(e => e.RejectionId);

                entity.ToTable("tblRejectionDetails");

                entity.Property(e => e.RejectionId).HasColumnName("rejectionId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.DefectQty).HasColumnName("defectQty");

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");
            });

            modelBuilder.Entity<TblReportmaster>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK__tbl_repo__D5BD48E5A6465FD8");

                entity.ToTable("tbl_reportmaster");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ReportDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDispName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTemplatePath)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblReworkDetails>(entity =>
            {
                entity.HasKey(e => e.ReworkId);

                entity.ToTable("tblReworkDetails");

                entity.Property(e => e.ReworkId).HasColumnName("reworkId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.DefectQty).HasColumnName("defectQty");

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");
            });

            modelBuilder.Entity<TblSourceMaster>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("tblSourceMaster");

                entity.Property(e => e.SourceId).HasColumnName("sourceId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceDescription)
                    .HasColumnName("sourceDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.SourceName)
                    .HasColumnName("sourceName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblStatusMaster>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tblStatusMaster");

                entity.Property(e => e.StatusId).HasColumnName("statusId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.StatusDesc)
                    .HasColumnName("statusDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.StatusName)
                    .HasColumnName("statusName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblStoppage>(entity =>
            {
                entity.HasKey(e => e.StoppagesId);

                entity.ToTable("tblStoppage");

                entity.Property(e => e.StoppagesId).HasColumnName("stoppagesId");

                entity.Property(e => e.AlramDesc)
                    .HasColumnName("alramDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.AlramNo).HasColumnName("alramNo");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.SourceId).HasColumnName("sourceId");
            });

            modelBuilder.Entity<TblSubCellFinalMaster>(entity =>
            {
                entity.HasKey(e => e.SubCellFinalId);

                entity.ToTable("tblSubCellFinalMaster");

                entity.Property(e => e.SubCellFinalId).HasColumnName("subCellFinalId");

                entity.Property(e => e.CellFinalId).HasColumnName("cellFinalId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.SubCellFinalDesc)
                    .HasColumnName("subCellFinalDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.SubCellFinalName)
                    .HasColumnName("subCellFinalName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblSystemConfig>(entity =>
            {
                entity.HasKey(e => e.SystemConfigId);

                entity.ToTable("tblSystemConfig");

                entity.Property(e => e.SystemConfigId).HasColumnName("systemConfigId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PcHostName)
                    .HasColumnName("pcHostName")
                    .HasMaxLength(500);

                entity.Property(e => e.PcIpAddress)
                    .HasColumnName("pcIpAddress")
                    .HasMaxLength(500);

                entity.Property(e => e.PcMacAddress)
                    .HasColumnName("pcMacAddress")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblTicketRaisedDet>(entity =>
            {
                entity.HasKey(e => e.TicketRaisedDetId);

                entity.ToTable("tblTicketRaisedDet");

                entity.Property(e => e.TicketRaisedDetId).HasColumnName("ticketRaisedDetId");

                entity.Property(e => e.CommentsByOperator)
                    .HasColumnName("commentsByOperator")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IfOperatorAccepts).HasColumnName("ifOperatorAccepts");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsStatus).HasColumnName("isStatus");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorAcceptRejectDate)
                    .HasColumnName("operatorAcceptRejectDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.Reason)
                    .HasColumnName("reason")
                    .HasMaxLength(500);

                entity.Property(e => e.SupportTeamAckDate)
                    .HasColumnName("supportTeamAckDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupportTeamClosureDate)
                    .HasColumnName("supportTeamClosureDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupportTeamId).HasColumnName("supportTeamId");

                entity.Property(e => e.TicketId).HasColumnName("ticketId");

                entity.Property(e => e.TicketNo)
                    .HasColumnName("ticketNo")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblToolBrDnReasonLvl1>(entity =>
            {
                entity.ToTable("tblToolBrDnReasonLvl1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonId).HasColumnName("reasonId");

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblToolBrkDnReason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("tblToolBrkDnReason");

                entity.Property(e => e.ReasonId).HasColumnName("reasonId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ForResharpening).HasColumnName("forResharpening");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblTools>(entity =>
            {
                entity.HasKey(e => e.ToolId);

                entity.ToTable("tblTools");

                entity.Property(e => e.ToolId).HasColumnName("toolId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.GrnNo)
                    .HasColumnName("grnNo")
                    .HasMaxLength(500);

                entity.Property(e => e.InspLotNo)
                    .HasColumnName("inspLotNo")
                    .HasMaxLength(200);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.SapCode)
                    .HasColumnName("sapCode")
                    .HasMaxLength(500);

                entity.Property(e => e.SlipNo).HasColumnName("slipNo");

                entity.Property(e => e.StandardToolLife).HasColumnName("standardToolLife");

                entity.Property(e => e.ToolBatchNo)
                    .HasColumnName("toolBatchNo")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolDesc)
                    .HasColumnName("toolDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolInsert)
                    .HasColumnName("toolInsert")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolLocation)
                    .HasColumnName("toolLocation")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolName)
                    .HasColumnName("toolName")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolSapCode)
                    .HasColumnName("toolSapCode")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolType)
                    .HasColumnName("toolType")
                    .HasMaxLength(500);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblWorkCenter>(entity =>
            {
                entity.HasKey(e => e.WorkCenterId);

                entity.ToTable("tblWorkCenter");

                entity.Property(e => e.WorkCenterId).HasColumnName("workCenterId");

                entity.Property(e => e.CostCenter)
                    .HasColumnName("costCenter")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.WoCode)
                    .HasColumnName("woCode")
                    .HasMaxLength(500);

                entity.Property(e => e.WorkCenterDescription)
                    .HasColumnName("workCenterDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.WorkCenterName)
                    .HasColumnName("workCenterName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Tblactivitylog>(entity =>
            {
                entity.HasKey(e => e.TrackId)
                    .HasName("PK__tblactiv__7A74F8C08763B77B");

                entity.ToTable("tblactivitylog");

                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ClientSystemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompleteModificationDetails)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate).HasColumnType("date");

                entity.Property(e => e.OpDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.OpTime)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblappPaths>(entity =>
            {
                entity.HasKey(e => e.AppPathsId)
                    .HasName("PK__tblapp_p__BCF76C1059FF8032");

                entity.ToTable("tblapp_paths");

                entity.Property(e => e.AppPathsId).HasColumnName("AppPathsID");

                entity.Property(e => e.AppName)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.AppPath)
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Tblbreakdown>(entity =>
            {
                entity.HasKey(e => e.BreakdownId)
                    .HasName("PK__tblbreak__B4C97408F25FEC71");

                entity.ToTable("tblbreakdown");

                entity.Property(e => e.BreakdownId).HasColumnName("BreakdownID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.BreakDownCodeNavigation)
                    .WithMany(p => p.Tblbreakdown)
                    .HasForeignKey(d => d.BreakDownCode)
                    .HasConstraintName("BreakdowncodeId");
            });

            modelBuilder.Entity<Tblbreakdowncodes>(entity =>
            {
                entity.HasKey(e => e.BreakDownCodeId)
                    .HasName("PK__tblbreak__3F8A57417D5EDA5C");

                entity.ToTable("tblbreakdowncodes");

                entity.Property(e => e.BreakDownCodeId).HasColumnName("BreakDownCodeID");

                entity.Property(e => e.BreakDownCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.BreakDownCodeDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.BreakDownCodesLevel1Id).HasColumnName("BreakDownCodesLevel1ID");

                entity.Property(e => e.BreakDownCodesLevel2Id).HasColumnName("BreakDownCodesLevel2ID");

                entity.Property(e => e.ContributeTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblcell>(entity =>
            {
                entity.HasKey(e => e.CellId)
                    .HasName("PK__tblcell__EA424A28F9A03B68");

                entity.ToTable("tblcell");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CellDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblcell)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantsId");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblcell)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ShopId");
            });

            modelBuilder.Entity<Tblcustomer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK__tblcusto__C1F8DC59F2184984");

                entity.ToTable("tblcustomer");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cpdepartment)
                    .HasColumnName("CPDepartment")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cpdesignation)
                    .HasColumnName("CPDesignation")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CpemailId)
                    .HasColumnName("CPEmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpmobileNo).HasColumnName("CPMobileNO");

                entity.Property(e => e.Cpname)
                    .HasColumnName("CPName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId1)
                    .IsRequired()
                    .HasColumnName("EmailID1")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId2)
                    .HasColumnName("EmailID2")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Logo).IsRequired();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Website)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldailyprodstatus>(entity =>
            {
                entity.ToTable("tbldailyprodstatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbldailyprodstatus)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("MachineID1");
            });

            modelBuilder.Entity<Tbldailyprodstatushis>(entity =>
            {
                entity.ToTable("tbldailyprodstatushis");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldaytiming>(entity =>
            {
                entity.ToTable("tbldaytiming");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<Tblddl>(entity =>
            {
                entity.HasKey(e => e.Ddlid)
                    .HasName("PK__tblddl__47402305084DA64A");

                entity.ToTable("tblddl");

                entity.HasIndex(e => e.Ddlid)
                    .HasName("DDLID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Ddlid)
                    .HasColumnName("DDLID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DaysAgeing)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveredQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.DueDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FlagRushInd)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Maddate)
                    .HasColumnName("MADDate")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MaddateInd)
                    .HasColumnName("MADDateInd")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperationDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OperationsOnHold)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreOpnEndDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForHold)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.TargetQty)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenter)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrder)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbldowntimecategory>(entity =>
            {
                entity.HasKey(e => e.DtcId)
                    .HasName("PK__tbldownt__496D20BF4283FC86");

                entity.ToTable("tbldowntimecategory");

                entity.Property(e => e.DtcId).HasColumnName("DTC_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Dtcategory)
                    .IsRequired()
                    .HasColumnName("DTCategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DtcategoryDesc)
                    .IsRequired()
                    .HasColumnName("DTCategoryDesc")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tbldowntimedetails>(entity =>
            {
                entity.HasKey(e => e.DtId)
                    .HasName("PK__tbldownt__148CEA33E2BDB4B2");

                entity.ToTable("tbldowntimedetails");

                entity.Property(e => e.DtId).HasColumnName("DT_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DtcategoryId).HasColumnName("DTCategoryID");

                entity.Property(e => e.Dtdesc)
                    .IsRequired()
                    .HasColumnName("DTDesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dtreason)
                    .IsRequired()
                    .HasColumnName("DTReason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Dtcategory)
                    .WithMany(p => p.Tbldowntimedetails)
                    .HasForeignKey(d => d.DtcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbldowntimedetails_ibfk_1");
            });

            modelBuilder.Entity<Tblemailescalation>(entity =>
            {
                entity.HasKey(e => e.EmailEscalationId)
                    .HasName("PK__tblemail__A1433C4BBDE6A993");

                entity.ToTable("tblemailescalation");

                entity.HasIndex(e => e.EmailEscalationId)
                    .HasName("EMailEscalationID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.EmailEscalationId).HasColumnName("EMailEscalationID");

                entity.Property(e => e.CcList).IsUnicode(false);

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EmailEscalationName)
                    .HasColumnName("EMailEscalationName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hours).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Minutes).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ToList).IsUnicode(false);

                entity.Property(e => e.WorkCenterId).HasColumnName("WorkCenterID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("CellIDFK");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantIDFK");

                entity.HasOne(d => d.ReasonLevel1Navigation)
                    .WithMany(p => p.TblemailescalationReasonLevel1Navigation)
                    .HasForeignKey(d => d.ReasonLevel1)
                    .HasConstraintName("ReasonLevel1FK");

                entity.HasOne(d => d.ReasonLevel2Navigation)
                    .WithMany(p => p.TblemailescalationReasonLevel2Navigation)
                    .HasForeignKey(d => d.ReasonLevel2)
                    .HasConstraintName("ReasonLevel2FK");

                entity.HasOne(d => d.ReasonLevel3Navigation)
                    .WithMany(p => p.TblemailescalationReasonLevel3Navigation)
                    .HasForeignKey(d => d.ReasonLevel3)
                    .HasConstraintName("ReasonLevel3FK");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopIDFK");

                entity.HasOne(d => d.WorkCenter)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.WorkCenterId)
                    .HasConstraintName("WCIDFK");
            });

            modelBuilder.Entity<Tblemailreporttype>(entity =>
            {
                entity.HasKey(e => e.Ertid)
                    .HasName("PK__tblemail__C80B1963D40EAE50");

                entity.ToTable("tblemailreporttype");

                entity.Property(e => e.Ertid).HasColumnName("ERTID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ReportDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblendcodes>(entity =>
            {
                entity.HasKey(e => e.EndCodeId)
                    .HasName("PK__tblendco__4DDCD6003CB8EEAD");

                entity.ToTable("tblendcodes");

                entity.Property(e => e.EndCodeId).HasColumnName("EndCodeID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndCode)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.EndCodeLdesc)
                    .HasColumnName("EndCodeLDesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndCodeSdesc)
                    .HasColumnName("EndCodeSDesc")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblescalationlog>(entity =>
            {
                entity.HasKey(e => e.Elid)
                    .HasName("PK__tblescal__25755679FF0AB5F1");

                entity.ToTable("tblescalationlog");

                entity.HasIndex(e => e.Elid)
                    .HasName("ELID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Elid).HasColumnName("ELID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EscalationId).HasColumnName("EscalationID");

                entity.Property(e => e.EscalationSentOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsIdle).HasDefaultValueSql("('0')");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wcid).HasColumnName("WCID");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.Tblescalationlog)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("EscalationLossCodeID");
            });

            modelBuilder.Entity<Tblgenericworkcodes>(entity =>
            {
                entity.HasKey(e => e.GenericWorkId)
                    .HasName("PK__tblgener__D8A628886EB40F0C");

                entity.ToTable("tblgenericworkcodes");

                entity.Property(e => e.GenericWorkId).HasColumnName("GenericWorkID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.GenericWorkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenericWorkDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.GwcodesLevel).HasColumnName("GWCodesLevel");

                entity.Property(e => e.GwcodesLevel1Id).HasColumnName("GWCodesLevel1ID");

                entity.Property(e => e.GwcodesLevel2Id).HasColumnName("GWCodesLevel2ID");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblgenericworkentry>(entity =>
            {
                entity.HasKey(e => e.GwentryId)
                    .HasName("PK__tblgener__25BD573EE7DC2ACB");

                entity.ToTable("tblgenericworkentry");

                entity.Property(e => e.GwentryId).HasColumnName("GWEntryID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Gwcode)
                    .HasColumnName("GWCode")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.GwcodeDesc)
                    .HasColumnName("GWCodeDesc")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.GwcodeId).HasColumnName("GWCodeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.GwcodeNavigation)
                    .WithMany(p => p.Tblgenericworkentry)
                    .HasForeignKey(d => d.GwcodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("GenericWorkID");
            });

            modelBuilder.Entity<Tblhmiscreen>(entity =>
            {
                entity.HasKey(e => e.Hmiid)
                    .HasName("PK__tblhmisc__B07815CA8F773C52");

                entity.ToTable("tblhmiscreen");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.BatchCount).HasColumnName("batchCount");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime2(0)");

                entity.Property(e => e.DdlwokrCentre)
                    .HasColumnName("DDLWokrCentre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveredQty).HasColumnName("Delivered_Qty");

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.Hmimonth).HasColumnName("HMIMonth");

                entity.Property(e => e.Hmiquarter).HasColumnName("HMIQuarter");

                entity.Property(e => e.HmiweekNumber).HasColumnName("HMIWeekNumber");

                entity.Property(e => e.Hmiyear).HasColumnName("HMIYear");

                entity.Property(e => e.IsHold).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMultiWo)
                    .HasColumnName("IsMultiWO")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsUpdate)
                    .HasColumnName("isUpdate")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsWorkInProgress)
                    .HasColumnName("isWorkInProgress")
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.IsWorkOrder)
                    .HasColumnName("isWorkOrder")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OperatiorId).HasColumnName("OperatiorID");

                entity.Property(e => e.OperatorDet)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PestartTime)
                    .HasColumnName("PEStartTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ProcessQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.ProdFai)
                    .HasColumnName("Prod_FAI")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RejQty)
                    .HasColumnName("Rej_Qty")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TargetQty).HasColumnName("Target_Qty");

                entity.Property(e => e.Time).HasColumnType("datetime2(0)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("Work_Order_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblhmiscreen)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineIDhmi");
            });

            modelBuilder.Entity<Tblholdcodes>(entity =>
            {
                entity.HasKey(e => e.HoldCodeId)
                    .HasName("PK__tblholdc__EA8D1E84243C7D5A");

                entity.ToTable("tblholdcodes");

                entity.Property(e => e.HoldCodeId).HasColumnName("HoldCodeID");

                entity.Property(e => e.ContributeTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.HoldCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoldCodeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoldCodesLevel1Id).HasColumnName("HoldCodesLevel1ID");

                entity.Property(e => e.HoldCodesLevel2Id).HasColumnName("HoldCodesLevel2ID");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tbllivedailyprodstatus>(entity =>
            {
                entity.ToTable("tbllivedailyprodstatus");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivedailyprodstatus)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("MachineIDLDPS");
            });

            modelBuilder.Entity<Tbllivehmiscreen>(entity =>
            {
                entity.HasKey(e => e.Hmiid)
                    .HasName("PK__tblliveh__B07815CA2EE88F09");

                entity.ToTable("tbllivehmiscreen");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.BatchNo).HasColumnName("batchNo");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime2(0)");

                entity.Property(e => e.DdlwokrCentre)
                    .HasColumnName("DDLWokrCentre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveredQty).HasColumnName("Delivered_Qty");

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsHold).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMultiWo)
                    .HasColumnName("IsMultiWO")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsUpdate)
                    .HasColumnName("isUpdate")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsWorkInProgress)
                    .HasColumnName("isWorkInProgress")
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.IsWorkOrder)
                    .HasColumnName("isWorkOrder")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OperatiorId).HasColumnName("OperatiorID");

                entity.Property(e => e.OperatorDet)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PestartTime)
                    .HasColumnName("PEStartTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ProcessQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.ProdFai)
                    .HasColumnName("Prod_FAI")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RejQty)
                    .HasColumnName("Rej_Qty")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TargetQty).HasColumnName("Target_Qty");

                entity.Property(e => e.Time).HasColumnType("datetime2(0)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("Work_Order_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivehmiscreen)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineIDhmiLive");
            });

            modelBuilder.Entity<Tbllivehmiscreenrep>(entity =>
            {
                entity.HasKey(e => e.Hmiid)
                    .HasName("PK__tblliveh__B07815CA636A7E68");

                entity.ToTable("tbllivehmiscreenrep");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime2(0)");

                entity.Property(e => e.DdlwokrCentre)
                    .HasColumnName("DDLWokrCentre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveredQty).HasColumnName("Delivered_Qty");

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsHold).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMultiWo)
                    .HasColumnName("IsMultiWO")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsUpdate)
                    .HasColumnName("isUpdate")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsWorkInProgress)
                    .HasColumnName("isWorkInProgress")
                    .HasDefaultValueSql("('2')");

                entity.Property(e => e.IsWorkOrder)
                    .HasColumnName("isWorkOrder")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OperatiorId).HasColumnName("OperatiorID");

                entity.Property(e => e.OperatorDet)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PestartTime)
                    .HasColumnName("PEStartTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ProcessQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.ProdFai)
                    .HasColumnName("Prod_FAI")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RejQty)
                    .HasColumnName("Rej_Qty")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TargetQty).HasColumnName("Target_Qty");

                entity.Property(e => e.Time).HasColumnType("datetime2(0)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("Work_Order_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivehmiscreenrep)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineIDhmiLiveRep");
            });

            modelBuilder.Entity<Tbllivelossofentry>(entity =>
            {
                entity.HasKey(e => e.LossId)
                    .HasName("PK__tbllivel__7025E39412BAD000");

                entity.ToTable("tbllivelossofentry");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EntryTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.ForRefresh).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsUpdate).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tbllivelossofentry)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LossCodeIDLiveLoss");
            });

            modelBuilder.Entity<Tbllivelossofentryrep>(entity =>
            {
                entity.HasKey(e => e.LossId)
                    .HasName("PK__tbllivel__7025E394F03A0093");

                entity.ToTable("tbllivelossofentryrep");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EntryTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.ForRefresh).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsUpdate).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tbllivelossofentryrep)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LossCodeIDLiveLossRep");
            });

            modelBuilder.Entity<Tbllivemanuallossofentry>(entity =>
            {
                entity.HasKey(e => e.MlossId)
                    .HasName("PK__tbllivem__1ED730DE45B4F6E3");

                entity.ToTable("tbllivemanuallossofentry");

                entity.Property(e => e.MlossId).HasColumnName("MLossID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndHmiid).HasColumnName("EndHMIID");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wono)
                    .HasColumnName("WONo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tbllivemanuallossofentry)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ManualLossCodeIDLive");
            });

            modelBuilder.Entity<Tbllivemanuallossofentryrep>(entity =>
            {
                entity.HasKey(e => e.MlossId)
                    .HasName("PK__tbllivem__1ED730DE47BF29B7");

                entity.ToTable("tbllivemanuallossofentryrep");

                entity.Property(e => e.MlossId).HasColumnName("MLossID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndHmiid).HasColumnName("EndHMIID");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wono)
                    .HasColumnName("WONo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tbllivemanuallossofentryrep)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ManualLossCodeIDLiveRep");
            });

            modelBuilder.Entity<Tbllivemode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__tbllivem__D83F75E4774F6B23");

                entity.ToTable("tbllivemode");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DurationInSec).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivemode)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("machineryLive");
            });

            modelBuilder.Entity<Tbllivemodedb>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__tbllivem__D83F75E449B88DC2");

                entity.ToTable("tbllivemodedb");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DurationInSec).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivemodedb)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("machineryDBLive");
            });

            modelBuilder.Entity<Tbllivemultiwoselection>(entity =>
            {
                entity.HasKey(e => e.MultiWoid)
                    .HasName("PK__tbllivem__22EB3C7E838BE2C0");

                entity.ToTable("tbllivemultiwoselection");

                entity.Property(e => e.MultiWoid).HasColumnName("MultiWOID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DdlworkCentre)
                    .HasColumnName("DDLWorkCentre")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsSubmit).HasDefaultValueSql("('0')");

                entity.Property(e => e.OperationNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.WorkOrder)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hmi)
                    .WithMany(p => p.Tbllivemultiwoselection)
                    .HasForeignKey(d => d.Hmiid)
                    .HasConstraintName("fkwoliveHMIID");
            });

            modelBuilder.Entity<Tbllossescodes>(entity =>
            {
                entity.HasKey(e => e.LossCodeId)
                    .HasName("PK__tbllosse__9A1C17316AD81566");

                entity.ToTable("tbllossescodes");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.ContributeTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LossCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodesLevel1Id).HasColumnName("LossCodesLevel1ID");

                entity.Property(e => e.LossCodesLevel2Id).HasColumnName("LossCodesLevel2ID");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tbllossofentry>(entity =>
            {
                entity.HasKey(e => e.LossId)
                    .HasName("PK__tbllosso__7025E39495D86E55");

                entity.ToTable("tbllossofentry");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EntryTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.ForRefresh).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsUpdate).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tbllossofentry)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LossCodeID");
            });

            modelBuilder.Entity<TblmachineMaster>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK__tblmachi__44EE5B582EC20945");

                entity.ToTable("tblmachine_master");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ControllerType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineInvNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblmachineallocation>(entity =>
            {
                entity.ToTable("tblmachineallocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblmachineallocation)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("macid");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Tblmachineallocation)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("shiftid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Tblmachineallocation)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("userid");
            });

            modelBuilder.Entity<Tblmachinecategory>(entity =>
            {
                entity.ToTable("tblmachinecategory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblmachinedetails>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK__tblmachi__44EE5B581260F92F");

                entity.ToTable("tblmachinedetails");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.ControllerType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter).HasMaxLength(500);

                entity.Property(e => e.DeletedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsNormalWc)
                    .HasColumnName("IsNormalWC")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsPcb).HasColumnName("IsPCB");

                entity.Property(e => e.MachineDispName).HasMaxLength(500);

                entity.Property(e => e.MachineInvNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MachineMake).HasMaxLength(500);

                entity.Property(e => e.MachineModel).HasMaxLength(500);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManualWcid).HasColumnName("ManualWCID");

                entity.Property(e => e.ModelType).HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopNo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Wccode)
                    .HasColumnName("WCCode")
                    .HasMaxLength(500);

                entity.Property(e => e.Wcdescription)
                    .HasColumnName("WCDescription")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblmachinedetails)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("CellIDtblmachinedetails");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblmachinedetails)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantIDtblmachinedetails");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblmachinedetails)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopIDtblmachinedetails");
            });

            modelBuilder.Entity<Tblmachinedetailsnew>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK__tblmachi__44EE5B58D6E9C254");

                entity.ToTable("tblmachinedetailsnew");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.ControllerType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsPcb).HasColumnName("IsPCB");

                entity.Property(e => e.MachineDispName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineInvNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineMake)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModelType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopNo)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblmachinedetailsnew)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("CellIDtblmachinedetailsnew");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblmachinedetailsnew)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantIDtblmachinedetailsnew");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblmachinedetailsnew)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopIDtblmachinedetailsnew");
            });

            modelBuilder.Entity<Tblmailids>(entity =>
            {
                entity.HasKey(e => e.MailIdsId)
                    .HasName("PK__tblmaili__E530A8B654361CD2");

                entity.ToTable("tblmailids");

                entity.HasIndex(e => e.MailIdsId)
                    .HasName("MailIDsID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.MailIdsId).HasColumnName("MailIDsID");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblmanuallossofentry>(entity =>
            {
                entity.HasKey(e => e.MlossId)
                    .HasName("PK__tblmanua__1ED730DEB0036E86");

                entity.ToTable("tblmanuallossofentry");

                entity.Property(e => e.MlossId).HasColumnName("MLossID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndHmiid).HasColumnName("EndHMIID");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wono)
                    .HasColumnName("WONo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tblmanuallossofentry)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ManualLossCodeID");
            });

            modelBuilder.Entity<TblmasterpartsStSw>(entity =>
            {
                entity.HasKey(e => e.Partsstswid)
                    .HasName("PK__tblmaste__C2C24D0FF1D5BBC5");

                entity.ToTable("tblmasterparts_st_sw");

                entity.Property(e => e.Partsstswid).HasColumnName("PARTSSTSWID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.InputWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InputWeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MaterialRemovedQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaterialRemovedQtyUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OpNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OutputWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OutputWeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo).HasMaxLength(200);

                entity.Property(e => e.StdChangeoverTime).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StdChangeoverTimeUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StdCuttingTime).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StdCuttingTimeUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StdSetupTime).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StdSetupTimeUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblmimics>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK__tblmimic__DF5032ECF6B0DADC");

                entity.ToTable("tblmimics");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.BreakdownTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdleTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineOffTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineOnTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OperatingTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SetupTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblmimics)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineID");
            });

            modelBuilder.Entity<Tblmode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__tblmode__D83F75E448911E15");

                entity.ToTable("tblmode");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DurationInSec).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblmodulehelper>(entity =>
            {
                entity.ToTable("tblmodulehelper");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsAdded)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsAll)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsEdited)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsReadonly)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.IsRemoved)
                    .IsRequired()
                    .HasDefaultValueSql("('1')");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Tblmodulemaster>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK__tblmodul__2B7477874A289BDF");

                entity.ToTable("tblmodulemaster");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblmultipleworkorder>(entity =>
            {
                entity.HasKey(e => e.Mwoid)
                    .HasName("PK__tblmulti__4B6BE6F751B6BECF");

                entity.ToTable("tblmultipleworkorder");

                entity.Property(e => e.Mwoid).HasColumnName("MWOID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsEnabled).HasDefaultValueSql("('1')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MultipleWodesc)
                    .HasColumnName("MultipleWODesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MultipleWoname)
                    .IsRequired()
                    .HasColumnName("MultipleWOName")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Wcid).HasColumnName("WCID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("CellIDtblMWO");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantIDtblMWO");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopIdtblMWO");

                entity.HasOne(d => d.Wc)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.Wcid)
                    .HasConstraintName("WCIDtblMWO");
            });

            modelBuilder.Entity<Tblnetworkdetailsforddl>(entity =>
            {
                entity.HasKey(e => e.Npfddlid)
                    .HasName("PK__tblnetwo__F454508FA5DA51BA");

                entity.ToTable("tblnetworkdetailsforddl");

                entity.HasIndex(e => e.Npfddlid)
                    .HasName("NPFDDLID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Npfddlid).HasColumnName("NPFDDLID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbloeedashboardfinalvariables>(entity =>
            {
                entity.HasKey(e => e.OeedashboardId)
                    .HasName("PK__tbloeeda__8BF75546E7809594");

                entity.ToTable("tbloeedashboardfinalvariables");

                entity.HasIndex(e => e.OeedashboardId)
                    .HasName("OEEDashboardID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeedashboardId).HasColumnName("OEEDashboardID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOverallCellWise).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOverallPlantWise).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOverallShopWise).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsOverallWcwise)
                    .HasColumnName("IsOverallWCWise")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsToday).HasDefaultValueSql("('0')");

                entity.Property(e => e.Loss1Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss2Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss3Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss4Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss5Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Oee).HasColumnName("OEE");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wcid).HasColumnName("WCID");
            });

            modelBuilder.Entity<Tbloeedashboardvariables>(entity =>
            {
                entity.HasKey(e => e.OeevariablesId)
                    .HasName("PK__tbloeeda__BB29BFE58B476DBD");

                entity.ToTable("tbloeedashboardvariables");

                entity.HasIndex(e => e.OeevariablesId)
                    .HasName("OEEVariablesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeevariablesId).HasColumnName("OEEVariablesID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.Loss1Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss2Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss3Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss4Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss5Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ReWotime).HasColumnName("ReWOTime");

                entity.Property(e => e.Roalossess).HasColumnName("ROALossess");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SummationOfSctvsPp).HasColumnName("SummationOfSCTvsPP");

                entity.Property(e => e.Wcid).HasColumnName("WCID");
            });

            modelBuilder.Entity<Tbloeedashboardvariablestoday>(entity =>
            {
                entity.HasKey(e => e.OeevariablesId)
                    .HasName("PK__tbloeeda__BB29BFE5E41072D4");

                entity.ToTable("tbloeedashboardvariablestoday");

                entity.Property(e => e.OeevariablesId).HasColumnName("OEEVariablesID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsToday).HasDefaultValueSql("('0')");

                entity.Property(e => e.Loss1Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss2Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss3Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss4Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss5Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ReWotime).HasColumnName("ReWOTime");

                entity.Property(e => e.Roalossess).HasColumnName("ROALossess");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.SummationOfSctvsPp).HasColumnName("SummationOfSCTvsPP");

                entity.Property(e => e.Wcid).HasColumnName("WCID");
            });

            modelBuilder.Entity<Tblparts>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("PK__tblparts__7C3F0D300098F72D");

                entity.ToTable("tblparts");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PartDesc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Uom)
                    .HasColumnName("uom")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblparts)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_tblparts_tblmachinedetails");

                entity.HasOne(d => d.UnitDescNavigation)
                    .WithMany(p => p.Tblparts)
                    .HasForeignKey(d => d.UnitDesc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("U_ID");
            });

            modelBuilder.Entity<Tblpartwisesp>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("PK__tblpartw__7C3F0D50D8CDE1E4");

                entity.ToTable("tblpartwisesp");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PartName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblpartwiseworkcenter>(entity =>
            {
                entity.HasKey(e => e.PartWiseWcId)
                    .HasName("PK__tblpartw__6C1D85B7B237127E");

                entity.ToTable("tblpartwiseworkcenter");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.WorkCenter)
                    .WithMany(p => p.Tblpartwiseworkcenter)
                    .HasForeignKey(d => d.WorkCenterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("WorkCenterId");
            });

            modelBuilder.Entity<Tblplannedbreak>(entity =>
            {
                entity.HasKey(e => e.BreakId)
                    .HasName("PK__tblplann__B267A619DE6A3B0E");

                entity.ToTable("tblplannedbreak");

                entity.Property(e => e.BreakId).HasColumnName("BreakID");

                entity.Property(e => e.BreakReason)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Tblplannedbreak)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("shiftbreak");
            });

            modelBuilder.Entity<Tblplant>(entity =>
            {
                entity.HasKey(e => e.PlantId)
                    .HasName("PK__tblplant__98FE46BC7921451F");

                entity.ToTable("tblplant");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantCode).HasMaxLength(500);

                entity.Property(e => e.PlantDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblpriorityalarms>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("PK__tblprior__43E5EB15775FA352");

                entity.ToTable("tblpriorityalarms");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AlarmDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AxisNo).HasDefaultValueSql("('0')");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsMailSent)
                    .HasColumnName("isMailSent")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblreportholder>(entity =>
            {
                entity.HasKey(e => e.Rhid)
                    .HasName("PK__tblrepor__5A84283B9A6BD48F");

                entity.ToTable("tblreportholder");

                entity.Property(e => e.Rhid).HasColumnName("RHID");

                entity.Property(e => e.FromDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.WorkCenter)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblroleplaymaster>(entity =>
            {
                entity.HasKey(e => e.RolePlayId)
                    .HasName("PK__tblrolep__F8FE107CBE43F7F2");

                entity.ToTable("tblroleplaymaster");

                entity.Property(e => e.RolePlayId).HasColumnName("RolePlayID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Tblroleplaymaster)
                    .HasForeignKey(d => d.ModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ModuleID");
            });

            modelBuilder.Entity<Tblroles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("tblroles");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.RoleDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RoleType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblsendermailid>(entity =>
            {
                entity.HasKey(e => e.SeId)
                    .HasName("PK__tblsende__A1AFF808EB332EA7");

                entity.ToTable("tblsendermailid");

                entity.Property(e => e.SeId).HasColumnName("SE_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryMailId)
                    .IsRequired()
                    .HasColumnName("PrimaryMailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AutoEmailTypeNavigation)
                    .WithMany(p => p.Tblsendermailid)
                    .HasForeignKey(d => d.AutoEmailType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ERTID");
            });

            modelBuilder.Entity<TblshiftBreaks>(entity =>
            {
                entity.HasKey(e => e.BreakId)
                    .HasName("PK__tblshift__B267A6193E50B9E6");

                entity.ToTable("tblshift_breaks");

                entity.Property(e => e.BreakId).HasColumnName("BreakID");

                entity.Property(e => e.BreakReason)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<TblshiftMstr>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK__tblshift__C0A838E1187B96F7");

                entity.ToTable("tblshift_mstr");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndTime).HasColumnType("time(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("time(0)");
            });

            modelBuilder.Entity<Tblshiftdetails>(entity =>
            {
                entity.HasKey(e => e.ShiftDetailsId)
                    .HasName("PK__tblshift__0D6A0A9307F05AA8");

                entity.ToTable("tblshiftdetails");

                entity.Property(e => e.ShiftDetailsId).HasColumnName("ShiftDetailsID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsGshift)
                    .HasColumnName("IsGShift")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsShiftDetailsEdited).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftDetailsDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftDetailsEditedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftDetailsName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftEndTime).HasColumnType("time(0)");

                entity.Property(e => e.ShiftMethodId).HasColumnName("ShiftMethodID");

                entity.Property(e => e.ShiftStartTime).HasColumnType("time(0)");

                entity.HasOne(d => d.ShiftMethod)
                    .WithMany(p => p.Tblshiftdetails)
                    .HasForeignKey(d => d.ShiftMethodId)
                    .HasConstraintName("ShiftMethodIDshiftmethod");
            });

            modelBuilder.Entity<TblshiftdetailsMachinewise>(entity =>
            {
                entity.HasKey(e => e.ShiftDetailsMacId)
                    .HasName("PK__tblshift__2CD49C3AC349F4B5");

                entity.ToTable("tblshiftdetails_machinewise");

                entity.Property(e => e.ShiftDetailsMacId).HasColumnName("ShiftDetailsMacID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ShiftDetailsId).HasColumnName("ShiftDetailsID");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblshiftdetailsMachinewise)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineIDShiftWise");
            });

            modelBuilder.Entity<Tblshiftmethod>(entity =>
            {
                entity.HasKey(e => e.ShiftMethodId)
                    .HasName("PK__tblshift__221B9BAF400EF53A");

                entity.ToTable("tblshiftmethod");

                entity.Property(e => e.ShiftMethodId).HasColumnName("ShiftMethodID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EditedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsShiftMethodEdited).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftMethodDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftMethodName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblshiftplanner>(entity =>
            {
                entity.HasKey(e => e.ShiftPlannerId)
                    .HasName("PK__tblshift__0ED3C6C2C2CA821D");

                entity.ToTable("tblshiftplanner");

                entity.Property(e => e.ShiftPlannerId).HasColumnName("ShiftPlannerID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsPlanRemoved).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsPlanStopped).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlanStoppedDate).HasColumnType("date");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShiftMethodId).HasColumnName("ShiftMethodID");

                entity.Property(e => e.ShiftPlannerDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftPlannerName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("CellIDshiftplanner");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("MachineIDshiftplanner");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantIDshiftplanner");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopIDshiftplanner");
            });

            modelBuilder.Entity<Tblshop>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .HasName("PK__tblshop__67C55629413FF0DA");

                entity.ToTable("tblshop");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblshop)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PlantID");
            });

            modelBuilder.Entity<Tbltosapfilepath>(entity =>
            {
                entity.HasKey(e => e.ToSapfilePathId)
                    .HasName("PK__tbltosap__D3E2EAF0CFD4609C");

                entity.ToTable("tbltosapfilepath");

                entity.Property(e => e.ToSapfilePathId).HasColumnName("toSAPFilePathID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Path)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PathName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Tbltosapfilepathcol)
                    .HasColumnName("tbltosapfilepathcol")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tbltosapshopnames>(entity =>
            {
                entity.HasKey(e => e.ToSapshopNamesId)
                    .HasName("PK__tbltosap__87FD78D9694D60A4");

                entity.ToTable("tbltosapshopnames");

                entity.Property(e => e.ToSapshopNamesId).HasColumnName("toSAPShopNamesID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsSetupShown)
                    .HasColumnName("isSetupShown")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShopName)
                    .HasMaxLength(65)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblunit>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK__tblunit__5A2040DB28141F27");

                entity.ToTable("tblunit");

                entity.HasIndex(e => e.UId)
                    .HasName("U_ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.UId).HasColumnName("U_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblusers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblusers__1788CCACEFA66AA0");

                entity.ToTable("tblusers");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblusers)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("Mid");

                entity.HasOne(d => d.PrimaryRoleNavigation)
                    .WithMany(p => p.TblusersPrimaryRoleNavigation)
                    .HasForeignKey(d => d.PrimaryRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblusers_tblrolesPrimary");

                entity.HasOne(d => d.SecondaryRoleNavigation)
                    .WithMany(p => p.TblusersSecondaryRoleNavigation)
                    .HasForeignKey(d => d.SecondaryRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblusers_tblrolesSecondary");
            });

            modelBuilder.Entity<Tblwolossess>(entity =>
            {
                entity.HasKey(e => e.WolossesId)
                    .HasName("PK__tblwolos__3B0E3C5A4209E126");

                entity.ToTable("tblwolossess");

                entity.Property(e => e.WolossesId).HasColumnName("WOLossesID");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.LossCodeLevel1Id).HasColumnName("LossCodeLevel1ID");

                entity.Property(e => e.LossCodeLevel1Name)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeLevel2Id).HasColumnName("LossCodeLevel2ID");

                entity.Property(e => e.LossCodeLevel2Name)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.LossDuration).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.LossName)
                    .HasMaxLength(145)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblworeport>(entity =>
            {
                entity.HasKey(e => e.WoreportId)
                    .HasName("PK__tblworep__E4D0233D169095A2");

                entity.ToTable("tblworeport");

                entity.HasIndex(e => e.WoreportId)
                    .HasName("WOReportID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.WoreportId).HasColumnName("WOReportID");

                entity.Property(e => e.BatchNo).HasColumnName("batchNo");

                entity.Property(e => e.Blue)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Breakdown).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CuttingTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.HoldReason)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Idle).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsMultiWo)
                    .HasColumnName("IsMultiWO")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsNormalWc)
                    .HasColumnName("IsNormalWC")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsPf).HasColumnName("IsPF");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MinorLoss)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.Mrweight)
                    .HasColumnName("MRWeight")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NccuttingTimePerPart)
                    .HasColumnName("NCCuttingTimePerPart")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OpNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Program)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ReWorkTime)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapQtyTime)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.SelfInspection).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("('0.00')");

                entity.Property(e => e.TotalNccuttingTime)
                    .HasColumnName("TotalNCCuttingTime")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Woefficiency)
                    .HasColumnName("WOEfficiency")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserMaster>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__user_mas__1788CC4CF8C0DF73");

                entity.ToTable("user_master");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.LastName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });
        }
    }
}
