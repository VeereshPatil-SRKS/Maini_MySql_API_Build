using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace IFacilityMaini.DBModels
{
    public partial class unitworksccsContext : DbContext
    {
        public unitworksccsContext()
        {
        }

        public unitworksccsContext(DbContextOptions<unitworksccsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AlarmHistoryMaster> AlarmHistoryMaster { get; set; }
        public virtual DbSet<ConfigurationTblpmchecklist> ConfigurationTblpmchecklist { get; set; }
        public virtual DbSet<ConfigurationTblpmcheckpoint> ConfigurationTblpmcheckpoint { get; set; }
        public virtual DbSet<ConfigurationTblprimitivemaintainancescheduling> ConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual DbSet<ConfigurationTblsensorgroup> ConfigurationTblsensorgroup { get; set; }
        public virtual DbSet<Configurationtblmachinesensor> Configurationtblmachinesensor { get; set; }
        public virtual DbSet<Configurationtblsensordatalink> Configurationtblsensordatalink { get; set; }
        public virtual DbSet<Configurationtblsensormaster> Configurationtblsensormaster { get; set; }
        public virtual DbSet<Frommail> Frommail { get; set; }
        public virtual DbSet<HandleNoPing> HandleNoPing { get; set; }
        public virtual DbSet<IotgatwayPacketsData> IotgatwayPacketsData { get; set; }
        public virtual DbSet<JobcardDetails> JobcardDetails { get; set; }
        public virtual DbSet<LoginTrackerDetails> LoginTrackerDetails { get; set; }
        public virtual DbSet<MachineDetailsWimerasys> MachineDetailsWimerasys { get; set; }
        public virtual DbSet<Mailmaster> Mailmaster { get; set; }
        public virtual DbSet<MessageCodeMaster> MessageCodeMaster { get; set; }
        public virtual DbSet<MessageHistoryMaster> MessageHistoryMaster { get; set; }
        public virtual DbSet<Monthdata> Monthdata { get; set; }
        public virtual DbSet<Operationlog> Operationlog { get; set; }
        public virtual DbSet<ParameterSendorData> ParameterSendorData { get; set; }
        public virtual DbSet<ParameterSensorDataCurrent> ParameterSensorDataCurrent { get; set; }
        public virtual DbSet<ParameterSensorDataLevel> ParameterSensorDataLevel { get; set; }
        public virtual DbSet<ParameterSensorDataPressure> ParameterSensorDataPressure { get; set; }
        public virtual DbSet<ParameterSensorDataTemperature> ParameterSensorDataTemperature { get; set; }
        public virtual DbSet<ParameterToolData> ParameterToolData { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<ParametersMaster> ParametersMaster { get; set; }
        public virtual DbSet<PcbDetails> PcbDetails { get; set; }
        public virtual DbSet<PcbParameters> PcbParameters { get; set; }
        public virtual DbSet<Pcbdaq> Pcbdaq { get; set; }
        public virtual DbSet<PcbdaqinTbl> PcbdaqinTbl { get; set; }
        public virtual DbSet<PcbdpsMaster> PcbdpsMaster { get; set; }
        public virtual DbSet<ProgramExecutionMaster> ProgramExecutionMaster { get; set; }
        public virtual DbSet<ProgramMaster> ProgramMaster { get; set; }
        public virtual DbSet<SapFileGeneratedDetails> SapFileGeneratedDetails { get; set; }
        public virtual DbSet<Sharathtable> Sharathtable { get; set; }
        public virtual DbSet<Smtpdetails> Smtpdetails { get; set; }
        public virtual DbSet<TblAndonDispDet> TblAndonDispDet { get; set; }
        public virtual DbSet<TblAndonImageTextScheduledDisplay> TblAndonImageTextScheduledDisplay { get; set; }
        public virtual DbSet<TblAutoreportLog> TblAutoreportLog { get; set; }
        public virtual DbSet<TblAutoreportbasedon> TblAutoreportbasedon { get; set; }
        public virtual DbSet<TblAutoreportsetting> TblAutoreportsetting { get; set; }
        public virtual DbSet<TblAutoreporttime> TblAutoreporttime { get; set; }
        public virtual DbSet<TblAxisdet> TblAxisdet { get; set; }
        public virtual DbSet<TblAxisdetails1> TblAxisdetails1 { get; set; }
        public virtual DbSet<TblAxisdetails2> TblAxisdetails2 { get; set; }
        public virtual DbSet<TblBookStock> TblBookStock { get; set; }
        public virtual DbSet<TblBreakDownTickect> TblBreakDownTickect { get; set; }
        public virtual DbSet<TblBreakdowncodes> TblBreakdowncodes { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCategoryMaster> TblCategoryMaster { get; set; }
        public virtual DbSet<TblCellFinalMaster> TblCellFinalMaster { get; set; }
        public virtual DbSet<TblChildFgPartNo> TblChildFgPartNo { get; set; }
        public virtual DbSet<TblClassMaster> TblClassMaster { get; set; }
        public virtual DbSet<TblControlPlan> TblControlPlan { get; set; }
        public virtual DbSet<TblControlPlanDetails> TblControlPlanDetails { get; set; }
        public virtual DbSet<TblCycleTimeAnalysis> TblCycleTimeAnalysis { get; set; }
        public virtual DbSet<TblDefectCodeMaster> TblDefectCodeMaster { get; set; }
        public virtual DbSet<TblDeletedProgDet> TblDeletedProgDet { get; set; }
        public virtual DbSet<TblDirLineInspector> TblDirLineInspector { get; set; }
        public virtual DbSet<TblDirQualityHead> TblDirQualityHead { get; set; }
        public virtual DbSet<TblDryRun> TblDryRun { get; set; }
        public virtual DbSet<TblFgAndCellAllocation> TblFgAndCellAllocation { get; set; }
        public virtual DbSet<TblFgPartNoDet> TblFgPartNoDet { get; set; }
        public virtual DbSet<TblGeneratePlanVisageSapFile> TblGeneratePlanVisageSapFile { get; set; }
        public virtual DbSet<TblGenericfilepath> TblGenericfilepath { get; set; }
        public virtual DbSet<TblHolidayManagment> TblHolidayManagment { get; set; }
        public virtual DbSet<TblHolidayTypeMasters> TblHolidayTypeMasters { get; set; }
        public virtual DbSet<TblIpAddress> TblIpAddress { get; set; }
        public virtual DbSet<TblIssuedReceived> TblIssuedReceived { get; set; }
        public virtual DbSet<TblLivecbmparameters> TblLivecbmparameters { get; set; }
        public virtual DbSet<TblMasterValue> TblMasterValue { get; set; }
        public virtual DbSet<TblMaterialMaster> TblMaterialMaster { get; set; }
        public virtual DbSet<TblNcProgramTransferMain> TblNcProgramTransferMain { get; set; }
        public virtual DbSet<TblOeedetails> TblOeedetails { get; set; }
        public virtual DbSet<TblOeereportasdivision> TblOeereportasdivision { get; set; }
        public virtual DbSet<TblOperatorDashboard> TblOperatorDashboard { get; set; }
        public virtual DbSet<TblOperatorDetails> TblOperatorDetails { get; set; }
        public virtual DbSet<TblOperatorHeader> TblOperatorHeader { get; set; }
        public virtual DbSet<TblOperatorLoginDetails> TblOperatorLoginDetails { get; set; }
        public virtual DbSet<TblOperatorMachineDetails> TblOperatorMachineDetails { get; set; }
        public virtual DbSet<TblPlanLinkageMaster> TblPlanLinkageMaster { get; set; }
        public virtual DbSet<TblPrecentColour> TblPrecentColour { get; set; }
        public virtual DbSet<TblPresentTool> TblPresentTool { get; set; }
        public virtual DbSet<TblProcess> TblProcess { get; set; }
        public virtual DbSet<TblProdAndonDisp> TblProdAndonDisp { get; set; }
        public virtual DbSet<TblProdManMachine> TblProdManMachine { get; set; }
        public virtual DbSet<TblProdOrderLosses> TblProdOrderLosses { get; set; }
        public virtual DbSet<TblProdPlanMasters> TblProdPlanMasters { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
        public virtual DbSet<TblProductWiseDefectCode> TblProductWiseDefectCode { get; set; }
        public virtual DbSet<TblRaisedTicket> TblRaisedTicket { get; set; }
        public virtual DbSet<TblRejectionDetails> TblRejectionDetails { get; set; }
        public virtual DbSet<TblReportmaster> TblReportmaster { get; set; }
        public virtual DbSet<TblReworkDetails> TblReworkDetails { get; set; }
        public virtual DbSet<TblReworkReasons> TblReworkReasons { get; set; }
        public virtual DbSet<TblRoutingNo> TblRoutingNo { get; set; }
        public virtual DbSet<TblSapinput> TblSapinput { get; set; }
        public virtual DbSet<TblSar> TblSar { get; set; }
        public virtual DbSet<TblSarminmax> TblSarminmax { get; set; }
        public virtual DbSet<TblSaveNcprogVer> TblSaveNcprogVer { get; set; }
        public virtual DbSet<TblServodetails> TblServodetails { get; set; }
        public virtual DbSet<TblSetupMaint> TblSetupMaint { get; set; }
        public virtual DbSet<TblSmsDetails> TblSmsDetails { get; set; }
        public virtual DbSet<TblSourceMaster> TblSourceMaster { get; set; }
        public virtual DbSet<TblStatusMaster> TblStatusMaster { get; set; }
        public virtual DbSet<TblStdToolLife> TblStdToolLife { get; set; }
        public virtual DbSet<TblStoppage> TblStoppage { get; set; }
        public virtual DbSet<TblSubCellFinalMaster> TblSubCellFinalMaster { get; set; }
        public virtual DbSet<TblSystemConfig> TblSystemConfig { get; set; }
        public virtual DbSet<TblTicketRaisedDet> TblTicketRaisedDet { get; set; }
        public virtual DbSet<TblTicketReason> TblTicketReason { get; set; }
        public virtual DbSet<TblToolAndSocketDetails> TblToolAndSocketDetails { get; set; }
        public virtual DbSet<TblToolBrDnReasonLvl1> TblToolBrDnReasonLvl1 { get; set; }
        public virtual DbSet<TblToolBrkDnReason> TblToolBrkDnReason { get; set; }
        public virtual DbSet<TblToolCounter> TblToolCounter { get; set; }
        public virtual DbSet<TblTools> TblTools { get; set; }
        public virtual DbSet<TblTrialPartCount> TblTrialPartCount { get; set; }
        public virtual DbSet<TblUtilReport> TblUtilReport { get; set; }
        public virtual DbSet<TblWorkCenter> TblWorkCenter { get; set; }
        public virtual DbSet<Tblactivitylog> Tblactivitylog { get; set; }
        public virtual DbSet<TblappPaths> TblappPaths { get; set; }
        public virtual DbSet<Tblatccounter> Tblatccounter { get; set; }
        public virtual DbSet<Tblbottelneck> Tblbottelneck { get; set; }
        public virtual DbSet<Tblbreakdown> Tblbreakdown { get; set; }
        public virtual DbSet<Tblcell> Tblcell { get; set; }
        public virtual DbSet<Tblcellpart> Tblcellpart { get; set; }
        public virtual DbSet<Tblcustomer> Tblcustomer { get; set; }
        public virtual DbSet<Tbldailyprodstatus> Tbldailyprodstatus { get; set; }
        public virtual DbSet<Tbldaytiming> Tbldaytiming { get; set; }
        public virtual DbSet<Tbldowntimecategory> Tbldowntimecategory { get; set; }
        public virtual DbSet<Tbldowntimedetails> Tbldowntimedetails { get; set; }
        public virtual DbSet<Tblemailescalation> Tblemailescalation { get; set; }
        public virtual DbSet<Tblendcodes> Tblendcodes { get; set; }
        public virtual DbSet<Tblescalationlog> Tblescalationlog { get; set; }
        public virtual DbSet<Tblgenericworkcodes> Tblgenericworkcodes { get; set; }
        public virtual DbSet<Tblgenericworkentry> Tblgenericworkentry { get; set; }
        public virtual DbSet<Tblhistpms> Tblhistpms { get; set; }
        public virtual DbSet<Tblholdcodes> Tblholdcodes { get; set; }
        public virtual DbSet<Tblholidays> Tblholidays { get; set; }
        public virtual DbSet<Tbllivedailyprodstatus> Tbllivedailyprodstatus { get; set; }
        public virtual DbSet<Tbllivemode> Tbllivemode { get; set; }
        public virtual DbSet<Tbllossescodes> Tbllossescodes { get; set; }
        public virtual DbSet<Tbllossofentry> Tbllossofentry { get; set; }
        public virtual DbSet<Tblmachineaxisdetails> Tblmachineaxisdetails { get; set; }
        public virtual DbSet<Tblmachinecategory> Tblmachinecategory { get; set; }
        public virtual DbSet<Tblmachinedetails> Tblmachinedetails { get; set; }
        public virtual DbSet<Tblmailids> Tblmailids { get; set; }
        public virtual DbSet<TblmasterpartsStSw> TblmasterpartsStSw { get; set; }
        public virtual DbSet<Tblmimics> Tblmimics { get; set; }
        public virtual DbSet<Tblmode> Tblmode { get; set; }
        public virtual DbSet<Tblmodetemp> Tblmodetemp { get; set; }
        public virtual DbSet<Tblmodulehelper> Tblmodulehelper { get; set; }
        public virtual DbSet<Tblmodulemaster> Tblmodulemaster { get; set; }
        public virtual DbSet<Tblmodules> Tblmodules { get; set; }
        public virtual DbSet<Tblmultipleworkorder> Tblmultipleworkorder { get; set; }
        public virtual DbSet<Tbloeedashboardfinalvariables> Tbloeedashboardfinalvariables { get; set; }
        public virtual DbSet<Tbloeedashboardvariables> Tbloeedashboardvariables { get; set; }
        public virtual DbSet<Tbloeedashboardvariablestoday> Tbloeedashboardvariablestoday { get; set; }
        public virtual DbSet<Tblpartlearningreport> Tblpartlearningreport { get; set; }
        public virtual DbSet<Tblparts> Tblparts { get; set; }
        public virtual DbSet<Tblpartscountandcutting> Tblpartscountandcutting { get; set; }
        public virtual DbSet<Tblpir> Tblpir { get; set; }
        public virtual DbSet<Tblpirminmax> Tblpirminmax { get; set; }
        public virtual DbSet<Tblplannedbreak> Tblplannedbreak { get; set; }
        public virtual DbSet<Tblplant> Tblplant { get; set; }
        public virtual DbSet<Tblpmsdetails> Tblpmsdetails { get; set; }
        public virtual DbSet<Tblpriorityalarms> Tblpriorityalarms { get; set; }
        public virtual DbSet<Tblprogramtransferhistory> Tblprogramtransferhistory { get; set; }
        public virtual DbSet<Tblrejectqty> Tblrejectqty { get; set; }
        public virtual DbSet<Tblrejectreason> Tblrejectreason { get; set; }
        public virtual DbSet<Tblreportholder> Tblreportholder { get; set; }
        public virtual DbSet<Tblrolemodulelink> Tblrolemodulelink { get; set; }
        public virtual DbSet<Tblroles> Tblroles { get; set; }
        public virtual DbSet<Tblsendermailid> Tblsendermailid { get; set; }
        public virtual DbSet<TblshiftBreaks> TblshiftBreaks { get; set; }
        public virtual DbSet<TblshiftMstr> TblshiftMstr { get; set; }
        public virtual DbSet<Tblshiftdetails> Tblshiftdetails { get; set; }
        public virtual DbSet<TblshiftdetailsMachinewise> TblshiftdetailsMachinewise { get; set; }
        public virtual DbSet<Tblshiftmethod> Tblshiftmethod { get; set; }
        public virtual DbSet<Tblshiftplanner> Tblshiftplanner { get; set; }
        public virtual DbSet<Tblshop> Tblshop { get; set; }
        public virtual DbSet<Tbltoollifeoperator> Tbltoollifeoperator { get; set; }
        public virtual DbSet<Tbltosapfilepath> Tbltosapfilepath { get; set; }
        public virtual DbSet<Tbltosapshopnames> Tbltosapshopnames { get; set; }
        public virtual DbSet<Tblunit> Tblunit { get; set; }
        public virtual DbSet<Tblusers> Tblusers { get; set; }
        public virtual DbSet<Tblwolossess> Tblwolossess { get; set; }
        public virtual DbSet<Tblworeport> Tblworeport { get; set; }
        public virtual DbSet<Tblworkorderentry> Tblworkorderentry { get; set; }
        public virtual DbSet<Weekdata> Weekdata { get; set; }

        // Unable to generate entity type for table 'unitworkccs.shift_master'. Please see the warning messages.
        // Unable to generate entity type for table 'unitworkccs.tbl_livecbmdetails'. Please see the warning messages.
        // Unable to generate entity type for table 'unitworkccs.tbl_livetblsensorvalue'. Please see the warning messages.
        // Unable to generate entity type for table 'unitworkccs.tblAndonDisplayRotate'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer("Server=DESKTOP-R067I08\\SQLEXPRESS;Database=unitworksccs;user id=sa;password=srks4$;");
                optionsBuilder.UseSqlServer("Server=EC2AMAZ-L5INV42\\SQLEXPRESS;Database=unitworksccs;user id=sa;password=srks4$;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AlarmHistoryMaster>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("PK_alarm_history_master_AlarmID");

                entity.ToTable("alarm_history_master", "unitworkccs");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AbsPos)
                    .HasColumnName("Abs_Pos")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmDate).HasColumnType("date");

                entity.Property(e => e.AlarmDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.AlarmMessage).IsRequired();

                entity.Property(e => e.AlarmNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AxisNo)
                    .HasColumnName("Axis_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AxisNum)
                    .HasColumnName("Axis_Num")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.DetailCode1).HasMaxLength(45);

                entity.Property(e => e.DetailCode2).HasMaxLength(45);

                entity.Property(e => e.DetailCode3).HasMaxLength(45);

                entity.Property(e => e.ErrorNum).HasMaxLength(45);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.InterferedPart).HasMaxLength(45);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Shift).HasMaxLength(4);

                entity.Property(e => e.Status).HasMaxLength(45);

                entity.Property(e => e.SystemHead).HasMaxLength(10);
            });

            modelBuilder.Entity<ConfigurationTblpmchecklist>(entity =>
            {
                entity.HasKey(e => e.Pmcid)
                    .HasName("PK__configur__23BAE1136956A0F2");

                entity.ToTable("configuration_tblpmchecklist", "unitworkccs");

                entity.Property(e => e.Pmcid).HasColumnName("pmcid");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CheckList)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.Property(e => e.How)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PmcpId).HasColumnName("pmcpID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Value)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.ConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cellID_tblcell_tblpmchecklist");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.ConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plantID_FK");

                entity.HasOne(d => d.Pmcp)
                    .WithMany(p => p.ConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.PmcpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pmcpID_FK");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shopID_FK");
            });

            modelBuilder.Entity<ConfigurationTblpmcheckpoint>(entity =>
            {
                entity.HasKey(e => e.PmcpId)
                    .HasName("PK__configur__77319ED65B0EC7A9");

                entity.ToTable("configuration_tblpmcheckpoint", "unitworkccs");

                entity.Property(e => e.PmcpId).HasColumnName("pmcpID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CheckList)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnName("frequency")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.How)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.TypeofCheckpoint)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.ConfigurationTblpmcheckpoint)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cellID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.ConfigurationTblpmcheckpoint)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plantid_tblplant");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ConfigurationTblpmcheckpoint)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shopid_tblshop");
            });

            modelBuilder.Entity<ConfigurationTblprimitivemaintainancescheduling>(entity =>
            {
                entity.HasKey(e => e.Pmid)
                    .HasName("PK__configur__412600BA35FA1CB3");

                entity.ToTable("configuration_tblprimitivemaintainancescheduling", "unitworkccs");

                entity.Property(e => e.Pmid).HasColumnName("pmid");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CellName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Null')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.PlantName)
                    .HasColumnName("plantName")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Shopname)
                    .HasColumnName("shopname")
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('null')");

                entity.Property(e => e.WeekId).HasColumnName("WeekID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.ConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cellid_tblprimitivemaintainancescheduling2223");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.ConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("machineID_tblprimitivemaintainancescheduling2223");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.ConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("PlantID_tblprimitivemaintainancescheduling2223");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("ShopID_tblprimitivemaintainancescheduling2223");
            });

            modelBuilder.Entity<ConfigurationTblsensorgroup>(entity =>
            {
                entity.HasKey(e => e.Sid)
                    .HasName("PK__configur__CA195970D4E15FC0");

                entity.ToTable("configuration_tblsensorgroup", "unitworkccs");

                entity.Property(e => e.Sid).HasColumnName("SID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.SensorDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SensorGroupName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Configurationtblmachinesensor>(entity =>
            {
                entity.HasKey(e => e.Msid)
                    .HasName("PK__configur__6CB36003A1847136");

                entity.ToTable("configurationtblmachinesensor", "unitworkccs");

                entity.Property(e => e.Msid).HasColumnName("MSID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(6)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Configurationtblmachinesensor)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbllk_tblMachineSensor");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.Configurationtblmachinesensor)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblkl_tblMachineSensor");
            });

            modelBuilder.Entity<Configurationtblsensordatalink>(entity =>
            {
                entity.HasKey(e => e.ParameterTypeId)
                    .HasName("PK__configur__7FF7AC588F351EF3");

                entity.ToTable("configurationtblsensordatalink", "unitworkccs");

                entity.Property(e => e.ParameterTypeId).HasColumnName("ParameterTypeID");

                entity.Property(e => e.AxisId).HasColumnName("AxisID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.Deterioration)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Element)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.LogFreqUnitId).HasColumnName("LogFreqUnitID");

                entity.Property(e => e.Lsl)
                    .HasColumnName("LSL")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.ParameterDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SubElement)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Usl)
                    .HasColumnName("USL")
                    .HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Axis)
                    .WithMany(p => p.Configurationtblsensordatalink)
                    .HasForeignKey(d => d.AxisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("axisid");

                entity.HasOne(d => d.LogFreqUnit)
                    .WithMany(p => p.ConfigurationtblsensordatalinkLogFreqUnit)
                    .HasForeignKey(d => d.LogFreqUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("logfreqid");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.ConfigurationtblsensordatalinkUnitNavigation)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("unit");
            });

            modelBuilder.Entity<Configurationtblsensormaster>(entity =>
            {
                entity.HasKey(e => e.Smid)
                    .HasName("PK__configur__A47B2F5613189512");

                entity.ToTable("configurationtblsensormaster", "unitworkccs");

                entity.Property(e => e.Smid).HasColumnName("SMID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(6)");

                entity.Property(e => e.Parametertypeid).HasColumnName("parametertypeid");

                entity.Property(e => e.ScalingFactor)
                    .HasColumnName("scalingFactor")
                    .HasColumnType("decimal(6, 4)");

                entity.Property(e => e.SensorDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SensorlimitHigh).HasColumnName("sensorlimitHigh");

                entity.Property(e => e.SensorlimitLow).HasColumnName("sensorlimitLow");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.Configurationtblsensormaster)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SID_FK_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.Configurationtblsensormaster)
                    .HasForeignKey(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("uid");
            });

            modelBuilder.Entity<Frommail>(entity =>
            {
                entity.ToTable("frommail", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(45);

                entity.Property(e => e.FromEmailAdd)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Password).HasMaxLength(45);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<HandleNoPing>(entity =>
            {
                entity.HasKey(e => e.NoPingId)
                    .HasName("PK_handle_no_ping_NoPingID");

                entity.ToTable("handle_no_ping", "unitworkccs");

                entity.Property(e => e.NoPingId).HasColumnName("NoPingID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<IotgatwayPacketsData>(entity =>
            {
                entity.HasKey(e => e.GatewayMsgId);

                entity.ToTable("IOTGatwayPacketsData", "unitworkccs");

                entity.Property(e => e.GatewayMsgId).HasColumnName("GatewayMsgID");

                entity.Property(e => e.AlaramInput116).HasColumnName("AlaramInput1_16");

                entity.Property(e => e.AlaramInput217).HasColumnName("AlaramInput2_17");

                entity.Property(e => e.AlaramInput318).HasColumnName("AlaramInput3_18");

                entity.Property(e => e.AlaramInput419).HasColumnName("AlaramInput4_19");

                entity.Property(e => e.AlaramInput520).HasColumnName("AlaramInput5_20");

                entity.Property(e => e.AlaramInput622).HasColumnName("AlaramInput6_22");

                entity.Property(e => e.AlaramInput723).HasColumnName("AlaramInput7_23");

                entity.Property(e => e.AlaramInput824).HasColumnName("AlaramInput8_24");

                entity.Property(e => e.CorrectedDate).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.DevicePayLoadLength).HasMaxLength(50);

                entity.Property(e => e.Eof)
                    .HasColumnName("EOF")
                    .HasMaxLength(50);

                entity.Property(e => e.IotgateWayMsg)
                    .HasColumnName("IOTGateWayMsg")
                    .HasMaxLength(200);

                entity.Property(e => e.Ipaddres)
                    .HasColumnName("IPAddres")
                    .HasMaxLength(50);

                entity.Property(e => e.NodeCommunication).HasMaxLength(50);

                entity.Property(e => e.NodeDataPayLoad).HasMaxLength(50);

                entity.Property(e => e.NodeId).HasMaxLength(50);

                entity.Property(e => e.NodePayLoadLength).HasMaxLength(50);

                entity.Property(e => e.NumOfNodeActive).HasMaxLength(50);

                entity.Property(e => e.NumOfNodeDetected).HasMaxLength(50);

                entity.Property(e => e.PacketType).HasMaxLength(50);

                entity.Property(e => e.ProductSerialNo).HasMaxLength(50);

                entity.Property(e => e.RelayFeedbak1Status).HasMaxLength(50);

                entity.Property(e => e.RelayFeedbak2Status).HasMaxLength(50);

                entity.Property(e => e.RelayFeedbak3Status).HasMaxLength(50);

                entity.Property(e => e.RelayFeedbak4Status).HasMaxLength(50);

                entity.Property(e => e.Reserved).HasMaxLength(50);

                entity.Property(e => e.SiteId).HasMaxLength(50);

                entity.Property(e => e.Sof)
                    .HasColumnName("SOF")
                    .HasMaxLength(50);

                entity.Property(e => e.Swversion)
                    .HasColumnName("SWversion")
                    .HasMaxLength(50);

                entity.Property(e => e.Time).HasMaxLength(50);

                entity.Property(e => e.TypeOfDevice).HasMaxLength(50);

                entity.Property(e => e.UnitId).HasMaxLength(50);
            });

            modelBuilder.Entity<JobcardDetails>(entity =>
            {
                entity.HasKey(e => e.JobcardId)
                    .HasName("PK_jobcard_details_JobcardID");

                entity.ToTable("jobcard_details", "unitworkccs");

                entity.Property(e => e.JobcardId).HasColumnName("JobcardID");

                entity.Property(e => e.Compcode).HasMaxLength(25);

                entity.Property(e => e.EmpNo).HasMaxLength(25);

                entity.Property(e => e.Fromdatetime).HasColumnType("datetime2(0)");

                entity.Property(e => e.JobCardDate).HasMaxLength(45);

                entity.Property(e => e.MachineInvNumber).HasMaxLength(45);

                entity.Property(e => e.OpnIdleCode).HasMaxLength(25);

                entity.Property(e => e.Shift).HasMaxLength(45);

                entity.Property(e => e.Slno).HasColumnName("slno");

                entity.Property(e => e.Totalhours).HasMaxLength(45);

                entity.Property(e => e.Workorderno).HasMaxLength(25);
            });

            modelBuilder.Entity<LoginTrackerDetails>(entity =>
            {
                entity.ToTable("loginTrackerDetails", "unitworkccs");

                entity.Property(e => e.LoginTrackerDetailsId).HasColumnName("loginTrackerDetailsId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50);

                entity.Property(e => e.CurrentFgpart).HasColumnName("currentFGPart");

                entity.Property(e => e.CurrentTicketRaisedId)
                    .HasColumnName("currentTicketRaisedId")
                    .HasMaxLength(500);

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

                entity.ToTable("machineDetailsWimerasys", "unitworkccs");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

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

            modelBuilder.Entity<Mailmaster>(entity =>
            {
                entity.ToTable("mailmaster", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bccadd).HasColumnName("BCCAdd");

                entity.Property(e => e.Ccadd).HasColumnName("CCAdd");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(45);

                entity.Property(e => e.Toadd)
                    .HasColumnName("TOAdd")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<MessageCodeMaster>(entity =>
            {
                entity.HasKey(e => e.MessageCodeId)
                    .HasName("PK_message_code_master_MessageCodeID");

                entity.ToTable("message_code_master", "unitworkccs");

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.ColourCode).HasMaxLength(45);

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MessageCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MessageDescription)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.MessageMcode)
                    .IsRequired()
                    .HasColumnName("MessageMCode")
                    .HasMaxLength(10);

                entity.Property(e => e.MessageType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedBy).HasMaxLength(20);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ReportDispName).HasMaxLength(100);
            });

            modelBuilder.Entity<MessageHistoryMaster>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_message_history_master_MessageID");

                entity.ToTable("message_history_master", "unitworkccs");

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Meassage).IsRequired();

                entity.Property(e => e.MessageCode).HasMaxLength(10);

                entity.Property(e => e.MessageDate).HasColumnType("date");

                entity.Property(e => e.MessageDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.MessageNo)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MessageShift).HasMaxLength(10);

                entity.Property(e => e.MessageType).HasMaxLength(10);
            });

            modelBuilder.Entity<Monthdata>(entity =>
            {
                entity.HasKey(e => e.MonthId)
                    .HasName("PK__monthdat__9FA83F86AFB041A2");

                entity.ToTable("monthdata", "unitworkccs");

                entity.Property(e => e.MonthId).HasColumnName("MonthID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Isdeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Operationlog>(entity =>
            {
                entity.HasKey(e => e.Idoperationlog)
                    .HasName("PK_operationlog_idoperationlog");

                entity.ToTable("operationlog", "unitworkccs");

                entity.Property(e => e.Idoperationlog).HasColumnName("idoperationlog");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OpDate).HasColumnType("date");

                entity.Property(e => e.OpDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.OpReason).HasMaxLength(256);
            });

            modelBuilder.Entity<ParameterSendorData>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataId);

                entity.ToTable("parameter_sendor_data", "unitworkccs");

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
                entity.ToTable("parameter_sensor_data_current", "unitworkccs");

                entity.Property(e => e.ParameterSensorDataCurrentId).HasColumnName("parameterSensorDataCurrentId");

                entity.Property(e => e.CurrentValue)
                    .HasColumnName("currentValue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");
            });

            modelBuilder.Entity<ParameterSensorDataLevel>(entity =>
            {
                entity.ToTable("parameter_sensor_data_level", "unitworkccs");

                entity.Property(e => e.ParameterSensorDataLevelId).HasColumnName("parameterSensorDataLevelId");

                entity.Property(e => e.LevelValue)
                    .HasColumnName("levelValue")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");
            });

            modelBuilder.Entity<ParameterSensorDataPressure>(entity =>
            {
                entity.ToTable("parameter_sensor_data_pressure", "unitworkccs");

                entity.Property(e => e.ParameterSensorDataPressureId).HasColumnName("parameterSensorDataPressureId");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");

                entity.Property(e => e.PressureValue)
                    .HasColumnName("pressureValue")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ParameterSensorDataTemperature>(entity =>
            {
                entity.ToTable("parameter_sensor_data_temperature", "unitworkccs");

                entity.Property(e => e.ParameterSensorDataTemperatureId).HasColumnName("parameterSensorDataTemperatureId");

                entity.Property(e => e.ParameterSensorDataId).HasColumnName("parameterSensorDataID");

                entity.Property(e => e.TemperatureValue)
                    .HasColumnName("temperatureValue")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ParameterToolData>(entity =>
            {
                entity.ToTable("parameter_tool_data", "unitworkccs");

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
                    .HasName("PK_parameters_ParameterID");

                entity.ToTable("parameters", "unitworkccs");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ParameterType).HasMaxLength(45);
            });

            modelBuilder.Entity<ParametersMaster>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK_parameters_master_ParameterID");

                entity.ToTable("parameters_master", "unitworkccs");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.AutoCutTime).HasMaxLength(45);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CuttingTime).HasMaxLength(45);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperatingTime)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.PowerOnTime)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.SetupTime).HasMaxLength(45);

                entity.Property(e => e.TotalCutTime)
                    .HasColumnName("Total_CutTime")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<PcbDetails>(entity =>
            {
                entity.HasKey(e => e.Pcbid)
                    .HasName("PK_pcb_details_PCBID");

                entity.ToTable("pcb_details", "unitworkccs");

                entity.Property(e => e.Pcbid).HasColumnName("PCBID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30);

                entity.Property(e => e.Pcbmacaddress)
                    .HasColumnName("PCBMACAddress")
                    .HasMaxLength(45);

                entity.Property(e => e.Pcbno).HasColumnName("PCBNo");
            });

            modelBuilder.Entity<PcbParameters>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK_pcb_parameters_ParameterID");

                entity.ToTable("pcb_parameters", "unitworkccs");

                entity.Property(e => e.ParameterId).HasColumnName("ParameterID");

                entity.Property(e => e.ColorCode).HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.LogFile).HasMaxLength(45);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ParameterType).HasMaxLength(45);
            });

            modelBuilder.Entity<Pcbdaq>(entity =>
            {
                entity.ToTable("pcbdaq", "unitworkccs");

                entity.Property(e => e.Pcbdaqid).HasColumnName("PCBDAQID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PcbdateTime)
                    .HasColumnName("PCBDateTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<PcbdaqinTbl>(entity =>
            {
                entity.HasKey(e => e.Daqinid)
                    .HasName("PK_pcbdaqin_tbl_DAQINID");

                entity.ToTable("pcbdaqin_tbl", "unitworkccs");

                entity.Property(e => e.Daqinid).HasColumnName("DAQINID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ParamPin).HasColumnName("ParamPIN");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<PcbdpsMaster>(entity =>
            {
                entity.ToTable("pcbdps_master", "unitworkccs");

                entity.Property(e => e.PcbDpsMasterId).HasColumnName("PcbDpsMasterID");

                entity.Property(e => e.ColorValue).HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");
            });

            modelBuilder.Entity<ProgramExecutionMaster>(entity =>
            {
                entity.HasKey(e => e.ProgramExecutionId);

                entity.ToTable("program_execution_master", "unitworkccs");

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
                    .HasName("PK_program_master_ProgramID");

                entity.ToTable("program_master", "unitworkccs");

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ComponentCode).HasMaxLength(20);

                entity.Property(e => e.ComponentDescription).HasMaxLength(50);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperationDescription).HasMaxLength(20);

                entity.Property(e => e.OpnCode1)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OpnCode2).HasMaxLength(10);

                entity.Property(e => e.OpnCode3).HasMaxLength(10);

                entity.Property(e => e.ProgramDate).HasColumnType("date");

                entity.Property(e => e.ProgramDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Shift).HasMaxLength(10);

                entity.Property(e => e.WorkOrderNo1)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.WorkOrderNo2).HasMaxLength(20);

                entity.Property(e => e.WorkOrderNo3).HasMaxLength(20);
            });

            modelBuilder.Entity<SapFileGeneratedDetails>(entity =>
            {
                entity.HasKey(e => e.SapFileGeneratedId);

                entity.ToTable("sapFileGeneratedDetails", "unitworkccs");

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

            modelBuilder.Entity<Sharathtable>(entity =>
            {
                entity.HasKey(e => e.Sharathid);

                entity.ToTable("sharathtable", "unitworkccs");

                entity.Property(e => e.Sharathid).HasColumnName("sharathid");

                entity.Property(e => e.Mcid).HasColumnName("MCID");

                entity.Property(e => e.Sharathname)
                    .HasColumnName("sharathname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sharathvalue).HasColumnName("sharathvalue");

                entity.Property(e => e.Syncid).HasColumnName("syncid");

                entity.Property(e => e.TabSharathId).HasColumnName("TabSharathID");
            });

            modelBuilder.Entity<Smtpdetails>(entity =>
            {
                entity.HasKey(e => e.SmtpId);

                entity.ToTable("smtpdetails", "unitworkccs");

                entity.Property(e => e.SmtpId).HasColumnName("smtpID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblAndonDispDet>(entity =>
            {
                entity.HasKey(e => e.Andondispid)
                    .HasName("PK_tblAndonDispDet_1");

                entity.ToTable("tblAndonDispDet", "unitworkccs");

                entity.Property(e => e.Andondispid)
                    .HasColumnName("ANDONDISPID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.TblAndonDispDet)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("FK_tblAndonDispDEt_tblcell");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.TblAndonDispDet)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAndonDispDEt_tblplant");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.TblAndonDispDet)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_tblAndonDispDEt_tblshop");
            });

            modelBuilder.Entity<TblAndonImageTextScheduledDisplay>(entity =>
            {
                entity.HasKey(e => e.TextImageAndonId);

                entity.ToTable("tblAndonImageTextScheduledDisplay", "unitworkccs");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.DefaultScreenVisible).HasDefaultValueSql("(N'0')");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ScreenType)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'1,1,0,0-1')");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.TblAndonImageTextScheduledDisplay)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("FK_tblAndonImageTextScheduledDisplay_tblcell");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.TblAndonImageTextScheduledDisplay)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK_tblAndonImageTextScheduledDisplay_tblplant");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.TblAndonImageTextScheduledDisplay)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_tblAndonImageTextScheduledDisplay_tblshop");
            });

            modelBuilder.Entity<TblAutoreportLog>(entity =>
            {
                entity.HasKey(e => e.AutoReportLogId)
                    .HasName("PK_tbl_autoreport_log_AutoReportLogID");

                entity.ToTable("tbl_autoreport_log", "unitworkccs");

                entity.Property(e => e.AutoReportLogId).HasColumnName("AutoReportLogID");

                entity.Property(e => e.AutoReportId).HasColumnName("AutoReportID");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.ExcelCreated).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExcelCreatedTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MailSent).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AutoReport)
                    .WithMany(p => p.TblAutoreportLog)
                    .HasForeignKey(d => d.AutoReportId)
                    .HasConstraintName("tbl_autoreport_log$AutoReportID");
            });

            modelBuilder.Entity<TblAutoreportbasedon>(entity =>
            {
                entity.HasKey(e => e.BasedOnId)
                    .HasName("PK_tbl_autoreportbasedon_BasedOnID");

                entity.ToTable("tbl_autoreportbasedon", "unitworkccs");

                entity.Property(e => e.BasedOnId).HasColumnName("BasedOnID");

                entity.Property(e => e.BasedOn).HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Desc).HasMaxLength(100);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblAutoreportsetting>(entity =>
            {
                entity.HasKey(e => e.AutoReportId)
                    .HasName("PK_tbl_autoreportsetting_AutoReportID");

                entity.ToTable("tbl_autoreportsetting", "unitworkccs");

                entity.Property(e => e.AutoReportId).HasColumnName("AutoReportID");

                entity.Property(e => e.AutoReportTimeId).HasColumnName("AutoReportTimeID");

                entity.Property(e => e.CcmailList).HasColumnName("CCMailList");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.NextRunDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.AutoReportTime)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.AutoReportTimeId)
                    .HasConstraintName("tbl_autoreportsetting$ReportTimeID");

                entity.HasOne(d => d.BasedOnNavigation)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.BasedOn)
                    .HasConstraintName("tbl_autoreportsetting$BasedOnID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("tbl_autoreportsetting$ReportCellID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("tbl_autoreportsetting$ReportWorkCentreID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tbl_autoreportsetting$ReportPlantID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("tbl_autoreportsetting$ReportID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.TblAutoreportsetting)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tbl_autoreportsetting$ReportShopID");
            });

            modelBuilder.Entity<TblAutoreporttime>(entity =>
            {
                entity.HasKey(e => e.AutoReportTimeId)
                    .HasName("PK_tbl_autoreporttime_AutoReportTimeID");

                entity.ToTable("tbl_autoreporttime", "unitworkccs");

                entity.Property(e => e.AutoReportTimeId).HasColumnName("AutoReportTimeID");

                entity.Property(e => e.AutoReportTime).HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Description).HasMaxLength(45);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblAxisdet>(entity =>
            {
                entity.HasKey(e => e.AxisDetId)
                    .HasName("PK_tbl_axisdet_AxisDetID");

                entity.ToTable("tbl_axisdet", "unitworkccs");

                entity.Property(e => e.AxisDetId).HasColumnName("AxisDetID");

                entity.Property(e => e.AxisId).HasColumnName("AxisID");

                entity.Property(e => e.AxisName)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.SpindlePath).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblAxisdet)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbl_axisdet$AxisMachineIDIdx");
            });

            modelBuilder.Entity<TblAxisdetails1>(entity =>
            {
                entity.HasKey(e => e.Adid);

                entity.ToTable("tbl_axisdetails1", "unitworkccs");

                entity.Property(e => e.Adid).HasColumnName("ADID");

                entity.Property(e => e.AbsPos).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Axis).HasMaxLength(50);

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

                entity.ToTable("tbl_axisdetails2", "unitworkccs");

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

                entity.ToTable("tblBookStock", "unitworkccs");

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

            modelBuilder.Entity<TblBreakDownTickect>(entity =>
            {
                entity.ToTable("tblBreakDownTickect", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptFlage).HasDefaultValueSql("((0))");

                entity.Property(e => e.BdTktDateTime)
                    .HasColumnName("bdTktDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.MaintFinished).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintFlage).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaintRejId).HasColumnName("maintRejId");

                entity.Property(e => e.MntAcpRejDateTime)
                    .HasColumnName("mntAcp/RejDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MntClosureOpId).HasColumnName("mntClosureOpId");

                entity.Property(e => e.MntOpId).HasColumnName("mntOpId");

                entity.Property(e => e.MntRemarks)
                    .HasColumnName("mntRemarks")
                    .HasMaxLength(500);

                entity.Property(e => e.MntRrejectReason)
                    .HasColumnName("mntRrejectReason")
                    .HasMaxLength(500);

                entity.Property(e => e.MntStatus).HasColumnName("mntStatus");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdAcpRejDateTime)
                    .HasColumnName("prodAcp/RejDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProdFinished).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProdOpId).HasColumnName("prodOpId");

                entity.Property(e => e.ProdRejId).HasColumnName("prodRejId");

                entity.Property(e => e.ProdRemarks)
                    .HasColumnName("prodRemarks")
                    .HasMaxLength(500);

                entity.Property(e => e.ProdStatus).HasColumnName("prodStatus");

                entity.Property(e => e.ReasonId).HasColumnName("reasonId");

                entity.Property(e => e.TktClosingTime)
                    .HasColumnName("tktClosingTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.WoId).HasColumnName("woId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblBreakDownTickect)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_tblBreakDownTickect_tblmachinedetails");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.TblBreakDownTickect)
                    .HasForeignKey(d => d.ReasonId)
                    .HasConstraintName("FK_tblBreakDownTickect_tbllossescodes");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.TblBreakDownTickect)
                    .HasForeignKey(d => d.WoId)
                    .HasConstraintName("FK_tblBreakDownTickect_tblworkorderentry");
            });

            modelBuilder.Entity<TblBreakdowncodes>(entity =>
            {
                entity.HasKey(e => e.BreakdownId)
                    .HasName("PK_tblBreakdowncodes_BreakdownID");

                entity.ToTable("tblBreakdowncodes", "unitworkccs");

                entity.Property(e => e.BreakdownId)
                    .HasColumnName("BreakdownID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BreakdownCode).HasMaxLength(500);

                entity.Property(e => e.BreakdownDesc).HasMaxLength(450);

                entity.Property(e => e.BreakdownLevel1Id).HasColumnName("BreakdownLevel1ID");

                entity.Property(e => e.BreakdownLevel2Id).HasColumnName("BreakdownLevel2ID");

                entity.Property(e => e.ContributeTo).HasMaxLength(30);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.MessageType).HasMaxLength(450);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.TargetPercent)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.01))");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.ControlPlanCatId);

                entity.ToTable("tblCategory", "unitworkccs");

                entity.Property(e => e.ControlPlanCatId).HasColumnName("controlPlanCatId");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
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
            });

            modelBuilder.Entity<TblCategoryMaster>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("tblCategoryMaster", "unitworkccs");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CategoryDesc)
                    .HasColumnName("categoryDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
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
            });

            modelBuilder.Entity<TblCellFinalMaster>(entity =>
            {
                entity.HasKey(e => e.CellFinalId);

                entity.ToTable("tblCellFinalMaster", "unitworkccs");

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

            modelBuilder.Entity<TblChildFgPartNo>(entity =>
            {
                entity.HasKey(e => e.ChildFgpartId);

                entity.ToTable("tblChildFgPartNo", "unitworkccs");

                entity.Property(e => e.ChildFgpartId).HasColumnName("childFgpartId");

                entity.Property(e => e.ChildFgPartNo)
                    .HasColumnName("childFgPartNo")
                    .HasMaxLength(500);

                entity.Property(e => e.ChildPartNoDesc)
                    .HasColumnName("childPartNoDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgPartDesc)
                    .HasColumnName("fgPartDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500);

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

                entity.ToTable("tblClassMaster", "unitworkccs");

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

            modelBuilder.Entity<TblControlPlan>(entity =>
            {
                entity.HasKey(e => e.CpId);

                entity.ToTable("tblControlPlan", "unitworkccs");

                entity.Property(e => e.CpId).HasColumnName("cpId");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("approvedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CellId).HasColumnName("cellId");

                entity.Property(e => e.ChildPartNo).HasColumnName("childPartNo");

                entity.Property(e => e.ControlPlanNo)
                    .HasColumnName("controlPlanNo")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgDesc)
                    .HasColumnName("fgDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.RevisionNo)
                    .HasColumnName("revisionNo")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.RoutingNo).HasColumnName("routingNo");
            });

            modelBuilder.Entity<TblControlPlanDetails>(entity =>
            {
                entity.HasKey(e => e.ControlPlanDetId);

                entity.ToTable("tblControlPlanDetails", "unitworkccs");

                entity.Property(e => e.ControlPlanDetId).HasColumnName("controlPlanDetId");

                entity.Property(e => e.BallunNo)
                    .HasColumnName("ballunNo")
                    .HasMaxLength(500);

                entity.Property(e => e.ControlPlanId).HasColumnName("controlPlanId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerRefCpNo)
                    .HasColumnName("customerRefCpNo")
                    .HasMaxLength(500);

                entity.Property(e => e.Dimension).HasColumnName("dimension");

                entity.Property(e => e.EvaluationMethod)
                    .HasColumnName("evaluationMethod")
                    .HasMaxLength(500);

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MaxTolerance)
                    .HasColumnName("maxTolerance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinToleranace)
                    .HasColumnName("minToleranace")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperationNo)
                    .HasColumnName("operationNo")
                    .HasMaxLength(500);

                entity.Property(e => e.OperationalDescription)
                    .HasColumnName("operationalDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(500);

                entity.Property(e => e.ProcessId).HasColumnName("processId");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ReactionPlan)
                    .HasColumnName("reactionPlan")
                    .HasMaxLength(500);

                entity.Property(e => e.RecordingMethod)
                    .HasColumnName("recordingMethod")
                    .HasMaxLength(500);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(500);

                entity.Property(e => e.RevisionNo)
                    .HasColumnName("revisionNo")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SpecialCharacterClass)
                    .HasColumnName("specialCharacterClass")
                    .HasMaxLength(500);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time(0)");
            });

            modelBuilder.Entity<TblCycleTimeAnalysis>(entity =>
            {
                entity.HasKey(e => e.Ctaid);

                entity.ToTable("tbl_CycleTimeAnalysis", "unitworkccs");

                entity.Property(e => e.Ctaid).HasColumnName("CTAID");

                entity.Property(e => e.AvgLoadTimeinMinutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvgOperatingTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AvgOperatingTimeUnit).HasMaxLength(50);

                entity.Property(e => e.CorrectedDate).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.LossTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LossTimeUnit).HasMaxLength(50);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperatingTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperatingTimeUnit).HasMaxLength(50);

                entity.Property(e => e.PartNum).HasMaxLength(50);

                entity.Property(e => e.StdCycleTime)
                    .HasColumnName("Std_CycleTime")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StdCycleTimeUnit)
                    .HasColumnName("Std_CycleTimeUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.StdLoadTime)
                    .HasColumnName("Std_LoadTime")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StdLoadTimeUnit)
                    .HasColumnName("Std_LoadTimeUnit")
                    .HasMaxLength(50);

                entity.Property(e => e.TotalLoadTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalLoadTimeUnit).HasMaxLength(50);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblCycleTimeAnalysis)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_tbl_CycleTimeAnalysis_tblmachinedetails");
            });

            modelBuilder.Entity<TblDefectCodeMaster>(entity =>
            {
                entity.HasKey(e => e.DefectCodeId);

                entity.ToTable("tblDefectCodeMaster", "unitworkccs");

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

            modelBuilder.Entity<TblDeletedProgDet>(entity =>
            {
                entity.HasKey(e => e.ProgDeletedId);

                entity.ToTable("tbl_deletedProgDet", "unitworkccs");

                entity.Property(e => e.ProgDeletedId).HasColumnName("ProgDeletedID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifedOn).HasColumnType("datetime");

                entity.Property(e => e.ProgramData)
                    .IsRequired()
                    .HasColumnType("text");

                entity.Property(e => e.ProgramNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDirLineInspector>(entity =>
            {
                entity.HasKey(e => e.DirLineInspId);

                entity.ToTable("tblDirLineInspector", "unitworkccs");

                entity.Property(e => e.DirLineInspId).HasColumnName("dirLineInspId");

                entity.Property(e => e.CellId).HasColumnName("cellId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCode)
                    .HasColumnName("defectCode")
                    .HasMaxLength(500);

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.DefectDescription)
                    .HasColumnName("defectDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.EmployeeNo)
                    .HasColumnName("employeeNo")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(500);

                entity.Property(e => e.PartQrCode)
                    .HasColumnName("partQrCode")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCellId).HasColumnName("subCellId");

                entity.Property(e => e.WorkorderNumber)
                    .HasColumnName("workorderNumber")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblDirQualityHead>(entity =>
            {
                entity.HasKey(e => e.DirQhId);

                entity.ToTable("tblDirQualityHead", "unitworkccs");

                entity.Property(e => e.DirQhId).HasColumnName("dirQhId");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(500);

                entity.Property(e => e.CompletedOn)
                    .HasColumnName("completedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeNo)
                    .HasColumnName("employeeNo")
                    .HasMaxLength(500);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenTracker)
                    .HasColumnName("openTracker")
                    .HasMaxLength(500);

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(500);

                entity.Property(e => e.ReworkOrReject)
                    .HasColumnName("reworkOrReject")
                    .HasMaxLength(500);

                entity.Property(e => e.RouteCause)
                    .HasColumnName("routeCause")
                    .HasMaxLength(500);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.TargetDate)
                    .HasColumnName("targetDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrackerNo)
                    .HasColumnName("trackerNo")
                    .HasMaxLength(500);

                entity.Property(e => e.WorkOrderNumber)
                    .HasColumnName("workOrderNumber")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblDryRun>(entity =>
            {
                entity.HasKey(e => e.DryRunId);

                entity.ToTable("tblDryRun", "unitworkccs");

                entity.Property(e => e.DryRunId).HasColumnName("dryRunId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnName("modifiedOn");

                entity.Property(e => e.PartCount).HasColumnName("partCount");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("userId");
            });

            modelBuilder.Entity<TblFgAndCellAllocation>(entity =>
            {
                entity.HasKey(e => e.FgAndCellAllocationId);

                entity.ToTable("tblFgAndCellAllocation", "unitworkccs");

                entity.Property(e => e.FgAndCellAllocationId).HasColumnName("fgAndCellAllocationId");

                entity.Property(e => e.CellFinalId).HasColumnName("cellFinalId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DmcCodeStatus)
                    .HasColumnName("dmcCodeStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.SubCellFinalId).HasColumnName("subCellFinalId");
            });

            modelBuilder.Entity<TblFgPartNoDet>(entity =>
            {
                entity.HasKey(e => e.FgPartId);

                entity.ToTable("tblFgPartNoDet", "unitworkccs");

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.ActaulValue).HasColumnName("actaulValue");

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

                entity.Property(e => e.PlanLinkageId).HasColumnName("planLinkageId");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("workOrderNo")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblGeneratePlanVisageSapFile>(entity =>
            {
                entity.HasKey(e => e.SapFileId);

                entity.ToTable("tblGeneratePlanVisageSapFile");

                entity.Property(e => e.SapFileId).HasColumnName("sapFileId");

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

                entity.Property(e => e.SapFileGeneratedDate)
                    .HasColumnName("sapFileGeneratedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.SapFileName)
                    .HasColumnName("sapFileName")
                    .HasMaxLength(500);

                entity.Property(e => e.TotalActualCount).HasColumnName("totalActualCount");
            });

            modelBuilder.Entity<TblGenericfilepath>(entity =>
            {
                entity.HasKey(e => e.FilePathId)
                    .HasName("PK_tbl_genericfilepath_FilePathID");

                entity.ToTable("tbl_genericfilepath", "unitworkccs");

                entity.Property(e => e.FilePathId).HasColumnName("FilePathID");

                entity.Property(e => e.CompleteFilePath).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.FilePathDesc).HasMaxLength(150);

                entity.Property(e => e.FilePathDet).HasMaxLength(45);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblHolidayManagment>(entity =>
            {
                entity.HasKey(e => e.HolidayManagmentId);

                entity.ToTable("tblHolidayManagment", "unitworkccs");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DaysDuration)
                    .HasColumnName("daysDuration")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.HolidayManagmentDesc).HasMaxLength(400);

                entity.Property(e => e.HolidayManagmentName).HasMaxLength(100);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("isDelete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHolidayTypeMasters>(entity =>
            {
                entity.HasKey(e => e.HolidayTypeId);

                entity.ToTable("tblHolidayTypeMasters", "unitworkccs");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.HolidayTypeColorCode).HasMaxLength(50);

                entity.Property(e => e.HolidayTypeName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblIpAddress>(entity =>
            {
                entity.HasKey(e => e.IpAddressId);

                entity.ToTable("tblIpAddress", "unitworkccs");

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
                entity.ToTable("tblIssuedReceived", "unitworkccs");

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

            modelBuilder.Entity<TblLivecbmparameters>(entity =>
            {
                entity.HasKey(e => e.CbmpId)
                    .HasName("PK__tbl_live__C79BE4D4CCA5249D");

                entity.ToTable("tbl_livecbmparameters", "unitworkccs");

                entity.Property(e => e.CbmpId).HasColumnName("cbmpID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime2(0)")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsConverted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.SensorGroupId).HasColumnName("SensorGroupID");
            });

            modelBuilder.Entity<TblMasterValue>(entity =>
            {
                entity.HasKey(e => e.MasterValueId)
                    .HasName("PK_masterValueTbl");

                entity.ToTable("tblMasterValue", "unitworkccs");

                entity.Property(e => e.MasterValueId).HasColumnName("masterValueId");

                entity.Property(e => e.MasterValue)
                    .HasColumnName("masterValue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MasterValueDesc)
                    .HasColumnName("masterValueDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.MasterValueName)
                    .HasColumnName("masterValueName")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblMaterialMaster>(entity =>
            {
                entity.HasKey(e => e.MaterialmasterId);

                entity.ToTable("tblMaterialMaster", "unitworkccs");

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

            modelBuilder.Entity<TblNcProgramTransferMain>(entity =>
            {
                entity.HasKey(e => e.NcProgramTransferId);

                entity.ToTable("tblNcProgramTransferMain", "unitworkccs");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FromCnc)
                    .HasColumnName("FromCNC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProgramNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Mc)
                    .WithMany(p => p.TblNcProgramTransferMain)
                    .HasForeignKey(d => d.McId)
                    .HasConstraintName("FK_tblNcProgramTransferMain_tblmachinedetails");
            });

            modelBuilder.Entity<TblOeedetails>(entity =>
            {
                entity.HasKey(e => e.Oeeid);

                entity.ToTable("tbl_OEEDetails", "unitworkccs");

                entity.Property(e => e.Oeeid).HasColumnName("OEEID");

                entity.Property(e => e.Availability).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CorrectedDate).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Oee)
                    .HasColumnName("OEE")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OperatingTimeinMin).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Performance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PerformanceFactor).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PowerOffTimeInMinutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PowerOnTimeInMinutes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Quality).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalIdletimeinMin)
                    .HasColumnName("TotalIDLETimeinMin")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalTimeInMinutes).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblOeedetails)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_tbl_OEEDetails_tbl_MachineDetails");
            });

            modelBuilder.Entity<TblOeereportasdivision>(entity =>
            {
                entity.HasKey(e => e.Lid)
                    .HasName("PK_unitworkccs.tbl_oeereportasdivision");

                entity.ToTable("tbl_oeereportasdivision", "unitworkccs");

                entity.Property(e => e.Lid).HasColumnName("LID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(50);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");
            });

            modelBuilder.Entity<TblOperatorDashboard>(entity =>
            {
                entity.HasKey(e => e.OperatorDashboardId);

                entity.ToTable("tblOperatorDashboard", "unitworkccs");

                entity.Property(e => e.OperatorDashboardId).HasColumnName("OperatorDashboardID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MessageDescription).HasMaxLength(150);

                entity.Property(e => e.MessageEndTime).HasColumnType("datetime");

                entity.Property(e => e.MessageStartTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblOperatorDashboard)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOperatorDashboard_tblmachinedetails");
            });

            modelBuilder.Entity<TblOperatorDetails>(entity =>
            {
                entity.HasKey(e => e.OpId);

                entity.ToTable("tblOperatorDetails", "unitworkccs");

                entity.Property(e => e.OpId).HasColumnName("opId");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.CellId).HasColumnName("cellId");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(50);

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
                    .HasMaxLength(500);

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

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(500);

                entity.Property(e => e.SubCellId).HasColumnName("subCellId");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<TblOperatorHeader>(entity =>
            {
                entity.HasKey(e => e.OperatorId);

                entity.ToTable("tblOperatorHeader", "unitworkccs");

                entity.Property(e => e.OperatorId).HasColumnName("OperatorID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineMode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ServerConnecStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TabConnecStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblOperatorHeader)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblOperatorHeader_tblmachinedetails");
            });

            modelBuilder.Entity<TblOperatorLoginDetails>(entity =>
            {
                entity.HasKey(e => e.OperatorLoginId);

                entity.ToTable("tblOperatorLoginDetails", "unitworkccs");

                entity.Property(e => e.OperatorLoginId).HasColumnName("operatorLoginId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorEmailId)
                    .HasColumnName("operatorEmailId")
                    .HasMaxLength(200);

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.OperatorMobileNo)
                    .HasColumnName("operatorMobileNo")
                    .HasMaxLength(20);

                entity.Property(e => e.OperatorName)
                    .HasColumnName("operatorName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorPwd)
                    .HasColumnName("operatorPwd")
                    .HasMaxLength(200);

                entity.Property(e => e.OperatorUserName)
                    .HasColumnName("operatorUserName")
                    .HasMaxLength(200);

                entity.Property(e => e.Reasons)
                    .HasColumnName("reasons")
                    .HasMaxLength(500);

                entity.Property(e => e.RoleId).HasColumnName("roleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblOperatorLoginDetails)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_tblOperatorLoginDetails_tblroles");
            });

            modelBuilder.Entity<TblOperatorMachineDetails>(entity =>
            {
                entity.HasKey(e => e.OpertorMacDetId);

                entity.ToTable("tblOperatorMachineDetails", "unitworkccs");

                entity.Property(e => e.OpertorMacDetId).HasColumnName("opertorMacDetId");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorLoginId).HasColumnName("operatorLoginId");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblOperatorMachineDetails)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("FK_tblOperatorMachineDetails_tblmachinedetails");

                entity.HasOne(d => d.OperatorLogin)
                    .WithMany(p => p.TblOperatorMachineDetails)
                    .HasForeignKey(d => d.OperatorLoginId)
                    .HasConstraintName("FK_tblOperatorMachineDetails_tblOperatorLoginDetails");
            });

            modelBuilder.Entity<TblPlanLinkageMaster>(entity =>
            {
                entity.HasKey(e => e.PlanLinkageId);

                entity.ToTable("tblPlanLinkageMaster", "unitworkccs");

                entity.Property(e => e.PlanLinkageId).HasColumnName("planLinkageId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500);

                entity.Property(e => e.IdealCycleTime)
                    .HasColumnName("idealCycleTime")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdatedUse)
                    .HasColumnName("lastUpdatedUse")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumUpdates).HasColumnName("numUpdates");

                entity.Property(e => e.Operation).HasColumnName("operation");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500);

                entity.Property(e => e.PlannedEndTime)
                    .HasColumnName("plannedEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlannedStartTime)
                    .HasColumnName("plannedStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.ProductionOrder)
                    .HasColumnName("productionOrder")
                    .HasMaxLength(500);

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resourceId")
                    .HasMaxLength(500);

                entity.Property(e => e.RoutingId)
                    .HasColumnName("routingId")
                    .HasMaxLength(500);

                entity.Property(e => e.SapDateTimeStamp)
                    .HasColumnName("sapDateTimeStamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnName("scheduleDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScheduleId).HasColumnName("scheduleId");

                entity.Property(e => e.ScheduledQty).HasColumnName("scheduledQty");

                entity.Property(e => e.SetUpTime)
                    .HasColumnName("setUpTime")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShiftId).HasColumnName("shiftId");

                entity.Property(e => e.TargetPerHr).HasColumnName("targetPerHr");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50);

                entity.Property(e => e.WorkOrderCompletedQty).HasColumnName("workOrderCompletedQty");

                entity.Property(e => e.WorkOrderQty)
                    .HasColumnName("workOrderQty")
                    .HasColumnType("decimal(18, 6)");
            });

            modelBuilder.Entity<TblPrecentColour>(entity =>
            {
                entity.HasKey(e => e.ColourId);

                entity.ToTable("tblPrecentColour", "unitworkccs");

                entity.Property(e => e.ColourId).HasColumnName("ColourID");

                entity.Property(e => e.Colour).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblPresentTool>(entity =>
            {
                entity.HasKey(e => e.PreToolId);

                entity.ToTable("tblPresentTool", "unitworkccs");

                entity.Property(e => e.PreToolId).HasColumnName("PreToolID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");
            });

            modelBuilder.Entity<TblProcess>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("tblProcess", "unitworkccs");

                entity.Property(e => e.ProcessId).HasColumnName("processId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessName)
                    .HasColumnName("processName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblProdAndonDisp>(entity =>
            {
                entity.HasKey(e => e.ProdDashboardId);

                entity.ToTable("tbl_ProdAndonDisp", "unitworkccs");

                entity.Property(e => e.ProdDashboardId).HasColumnName("ProdDashboardID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.TotalLoss).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TotalOperatingTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TotalSetup).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UtilPercent).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Woid).HasColumnName("WOID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblProdAndonDisp)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdAndonDisp_tblmachinedetails");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.TblProdAndonDisp)
                    .HasForeignKey(d => d.Woid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdAndonDisp_tblworkorderentry");
            });

            modelBuilder.Entity<TblProdManMachine>(entity =>
            {
                entity.HasKey(e => e.ProdManMachineId);

                entity.ToTable("tbl_ProdManMachine", "unitworkccs");

                entity.Property(e => e.ProdManMachineId).HasColumnName("ProdManMachineID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.PerformancePerCent).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.QualityPercent).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TotalLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalMinorLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalOperatingTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalPowerLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalSetup).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalSetupMinorLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UtilPercent).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Woid).HasColumnName("WOID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblProdManMachine)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdManMachine_tblmachinedetails");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.TblProdManMachine)
                    .HasForeignKey(d => d.Woid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdManMachine_tblworkorderentry");
            });

            modelBuilder.Entity<TblProdOrderLosses>(entity =>
            {
                entity.HasKey(e => e.ProdOrderlossId);

                entity.ToTable("tbl_ProdOrderLosses", "unitworkccs");

                entity.Property(e => e.ProdOrderlossId).HasColumnName("ProdOrderlossID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.LossCodeL1id).HasColumnName("LossCodeL1ID");

                entity.Property(e => e.LossCodeL2id).HasColumnName("LossCodeL2ID");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Woid).HasColumnName("WOID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblProdOrderLosses)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdOrderLosses_tblmachinedetails");
            });

            modelBuilder.Entity<TblProdPlanMasters>(entity =>
            {
                entity.HasKey(e => e.ProdPlanId);

                entity.ToTable("tblProdPlanMasters", "unitworkccs");

                entity.Property(e => e.ProdPlanId).HasColumnName("ProdPlanID");

                entity.Property(e => e.Fgcode)
                    .IsRequired()
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderNo)
                    .IsRequired()
                    .HasColumnName("Prod_Order_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtyUnit)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenter)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("tblProduct", "unitworkccs");

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblProductWiseDefectCode>(entity =>
            {
                entity.HasKey(e => e.ProductWiseDefectCodeId);

                entity.ToTable("tblProductWiseDefectCode", "unitworkccs");

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

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(500);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Trim).HasColumnName("trim");
            });

            modelBuilder.Entity<TblRaisedTicket>(entity =>
            {
                entity.HasKey(e => e.TicketId)
                    .HasName("PK_tblTicketMaster");

                entity.ToTable("tblRaisedTicket", "unitworkccs");

                entity.Property(e => e.TicketId).HasColumnName("ticketId");

                entity.Property(e => e.AlarmId).HasColumnName("alarmId");

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

                entity.Property(e => e.TicketClosedDate)
                    .HasColumnName("ticketClosedDate")
                    .HasColumnType("datetime");

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

                entity.ToTable("tblRejectionDetails", "unitworkccs");

                entity.Property(e => e.RejectionId).HasColumnName("rejectionId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.DefectQty).HasColumnName("defectQty");

                entity.Property(e => e.DmcCodeStatus)
                    .HasColumnName("dmcCodeStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsDirLineInsp).HasColumnName("isDirLineInsp");

                entity.Property(e => e.IsDirQualityHead).HasColumnName("isDirQualityHead");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.QrCodeNo)
                    .HasColumnName("qrCodeNo")
                    .HasMaxLength(500);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblReportmaster>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PK_tbl_reportmaster_ReportID");

                entity.ToTable("tbl_reportmaster", "unitworkccs");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ReportDescription).HasMaxLength(100);

                entity.Property(e => e.ReportDispName).HasMaxLength(50);

                entity.Property(e => e.ReportName).HasMaxLength(100);

                entity.Property(e => e.ReportTemplatePath).HasMaxLength(100);
            });

            modelBuilder.Entity<TblReworkDetails>(entity =>
            {
                entity.HasKey(e => e.ReworkId);

                entity.ToTable("tblReworkDetails", "unitworkccs");

                entity.Property(e => e.ReworkId).HasColumnName("reworkId");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectCodeId).HasColumnName("defectCodeId");

                entity.Property(e => e.DefectQty).HasColumnName("defectQty");

                entity.Property(e => e.DmcCodeStatus)
                    .HasColumnName("dmcCodeStatus")
                    .HasMaxLength(50);

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsDirLineInsp).HasColumnName("isDirLineInsp");

                entity.Property(e => e.IsDirQualityHead).HasColumnName("isDirQualityHead");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

                entity.Property(e => e.QrCodeNo)
                    .HasColumnName("qrCodeNo")
                    .HasMaxLength(500);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblReworkReasons>(entity =>
            {
                entity.HasKey(e => e.ReWorkId)
                    .HasName("PK_unitworkccs.tblReworkDetails");

                entity.ToTable("tblReworkReasons", "unitworkccs");

                entity.Property(e => e.ReWorkId).HasColumnName("ReWorkID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ReworkName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRoutingNo>(entity =>
            {
                entity.ToTable("tblRoutingNo", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CellId).HasColumnName("cellId");

                entity.Property(e => e.ChildFgPartId).HasColumnName("childFgPartId");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.FgPartId).HasColumnName("fgPartId");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperationNo).HasColumnName("operationNo");

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.ProducedItemDescription)
                    .HasColumnName("producedItemDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.RoutingNo)
                    .HasColumnName("routingNo")
                    .HasMaxLength(50);

                entity.Property(e => e.SubCellId).HasColumnName("subCellId");
            });

            modelBuilder.Entity<TblSapinput>(entity =>
            {
                entity.HasKey(e => e.SapInputId);

                entity.ToTable("tblSAPInput", "unitworkccs");

                entity.Property(e => e.SapInputId).HasColumnName("SapInputID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PathLocation)
                    .IsRequired()
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TblSar>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("tblSar", "unitworkccs");

                entity.Property(e => e.Sid).ValueGeneratedNever();

                entity.Property(e => e.BallunNo)
                    .HasColumnName("ballunNo")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Freq)
                    .HasColumnName("freq")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineID");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasMaxLength(50);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdAndLocation)
                    .HasColumnName("prodAndLocation")
                    .HasMaxLength(500);

                entity.Property(e => e.ProdQuality)
                    .HasColumnName("prodQuality")
                    .HasMaxLength(50);

                entity.Property(e => e.RejarctionQuality)
                    .HasColumnName("rejarctionQuality")
                    .HasMaxLength(50);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialChar)
                    .HasColumnName("specialChar")
                    .HasMaxLength(50);

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblSarminmax>(entity =>
            {
                entity.HasKey(e => e.Smid);

                entity.ToTable("tblSarminmax", "unitworkccs");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Sarmax)
                    .HasColumnName("sarmax")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Sarmin).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Sarstatus)
                    .HasColumnName("sarstatus")
                    .HasMaxLength(50);

                entity.Property(e => e.Sid).HasColumnName("sid");
            });

            modelBuilder.Entity<TblSaveNcprogVer>(entity =>
            {
                entity.HasKey(e => e.NcprogVerId);

                entity.ToTable("tbl_SaveNCProgVer", "unitworkccs");

                entity.Property(e => e.NcprogVerId).HasColumnName("NCProgVerID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ProgramData).HasColumnType("ntext");

                entity.Property(e => e.ProgramNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblServodetails>(entity =>
            {
                entity.HasKey(e => e.Sdid);

                entity.ToTable("tbl_servodetails", "unitworkccs");

                entity.Property(e => e.Sdid).HasColumnName("SDID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.LoadCurrent).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.LoadCurrentAmp).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ServoAxis)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ServoLoadMeter).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSetupMaint>(entity =>
            {
                entity.HasKey(e => e.SetMainId);

                entity.ToTable("tblSetupMaint", "unitworkccs");

                entity.Property(e => e.SetMainId).HasColumnName("SetMainID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.ServerSetMainId).HasColumnName("ServerSetMainID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.TblSetupMaint)
                    .HasForeignKey(d => d.LossCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSetupMaint_tbllossescodes");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblSetupMaint)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSetupMaint_tblmachinedetails");
            });

            modelBuilder.Entity<TblSmsDetails>(entity =>
            {
                entity.HasKey(e => e.SmsId)
                    .HasName("PK_Table_1");

                entity.ToTable("tblSmsDetails", "unitworkccs");

                entity.Property(e => e.SmsId).HasColumnName("smsId");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(50);

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdleResponseId)
                    .HasColumnName("idleResponseId")
                    .HasMaxLength(500);

                entity.Property(e => e.IdleSms).HasColumnName("idleSms");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseId)
                    .HasColumnName("responseId")
                    .HasMaxLength(500);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.TicketId).HasColumnName("ticketId");
            });

            modelBuilder.Entity<TblSourceMaster>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("tblSourceMaster", "unitworkccs");

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

                entity.ToTable("tblStatusMaster", "unitworkccs");

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

            modelBuilder.Entity<TblStdToolLife>(entity =>
            {
                entity.HasKey(e => e.StdToolLifeId);

                entity.ToTable("tblStdToolLife", "unitworkccs");

                entity.Property(e => e.StdToolLifeId).ValueGeneratedNever();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Ctcode)
                    .IsRequired()
                    .HasColumnName("CTCode")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fgcode)
                    .IsRequired()
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(255);

                entity.Property(e => e.ToolNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblStoppage>(entity =>
            {
                entity.HasKey(e => e.StoppagesId);

                entity.ToTable("tblStoppage", "unitworkccs");

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

                entity.ToTable("tblSubCellFinalMaster", "unitworkccs");

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

                entity.ToTable("tblSystemConfig", "unitworkccs");

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

                entity.ToTable("tblTicketRaisedDet", "unitworkccs");

                entity.Property(e => e.TicketRaisedDetId).HasColumnName("ticketRaisedDetId");

                entity.Property(e => e.CommentsByOperator)
                    .HasColumnName("commentsByOperator")
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.IfOperatorAccepts).HasColumnName("ifOperatorAccepts");

                entity.Property(e => e.IfSupportTeamOpen).HasColumnName("ifSupportTeamOpen");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsStatus).HasColumnName("isStatus");

                entity.Property(e => e.MntAcceptReason)
                    .HasColumnName("mntAcceptReason")
                    .HasMaxLength(500);

                entity.Property(e => e.MntRejectReason)
                    .HasColumnName("mntRejectReason")
                    .HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpAcceptReson)
                    .HasColumnName("opAcceptReson")
                    .HasMaxLength(500);

                entity.Property(e => e.OpRejectReason)
                    .HasColumnName("opRejectReason")
                    .HasMaxLength(500);

                entity.Property(e => e.OperatorAcceptRejectDate)
                    .HasColumnName("operatorAcceptRejectDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("operatorId");

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

            modelBuilder.Entity<TblTicketReason>(entity =>
            {
                entity.HasKey(e => e.TktReasonId);

                entity.ToTable("tblTicketReason", "unitworkccs");

                entity.Property(e => e.TktReasonId).HasColumnName("tktReasonId");

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

                entity.Property(e => e.ReasonDesc)
                    .HasColumnName("reasonDesc")
                    .HasMaxLength(500);

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblToolAndSocketDetails>(entity =>
            {
                entity.HasKey(e => e.SocketId);

                entity.ToTable("tblToolAndSocketDetails", "unitworkccs");

                entity.Property(e => e.SocketId).HasColumnName("socketId");

                entity.Property(e => e.ActaulToolLife).HasColumnName("actaulToolLife");

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

                entity.Property(e => e.Qrcode)
                    .HasColumnName("qrcode")
                    .HasMaxLength(500);

                entity.Property(e => e.SocketNo)
                    .HasColumnName("socketNo")
                    .HasMaxLength(500);

                entity.Property(e => e.StandardToolLife).HasColumnName("standardToolLife");

                entity.Property(e => e.ToolInsertedDateTime)
                    .HasColumnName("toolInsertedDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ToolNumber)
                    .HasColumnName("toolNumber")
                    .HasMaxLength(500);

                entity.Property(e => e.ToolRemovedDateTime)
                    .HasColumnName("toolRemovedDateTime")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblToolBrDnReasonLvl1>(entity =>
            {
                entity.ToTable("tblToolBrDnReasonLvl1", "unitworkccs");

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

                entity.ToTable("tblToolBrkDnReason", "unitworkccs");

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

            modelBuilder.Entity<TblToolCounter>(entity =>
            {
                entity.HasKey(e => e.ToolCounterId);

                entity.ToTable("tblToolCounter", "unitworkccs");

                entity.Property(e => e.ToolCounterId).HasColumnName("ToolCounterID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ToolNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblTools>(entity =>
            {
                entity.HasKey(e => e.ToolId);

                entity.ToTable("tblTools", "unitworkccs");

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

            modelBuilder.Entity<TblTrialPartCount>(entity =>
            {
                entity.HasKey(e => e.TrialPartId);

                entity.ToTable("tblTrialPartCount", "unitworkccs");

                entity.Property(e => e.TrialPartId).HasColumnName("trialPartId");

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

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.TrialPartCount).HasColumnName("trialPartCount");
            });

            modelBuilder.Entity<TblUtilReport>(entity =>
            {
                entity.HasKey(e => e.UtilReportId);

                entity.ToTable("tbl_UtilReport", "unitworkccs");

                entity.Property(e => e.UtilReportId).HasColumnName("UtilReportID");

                entity.Property(e => e.Bdtime)
                    .HasColumnName("BDTime")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.LossTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MinorLossTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.OperatingTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.PowerOffTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SetupMinorTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.SetupTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.TotalTime).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.UtilPercent).HasColumnType("decimal(6, 2)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblUtilReport)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_UtilReport_tblmachinedetails");
            });

            modelBuilder.Entity<TblWorkCenter>(entity =>
            {
                entity.HasKey(e => e.WorkCenterId);

                entity.ToTable("tblWorkCenter", "unitworkccs");

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
                    .HasName("PK_tblactivitylog_TrackID");

                entity.ToTable("tblactivitylog", "unitworkccs");

                entity.Property(e => e.TrackId).HasColumnName("TrackID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ClientSystemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompleteModificationDetails)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Controller)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OpDate).HasColumnType("date");

                entity.Property(e => e.OpDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.OpTime).IsRequired();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<TblappPaths>(entity =>
            {
                entity.HasKey(e => e.AppPathsId)
                    .HasName("PK_tblapp_paths_AppPathsID");

                entity.ToTable("tblapp_paths", "unitworkccs");

                entity.Property(e => e.AppPathsId).HasColumnName("AppPathsID");

                entity.Property(e => e.AppName).HasMaxLength(145);

                entity.Property(e => e.AppPath).HasMaxLength(245);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblatccounter>(entity =>
            {
                entity.HasKey(e => e.Atcid)
                    .HasName("PK_tblatccounter_ATCID");

                entity.ToTable("tblatccounter", "unitworkccs");

                entity.HasIndex(e => e.Atcid)
                    .HasName("tblatccounter$ATCID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Atcid).HasColumnName("ATCID");

                entity.Property(e => e.CycleEndTime).HasColumnType("datetime");

                entity.Property(e => e.CycleStartTime).HasColumnType("datetime");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.PartCount).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Tblbottelneck>(entity =>
            {
                entity.HasKey(e => e.Bid)
                    .HasName("PK__tblbotte__C6D111C9FA323F1E");

                entity.ToTable("tblbottelneck", "unitworkccs");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Cpid).HasColumnName("cpid");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId).HasColumnName("plantID");

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblbottelneck)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CellID");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.Tblbottelneck)
                    .HasForeignKey(d => d.Cpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cpid");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblbottelneck)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblbottelneck)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PlantID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblbottelneck)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ShopID");
            });

            modelBuilder.Entity<Tblbreakdown>(entity =>
            {
                entity.HasKey(e => e.BreakdownId)
                    .HasName("PK_tblbreakdown_BreakdownID");

                entity.ToTable("tblbreakdown", "unitworkccs");

                entity.Property(e => e.BreakdownId).HasColumnName("BreakdownID");

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode).HasMaxLength(45);

                entity.Property(e => e.MessageDesc).HasMaxLength(45);

                entity.Property(e => e.Shift).HasMaxLength(45);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.BreakDownCodeNavigation)
                    .WithMany(p => p.Tblbreakdown)
                    .HasForeignKey(d => d.BreakDownCode)
                    .HasConstraintName("tblbreakdown$BreakdowncodeId");
            });

            modelBuilder.Entity<Tblcell>(entity =>
            {
                entity.HasKey(e => e.CellId)
                    .HasName("PK_tblcell_CellID");

                entity.ToTable("tblcell", "unitworkccs");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CellDesc)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.CelldisplayName).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblcell)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblcell$PlantsId");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblcell)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblcell$ShopId");
            });

            modelBuilder.Entity<Tblcellpart>(entity =>
            {
                entity.HasKey(e => e.CpId)
                    .HasName("PK__tblcellp__2C1266AEAF824736");

                entity.ToTable("tblcellpart", "unitworkccs");

                entity.Property(e => e.CpId).HasColumnName("cpID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblcellpart)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CellID_FK");
            });

            modelBuilder.Entity<Tblcustomer>(entity =>
            {
                entity.HasKey(e => e.Cid)
                    .HasName("PK_tblcustomer_CID");

                entity.ToTable("tblcustomer", "unitworkccs");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AddressLine2).HasMaxLength(50);

                entity.Property(e => e.Cpdepartment)
                    .HasColumnName("CPDepartment")
                    .HasMaxLength(20);

                entity.Property(e => e.Cpdesignation)
                    .HasColumnName("CPDesignation")
                    .HasMaxLength(30);

                entity.Property(e => e.CpemailId)
                    .HasColumnName("CPEmailID")
                    .HasMaxLength(50);

                entity.Property(e => e.CpmobileNo).HasColumnName("CPMobileNO");

                entity.Property(e => e.Cpname)
                    .HasColumnName("CPName")
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerShortName).HasMaxLength(20);

                entity.Property(e => e.EmailId1)
                    .IsRequired()
                    .HasColumnName("EmailID1")
                    .HasMaxLength(30);

                entity.Property(e => e.EmailId2)
                    .HasColumnName("EmailID2")
                    .HasMaxLength(30);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Logo).IsRequired();

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Website).HasMaxLength(30);
            });

            modelBuilder.Entity<Tbldailyprodstatus>(entity =>
            {
                entity.ToTable("tbldailyprodstatus", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorCode).HasMaxLength(45);

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Status).HasMaxLength(45);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbldailyprodstatus)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("tbldailyprodstatus$MachineID1");
            });

            modelBuilder.Entity<Tbldaytiming>(entity =>
            {
                entity.ToTable("tbldaytiming", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tbldowntimecategory>(entity =>
            {
                entity.HasKey(e => e.DtcId)
                    .HasName("PK_tbldowntimecategory_DTC_ID");

                entity.ToTable("tbldowntimecategory", "unitworkccs");

                entity.Property(e => e.DtcId).HasColumnName("DTC_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Dtcategory)
                    .IsRequired()
                    .HasColumnName("DTCategory")
                    .HasMaxLength(50);

                entity.Property(e => e.DtcategoryDesc)
                    .IsRequired()
                    .HasColumnName("DTCategoryDesc")
                    .HasMaxLength(60);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tbldowntimedetails>(entity =>
            {
                entity.HasKey(e => e.DtId)
                    .HasName("PK_tbldowntimedetails_DT_ID");

                entity.ToTable("tbldowntimedetails", "unitworkccs");

                entity.Property(e => e.DtId).HasColumnName("DT_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DtcategoryId).HasColumnName("DTCategoryID");

                entity.Property(e => e.Dtdesc)
                    .IsRequired()
                    .HasColumnName("DTDesc")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtreason)
                    .IsRequired()
                    .HasColumnName("DTReason")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Dtcategory)
                    .WithMany(p => p.Tbldowntimedetails)
                    .HasForeignKey(d => d.DtcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbldowntimedetails$tbldowntimedetails_ibfk_1");
            });

            modelBuilder.Entity<Tblemailescalation>(entity =>
            {
                entity.HasKey(e => e.EmailEscalationId)
                    .HasName("PK_tblemailescalation_EMailEscalationID");

                entity.ToTable("tblemailescalation", "unitworkccs");

                entity.HasIndex(e => e.EmailEscalationId)
                    .HasName("tblemailescalation$EMailEscalationID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.EmailEscalationId).HasColumnName("EMailEscalationID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.EmailEscalationName)
                    .HasColumnName("EMailEscalationName")
                    .HasMaxLength(200);

                entity.Property(e => e.MessageType).HasMaxLength(45);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.WorkCenterId).HasColumnName("WorkCenterID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("tblemailescalation$CellIDFK");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblemailescalation$PlantIDFK");

                entity.HasOne(d => d.ReasonLevel1Navigation)
                    .WithMany(p => p.TblemailescalationReasonLevel1Navigation)
                    .HasForeignKey(d => d.ReasonLevel1)
                    .HasConstraintName("tblemailescalation$ReasonLevel1FK");

                entity.HasOne(d => d.ReasonLevel2Navigation)
                    .WithMany(p => p.TblemailescalationReasonLevel2Navigation)
                    .HasForeignKey(d => d.ReasonLevel2)
                    .HasConstraintName("tblemailescalation$ReasonLevel2FK");

                entity.HasOne(d => d.ReasonLevel3Navigation)
                    .WithMany(p => p.TblemailescalationReasonLevel3Navigation)
                    .HasForeignKey(d => d.ReasonLevel3)
                    .HasConstraintName("tblemailescalation$ReasonLevel3FK");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblemailescalation$ShopIDFK");

                entity.HasOne(d => d.WorkCenter)
                    .WithMany(p => p.Tblemailescalation)
                    .HasForeignKey(d => d.WorkCenterId)
                    .HasConstraintName("tblemailescalation$WCIDFK");
            });

            modelBuilder.Entity<Tblendcodes>(entity =>
            {
                entity.HasKey(e => e.EndCodeId)
                    .HasName("PK_tblendcodes_EndCodeID");

                entity.ToTable("tblendcodes", "unitworkccs");

                entity.Property(e => e.EndCodeId).HasColumnName("EndCodeID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndCode).HasMaxLength(11);

                entity.Property(e => e.EndCodeLdesc)
                    .HasColumnName("EndCodeLDesc")
                    .HasMaxLength(200);

                entity.Property(e => e.EndCodeSdesc)
                    .HasColumnName("EndCodeSDesc")
                    .HasMaxLength(45);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblescalationlog>(entity =>
            {
                entity.HasKey(e => e.Elid)
                    .HasName("PK_tblescalationlog_ELID");

                entity.ToTable("tblescalationlog", "unitworkccs");

                entity.HasIndex(e => e.Elid)
                    .HasName("tblescalationlog$ELID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Elid).HasColumnName("ELID");

                entity.Property(e => e.CorrectedDate).HasMaxLength(20);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EscalationId).HasColumnName("EscalationID");

                entity.Property(e => e.EscalationSentOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wcid).HasColumnName("WCID");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.Tblescalationlog)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("tblescalationlog$EscalationLossCodeID");
            });

            modelBuilder.Entity<Tblgenericworkcodes>(entity =>
            {
                entity.HasKey(e => e.GenericWorkId)
                    .HasName("PK_tblgenericworkcodes_GenericWorkID");

                entity.ToTable("tblgenericworkcodes", "unitworkccs");

                entity.Property(e => e.GenericWorkId).HasColumnName("GenericWorkID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.GenericWorkCode).HasMaxLength(50);

                entity.Property(e => e.GenericWorkDesc).HasMaxLength(45);

                entity.Property(e => e.GwcodesLevel).HasColumnName("GWCodesLevel");

                entity.Property(e => e.GwcodesLevel1Id).HasColumnName("GWCodesLevel1ID");

                entity.Property(e => e.GwcodesLevel2Id).HasColumnName("GWCodesLevel2ID");

                entity.Property(e => e.MessageType).HasMaxLength(45);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblgenericworkentry>(entity =>
            {
                entity.HasKey(e => e.GwentryId)
                    .HasName("PK_tblgenericworkentry_GWEntryID");

                entity.ToTable("tblgenericworkentry", "unitworkccs");

                entity.Property(e => e.GwentryId).HasColumnName("GWEntryID");

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Gwcode)
                    .HasColumnName("GWCode")
                    .HasMaxLength(45);

                entity.Property(e => e.GwcodeDesc)
                    .HasColumnName("GWCodeDesc")
                    .HasMaxLength(45);

                entity.Property(e => e.GwcodeId).HasColumnName("GWCodeID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Shift).HasMaxLength(45);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.GwcodeNavigation)
                    .WithMany(p => p.Tblgenericworkentry)
                    .HasForeignKey(d => d.GwcodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblgenericworkentry$GenericWorkID");
            });

            modelBuilder.Entity<Tblhistpms>(entity =>
            {
                entity.ToTable("tblhistpms", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Pmchecklistname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pmsid).HasColumnName("pmsid");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Workdone)
                    .HasColumnName("workdone")
                    .HasDefaultValueSql("('0')");
            });

            modelBuilder.Entity<Tblholdcodes>(entity =>
            {
                entity.HasKey(e => e.HoldCodeId)
                    .HasName("PK_tblholdcodes_HoldCodeID");

                entity.ToTable("tblholdcodes", "unitworkccs");

                entity.Property(e => e.HoldCodeId).HasColumnName("HoldCodeID");

                entity.Property(e => e.ContributeTo).HasMaxLength(10);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.HoldCode).HasMaxLength(100);

                entity.Property(e => e.HoldCodeDesc).HasMaxLength(100);

                entity.Property(e => e.HoldCodesLevel1Id).HasColumnName("HoldCodesLevel1ID");

                entity.Property(e => e.HoldCodesLevel2Id).HasColumnName("HoldCodesLevel2ID");

                entity.Property(e => e.MessageType).HasMaxLength(45);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblholidays>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK_tblholidays_HolidayId");

                entity.ToTable("tblholidays", "unitworkccs");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.HolidayDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Reason).HasMaxLength(45);
            });

            modelBuilder.Entity<Tbllivedailyprodstatus>(entity =>
            {
                entity.ToTable("tbllivedailyprodstatus", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColorCode).HasMaxLength(45);

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Status).HasMaxLength(45);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivedailyprodstatus)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("tbllivedailyprodstatus$MachineIDLDPS");
            });

            modelBuilder.Entity<Tbllivemode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK__tbllivem__D83F75E4DC92BA1A");

                entity.ToTable("tbllivemode", "unitworkccs");

                entity.HasIndex(e => new { e.ModeId, e.MachineId, e.MacMode, e.CorrectedDate, e.StartTime, e.EndTime, e.ColorCode, e.IsCompleted, e.DurationInSec, e.LossCodeId, e.BreakdownId, e.ModeType, e.ModeTypeEnd, e.StartIdle, e.TotalPartsCount })
                    .HasName("LivemodeIndexer")
                    .IsUnique();

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.BreakDownCodeId).HasColumnName("breakDownCodeID");

                entity.Property(e => e.BreakdownId).HasColumnName("BreakdownID");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CuttingDuration).HasDefaultValueSql("('0')");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsInserted).HasDefaultValueSql("('0')");

                entity.Property(e => e.LossCodeEnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeEnteredTime).HasColumnType("datetime2(3)");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.MacMode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeEnd).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.StartIdle).HasDefaultValueSql("('0')");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.TotalPartsCount).HasDefaultValueSql("('0')");

                entity.HasOne(d => d.Breakdown)
                    .WithMany(p => p.Tbllivemode)
                    .HasForeignKey(d => d.BreakdownId)
                    .HasConstraintName("FK_tblmode_tblbreakdown1");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.Tbllivemode)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("FK_tblmode_tbllossescodes1");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbllivemode)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblmode_tblmachinedetails1");
            });

            modelBuilder.Entity<Tbllossescodes>(entity =>
            {
                entity.HasKey(e => e.LossCodeId)
                    .HasName("PK_tbllossescodes_LossCodeID");

                entity.ToTable("tbllossescodes", "unitworkccs");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.ContributeTo).HasMaxLength(30);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.LossCode).HasMaxLength(50);

                entity.Property(e => e.LossCodeDesc).HasMaxLength(45);

                entity.Property(e => e.LossCodesLevel1Id).HasColumnName("LossCodesLevel1ID");

                entity.Property(e => e.LossCodesLevel2Id).HasColumnName("LossCodesLevel2ID");

                entity.Property(e => e.MessageType).HasMaxLength(45);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.TargetPercent)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.01))");
            });

            modelBuilder.Entity<Tbllossofentry>(entity =>
            {
                entity.HasKey(e => e.LossId)
                    .HasName("PK_tbllossofentry_LossID");

                entity.ToTable("tbllossofentry", "unitworkccs");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.EntryTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MessageCode).HasMaxLength(45);

                entity.Property(e => e.MessageCodeId).HasColumnName("MessageCodeID");

                entity.Property(e => e.MessageDesc).HasMaxLength(45);

                entity.Property(e => e.Shift).HasMaxLength(45);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.Tbllossofentry)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbllossofentry$LossCodeID");
            });

            modelBuilder.Entity<Tblmachineaxisdetails>(entity =>
            {
                entity.HasKey(e => e.MacAxisId)
                    .HasName("PK_tblmachineaxisdetails_MacAxisID");

                entity.ToTable("tblmachineaxisdetails", "unitworkccs");

                entity.HasIndex(e => e.MacAxisId)
                    .HasName("tblmachineaxisdetails$MacAxisID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.MacAxisId).HasColumnName("MacAxisID");

                entity.Property(e => e.AxisName).HasMaxLength(150);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblmachinecategory>(entity =>
            {
                entity.ToTable("tblmachinecategory", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblmachinedetails>(entity =>
            {
                entity.HasKey(e => e.MachineId)
                    .HasName("PK_tblmachinedetails_MachineID");

                entity.ToTable("tblmachinedetails", "unitworkccs");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.ControllerType).HasMaxLength(50);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime");

                entity.Property(e => e.EnableToolLife).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertedOn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IotgatewayIp)
                    .HasColumnName("IOTGatewayIP")
                    .HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDlversion).HasColumnName("IsDLVersion");

                entity.Property(e => e.IsNormalWc)
                    .HasColumnName("IsNormalWC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPcb).HasColumnName("IsPCB");

                entity.Property(e => e.IsWimerasys).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoggerType).HasMaxLength(500);

                entity.Property(e => e.LossFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.MacConnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MacType).HasMaxLength(45);

                entity.Property(e => e.MachineDescription).HasMaxLength(150);

                entity.Property(e => e.MachineDisplayName).HasMaxLength(100);

                entity.Property(e => e.MachineMake).HasMaxLength(50);

                entity.Property(e => e.MachineModel).HasMaxLength(50);

                entity.Property(e => e.MachineModelType).HasDefaultValueSql("((1))");

                entity.Property(e => e.MachineName).HasMaxLength(45);

                entity.Property(e => e.MachinePockets).HasColumnName("machinePockets");

                entity.Property(e => e.ManualWcid).HasColumnName("ManualWCID");

                entity.Property(e => e.ModelType).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.NoOfPartsPerCycle).HasColumnName("noOfPartsPerCycle");

                entity.Property(e => e.NodeId).HasColumnName("NodeID");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ProgDbit)
                    .HasColumnName("ProgDBit")
                    .HasMaxLength(10);

                entity.Property(e => e.ProgramNum).HasMaxLength(10);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.ShopNo).HasMaxLength(200);

                entity.Property(e => e.SpindleAxis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TabIpaddress)
                    .HasColumnName("TabIPAddress")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblmachinedetails)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("tblmachinedetails$CellIDtblmachinedetails");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblmachinedetails)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblmachinedetails$PlantIDtblmachinedetails");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblmachinedetails)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblmachinedetails$ShopIDtblmachinedetails");
            });

            modelBuilder.Entity<Tblmailids>(entity =>
            {
                entity.HasKey(e => e.MailIdsId)
                    .HasName("PK_tblmailids_MailIDsID");

                entity.ToTable("tblmailids", "unitworkccs");

                entity.HasIndex(e => e.MailIdsId)
                    .HasName("tblmailids$MailIDsID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.MailIdsId).HasColumnName("MailIDsID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(100);

                entity.Property(e => e.EmployeeCode).HasMaxLength(45);

                entity.Property(e => e.EmployeeContactNum).HasMaxLength(15);

                entity.Property(e => e.EmployeeDesignation).HasMaxLength(45);

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<TblmasterpartsStSw>(entity =>
            {
                entity.HasKey(e => e.Partsstswid)
                    .HasName("PK_tblmasterparts_st_sw_PARTSSTSWID");

                entity.ToTable("tblmasterparts_st_sw", "unitworkccs");

                entity.Property(e => e.Partsstswid).HasColumnName("PARTSSTSWID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.InputWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InputWeightUnit).HasMaxLength(10);

                entity.Property(e => e.MaterialRemovedQty).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaterialRemovedQtyUnit).HasMaxLength(10);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.OpNo).HasMaxLength(45);

                entity.Property(e => e.OutputWeight).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.OutputWeightUnit).HasMaxLength(10);

                entity.Property(e => e.PartNo).HasMaxLength(45);

                entity.Property(e => e.StdChangeoverTime).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StdChangeoverTimeUnit).HasMaxLength(10);

                entity.Property(e => e.StdCuttingTime).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StdCuttingTimeUnit).HasMaxLength(10);

                entity.Property(e => e.StdSetupTime).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StdSetupTimeUnit).HasMaxLength(10);
            });

            modelBuilder.Entity<Tblmimics>(entity =>
            {
                entity.HasKey(e => e.Mid)
                    .HasName("PK_tblmimics_mid");

                entity.ToTable("tblmimics", "unitworkccs");

                entity.Property(e => e.Mid).HasColumnName("mid");

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.IsSync).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.Shift).HasMaxLength(45);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblmimics)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblmimics$MachineID");
            });

            modelBuilder.Entity<Tblmode>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK_tblmode_ModeID");

                entity.ToTable("tblmode", "unitworkccs");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.BreakdownId).HasColumnName("BreakdownID");

                entity.Property(e => e.ColorCode).HasMaxLength(45);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.DurationInSec).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.LossCodeEnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeEnteredTime).HasColumnType("datetime");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.MacMode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModeType).HasMaxLength(20);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Breakdown)
                    .WithMany(p => p.TblmodeBreakdown)
                    .HasForeignKey(d => d.BreakdownId)
                    .HasConstraintName("FK_tblmode_tblbreakdown");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.TblmodeLossCode)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("FK_tblmode_tbllossescodes");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblmode)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblmode_tblmachinedetails");
            });

            modelBuilder.Entity<Tblmodetemp>(entity =>
            {
                entity.HasKey(e => e.ModeId)
                    .HasName("PK_tblmodetemp_ModeID");

                entity.ToTable("tblmodetemp", "unitworkccs");

                entity.Property(e => e.ModeId).HasColumnName("ModeID");

                entity.Property(e => e.BreakdownId).HasColumnName("BreakdownID");

                entity.Property(e => e.ColorCode).HasMaxLength(45);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.DurationInSec).HasDefaultValueSql("((0))");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.LossCodeEnteredTime).HasColumnType("datetime");

                entity.Property(e => e.LossCodeId).HasColumnName("LossCodeID");

                entity.Property(e => e.MacMode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModeType).HasMaxLength(20);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.TabModeId).HasColumnName("TabModeID");

                entity.HasOne(d => d.Breakdown)
                    .WithMany(p => p.Tblmodetemp)
                    .HasForeignKey(d => d.BreakdownId)
                    .HasConstraintName("FK_tblmodetemp_tblbreakdown");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.Tblmodetemp)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("FK_tblmodetemp_tbllossescodes");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblmodetemp)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblmodetemp_tblmachinedetails");
            });

            modelBuilder.Entity<Tblmodulehelper>(entity =>
            {
                entity.ToTable("tblmodulehelper", "unitworkccs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsAdded)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(0x01)");

                entity.Property(e => e.IsAll)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(0x00)");

                entity.Property(e => e.IsEdited)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(0x01)");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(0x01)");

                entity.Property(e => e.IsReadonly)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(0x01)");

                entity.Property(e => e.IsRemoved)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(0x01)");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Tblmodulemaster>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_tblmodulemaster_ModuleID");

                entity.ToTable("tblmodulemaster", "unitworkccs");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EnableAdd).HasMaxLength(1);

                entity.Property(e => e.EnableDelete).HasMaxLength(1);

                entity.Property(e => e.EnableEdit).HasMaxLength(1);

                entity.Property(e => e.EnableReport).HasMaxLength(1);

                entity.Property(e => e.IsSuperAdmin).HasMaxLength(1);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Tblmodules>(entity =>
            {
                entity.HasKey(e => e.ModuleId)
                    .HasName("PK_tblmodules_ModuleId");

                entity.ToTable("tblmodules", "unitworkccs");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Module).HasMaxLength(50);

                entity.Property(e => e.ModuleDesc).HasMaxLength(100);

                entity.Property(e => e.ModuleDispName).HasMaxLength(50);
            });

            modelBuilder.Entity<Tblmultipleworkorder>(entity =>
            {
                entity.HasKey(e => e.Mwoid)
                    .HasName("PK_tblmultipleworkorder_MWOID");

                entity.ToTable("tblmultipleworkorder", "unitworkccs");

                entity.Property(e => e.Mwoid).HasColumnName("MWOID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsEnabled).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MultipleWodesc)
                    .HasColumnName("MultipleWODesc")
                    .HasMaxLength(200);

                entity.Property(e => e.MultipleWoname)
                    .IsRequired()
                    .HasColumnName("MultipleWOName")
                    .HasMaxLength(45);

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.Wcid).HasColumnName("WCID");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("tblmultipleworkorder$CellIDtblMWO");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblmultipleworkorder$PlantIDtblMWO");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblmultipleworkorder$ShopIdtblMWO");

                entity.HasOne(d => d.Wc)
                    .WithMany(p => p.Tblmultipleworkorder)
                    .HasForeignKey(d => d.Wcid)
                    .HasConstraintName("tblmultipleworkorder$WCIDtblMWO");
            });

            modelBuilder.Entity<Tbloeedashboardfinalvariables>(entity =>
            {
                entity.HasKey(e => e.OeedashboardId)
                    .HasName("PK_tbloeedashboardfinalvariables_OEEDashboardID");

                entity.ToTable("tbloeedashboardfinalvariables", "unitworkccs");

                entity.HasIndex(e => e.OeedashboardId)
                    .HasName("tbloeedashboardfinalvariables$OEEDashboardID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeedashboardId).HasColumnName("OEEDashboardID");

                entity.Property(e => e.Availability).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(65);

                entity.Property(e => e.IsOverallPlantWise).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOverallShopWise).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOverallWcwise)
                    .HasColumnName("IsOverallWCWise")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Loss1Name).HasMaxLength(45);

                entity.Property(e => e.Loss2Name).HasMaxLength(45);

                entity.Property(e => e.Loss3Name).HasMaxLength(45);

                entity.Property(e => e.Loss4Name).HasMaxLength(45);

                entity.Property(e => e.Loss5Name).HasMaxLength(45);

                entity.Property(e => e.Oee)
                    .HasColumnName("OEE")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Performance).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.Quality).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Wcid).HasColumnName("WCID");
            });

            modelBuilder.Entity<Tbloeedashboardvariables>(entity =>
            {
                entity.HasKey(e => e.OeevariablesId)
                    .HasName("PK_tbloeedashboardvariables_OEEVariablesID");

                entity.ToTable("tbloeedashboardvariables", "unitworkccs");

                entity.HasIndex(e => e.OeevariablesId)
                    .HasName("tbloeedashboardvariables$OEEVariablesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeevariablesId).HasColumnName("OEEVariablesID");

                entity.Property(e => e.Blue).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DownTimeBreakdown).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Green).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Loss1Name).HasMaxLength(45);

                entity.Property(e => e.Loss2Name).HasMaxLength(45);

                entity.Property(e => e.Loss3Name).HasMaxLength(45);

                entity.Property(e => e.Loss4Name).HasMaxLength(45);

                entity.Property(e => e.Loss5Name).HasMaxLength(45);

                entity.Property(e => e.MinorLosses).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ReWotime)
                    .HasColumnName("ReWOTime")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Roalossess)
                    .HasColumnName("ROALossess")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ScrapQtyTime).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.SettingTime).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("numeric(10, 2)");

                entity.Property(e => e.Wcid).HasColumnName("WCID");
            });

            modelBuilder.Entity<Tbloeedashboardvariablestoday>(entity =>
            {
                entity.HasKey(e => e.OeevariablesId)
                    .HasName("PK_tbloeedashboardvariablestoday_OEEVariablesID");

                entity.ToTable("tbloeedashboardvariablestoday", "unitworkccs");

                entity.HasIndex(e => e.OeevariablesId)
                    .HasName("tbloeedashboardvariablestoday$OEEVariablesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeevariablesId).HasColumnName("OEEVariablesID");

                entity.Property(e => e.Blue).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DownTimeBreakdown).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Green).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45);

                entity.Property(e => e.Loss1Name).HasMaxLength(45);

                entity.Property(e => e.Loss2Name).HasMaxLength(45);

                entity.Property(e => e.Loss3Name).HasMaxLength(45);

                entity.Property(e => e.Loss4Name).HasMaxLength(45);

                entity.Property(e => e.Loss5Name).HasMaxLength(45);

                entity.Property(e => e.MinorLosses).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ReWotime)
                    .HasColumnName("ReWOTime")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Roalossess)
                    .HasColumnName("ROALossess")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ScrapQtyTime).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.SettingTime).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("numeric(6, 2)");

                entity.Property(e => e.Wcid).HasColumnName("WCID");
            });

            modelBuilder.Entity<Tblpartlearningreport>(entity =>
            {
                entity.HasKey(e => e.PlreportId)
                    .HasName("PK_tblworeport_PLReportID");

                entity.ToTable("tblpartlearningreport", "unitworkccs");

                entity.HasIndex(e => e.PlreportId)
                    .HasName("tblworeport$PLReportID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.PlreportId).HasColumnName("PLReportID");

                entity.Property(e => e.AvgCuttingTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Breakdown).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(45);

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.Idle).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MinorLoss).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.OpNo).HasMaxLength(6);

                entity.Property(e => e.PowerOff).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.StdCycleTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StdMinorLoss).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TotalNccuttingTime)
                    .HasColumnName("TotalNCCuttingTime")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalStdCycleTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalStdMinorLoss).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Woefficiency)
                    .HasColumnName("WOEfficiency")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkOrderNo).HasMaxLength(45);
            });

            modelBuilder.Entity<Tblparts>(entity =>
            {
                entity.HasKey(e => e.PartId)
                    .HasName("PK_tblparts_PartID");

                entity.ToTable("tblparts", "unitworkccs");

                entity.Property(e => e.PartId).HasColumnName("PartID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DrawingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fgcode)
                    .IsRequired()
                    .HasColumnName("FGCode")
                    .HasMaxLength(50);

                entity.Property(e => e.IdealCycleTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PartDesc).HasMaxLength(500);

                entity.Property(e => e.PartName).HasMaxLength(50);

                entity.Property(e => e.PartNo).HasMaxLength(200);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resourceId")
                    .HasMaxLength(500);

                entity.Property(e => e.RoutingId)
                    .HasColumnName("routingId")
                    .HasMaxLength(500);

                entity.Property(e => e.StdLoadUnloadTime)
                    .HasColumnName("Std_Load_UnloadTime")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StdLoadingTime).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.StdMinorLoss).HasMaxLength(50);

                entity.Property(e => e.StdSetupTime)
                    .HasColumnName("Std_SetupTime")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StdUnLoadingTime).HasColumnType("decimal(8, 3)");

                entity.Property(e => e.TargetPerHr).HasColumnName("targetPerHr");

                entity.Property(e => e.TargetPerShift).HasColumnName("targetPerShift");

                entity.HasOne(d => d.UnitDescNavigation)
                    .WithMany(p => p.Tblparts)
                    .HasForeignKey(d => d.UnitDesc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblparts_tblunit");
            });

            modelBuilder.Entity<Tblpartscountandcutting>(entity =>
            {
                entity.HasKey(e => e.Pcid)
                    .HasName("PK__tblparts__83E06A9F77B949E0");

                entity.ToTable("tblpartscountandcutting", "unitworkccs");

                entity.Property(e => e.Pcid).HasColumnName("pcid");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PartsPerCyscleEnteredTime).HasColumnType("datetime");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.WoPartCount).HasDefaultValueSql("((0))");

                entity.Property(e => e.WoTargetQty).HasColumnName("woTargetQty");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblpartscountandcutting)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MachineID_fk");
            });

            modelBuilder.Entity<Tblpir>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("tblpir", "unitworkccs");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.BallunNo)
                    .HasColumnName("ballunNo")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Freq)
                    .HasColumnName("freq")
                    .HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.MachineId).HasColumnName("machineId");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasMaxLength(50);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(50);

                entity.Property(e => e.ProdAndLocation)
                    .HasColumnName("prodAndLocation")
                    .HasMaxLength(500);

                entity.Property(e => e.ProdQuality).HasColumnName("prodQuality");

                entity.Property(e => e.RejarctionQuality).HasColumnName("rejarctionQuality");

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50);

                entity.Property(e => e.SpecialChar)
                    .HasColumnName("specialChar")
                    .HasMaxLength(50);

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Tblpirminmax>(entity =>
            {
                entity.HasKey(e => e.Pmid);

                entity.ToTable("tblpirminmax", "unitworkccs");

                entity.Property(e => e.Pmid).HasColumnName("pmid");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasColumnName("modifiedBy");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Pirmax)
                    .HasColumnName("pirmax")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Pirmin)
                    .HasColumnName("pirmin")
                    .HasColumnType("decimal(8, 3)");

                entity.Property(e => e.Pirstatus)
                    .HasColumnName("pirstatus")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tblplannedbreak>(entity =>
            {
                entity.HasKey(e => e.BreakId)
                    .HasName("PK_tblplannedbreak_BreakID");

                entity.ToTable("tblplannedbreak", "unitworkccs");

                entity.Property(e => e.BreakId).HasColumnName("BreakID");

                entity.Property(e => e.BreakReason).HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Tblplannedbreak)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("tblplannedbreak$shiftbreak");
            });

            modelBuilder.Entity<Tblplant>(entity =>
            {
                entity.HasKey(e => e.PlantId)
                    .HasName("PK_tblplant_PlantID");

                entity.ToTable("tblplant", "unitworkccs");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantCode).HasMaxLength(50);

                entity.Property(e => e.PlantDesc)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PlantDisplayName).HasMaxLength(150);

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Tblpmsdetails>(entity =>
            {
                entity.HasKey(e => e.Pmsid)
                    .HasName("PK__tblpmsde__1FBBE5221EDF177A");

                entity.ToTable("tblpmsdetails", "unitworkccs");

                entity.Property(e => e.Pmsid).HasColumnName("pmsid");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.IsSubmitted).HasDefaultValueSql("('0')");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PmendDate)
                    .HasColumnName("PMEndDate")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PmstartDate)
                    .HasColumnName("PMStartDate")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tblpriorityalarms>(entity =>
            {
                entity.HasKey(e => e.AlarmId)
                    .HasName("PK_tblpriorityalarms_AlarmID");

                entity.ToTable("tblpriorityalarms", "unitworkccs");

                entity.Property(e => e.AlarmId).HasColumnName("AlarmID");

                entity.Property(e => e.AlarmDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AlarmGroup).HasMaxLength(50);

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IsMailSent)
                    .HasColumnName("isMailSent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");
            });

            modelBuilder.Entity<Tblprogramtransferhistory>(entity =>
            {
                entity.HasKey(e => e.Pthid)
                    .HasName("PK_tblprogramtransferhistory_PTHID");

                entity.ToTable("tblprogramtransferhistory", "unitworkccs");

                entity.Property(e => e.Pthid).HasColumnName("PTHID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ProgramName).HasMaxLength(150);

                entity.Property(e => e.ReturnTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.UploadedTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Tblrejectqty>(entity =>
            {
                entity.HasKey(e => e.Rqid)
                    .HasName("PK__tblrejec__E345435AD46C3154");

                entity.ToTable("tblrejectqty", "unitworkccs");

                entity.Property(e => e.Rqid).HasColumnName("RQID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("('0')");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.IsFinished)
                    .HasColumnName("isFinished")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.RejectQty).HasDefaultValueSql("('0')");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Woid).HasColumnName("WOID");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.Tblrejectqty)
                    .HasForeignKey(d => d.Rid)
                    .HasConstraintName("tblrejectqty_ibfk_1");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.Tblrejectqty)
                    .HasForeignKey(d => d.Woid)
                    .HasConstraintName("tblrejectqty_ibfk_2");
            });

            modelBuilder.Entity<Tblrejectreason>(entity =>
            {
                entity.HasKey(e => e.Rid)
                    .HasName("PK__tblrejec__CAFF4132EBA8C9D3");

                entity.ToTable("tblrejectreason", "unitworkccs");

                entity.Property(e => e.Rid).HasColumnName("RID");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("('1')");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("('1')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.RejectName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RejectNameDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblrejectreason)
                    .HasForeignKey(d => d.Cellid)
                    .HasConstraintName("tblrejectreason_ibfk_1");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblrejectreason)
                    .HasForeignKey(d => d.Machineid)
                    .HasConstraintName("tblrejectreason_ibfk_2");
            });

            modelBuilder.Entity<Tblreportholder>(entity =>
            {
                entity.HasKey(e => e.Rhid)
                    .HasName("PK_tblreportholder_RHID");

                entity.ToTable("tblreportholder", "unitworkccs");

                entity.Property(e => e.Rhid).HasColumnName("RHID");

                entity.Property(e => e.FromDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.Shift).HasMaxLength(45);

                entity.Property(e => e.ShopNo).HasMaxLength(100);

                entity.Property(e => e.ToDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.WorkCenter).HasMaxLength(100);
            });

            modelBuilder.Entity<Tblrolemodulelink>(entity =>
            {
                entity.HasKey(e => e.Mrmlid)
                    .HasName("PK_tblrolemodulelink_MRMLID");

                entity.ToTable("tblrolemodulelink", "unitworkccs");

                entity.Property(e => e.Mrmlid).HasColumnName("MRMLID");

                entity.Property(e => e.EnableAdd).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.EnableDelete).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.EnableEdit).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.EnableReadOnly).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.EnableReport).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsSuperAdmin).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("(0x00)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModuleId).HasColumnName("ModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.Tblrolemodulelink)
                    .HasForeignKey(d => d.InsertedBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tblrolemodulelink$InsertedBy_Id");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Tblrolemodulelink)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_tblrolemodulelink_tblmodules");

                entity.HasOne(d => d.ModuleNavigation)
                    .WithMany(p => p.Tblrolemodulelink)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_tblrolemodulelink_tblroles");
            });

            modelBuilder.Entity<Tblroles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_tblroles_Role_ID");

                entity.ToTable("tblroles", "unitworkccs");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.RoleDesc).HasMaxLength(45);

                entity.Property(e => e.RoleDisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<Tblsendermailid>(entity =>
            {
                entity.HasKey(e => e.SeId)
                    .HasName("PK_tblsendermailid_SE_ID");

                entity.ToTable("tblsendermailid", "unitworkccs");

                entity.Property(e => e.SeId).HasColumnName("SE_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PrimaryMailId)
                    .IsRequired()
                    .HasColumnName("PrimaryMailID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblshiftBreaks>(entity =>
            {
                entity.HasKey(e => e.BreakId)
                    .HasName("PK_tblshift_breaks_BreakID");

                entity.ToTable("tblshift_breaks", "unitworkccs");

                entity.Property(e => e.BreakId).HasColumnName("BreakID");

                entity.Property(e => e.BreakReason).HasMaxLength(45);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");
            });

            modelBuilder.Entity<TblshiftMstr>(entity =>
            {
                entity.HasKey(e => e.ShiftId)
                    .HasName("PK_tblshift_mstr_ShiftID");

                entity.ToTable("tblshift_mstr", "unitworkccs");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftName).HasMaxLength(45);
            });

            modelBuilder.Entity<Tblshiftdetails>(entity =>
            {
                entity.HasKey(e => e.ShiftDetailsId)
                    .HasName("PK_tblshiftdetails_ShiftDetailsID");

                entity.ToTable("tblshiftdetails", "unitworkccs");

                entity.Property(e => e.ShiftDetailsId).HasColumnName("ShiftDetailsID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGshift)
                    .HasColumnName("IsGShift")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsShiftDetailsEdited).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftDetailsDesc).HasMaxLength(60);

                entity.Property(e => e.ShiftDetailsEditedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftDetailsName).HasMaxLength(30);

                entity.Property(e => e.ShiftMethodId).HasColumnName("ShiftMethodID");

                entity.HasOne(d => d.ShiftMethod)
                    .WithMany(p => p.Tblshiftdetails)
                    .HasForeignKey(d => d.ShiftMethodId)
                    .HasConstraintName("tblshiftdetails$ShiftMethodIDshiftmethod");
            });

            modelBuilder.Entity<TblshiftdetailsMachinewise>(entity =>
            {
                entity.HasKey(e => e.ShiftDetailsMacId)
                    .HasName("PK_tblshiftdetails_machinewise_ShiftDetailsMacID");

                entity.ToTable("tblshiftdetails_machinewise", "unitworkccs");

                entity.Property(e => e.ShiftDetailsMacId).HasColumnName("ShiftDetailsMacID");

                entity.Property(e => e.CorrectedDate).HasMaxLength(30);

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.InsertedOn).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ShiftDetailsId).HasColumnName("ShiftDetailsID");

                entity.Property(e => e.ShiftName).HasMaxLength(30);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.TblshiftdetailsMachinewise)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblshiftdetails_machinewise$MachineIDShiftWise");
            });

            modelBuilder.Entity<Tblshiftmethod>(entity =>
            {
                entity.HasKey(e => e.ShiftMethodId)
                    .HasName("PK_tblshiftmethod_ShiftMethodID");

                entity.ToTable("tblshiftmethod", "unitworkccs");

                entity.Property(e => e.ShiftMethodId).HasColumnName("ShiftMethodID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EditedDate).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsShiftMethodEdited).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShiftMethodDesc)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ShiftMethodName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Tblshiftplanner>(entity =>
            {
                entity.HasKey(e => e.ShiftPlannerId)
                    .HasName("PK_tblshiftplanner_ShiftPlannerID");

                entity.ToTable("tblshiftplanner", "unitworkccs");

                entity.Property(e => e.ShiftPlannerId).HasColumnName("ShiftPlannerID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsPlanRemoved).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPlanStopped).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlanStoppedDate).HasColumnType("date");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShiftMethodId).HasColumnName("ShiftMethodID");

                entity.Property(e => e.ShiftPlannerDesc).HasMaxLength(100);

                entity.Property(e => e.ShiftPlannerName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("tblshiftplanner$CellIDshiftplanner");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.MachineId)
                    .HasConstraintName("tblshiftplanner$MachineIDshiftplanner");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblshiftplanner$PlantIDshiftplanner");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.Tblshiftplanner)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblshiftplanner$ShopIDshiftplanner");
            });

            modelBuilder.Entity<Tblshop>(entity =>
            {
                entity.HasKey(e => e.ShopId)
                    .HasName("PK_tblshop_ShopID");

                entity.ToTable("tblshop", "unitworkccs");

                entity.Property(e => e.ShopId).HasColumnName("ShopID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.PlantId).HasColumnName("PlantID");

                entity.Property(e => e.ShopDesc)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Shopdisplayname).HasMaxLength(100);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Tblshop)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblshop$PlantID");
            });

            modelBuilder.Entity<Tbltoollifeoperator>(entity =>
            {
                entity.HasKey(e => e.ToolLifeId);

                entity.ToTable("tbltoollifeoperator", "unitworkccs");

                entity.Property(e => e.ToolLifeId).HasColumnName("ToolLifeID");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime");

                entity.Property(e => e.IsCompleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.ResetReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToolCtcode)
                    .HasColumnName("ToolCTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolIdadmin).HasColumnName("ToolIDAdmin");

                entity.Property(e => e.ToolName).HasMaxLength(150);

                entity.Property(e => e.ToolNo)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Toollifecounter).HasColumnName("toollifecounter");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tbltoollifeoperator)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbltoollifeoperator_tblmachinedetails");
            });

            modelBuilder.Entity<Tbltosapfilepath>(entity =>
            {
                entity.HasKey(e => e.ToSapfilePathId)
                    .HasName("PK_tbltosapfilepath_toSAPFilePathID");

                entity.ToTable("tbltosapfilepath", "unitworkccs");

                entity.Property(e => e.ToSapfilePathId).HasColumnName("toSAPFilePathID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Path).HasMaxLength(250);

                entity.Property(e => e.PathName).HasMaxLength(45);

                entity.Property(e => e.Tbltosapfilepathcol)
                    .HasColumnName("tbltosapfilepathcol")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Tbltosapshopnames>(entity =>
            {
                entity.HasKey(e => e.ToSapshopNamesId)
                    .HasName("PK_tbltosapshopnames_toSAPShopNamesID");

                entity.ToTable("tbltosapshopnames", "unitworkccs");

                entity.Property(e => e.ToSapshopNamesId).HasColumnName("toSAPShopNamesID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsSetupShown)
                    .HasColumnName("isSetupShown")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ShopName).HasMaxLength(65);
            });

            modelBuilder.Entity<Tblunit>(entity =>
            {
                entity.HasKey(e => e.UId)
                    .HasName("PK_tblunit_U_ID");

                entity.ToTable("tblunit", "unitworkccs");

                entity.HasIndex(e => e.UId)
                    .HasName("tblunit$U_ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.UId).HasColumnName("U_ID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnitDesc)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Tblusers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_tblusers_UserID");

                entity.ToTable("tblusers", "unitworkccs");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.PlantId).HasColumnName("plantId");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.Tblusers)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tblusers$MachineFkforUser");

                entity.HasOne(d => d.PrimaryRoleNavigation)
                    .WithMany(p => p.TblusersPrimaryRoleNavigation)
                    .HasForeignKey(d => d.PrimaryRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblusers$PrimaryRole");

                entity.HasOne(d => d.SecondaryRoleNavigation)
                    .WithMany(p => p.TblusersSecondaryRoleNavigation)
                    .HasForeignKey(d => d.SecondaryRole)
                    .HasConstraintName("tblusers$SecondaryRole");
            });

            modelBuilder.Entity<Tblwolossess>(entity =>
            {
                entity.HasKey(e => e.WolossesId)
                    .HasName("PK_tblwolossess_WOLossesID");

                entity.ToTable("tblwolossess", "unitworkccs");

                entity.Property(e => e.WolossesId).HasColumnName("WOLossesID");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.LossCodeLevel1Id).HasColumnName("LossCodeLevel1ID");

                entity.Property(e => e.LossCodeLevel1Name).HasMaxLength(145);

                entity.Property(e => e.LossCodeLevel2Id).HasColumnName("LossCodeLevel2ID");

                entity.Property(e => e.LossCodeLevel2Name).HasMaxLength(145);

                entity.Property(e => e.LossDuration).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LossId).HasColumnName("LossID");

                entity.Property(e => e.LossName).HasMaxLength(145);
            });

            modelBuilder.Entity<Tblworeport>(entity =>
            {
                entity.HasKey(e => e.WoreportId)
                    .HasName("PK_tblworeport_WOReportID");

                entity.ToTable("tblworeport", "unitworkccs");

                entity.HasIndex(e => e.WoreportId)
                    .HasName("tblworeport$WOReportID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.WoreportId).HasColumnName("WOReportID");

                entity.Property(e => e.Blue)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Breakdown).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CorrectedDate).HasMaxLength(45);

                entity.Property(e => e.CuttingTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EndTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.HoldReason).HasMaxLength(225);

                entity.Property(e => e.Idle).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.IsMultiWo).HasColumnName("IsMultiWO");

                entity.Property(e => e.IsNormalWc)
                    .HasColumnName("IsNormalWC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPf).HasColumnName("IsPF");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.MinorLoss)
                    .HasColumnType("decimal(6, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.Mrweight)
                    .HasColumnName("MRWeight")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NccuttingTimePerPart)
                    .HasColumnName("NCCuttingTimePerPart")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OpNo).HasMaxLength(6);

                entity.Property(e => e.OperatorName).HasMaxLength(45);

                entity.Property(e => e.PartNo).HasMaxLength(45);

                entity.Property(e => e.Program).HasMaxLength(45);

                entity.Property(e => e.ReWorkTime)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.RejectedReason).HasMaxLength(245);

                entity.Property(e => e.ScrapQtyTime)
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SelfInspection).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Shift).HasMaxLength(4);

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(10);

                entity.Property(e => e.StartTime).HasColumnType("datetime2(0)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("decimal(8, 2)")
                    .HasDefaultValueSql("((0.00))");

                entity.Property(e => e.TotalNccuttingTime)
                    .HasColumnName("TotalNCCuttingTime")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Type).HasMaxLength(45);

                entity.Property(e => e.Woefficiency)
                    .HasColumnName("WOEfficiency")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WorkOrderNo).HasMaxLength(45);
            });

            modelBuilder.Entity<Tblworkorderentry>(entity =>
            {
                entity.HasKey(e => e.Hmiid)
                    .HasName("PK_tblworkorderentry_HMIID");

                entity.ToTable("tblworkorderentry", "unitworkccs");

                entity.Property(e => e.Hmiid).HasColumnName("HMIID");

                entity.Property(e => e.CellId).HasColumnName("CellID");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(50);

                entity.Property(e => e.HoldCodeId).HasColumnName("HoldCodeID");

                entity.Property(e => e.HoldTime).HasColumnType("datetime");

                entity.Property(e => e.IsMultiWo).HasColumnName("IsMultiWO");

                entity.Property(e => e.IsSplit).HasColumnName("isSplit");

                entity.Property(e => e.IsWorkOrder).HasColumnName("isWorkOrder");

                entity.Property(e => e.MachineId).HasColumnName("MachineID");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.OperatorId)
                    .IsRequired()
                    .HasColumnName("OperatorID")
                    .HasMaxLength(45);

                entity.Property(e => e.PartNo).HasMaxLength(45);

                entity.Property(e => e.PartsPerCycle).HasDefaultValueSql("((1))");

                entity.Property(e => e.PestartTime)
                    .HasColumnName("PEStartTime")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.ProdOrderNo)
                    .IsRequired()
                    .HasColumnName("Prod_Order_No")
                    .HasMaxLength(45);

                entity.Property(e => e.ReWorkReasonId).HasColumnName("ReWorkReasonID");

                entity.Property(e => e.ReworkEndTime)
                    .HasColumnName("reworkEndTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReworkStartTime)
                    .HasColumnName("reworkStartTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.TotalQty).HasColumnName("Total_Qty");

                entity.Property(e => e.Woend)
                    .HasColumnName("WOEnd")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.Wostart)
                    .HasColumnName("WOStart")
                    .HasColumnType("datetime2(0)");

                entity.Property(e => e.YieldQty).HasColumnName("Yield_Qty");
            });

            modelBuilder.Entity<Weekdata>(entity =>
            {
                entity.HasKey(e => e.WeekId)
                    .HasName("PK__weekdata__C814A5E1818A3E05");

                entity.ToTable("weekdata", "unitworkccs");

                entity.Property(e => e.WeekId).HasColumnName("WeekID");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Isdeleted).HasDefaultValueSql("('0')");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime2(0)");

                entity.Property(e => e.Value).HasColumnName("value");
            });
        }
    }
}
