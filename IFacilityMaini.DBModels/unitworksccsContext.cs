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

        public virtual DbSet<Tblchecklistdetailsnew> Tblchecklistdetailsnew { get; set; }
        public virtual DbSet<UnitworkccsAlarmHistoryMaster> UnitworkccsAlarmHistoryMaster { get; set; }
        public virtual DbSet<UnitworkccsConfigurationTblpmchecklist> UnitworkccsConfigurationTblpmchecklist { get; set; }
        public virtual DbSet<UnitworkccsConfigurationTblpmcheckpoint> UnitworkccsConfigurationTblpmcheckpoint { get; set; }
        public virtual DbSet<UnitworkccsConfigurationTblprimitivemaintainancescheduling> UnitworkccsConfigurationTblprimitivemaintainancescheduling { get; set; }
        public virtual DbSet<UnitworkccsConfigurationTblsensorgroup> UnitworkccsConfigurationTblsensorgroup { get; set; }
        public virtual DbSet<UnitworkccsConfigurationtblmachinesensor> UnitworkccsConfigurationtblmachinesensor { get; set; }
        public virtual DbSet<UnitworkccsConfigurationtblsensordatalink> UnitworkccsConfigurationtblsensordatalink { get; set; }
        public virtual DbSet<UnitworkccsConfigurationtblsensormaster> UnitworkccsConfigurationtblsensormaster { get; set; }
        public virtual DbSet<UnitworkccsDocumentuploadermaster> UnitworkccsDocumentuploadermaster { get; set; }
        public virtual DbSet<UnitworkccsFrommail> UnitworkccsFrommail { get; set; }
        public virtual DbSet<UnitworkccsHandleNoPing> UnitworkccsHandleNoPing { get; set; }
        public virtual DbSet<UnitworkccsIotgatwaypacketsdata> UnitworkccsIotgatwaypacketsdata { get; set; }
        public virtual DbSet<UnitworkccsJobcardDetails> UnitworkccsJobcardDetails { get; set; }
        public virtual DbSet<UnitworkccsLogintrackerdetails> UnitworkccsLogintrackerdetails { get; set; }
        public virtual DbSet<UnitworkccsMachinedetailswimerasys> UnitworkccsMachinedetailswimerasys { get; set; }
        public virtual DbSet<UnitworkccsMailmaster> UnitworkccsMailmaster { get; set; }
        public virtual DbSet<UnitworkccsMessageCodeMaster> UnitworkccsMessageCodeMaster { get; set; }
        public virtual DbSet<UnitworkccsMessageHistoryMaster> UnitworkccsMessageHistoryMaster { get; set; }
        public virtual DbSet<UnitworkccsMonthdata> UnitworkccsMonthdata { get; set; }
        public virtual DbSet<UnitworkccsOperationlog> UnitworkccsOperationlog { get; set; }
        public virtual DbSet<UnitworkccsParameterSendorData> UnitworkccsParameterSendorData { get; set; }
        public virtual DbSet<UnitworkccsParameterSensorDataCurrent> UnitworkccsParameterSensorDataCurrent { get; set; }
        public virtual DbSet<UnitworkccsParameterSensorDataLevel> UnitworkccsParameterSensorDataLevel { get; set; }
        public virtual DbSet<UnitworkccsParameterSensorDataPressure> UnitworkccsParameterSensorDataPressure { get; set; }
        public virtual DbSet<UnitworkccsParameterSensorDataTemperature> UnitworkccsParameterSensorDataTemperature { get; set; }
        public virtual DbSet<UnitworkccsParameterToolData> UnitworkccsParameterToolData { get; set; }
        public virtual DbSet<UnitworkccsParametersMaster> UnitworkccsParametersMaster { get; set; }
        public virtual DbSet<UnitworkccsPcbDetails> UnitworkccsPcbDetails { get; set; }
        public virtual DbSet<UnitworkccsPcbParameters> UnitworkccsPcbParameters { get; set; }
        public virtual DbSet<UnitworkccsPcbdaq> UnitworkccsPcbdaq { get; set; }
        public virtual DbSet<UnitworkccsPcbdaqinTbl> UnitworkccsPcbdaqinTbl { get; set; }
        public virtual DbSet<UnitworkccsPcbdpsMaster> UnitworkccsPcbdpsMaster { get; set; }
        public virtual DbSet<UnitworkccsPinghandlerTbl> UnitworkccsPinghandlerTbl { get; set; }
        public virtual DbSet<UnitworkccsProgramExecutionMaster> UnitworkccsProgramExecutionMaster { get; set; }
        public virtual DbSet<UnitworkccsProgramMaster> UnitworkccsProgramMaster { get; set; }
        public virtual DbSet<UnitworkccsSapfilegenerateddetails> UnitworkccsSapfilegenerateddetails { get; set; }
        public virtual DbSet<UnitworkccsSharathtable> UnitworkccsSharathtable { get; set; }
        public virtual DbSet<UnitworkccsShiftMaster> UnitworkccsShiftMaster { get; set; }
        public virtual DbSet<UnitworkccsSmtpdetails> UnitworkccsSmtpdetails { get; set; }
        public virtual DbSet<UnitworkccsTblAutoreportLog> UnitworkccsTblAutoreportLog { get; set; }
        public virtual DbSet<UnitworkccsTblAutoreportbasedon> UnitworkccsTblAutoreportbasedon { get; set; }
        public virtual DbSet<UnitworkccsTblAutoreportsetting> UnitworkccsTblAutoreportsetting { get; set; }
        public virtual DbSet<UnitworkccsTblAutoreporttime> UnitworkccsTblAutoreporttime { get; set; }
        public virtual DbSet<UnitworkccsTblAxisdet> UnitworkccsTblAxisdet { get; set; }
        public virtual DbSet<UnitworkccsTblAxisdetails1> UnitworkccsTblAxisdetails1 { get; set; }
        public virtual DbSet<UnitworkccsTblAxisdetails2> UnitworkccsTblAxisdetails2 { get; set; }
        public virtual DbSet<UnitworkccsTblCategorynames> UnitworkccsTblCategorynames { get; set; }
        public virtual DbSet<UnitworkccsTblChecklistmachines> UnitworkccsTblChecklistmachines { get; set; }
        public virtual DbSet<UnitworkccsTblCycletimeanalysis> UnitworkccsTblCycletimeanalysis { get; set; }
        public virtual DbSet<UnitworkccsTblDeletedprogdet> UnitworkccsTblDeletedprogdet { get; set; }
        public virtual DbSet<UnitworkccsTblGenericfilepath> UnitworkccsTblGenericfilepath { get; set; }
        public virtual DbSet<UnitworkccsTblLivecbmdetails> UnitworkccsTblLivecbmdetails { get; set; }
        public virtual DbSet<UnitworkccsTblLivecbmparameters> UnitworkccsTblLivecbmparameters { get; set; }
        public virtual DbSet<UnitworkccsTblLivetblsensorvalue> UnitworkccsTblLivetblsensorvalue { get; set; }
        public virtual DbSet<UnitworkccsTblMachinemakedetails> UnitworkccsTblMachinemakedetails { get; set; }
        public virtual DbSet<UnitworkccsTblOeedetails> UnitworkccsTblOeedetails { get; set; }
        public virtual DbSet<UnitworkccsTblOeeoperatordetails> UnitworkccsTblOeeoperatordetails { get; set; }
        public virtual DbSet<UnitworkccsTblOeereportasdivision> UnitworkccsTblOeereportasdivision { get; set; }
        public virtual DbSet<UnitworkccsTblOeeshiftdetails> UnitworkccsTblOeeshiftdetails { get; set; }
        public virtual DbSet<UnitworkccsTblPmsdashboardchecklist> UnitworkccsTblPmsdashboardchecklist { get; set; }
        public virtual DbSet<UnitworkccsTblProdandondisp> UnitworkccsTblProdandondisp { get; set; }
        public virtual DbSet<UnitworkccsTblProdmanmachine> UnitworkccsTblProdmanmachine { get; set; }
        public virtual DbSet<UnitworkccsTblProdorderlosses> UnitworkccsTblProdorderlosses { get; set; }
        public virtual DbSet<UnitworkccsTblReportmaster> UnitworkccsTblReportmaster { get; set; }
        public virtual DbSet<UnitworkccsTblSavencprogver> UnitworkccsTblSavencprogver { get; set; }
        public virtual DbSet<UnitworkccsTblScreenpagesdetails> UnitworkccsTblScreenpagesdetails { get; set; }
        public virtual DbSet<UnitworkccsTblServodetails> UnitworkccsTblServodetails { get; set; }
        public virtual DbSet<UnitworkccsTblUtilreport> UnitworkccsTblUtilreport { get; set; }
        public virtual DbSet<UnitworkccsTblactivitylog> UnitworkccsTblactivitylog { get; set; }
        public virtual DbSet<UnitworkccsTblandondispdet> UnitworkccsTblandondispdet { get; set; }
        public virtual DbSet<UnitworkccsTblandondisplayrotate> UnitworkccsTblandondisplayrotate { get; set; }
        public virtual DbSet<UnitworkccsTblandonimagetextscheduleddisplay> UnitworkccsTblandonimagetextscheduleddisplay { get; set; }
        public virtual DbSet<UnitworkccsTblappPaths> UnitworkccsTblappPaths { get; set; }
        public virtual DbSet<UnitworkccsTblatccounter> UnitworkccsTblatccounter { get; set; }
        public virtual DbSet<UnitworkccsTblbookstock> UnitworkccsTblbookstock { get; set; }
        public virtual DbSet<UnitworkccsTblbottelneck> UnitworkccsTblbottelneck { get; set; }
        public virtual DbSet<UnitworkccsTblbreakdown> UnitworkccsTblbreakdown { get; set; }
        public virtual DbSet<UnitworkccsTblbreakdownReportdetails> UnitworkccsTblbreakdownReportdetails { get; set; }
        public virtual DbSet<UnitworkccsTblbreakdowncodes> UnitworkccsTblbreakdowncodes { get; set; }
        public virtual DbSet<UnitworkccsTblbreakdowntickect> UnitworkccsTblbreakdowntickect { get; set; }
        public virtual DbSet<UnitworkccsTblbusinessdetails> UnitworkccsTblbusinessdetails { get; set; }
        public virtual DbSet<UnitworkccsTblcategory> UnitworkccsTblcategory { get; set; }
        public virtual DbSet<UnitworkccsTblcategorydetails> UnitworkccsTblcategorydetails { get; set; }
        public virtual DbSet<UnitworkccsTblcategorymaster> UnitworkccsTblcategorymaster { get; set; }
        public virtual DbSet<UnitworkccsTblcell> UnitworkccsTblcell { get; set; }
        public virtual DbSet<UnitworkccsTblcellfinalmaster> UnitworkccsTblcellfinalmaster { get; set; }
        public virtual DbSet<UnitworkccsTblcellpart> UnitworkccsTblcellpart { get; set; }
        public virtual DbSet<UnitworkccsTblchecklistDetails> UnitworkccsTblchecklistDetails { get; set; }
        public virtual DbSet<UnitworkccsTblchecklistHeader> UnitworkccsTblchecklistHeader { get; set; }
        public virtual DbSet<UnitworkccsTblchecklistdetailsnew> UnitworkccsTblchecklistdetailsnew { get; set; }
        public virtual DbSet<UnitworkccsTblchildfgpartno> UnitworkccsTblchildfgpartno { get; set; }
        public virtual DbSet<UnitworkccsTblclassmaster> UnitworkccsTblclassmaster { get; set; }
        public virtual DbSet<UnitworkccsTblcontrolplan> UnitworkccsTblcontrolplan { get; set; }
        public virtual DbSet<UnitworkccsTblcontrolplandetails> UnitworkccsTblcontrolplandetails { get; set; }
        public virtual DbSet<UnitworkccsTblcustomer> UnitworkccsTblcustomer { get; set; }
        public virtual DbSet<UnitworkccsTbldailyprodstatus> UnitworkccsTbldailyprodstatus { get; set; }
        public virtual DbSet<UnitworkccsTbldaytiming> UnitworkccsTbldaytiming { get; set; }
        public virtual DbSet<UnitworkccsTbldefectcodemaster> UnitworkccsTbldefectcodemaster { get; set; }
        public virtual DbSet<UnitworkccsTbldepartmentdetails> UnitworkccsTbldepartmentdetails { get; set; }
        public virtual DbSet<UnitworkccsTbldirlineinspector> UnitworkccsTbldirlineinspector { get; set; }
        public virtual DbSet<UnitworkccsTbldirqualityhead> UnitworkccsTbldirqualityhead { get; set; }
        public virtual DbSet<UnitworkccsTbldowntimecategory> UnitworkccsTbldowntimecategory { get; set; }
        public virtual DbSet<UnitworkccsTbldowntimedetails> UnitworkccsTbldowntimedetails { get; set; }
        public virtual DbSet<UnitworkccsTbldryrun> UnitworkccsTbldryrun { get; set; }
        public virtual DbSet<UnitworkccsTblemailescalation> UnitworkccsTblemailescalation { get; set; }
        public virtual DbSet<UnitworkccsTblemployeeshiftdetails> UnitworkccsTblemployeeshiftdetails { get; set; }
        public virtual DbSet<UnitworkccsTblendcodes> UnitworkccsTblendcodes { get; set; }
        public virtual DbSet<UnitworkccsTblescalationlog> UnitworkccsTblescalationlog { get; set; }
        public virtual DbSet<UnitworkccsTblescalationmatrix> UnitworkccsTblescalationmatrix { get; set; }
        public virtual DbSet<UnitworkccsTblescalationprioritydetails> UnitworkccsTblescalationprioritydetails { get; set; }
        public virtual DbSet<UnitworkccsTblescalationtiming> UnitworkccsTblescalationtiming { get; set; }
        public virtual DbSet<UnitworkccsTblfgandcellallocation> UnitworkccsTblfgandcellallocation { get; set; }
        public virtual DbSet<UnitworkccsTblfgpartnodet> UnitworkccsTblfgpartnodet { get; set; }
        public virtual DbSet<UnitworkccsTblgeneraldefectcodes> UnitworkccsTblgeneraldefectcodes { get; set; }
        public virtual DbSet<UnitworkccsTblgenericworkcodes> UnitworkccsTblgenericworkcodes { get; set; }
        public virtual DbSet<UnitworkccsTblgenericworkentry> UnitworkccsTblgenericworkentry { get; set; }
        public virtual DbSet<UnitworkccsTblhistpms> UnitworkccsTblhistpms { get; set; }
        public virtual DbSet<UnitworkccsTblholdcodes> UnitworkccsTblholdcodes { get; set; }
        public virtual DbSet<UnitworkccsTblholidaymanagment> UnitworkccsTblholidaymanagment { get; set; }
        public virtual DbSet<UnitworkccsTblholidays> UnitworkccsTblholidays { get; set; }
        public virtual DbSet<UnitworkccsTblholidaytypemasters> UnitworkccsTblholidaytypemasters { get; set; }
        public virtual DbSet<UnitworkccsTblipaddress> UnitworkccsTblipaddress { get; set; }
        public virtual DbSet<UnitworkccsTblissuedreceived> UnitworkccsTblissuedreceived { get; set; }
        public virtual DbSet<UnitworkccsTbllivedailyprodstatus> UnitworkccsTbllivedailyprodstatus { get; set; }
        public virtual DbSet<UnitworkccsTbllivemode> UnitworkccsTbllivemode { get; set; }
        public virtual DbSet<UnitworkccsTbllossescodes> UnitworkccsTbllossescodes { get; set; }
        public virtual DbSet<UnitworkccsTbllossofentry> UnitworkccsTbllossofentry { get; set; }
        public virtual DbSet<UnitworkccsTblmachineaxisdetails> UnitworkccsTblmachineaxisdetails { get; set; }
        public virtual DbSet<UnitworkccsTblmachinecategory> UnitworkccsTblmachinecategory { get; set; }
        public virtual DbSet<UnitworkccsTblmachinecategorynames> UnitworkccsTblmachinecategorynames { get; set; }
        public virtual DbSet<UnitworkccsTblmachinedetails> UnitworkccsTblmachinedetails { get; set; }
        public virtual DbSet<UnitworkccsTblmailids> UnitworkccsTblmailids { get; set; }
        public virtual DbSet<UnitworkccsTblmasterpartsStSw> UnitworkccsTblmasterpartsStSw { get; set; }
        public virtual DbSet<UnitworkccsTblmastervalue> UnitworkccsTblmastervalue { get; set; }
        public virtual DbSet<UnitworkccsTblmaterialmaster> UnitworkccsTblmaterialmaster { get; set; }
        public virtual DbSet<UnitworkccsTblmimics> UnitworkccsTblmimics { get; set; }
        public virtual DbSet<UnitworkccsTblmode> UnitworkccsTblmode { get; set; }
        public virtual DbSet<UnitworkccsTblmodetemp> UnitworkccsTblmodetemp { get; set; }
        public virtual DbSet<UnitworkccsTblmodulehelper> UnitworkccsTblmodulehelper { get; set; }
        public virtual DbSet<UnitworkccsTblmodulemaster> UnitworkccsTblmodulemaster { get; set; }
        public virtual DbSet<UnitworkccsTblmodules> UnitworkccsTblmodules { get; set; }
        public virtual DbSet<UnitworkccsTblmultipleworkorder> UnitworkccsTblmultipleworkorder { get; set; }
        public virtual DbSet<UnitworkccsTblncprogramtransfermain> UnitworkccsTblncprogramtransfermain { get; set; }
        public virtual DbSet<UnitworkccsTblnoofaxis> UnitworkccsTblnoofaxis { get; set; }
        public virtual DbSet<UnitworkccsTbloeedashboardfinalvariables> UnitworkccsTbloeedashboardfinalvariables { get; set; }
        public virtual DbSet<UnitworkccsTbloeedashboardvariables> UnitworkccsTbloeedashboardvariables { get; set; }
        public virtual DbSet<UnitworkccsTbloeedashboardvariablestoday> UnitworkccsTbloeedashboardvariablestoday { get; set; }
        public virtual DbSet<UnitworkccsTbloperatordashboard> UnitworkccsTbloperatordashboard { get; set; }
        public virtual DbSet<UnitworkccsTbloperatordetails> UnitworkccsTbloperatordetails { get; set; }
        public virtual DbSet<UnitworkccsTbloperatorheader> UnitworkccsTbloperatorheader { get; set; }
        public virtual DbSet<UnitworkccsTbloperatorlogindetails> UnitworkccsTbloperatorlogindetails { get; set; }
        public virtual DbSet<UnitworkccsTbloperatormachinedetails> UnitworkccsTbloperatormachinedetails { get; set; }
        public virtual DbSet<UnitworkccsTblpallet> UnitworkccsTblpallet { get; set; }
        public virtual DbSet<UnitworkccsTblpartlearningreport> UnitworkccsTblpartlearningreport { get; set; }
        public virtual DbSet<UnitworkccsTblparts> UnitworkccsTblparts { get; set; }
        public virtual DbSet<UnitworkccsTblpartscountandcutting> UnitworkccsTblpartscountandcutting { get; set; }
        public virtual DbSet<UnitworkccsTblpir> UnitworkccsTblpir { get; set; }
        public virtual DbSet<UnitworkccsTblpirminmax> UnitworkccsTblpirminmax { get; set; }
        public virtual DbSet<UnitworkccsTblplanlinkagemaster> UnitworkccsTblplanlinkagemaster { get; set; }
        public virtual DbSet<UnitworkccsTblplannedbreak> UnitworkccsTblplannedbreak { get; set; }
        public virtual DbSet<UnitworkccsTblplant> UnitworkccsTblplant { get; set; }
        public virtual DbSet<UnitworkccsTblpmsdetails> UnitworkccsTblpmsdetails { get; set; }
        public virtual DbSet<UnitworkccsTblprecentcolour> UnitworkccsTblprecentcolour { get; set; }
        public virtual DbSet<UnitworkccsTblpresenttool> UnitworkccsTblpresenttool { get; set; }
        public virtual DbSet<UnitworkccsTblpriorityalarms> UnitworkccsTblpriorityalarms { get; set; }
        public virtual DbSet<UnitworkccsTblprocess> UnitworkccsTblprocess { get; set; }
        public virtual DbSet<UnitworkccsTblprodplanmasters> UnitworkccsTblprodplanmasters { get; set; }
        public virtual DbSet<UnitworkccsTblproduct> UnitworkccsTblproduct { get; set; }
        public virtual DbSet<UnitworkccsTblproductwisedefectcodes> UnitworkccsTblproductwisedefectcodes { get; set; }
        public virtual DbSet<UnitworkccsTblprogramtransferhistory> UnitworkccsTblprogramtransferhistory { get; set; }
        public virtual DbSet<UnitworkccsTblraisedticket> UnitworkccsTblraisedticket { get; set; }
        public virtual DbSet<UnitworkccsTblrejectiondetails> UnitworkccsTblrejectiondetails { get; set; }
        public virtual DbSet<UnitworkccsTblrejectqty> UnitworkccsTblrejectqty { get; set; }
        public virtual DbSet<UnitworkccsTblrejectreason> UnitworkccsTblrejectreason { get; set; }
        public virtual DbSet<UnitworkccsTblreportholder> UnitworkccsTblreportholder { get; set; }
        public virtual DbSet<UnitworkccsTblreworkdetails> UnitworkccsTblreworkdetails { get; set; }
        public virtual DbSet<UnitworkccsTblreworkreasons> UnitworkccsTblreworkreasons { get; set; }
        public virtual DbSet<UnitworkccsTblrolemodulelink> UnitworkccsTblrolemodulelink { get; set; }
        public virtual DbSet<UnitworkccsTblroles> UnitworkccsTblroles { get; set; }
        public virtual DbSet<UnitworkccsTblroutingno> UnitworkccsTblroutingno { get; set; }
        public virtual DbSet<UnitworkccsTblsapinput> UnitworkccsTblsapinput { get; set; }
        public virtual DbSet<UnitworkccsTblsar> UnitworkccsTblsar { get; set; }
        public virtual DbSet<UnitworkccsTblsarminmax> UnitworkccsTblsarminmax { get; set; }
        public virtual DbSet<UnitworkccsTblsendermailid> UnitworkccsTblsendermailid { get; set; }
        public virtual DbSet<UnitworkccsTblsetupmaint> UnitworkccsTblsetupmaint { get; set; }
        public virtual DbSet<UnitworkccsTblshiftBreaks> UnitworkccsTblshiftBreaks { get; set; }
        public virtual DbSet<UnitworkccsTblshiftMstr> UnitworkccsTblshiftMstr { get; set; }
        public virtual DbSet<UnitworkccsTblshiftdetails> UnitworkccsTblshiftdetails { get; set; }
        public virtual DbSet<UnitworkccsTblshiftdetailsMachinewise> UnitworkccsTblshiftdetailsMachinewise { get; set; }
        public virtual DbSet<UnitworkccsTblshiftmethod> UnitworkccsTblshiftmethod { get; set; }
        public virtual DbSet<UnitworkccsTblshiftplanner> UnitworkccsTblshiftplanner { get; set; }
        public virtual DbSet<UnitworkccsTblshop> UnitworkccsTblshop { get; set; }
        public virtual DbSet<UnitworkccsTblsmsdetails> UnitworkccsTblsmsdetails { get; set; }
        public virtual DbSet<UnitworkccsTblsourcemaster> UnitworkccsTblsourcemaster { get; set; }
        public virtual DbSet<UnitworkccsTblstatusmaster> UnitworkccsTblstatusmaster { get; set; }
        public virtual DbSet<UnitworkccsTblstdtoollife> UnitworkccsTblstdtoollife { get; set; }
        public virtual DbSet<UnitworkccsTblstoppage> UnitworkccsTblstoppage { get; set; }
        public virtual DbSet<UnitworkccsTblsubcellfinalmaster> UnitworkccsTblsubcellfinalmaster { get; set; }
        public virtual DbSet<UnitworkccsTblsystemconfig> UnitworkccsTblsystemconfig { get; set; }
        public virtual DbSet<UnitworkccsTbltallstockavailibility> UnitworkccsTbltallstockavailibility { get; set; }
        public virtual DbSet<UnitworkccsTblticketraiseddet> UnitworkccsTblticketraiseddet { get; set; }
        public virtual DbSet<UnitworkccsTblticketreason> UnitworkccsTblticketreason { get; set; }
        public virtual DbSet<UnitworkccsTbltoolandsocketdetails> UnitworkccsTbltoolandsocketdetails { get; set; }
        public virtual DbSet<UnitworkccsTbltoolbrdnreasonlvl1> UnitworkccsTbltoolbrdnreasonlvl1 { get; set; }
        public virtual DbSet<UnitworkccsTbltoolbrkdnreason> UnitworkccsTbltoolbrkdnreason { get; set; }
        public virtual DbSet<UnitworkccsTbltoolcounter> UnitworkccsTbltoolcounter { get; set; }
        public virtual DbSet<UnitworkccsTbltoollifeoperator> UnitworkccsTbltoollifeoperator { get; set; }
        public virtual DbSet<UnitworkccsTbltools> UnitworkccsTbltools { get; set; }
        public virtual DbSet<UnitworkccsTbltosapfilepath> UnitworkccsTbltosapfilepath { get; set; }
        public virtual DbSet<UnitworkccsTbltosapshopnames> UnitworkccsTbltosapshopnames { get; set; }
        public virtual DbSet<UnitworkccsTbltrialpartcount> UnitworkccsTbltrialpartcount { get; set; }
        public virtual DbSet<UnitworkccsTblunit> UnitworkccsTblunit { get; set; }
        public virtual DbSet<UnitworkccsTblusers> UnitworkccsTblusers { get; set; }
        public virtual DbSet<UnitworkccsTblvendor> UnitworkccsTblvendor { get; set; }
        public virtual DbSet<UnitworkccsTblwolossess> UnitworkccsTblwolossess { get; set; }
        public virtual DbSet<UnitworkccsTblworeport> UnitworkccsTblworeport { get; set; }
        public virtual DbSet<UnitworkccsTblworkcenter> UnitworkccsTblworkcenter { get; set; }
        public virtual DbSet<UnitworkccsTblworkorderentry> UnitworkccsTblworkorderentry { get; set; }
        public virtual DbSet<UnitworkccsToolnamemaster> UnitworkccsToolnamemaster { get; set; }
        public virtual DbSet<UnitworkccsWeekdata> UnitworkccsWeekdata { get; set; }
        public virtual DbSet<WimerasysControlplan> WimerasysControlplan { get; set; }
        public virtual DbSet<WimerasysCpdetails> WimerasysCpdetails { get; set; }
        public virtual DbSet<WimerasysDir> WimerasysDir { get; set; }
        public virtual DbSet<WimerasysDocuments> WimerasysDocuments { get; set; }
        public virtual DbSet<WimerasysEmployeedetails> WimerasysEmployeedetails { get; set; }
        public virtual DbSet<WimerasysEvaluation> WimerasysEvaluation { get; set; }
        public virtual DbSet<WimerasysFgandcellallocationdetails> WimerasysFgandcellallocationdetails { get; set; }
        public virtual DbSet<WimerasysProcess> WimerasysProcess { get; set; }
        public virtual DbSet<WimerasysProduct> WimerasysProduct { get; set; }
        public virtual DbSet<WimerasysProductwisedefectdetails> WimerasysProductwisedefectdetails { get; set; }
        public virtual DbSet<WimerasysRevisiondetails> WimerasysRevisiondetails { get; set; }
        public virtual DbSet<WimerasysScc> WimerasysScc { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=1068;database=unitworksccs");
             //   optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=srks4$maini;database=unitworksccs");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Tblchecklistdetailsnew>(entity =>
            {
                entity.HasKey(e => e.CheckListNewId);

                entity.ToTable("tblchecklistdetailsnew", "unitworksccs");

                entity.Property(e => e.CheckListNewId)
                    .HasColumnName("checkListNewId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddEdit)
                    .HasColumnName("addEdit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheckListId)
                    .HasColumnName("checkListId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderId)
                    .HasColumnName("headerId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.How)
                    .HasColumnName("how")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsAssigned)
                    .HasColumnName("isAssigned")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDashBoardEntry)
                    .HasColumnName("isDashBoardEntry")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsNumeric)
                    .HasColumnName("isNumeric")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IsOk)
                    .HasColumnName("isOk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrepared)
                    .HasColumnName("isPrepared")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsText)
                    .HasColumnName("isText")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.NumericValue)
                    .HasColumnName("numericValue")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartsCount)
                    .HasColumnName("partsCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PeriodFrequency)
                    .HasColumnName("periodFrequency")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RunningHrs)
                    .HasColumnName("runningHrs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextValue)
                    .HasColumnName("textValue")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WhatToCheck)
                    .HasColumnName("whatToCheck")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsAlarmHistoryMaster>(entity =>
            {
                entity.HasKey(e => e.AlarmId);

                entity.ToTable("unitworkccs.alarm_history_master", "unitworksccs");

                entity.Property(e => e.AlarmId)
                    .HasColumnName("AlarmID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AbsPos)
                    .HasColumnName("Abs_Pos")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmDate).HasColumnType("date");

                entity.Property(e => e.AlarmMessage)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.AlarmNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmTime).HasColumnType("time(6)");

                entity.Property(e => e.AxisNo)
                    .HasColumnName("Axis_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AxisNum)
                    .HasColumnName("Axis_Num")
                    .HasMaxLength(45)
                    .IsUnicode(false);

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

                entity.Property(e => e.InterferedPart)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

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

            modelBuilder.Entity<UnitworkccsConfigurationTblpmchecklist>(entity =>
            {
                entity.HasKey(e => e.Pmcid);

                entity.ToTable("unitworkccs.configuration_tblpmchecklist", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("plantID_FK");

                entity.HasIndex(e => e.PmcpId)
                    .HasName("pmcpID_FK");

                entity.HasIndex(e => e.ShopId)
                    .HasName("shopID_FK");

                entity.Property(e => e.Pmcid)
                    .HasColumnName("pmcid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheckList)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("null");

                entity.Property(e => e.How)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PmcpId)
                    .HasColumnName("pmcpID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Value)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("null");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plantID_FK");

                entity.HasOne(d => d.Pmcp)
                    .WithMany(p => p.UnitworkccsConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.PmcpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pmcpID_FK");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsConfigurationTblpmchecklist)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shopID_FK");
            });

            modelBuilder.Entity<UnitworkccsConfigurationTblpmcheckpoint>(entity =>
            {
                entity.HasKey(e => e.PmcpId);

                entity.ToTable("unitworkccs.configuration_tblpmcheckpoint", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("plantid_tblplant");

                entity.HasIndex(e => e.ShopId)
                    .HasName("shopid_tblshop");

                entity.Property(e => e.PmcpId)
                    .HasColumnName("pmcpID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheckList)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnName("frequency")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.How)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeofCheckpoint)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasDefaultValueSql("null");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsConfigurationTblpmcheckpoint)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("plantid_tblplant");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsConfigurationTblpmcheckpoint)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("shopid_tblshop");
            });

            modelBuilder.Entity<UnitworkccsConfigurationTblprimitivemaintainancescheduling>(entity =>
            {
                entity.HasKey(e => e.Pmid);

                entity.ToTable("unitworkccs.configuration_tblprimitivemaintainancescheduling", "unitworksccs");

                entity.HasIndex(e => e.CellId)
                    .HasName("FK_cellID");

                entity.HasIndex(e => e.MachineId)
                    .HasName("FK_machineID");

                entity.HasIndex(e => e.PlantId)
                    .HasName("plantIdFK_idx");

                entity.HasIndex(e => e.ShopId)
                    .HasName("ShopID");

                entity.Property(e => e.Pmid)
                    .HasColumnName("pmid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.Month).HasColumnType("int(11)");

                entity.Property(e => e.MonthId)
                    .HasColumnName("MonthID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantName)
                    .HasColumnName("plantName")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shopname)
                    .HasColumnName("shopname")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Week).HasColumnType("int(11)");

                entity.Property(e => e.WeekId)
                    .HasColumnName("WeekID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.UnitworkccsConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.CellId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cellID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.UnitworkccsConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_machineID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK_plantID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsConfigurationTblprimitivemaintainancescheduling)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("unitworkccs.configuration_tblprimitivemaintainancescheduling_ibf");
            });

            modelBuilder.Entity<UnitworkccsConfigurationTblsensorgroup>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("unitworkccs.configuration_tblsensorgroup", "unitworksccs");

                entity.Property(e => e.Sid)
                    .HasColumnName("SID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.SensorDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SensorGroupName)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsConfigurationtblmachinesensor>(entity =>
            {
                entity.HasKey(e => e.Msid);

                entity.ToTable("unitworkccs.configurationtblmachinesensor", "unitworksccs");

                entity.HasIndex(e => e.Sid)
                    .HasName("FK_tblkl_tblMachineSensor");

                entity.Property(e => e.Msid)
                    .HasColumnName("MSID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PortNo).HasColumnType("int(11)");

                entity.Property(e => e.Sid).HasColumnType("int(11)");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.UnitworkccsConfigurationtblmachinesensor)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblkl_tblMachineSensor");
            });

            modelBuilder.Entity<UnitworkccsConfigurationtblsensordatalink>(entity =>
            {
                entity.HasKey(e => e.ParameterTypeId);

                entity.ToTable("unitworkccs.configurationtblsensordatalink", "unitworksccs");

                entity.HasIndex(e => e.AxisId)
                    .HasName("axisid");

                entity.HasIndex(e => e.LogFreqUnitId)
                    .HasName("logfreqid");

                entity.HasIndex(e => e.Unit)
                    .HasName("unit");

                entity.Property(e => e.ParameterTypeId)
                    .HasColumnName("ParameterTypeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AxisId)
                    .HasColumnName("AxisID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Deterioration)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Element)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsAxis).HasColumnType("int(11)");

                entity.Property(e => e.IsCycle).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSensor).HasColumnType("int(11)");

                entity.Property(e => e.LogFreqUnitId)
                    .HasColumnName("LogFreqUnitID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LogFrequency).HasColumnType("int(11)");

                entity.Property(e => e.Lsl)
                    .HasColumnName("LSL")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ParameterDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SubElement)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Unit).HasColumnType("int(11)");

                entity.Property(e => e.Usl)
                    .HasColumnName("USL")
                    .HasColumnType("decimal(6,2)");

                entity.HasOne(d => d.Axis)
                    .WithMany(p => p.UnitworkccsConfigurationtblsensordatalink)
                    .HasForeignKey(d => d.AxisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("axisid");

                entity.HasOne(d => d.LogFreqUnit)
                    .WithMany(p => p.UnitworkccsConfigurationtblsensordatalinkLogFreqUnit)
                    .HasForeignKey(d => d.LogFreqUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("logfreqid");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.UnitworkccsConfigurationtblsensordatalinkUnitNavigation)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("unit");
            });

            modelBuilder.Entity<UnitworkccsConfigurationtblsensormaster>(entity =>
            {
                entity.HasKey(e => e.Smid);

                entity.ToTable("unitworkccs.configurationtblsensormaster", "unitworksccs");

                entity.HasIndex(e => e.Sid)
                    .HasName("SID_FK_ID");

                entity.HasIndex(e => e.Unitid)
                    .HasName("uid");

                entity.Property(e => e.Smid)
                    .HasColumnName("SMID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChannelNo).HasColumnType("int(11)");

                entity.Property(e => e.CountHigh).HasColumnType("int(11)");

                entity.Property(e => e.CountLow).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsAnalog).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MemoryAddress).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Parametertypeid)
                    .HasColumnName("parametertypeid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScalingFactor)
                    .HasColumnName("scalingFactor")
                    .HasColumnType("decimal(6,4)");

                entity.Property(e => e.SensorDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SensorlimitHigh)
                    .HasColumnName("sensorlimitHigh")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorlimitLow)
                    .HasColumnName("sensorlimitLow")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sid).HasColumnType("int(11)");

                entity.Property(e => e.Unitid).HasColumnType("int(11)");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.UnitworkccsConfigurationtblsensormaster)
                    .HasForeignKey(d => d.Sid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SID_FK_ID");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.UnitworkccsConfigurationtblsensormaster)
                    .HasForeignKey(d => d.Unitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("uid");
            });

            modelBuilder.Entity<UnitworkccsDocumentuploadermaster>(entity =>
            {
                entity.HasKey(e => e.DocumnetUploaderId);

                entity.ToTable("unitworkccs.documentuploadermaster", "unitworksccs");

                entity.Property(e => e.DocumnetUploaderId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Did).HasColumnType("int(11)");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumnetUploaderFor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath).HasColumnType("longtext");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PictureName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PicturePath).HasColumnType("longtext");
            });

            modelBuilder.Entity<UnitworkccsFrommail>(entity =>
            {
                entity.ToTable("unitworkccs.frommail", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Domain)
                    .HasColumnName("domain")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.FromEmailAdd)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Password)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsHandleNoPing>(entity =>
            {
                entity.HasKey(e => e.NoPingId);

                entity.ToTable("unitworkccs.handle_no_ping", "unitworksccs");

                entity.Property(e => e.NoPingId)
                    .HasColumnName("NoPingID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsIotgatwaypacketsdata>(entity =>
            {
                entity.HasKey(e => e.GatewayMsgId);

                entity.ToTable("unitworkccs.iotgatwaypacketsdata", "unitworksccs");

                entity.Property(e => e.GatewayMsgId)
                    .HasColumnName("GatewayMsgID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput116)
                    .HasColumnName("AlaramInput1_16")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput217)
                    .HasColumnName("AlaramInput2_17")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput318)
                    .HasColumnName("AlaramInput3_18")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput419)
                    .HasColumnName("AlaramInput4_19")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput520)
                    .HasColumnName("AlaramInput5_20")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput622)
                    .HasColumnName("AlaramInput6_22")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput723)
                    .HasColumnName("AlaramInput7_23")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlaramInput824)
                    .HasColumnName("AlaramInput8_24")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(3)");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DevicePayLoadLength)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eof)
                    .HasColumnName("EOF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IotgateWayMsg)
                    .HasColumnName("IOTGateWayMsg")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddres)
                    .HasColumnName("IPAddres")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NodeCommunication)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NodeDataPayLoad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NodeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NodePayLoadLength)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumOfNodeActive)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumOfNodeDetected)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PacketType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductSerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelayFeedbak1Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelayFeedbak2Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelayFeedbak3Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelayFeedbak4Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reserved)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sof)
                    .HasColumnName("SOF")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Swversion)
                    .HasColumnName("SWversion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfDevice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsJobcardDetails>(entity =>
            {
                entity.HasKey(e => e.JobcardId);

                entity.ToTable("unitworkccs.jobcard_details", "unitworksccs");

                entity.Property(e => e.JobcardId)
                    .HasColumnName("JobcardID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Compcode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Fromdatetime).HasColumnType("datetime(6)");

                entity.Property(e => e.Fromtime).HasColumnType("time(6)");

                entity.Property(e => e.JobCardDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineInvNumber)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OpnIdleCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.QtyAccp).HasColumnType("int(11)");

                entity.Property(e => e.QtyRej).HasColumnType("int(11)");

                entity.Property(e => e.Qtyprod).HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Slno)
                    .HasColumnName("slno")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Totalhours)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Totime).HasColumnType("time(6)");

                entity.Property(e => e.Workorderno)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsLogintrackerdetails>(entity =>
            {
                entity.HasKey(e => e.LoginTrackerDetailsId);

                entity.ToTable("unitworkccs.logintrackerdetails", "unitworksccs");

                entity.Property(e => e.LoginTrackerDetailsId)
                    .HasColumnName("loginTrackerDetailsId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentFgpart)
                    .HasColumnName("currentFGPart")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CurrentTicketRaisedId)
                    .HasColumnName("currentTicketRaisedId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn)
                    .HasColumnName("insertedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLoggedIn)
                    .HasColumnName("isLoggedIn")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.LoginDateTime)
                    .HasColumnName("loginDateTime")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.LogoutDateTime)
                    .HasColumnName("logoutDateTime")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsMachinedetailswimerasys>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("unitworkccs.machinedetailswimerasys", "unitworksccs");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.LoggerType)
                    .HasColumnName("loggerType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MachineIp)
                    .HasColumnName("machineIp")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MachineName)
                    .HasColumnName("machineName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MachinePort)
                    .HasColumnName("machinePort")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.NumOfAxis)
                    .HasColumnName("numOfAxis")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberOfCurrent)
                    .HasColumnName("numberOfCurrent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberOfLevel)
                    .HasColumnName("numberOfLevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberOfPresure)
                    .HasColumnName("numberOfPresure")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumberOfTemperature)
                    .HasColumnName("numberOfTemperature")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolGroupNum)
                    .HasColumnName("toolGroupNum")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TransmissionFrequency)
                    .HasColumnName("transmissionFrequency")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsMailmaster>(entity =>
            {
                entity.ToTable("unitworkccs.mailmaster", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bccadd)
                    .HasColumnName("BCCAdd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ccadd)
                    .HasColumnName("CCAdd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasColumnName("EmailID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Toadd)
                    .HasColumnName("TOAdd")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<UnitworkccsMessageCodeMaster>(entity =>
            {
                entity.HasKey(e => e.MessageCodeId);

                entity.ToTable("unitworkccs.message_code_master", "unitworksccs");

                entity.Property(e => e.MessageCodeId)
                    .HasColumnName("MessageCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColourCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

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

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ReportDispName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsMessageHistoryMaster>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.ToTable("unitworkccs.message_history_master", "unitworksccs");

                entity.Property(e => e.MessageId)
                    .HasColumnName("MessageID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsProgLock).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Meassage)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDate).HasColumnType("date");

                entity.Property(e => e.MessageDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.MessageNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageShift)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTime).HasColumnType("time(6)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsMonthdata>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.ToTable("unitworkccs.monthdata", "unitworksccs");

                entity.Property(e => e.MonthId)
                    .HasColumnName("MonthID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsOperationlog>(entity =>
            {
                entity.HasKey(e => e.Idoperationlog);

                entity.ToTable("unitworkccs.operationlog", "unitworksccs");

                entity.Property(e => e.Idoperationlog)
                    .HasColumnName("idoperationlog")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpDate).HasColumnType("date");

                entity.Property(e => e.OpMsg).HasColumnType("longtext");

                entity.Property(e => e.OpReason)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.OpTime).HasColumnType("time(6)");
            });

            modelBuilder.Entity<UnitworkccsParameterSendorData>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataId);

                entity.ToTable("unitworkccs.parameter_sendor_data", "unitworksccs");

                entity.Property(e => e.ParameterSensorDataId)
                    .HasColumnName("parameterSensorDataId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorDataCapturedTime)
                    .HasColumnName("sensorDataCapturedTime")
                    .HasColumnType("datetime(3)");
            });

            modelBuilder.Entity<UnitworkccsParameterSensorDataCurrent>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataCurrentId);

                entity.ToTable("unitworkccs.parameter_sensor_data_current", "unitworksccs");

                entity.Property(e => e.ParameterSensorDataCurrentId)
                    .HasColumnName("parameterSensorDataCurrentId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CurrentValue)
                    .HasColumnName("currentValue")
                    .HasColumnType("decimal(18,3)");

                entity.Property(e => e.ParameterSensorDataId)
                    .HasColumnName("parameterSensorDataID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsParameterSensorDataLevel>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataLevelId);

                entity.ToTable("unitworkccs.parameter_sensor_data_level", "unitworksccs");

                entity.Property(e => e.ParameterSensorDataLevelId)
                    .HasColumnName("parameterSensorDataLevelId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LevelValue)
                    .HasColumnName("levelValue")
                    .HasColumnType("decimal(18,3)");

                entity.Property(e => e.ParameterSensorDataId)
                    .HasColumnName("parameterSensorDataID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsParameterSensorDataPressure>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataPressureId);

                entity.ToTable("unitworkccs.parameter_sensor_data_pressure", "unitworksccs");

                entity.Property(e => e.ParameterSensorDataPressureId)
                    .HasColumnName("parameterSensorDataPressureId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParameterSensorDataId)
                    .HasColumnName("parameterSensorDataID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PressureValue)
                    .HasColumnName("pressureValue")
                    .HasColumnType("decimal(18,3)");
            });

            modelBuilder.Entity<UnitworkccsParameterSensorDataTemperature>(entity =>
            {
                entity.HasKey(e => e.ParameterSensorDataTemperatureId);

                entity.ToTable("unitworkccs.parameter_sensor_data_temperature", "unitworksccs");

                entity.Property(e => e.ParameterSensorDataTemperatureId)
                    .HasColumnName("parameterSensorDataTemperatureId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParameterSensorDataId)
                    .HasColumnName("parameterSensorDataID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TemperatureValue)
                    .HasColumnName("temperatureValue")
                    .HasColumnType("decimal(18,3)");
            });

            modelBuilder.Entity<UnitworkccsParameterToolData>(entity =>
            {
                entity.HasKey(e => e.ParameterToolDataId);

                entity.ToTable("unitworkccs.parameter_tool_data", "unitworksccs");

                entity.Property(e => e.ParameterToolDataId)
                    .HasColumnName("parameterToolDataId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParameterToolDataCapturedDate)
                    .HasColumnName("parameterToolDataCapturedDate")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.Partsproduced)
                    .HasColumnName("partsproduced")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolGroupName)
                    .HasColumnName("toolGroupName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolNumber)
                    .HasColumnName("toolNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsParametersMaster>(entity =>
            {
                entity.HasKey(e => e.ParameterId);

                entity.ToTable("unitworkccs.parameters_master", "unitworksccs");

                entity.Property(e => e.ParameterId)
                    .HasColumnName("ParameterID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoCutTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.AutoMode).HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CuttingTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatingTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartsTotal).HasColumnType("int(11)");

                entity.Property(e => e.PowerOnTime)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.SetupTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift).HasColumnType("int(11)");

                entity.Property(e => e.TotalCutTime)
                    .HasColumnName("Total_CutTime")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsPcbDetails>(entity =>
            {
                entity.HasKey(e => e.Pcbid);

                entity.ToTable("unitworkccs.pcb_details", "unitworksccs");

                entity.Property(e => e.Pcbid)
                    .HasColumnName("PCBID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbmacaddress)
                    .HasColumnName("PCBMACAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Pcbno)
                    .HasColumnName("PCBNo")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsPcbParameters>(entity =>
            {
                entity.HasKey(e => e.ParameterId);

                entity.ToTable("unitworkccs.pcb_parameters", "unitworksccs");

                entity.Property(e => e.ParameterId)
                    .HasColumnName("ParameterID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HighValue)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPulse)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LogFile)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ParameterType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PinNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsPcbdaq>(entity =>
            {
                entity.HasKey(e => e.Pcbdaqid);

                entity.ToTable("unitworkccs.pcbdaq", "unitworksccs");

                entity.Property(e => e.Pcbdaqid)
                    .HasColumnName("PCBDAQID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ParamValue).HasColumnType("int(11)");

                entity.Property(e => e.PcbdateTime)
                    .HasColumnName("PCBDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PinNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsPcbdaqinTbl>(entity =>
            {
                entity.HasKey(e => e.Daqinid);

                entity.ToTable("unitworkccs.pcbdaqin_tbl", "unitworksccs");

                entity.Property(e => e.Daqinid)
                    .HasColumnName("DAQINID")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.ParamPin)
                    .HasColumnName("ParamPIN")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ParamValue).HasColumnType("int(11)");

                entity.Property(e => e.Pcbipaddress)
                    .IsRequired()
                    .HasColumnName("PCBIPAddress")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsPcbdpsMaster>(entity =>
            {
                entity.HasKey(e => e.PcbDpsMasterId);

                entity.ToTable("unitworkccs.pcbdps_master", "unitworksccs");

                entity.Property(e => e.PcbDpsMasterId)
                    .HasColumnName("PcbDpsMasterID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorValue)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pin17).HasColumnType("int(11)");

                entity.Property(e => e.Pin18).HasColumnType("int(11)");

                entity.Property(e => e.Pin19).HasColumnType("int(11)");

                entity.Property(e => e.Pin20).HasColumnType("int(11)");

                entity.Property(e => e.Pin22).HasColumnType("int(11)");

                entity.Property(e => e.Pin23).HasColumnType("int(11)");

                entity.Property(e => e.Pin24).HasColumnType("int(11)");

                entity.Property(e => e.Pin25).HasColumnType("int(11)");

                entity.Property(e => e.Pin26).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsPinghandlerTbl>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("unitworkccs.pinghandler_tbl", "unitworksccs");

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pingcount).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsProgramExecutionMaster>(entity =>
            {
                entity.HasKey(e => e.ProgramExecutionId);

                entity.ToTable("unitworkccs.program_execution_master", "unitworksccs");

                entity.Property(e => e.ProgramExecutionId)
                    .HasColumnName("programExecutionId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProgramEndDateTime)
                    .HasColumnName("programEndDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProgramExcutedDateTime)
                    .HasColumnName("programExcutedDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProgramName)
                    .HasColumnName("programName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramStartDateTime)
                    .HasColumnName("programStartDateTime")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsProgramMaster>(entity =>
            {
                entity.HasKey(e => e.ProgramId);

                entity.ToTable("unitworkccs.program_master", "unitworksccs");

                entity.Property(e => e.ProgramId)
                    .HasColumnName("ProgramID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.PartsAccepted1).HasColumnType("int(11)");

                entity.Property(e => e.PartsAccepted2).HasColumnType("int(11)");

                entity.Property(e => e.PartsAccepted3).HasColumnType("int(11)");

                entity.Property(e => e.PartsProduced1).HasColumnType("int(11)");

                entity.Property(e => e.PartsProduced2).HasColumnType("int(11)");

                entity.Property(e => e.PartsProduced3).HasColumnType("int(11)");

                entity.Property(e => e.PartsRejected1).HasColumnType("int(11)");

                entity.Property(e => e.PartsRejected2).HasColumnType("int(11)");

                entity.Property(e => e.PartsRejected3).HasColumnType("int(11)");

                entity.Property(e => e.ProgramDate).HasColumnType("date");

                entity.Property(e => e.ProgramDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.ProgramTime).HasColumnType("time(6)");

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

            modelBuilder.Entity<UnitworkccsSapfilegenerateddetails>(entity =>
            {
                entity.HasKey(e => e.SapFileGeneratedId);

                entity.ToTable("unitworkccs.sapfilegenerateddetails", "unitworksccs");

                entity.Property(e => e.SapFileGeneratedId)
                    .HasColumnName("sapFileGeneratedId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SapFileGeneratedDate)
                    .HasColumnName("sapFileGeneratedDate")
                    .HasColumnType("date");

                entity.Property(e => e.SapFileGeneratedHour)
                    .HasColumnName("sapFileGeneratedHour")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SapFileNameGenerated)
                    .HasColumnName("sapFileNameGenerated")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCountOfRows).HasColumnType("bigint(20)");
            });

            modelBuilder.Entity<UnitworkccsSharathtable>(entity =>
            {
                entity.HasKey(e => e.Sharathid);

                entity.ToTable("unitworkccs.sharathtable", "unitworksccs");

                entity.Property(e => e.Sharathid)
                    .HasColumnName("sharathid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mcid)
                    .HasColumnName("MCID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sharathname)
                    .HasColumnName("sharathname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sharathvalue)
                    .HasColumnName("sharathvalue")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Syncid)
                    .HasColumnName("syncid")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabSharathId)
                    .HasColumnName("TabSharathID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsShiftMaster>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("unitworkccs.shift_master", "unitworksccs");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("time(6)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("time(6)");
            });

            modelBuilder.Entity<UnitworkccsSmtpdetails>(entity =>
            {
                entity.HasKey(e => e.SmtpId);

                entity.ToTable("unitworkccs.smtpdetails", "unitworksccs");

                entity.Property(e => e.SmtpId)
                    .HasColumnName("smtpID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Certificate)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EnableSsl)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Port).HasColumnType("int(11)");

                entity.Property(e => e.UseDefaultCredentials)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitworkccsTblAutoreportLog>(entity =>
            {
                entity.HasKey(e => e.AutoReportLogId);

                entity.ToTable("unitworkccs.tbl_autoreport_log", "unitworksccs");

                entity.HasIndex(e => e.AutoReportId)
                    .HasName("tbl_autoreport_log$AutoReportID");

                entity.Property(e => e.AutoReportLogId)
                    .HasColumnName("AutoReportLogID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoReportId)
                    .HasColumnName("AutoReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompletedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.ExcelCreated)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExcelCreatedTime).HasColumnType("datetime(6)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.MailSent)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AutoReport)
                    .WithMany(p => p.UnitworkccsTblAutoreportLog)
                    .HasForeignKey(d => d.AutoReportId)
                    .HasConstraintName("tbl_autoreport_log$AutoReportID");
            });

            modelBuilder.Entity<UnitworkccsTblAutoreportbasedon>(entity =>
            {
                entity.HasKey(e => e.BasedOnId);

                entity.ToTable("unitworkccs.tbl_autoreportbasedon", "unitworksccs");

                entity.Property(e => e.BasedOnId)
                    .HasColumnName("BasedOnID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BasedOn)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Desc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblAutoreportsetting>(entity =>
            {
                entity.HasKey(e => e.AutoReportId);

                entity.ToTable("unitworkccs.tbl_autoreportsetting", "unitworksccs");

                entity.HasIndex(e => e.AutoReportTimeId)
                    .HasName("tbl_autoreportsetting$ReportTimeID");

                entity.HasIndex(e => e.BasedOn)
                    .HasName("tbl_autoreportsetting$BasedOnID");

                entity.HasIndex(e => e.PlantId)
                    .HasName("tbl_autoreportsetting$ReportPlantID");

                entity.HasIndex(e => e.ReportId)
                    .HasName("tbl_autoreportsetting$ReportID");

                entity.HasIndex(e => e.ShopId)
                    .HasName("tbl_autoreportsetting$ReportShopID");

                entity.Property(e => e.AutoReportId)
                    .HasColumnName("AutoReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoReportTimeId)
                    .HasColumnName("AutoReportTimeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BasedOn).HasColumnType("int(11)");

                entity.Property(e => e.CcmailList)
                    .HasColumnName("CCMailList")
                    .HasColumnType("longtext");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NextRunDate).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToMailList).HasColumnType("longtext");

                entity.HasOne(d => d.AutoReportTime)
                    .WithMany(p => p.UnitworkccsTblAutoreportsetting)
                    .HasForeignKey(d => d.AutoReportTimeId)
                    .HasConstraintName("tbl_autoreportsetting$ReportTimeID");

                entity.HasOne(d => d.BasedOnNavigation)
                    .WithMany(p => p.UnitworkccsTblAutoreportsetting)
                    .HasForeignKey(d => d.BasedOn)
                    .HasConstraintName("tbl_autoreportsetting$BasedOnID");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblAutoreportsetting)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tbl_autoreportsetting$ReportPlantID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.UnitworkccsTblAutoreportsetting)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("tbl_autoreportsetting$ReportID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblAutoreportsetting)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tbl_autoreportsetting$ReportShopID");
            });

            modelBuilder.Entity<UnitworkccsTblAutoreporttime>(entity =>
            {
                entity.HasKey(e => e.AutoReportTimeId);

                entity.ToTable("unitworkccs.tbl_autoreporttime", "unitworksccs");

                entity.Property(e => e.AutoReportTimeId)
                    .HasColumnName("AutoReportTimeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoReportTime)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Description)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblAxisdet>(entity =>
            {
                entity.HasKey(e => e.AxisDetId);

                entity.ToTable("unitworkccs.tbl_axisdet", "unitworksccs");

                entity.Property(e => e.AxisDetId)
                    .HasColumnName("AxisDetID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AxisId)
                    .HasColumnName("AxisID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AxisName)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.SpindlePath)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");
            });

            modelBuilder.Entity<UnitworkccsTblAxisdetails1>(entity =>
            {
                entity.HasKey(e => e.Adid);

                entity.ToTable("unitworkccs.tbl_axisdetails1", "unitworksccs");

                entity.Property(e => e.Adid)
                    .HasColumnName("ADID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AbsPos).HasColumnType("decimal(10,3)");

                entity.Property(e => e.Axis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DistPos).HasColumnType("decimal(10,3)");

                entity.Property(e => e.EndTime).HasColumnType("datetime(3)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(3)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MacPos).HasColumnType("decimal(10,3)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RelPos).HasColumnType("decimal(10,3)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(3)");
            });

            modelBuilder.Entity<UnitworkccsTblAxisdetails2>(entity =>
            {
                entity.HasKey(e => e.Ad2id);

                entity.ToTable("unitworkccs.tbl_axisdetails2", "unitworksccs");

                entity.Property(e => e.Ad2id)
                    .HasColumnName("AD2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FeedRate).HasColumnType("decimal(10,3)");

                entity.Property(e => e.FeedRatePercentage).HasColumnType("decimal(10,3)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SpindleLoad).HasColumnType("decimal(10,3)");

                entity.Property(e => e.SpindleSpeed).HasColumnType("decimal(10,3)");
            });

            modelBuilder.Entity<UnitworkccsTblCategorynames>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("unitworkccs.tbl_categorynames", "unitworksccs");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NodifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.PlantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblChecklistmachines>(entity =>
            {
                entity.ToTable("unitworkccs.tbl_checklistmachines", "unitworksccs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CheckListHeaderId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsActive).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineIds)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MakeId).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblCycletimeanalysis>(entity =>
            {
                entity.HasKey(e => e.Ctaid);

                entity.ToTable("unitworkccs.tbl_cycletimeanalysis", "unitworksccs");

                entity.Property(e => e.Ctaid)
                    .HasColumnName("CTAID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvgLoadTimeinMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.AvgOperatingTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.AvgOperatingTimeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.LossTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.LossTimeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatingTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.OperatingTimeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartsCount).HasColumnType("int(11)");

                entity.Property(e => e.StdCycleTime)
                    .HasColumnName("Std_CycleTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.StdCycleTimeUnit)
                    .HasColumnName("Std_CycleTimeUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StdLoadTime)
                    .HasColumnName("Std_LoadTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.StdLoadTimeUnit)
                    .HasColumnName("Std_LoadTimeUnit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLoadTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalLoadTimeUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblDeletedprogdet>(entity =>
            {
                entity.HasKey(e => e.ProgDeletedId);

                entity.ToTable("unitworkccs.tbl_deletedprogdet", "unitworksccs");

                entity.Property(e => e.ProgDeletedId)
                    .HasColumnName("ProgDeletedID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ProgramData)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ProgramNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblGenericfilepath>(entity =>
            {
                entity.HasKey(e => e.FilePathId);

                entity.ToTable("unitworkccs.tbl_genericfilepath", "unitworksccs");

                entity.Property(e => e.FilePathId)
                    .HasColumnName("FilePathID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CompleteFilePath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.FilePathDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FilePathDet)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.TypeofFilePath).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblLivecbmdetails>(entity =>
            {
                entity.HasKey(e => e.Cbmdetailsid);

                entity.ToTable("unitworkccs.tbl_livecbmdetails", "unitworksccs");

                entity.Property(e => e.Cbmdetailsid)
                    .HasColumnName("cbmdetailsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorMasterId)
                    .HasColumnName("SensorMasterID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorValues).HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblLivecbmparameters>(entity =>
            {
                entity.HasKey(e => e.CbmpId);

                entity.ToTable("unitworkccs.tbl_livecbmparameters", "unitworksccs");

                entity.Property(e => e.CbmpId)
                    .HasColumnName("cbmpID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsConverted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MemoryAddress).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.SensorGroupId)
                    .HasColumnName("SensorGroupID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorValue).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblLivetblsensorvalue>(entity =>
            {
                entity.HasKey(e => e.Sensorvalueid);

                entity.ToTable("unitworkccs.tbl_livetblsensorvalue", "unitworksccs");

                entity.Property(e => e.Sensorvalueid)
                    .HasColumnName("sensorvalueid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsConverted).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorMasterId)
                    .HasColumnName("SensorMasterID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SensorValues)
                    .HasColumnName("sensorValues")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ValueDateTime).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblMachinemakedetails>(entity =>
            {
                entity.HasKey(e => e.MakeId);

                entity.ToTable("unitworkccs.tbl_machinemakedetails", "unitworksccs");

                entity.Property(e => e.MakeId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsActive).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineCategoryId).HasColumnType("int(11)");

                entity.Property(e => e.MakeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblOeedetails>(entity =>
            {
                entity.HasKey(e => e.Oeeid);

                entity.ToTable("unitworkccs.tbl_oeedetails", "unitworksccs");

                entity.Property(e => e.Oeeid)
                    .HasColumnName("OEEID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualQty)
                    .HasColumnName("actualQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvSumNumerator).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Availability).HasColumnType("decimal(18,2)");

                entity.Property(e => e.AvsumDenominator).HasColumnType("decimal(18,2)");

                entity.Property(e => e.BdTime)
                    .HasColumnName("bdTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DryRunQty)
                    .HasColumnName("dryRunQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLossTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Oee)
                    .HasColumnName("OEE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.OkQty)
                    .HasColumnName("okQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatingTimeinMin).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PerSumDenominator)
                    .HasColumnName("perSumDenominator")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.PerSumNumerator).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Performance).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PerformanceFactor).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOffTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOnTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.QntSumDenominator).HasColumnType("decimal(18,2)");

                entity.Property(e => e.QntSumNumerator).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Quality).HasColumnType("decimal(18,2)");

                entity.Property(e => e.RejectionQty)
                    .HasColumnName("rejectionQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReworkQty)
                    .HasColumnName("reworkQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalIdletimeinMin)
                    .HasColumnName("TotalIDLETimeinMin")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalPartsCount).HasColumnType("int(11)");

                entity.Property(e => e.TotalTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TrialPartCount)
                    .HasColumnName("trialPartCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("workOrderNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblOeeoperatordetails>(entity =>
            {
                entity.HasKey(e => e.Oeeid);

                entity.ToTable("unitworkccs.tbl_oeeoperatordetails", "unitworksccs");

                entity.Property(e => e.Oeeid)
                    .HasColumnName("OEEID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualQty)
                    .HasColumnName("actualQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Availability).HasColumnType("decimal(18,2)");

                entity.Property(e => e.BdTime)
                    .HasColumnName("bdTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DryRunQty)
                    .HasColumnName("dryRunQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLossTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Oee)
                    .HasColumnName("OEE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.OkQty)
                    .HasColumnName("okQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatingTimeinMin).HasColumnType("decimal(18,2)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Performance).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PerformanceFactor).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOffTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOnTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Quality).HasColumnType("decimal(18,2)");

                entity.Property(e => e.RejectionQty)
                    .HasColumnName("rejectionQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReworkQty)
                    .HasColumnName("reworkQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalIdletimeinMin)
                    .HasColumnName("TotalIDLETimeinMin")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalPartsCount).HasColumnType("int(11)");

                entity.Property(e => e.TotalTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TrialPartCount)
                    .HasColumnName("trialPartCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("workOrderNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblOeereportasdivision>(entity =>
            {
                entity.HasKey(e => e.Lid);

                entity.ToTable("unitworkccs.tbl_oeereportasdivision", "unitworksccs");

                entity.Property(e => e.Lid)
                    .HasColumnName("LID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.LossDuration)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LossId)
                    .HasColumnName("LossID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblOeeshiftdetails>(entity =>
            {
                entity.HasKey(e => e.Oeeid);

                entity.ToTable("unitworkccs.tbl_oeeshiftdetails", "unitworksccs");

                entity.Property(e => e.Oeeid)
                    .HasColumnName("OEEID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualQty)
                    .HasColumnName("actualQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Availability).HasColumnType("decimal(18,2)");

                entity.Property(e => e.BdTime)
                    .HasColumnName("bdTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DryRunQty)
                    .HasColumnName("dryRunQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLossTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Oee)
                    .HasColumnName("OEE")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.OkQty)
                    .HasColumnName("okQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatingTimeinMin).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Performance).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PerformanceFactor).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOffTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOnTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Quality).HasColumnType("decimal(18,2)");

                entity.Property(e => e.RejectionQty)
                    .HasColumnName("rejectionQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReworkQty)
                    .HasColumnName("reworkQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalIdletimeinMin)
                    .HasColumnName("TotalIDLETimeinMin")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalPartsCount).HasColumnType("int(11)");

                entity.Property(e => e.TotalTimeInMinutes).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TrialPartCount)
                    .HasColumnName("trialPartCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("workOrderNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblPmsdashboardchecklist>(entity =>
            {
                entity.ToTable("unitworkccs.tbl_pmsdashboardchecklist", "unitworksccs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CheckListDetailsId).HasColumnType("int(11)");

                entity.Property(e => e.CheckListHeaderId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsApproved).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsNumaric).HasColumnType("tinyint(1)");

                entity.Property(e => e.IsText).HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NumaricComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnType("int(11)");

                entity.Property(e => e.TextComment)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblProdandondisp>(entity =>
            {
                entity.HasKey(e => e.ProdDashboardId);

                entity.ToTable("unitworkccs.tbl_prodandondisp", "unitworksccs");

                entity.HasIndex(e => e.Woid)
                    .HasName("FK_tbl_ProdAndonDisp_tblworkorderentry");

                entity.Property(e => e.ProdDashboardId)
                    .HasColumnName("ProdDashboardID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TotalLoss)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalOperatingTime)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalSetup)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.UtilPercent).HasColumnType("decimal(6,2)");

                entity.Property(e => e.Woid)
                    .HasColumnName("WOID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.UnitworkccsTblProdandondisp)
                    .HasForeignKey(d => d.Woid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tbl_ProdAndonDisp_tblworkorderentry");
            });

            modelBuilder.Entity<UnitworkccsTblProdmanmachine>(entity =>
            {
                entity.HasKey(e => e.ProdManMachineId);

                entity.ToTable("unitworkccs.tbl_prodmanmachine", "unitworksccs");

                entity.HasIndex(e => e.Woid)
                    .HasName("FgIdFk_idx");

                entity.Property(e => e.ProdManMachineId)
                    .HasColumnName("ProdManMachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(3)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PerformancePerCent)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.PerfromaceFactor)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.QualityPercent)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalLoss).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalMinorLoss).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalOperatingTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalPowerLoss)
                    .HasColumnType("decimal(18,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalSetup).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalSetupMinorLoss).HasColumnType("decimal(18,2)");

                entity.Property(e => e.UtilPercent).HasColumnType("decimal(6,2)");

                entity.Property(e => e.Woid)
                    .HasColumnName("WOID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.UnitworkccsTblProdmanmachine)
                    .HasForeignKey(d => d.Woid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WOID");
            });

            modelBuilder.Entity<UnitworkccsTblProdorderlosses>(entity =>
            {
                entity.HasKey(e => e.ProdOrderlossId);

                entity.ToTable("unitworkccs.tbl_prodorderlosses", "unitworksccs");

                entity.Property(e => e.ProdOrderlossId)
                    .HasColumnName("ProdOrderlossID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.LossCodeL1id)
                    .HasColumnName("LossCodeL1ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LossCodeL2id)
                    .HasColumnName("LossCodeL2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LossDuration).HasColumnType("bigint(20)");

                entity.Property(e => e.LossId)
                    .HasColumnName("LossID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Woid)
                    .HasColumnName("WOID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblReportmaster>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.ToTable("unitworkccs.tbl_reportmaster", "unitworksccs");

                entity.Property(e => e.ReportId)
                    .HasColumnName("ReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

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

            modelBuilder.Entity<UnitworkccsTblSavencprogver>(entity =>
            {
                entity.HasKey(e => e.NcprogVerId);

                entity.ToTable("unitworkccs.tbl_savencprogver", "unitworksccs");

                entity.Property(e => e.NcprogVerId)
                    .HasColumnName("NCProgVerID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ProgramData).HasColumnType("longtext");

                entity.Property(e => e.ProgramNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblScreenpagesdetails>(entity =>
            {
                entity.HasKey(e => e.ScreenId);

                entity.ToTable("unitworkccs.tbl_screenpagesdetails", "unitworksccs");

                entity.Property(e => e.ScreenId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatredOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ScreenDisc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScreenUrl)
                    .HasColumnName("ScreenURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblServodetails>(entity =>
            {
                entity.HasKey(e => e.Sdid);

                entity.ToTable("unitworkccs.tbl_servodetails", "unitworksccs");

                entity.Property(e => e.Sdid)
                    .HasColumnName("SDID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Insertedby).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.LoadCurrent).HasColumnType("decimal(6,3)");

                entity.Property(e => e.LoadCurrentAmp).HasColumnType("decimal(6,3)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServoAxis)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ServoLoadMeter).HasColumnType("decimal(6,3)");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblUtilreport>(entity =>
            {
                entity.HasKey(e => e.UtilReportId);

                entity.ToTable("unitworkccs.tbl_utilreport", "unitworksccs");

                entity.Property(e => e.UtilReportId)
                    .HasColumnName("UtilReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Bdtime)
                    .HasColumnName("BDTime")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(3)");

                entity.Property(e => e.LossTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLossTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.OperatingTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.PowerOffTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.SetupMinorTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.SetupTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.TotalTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.UtilPercent).HasColumnType("decimal(6,2)");
            });

            modelBuilder.Entity<UnitworkccsTblactivitylog>(entity =>
            {
                entity.HasKey(e => e.TrackId);

                entity.ToTable("unitworkccs.tblactivitylog", "unitworksccs");

                entity.Property(e => e.TrackId)
                    .HasColumnName("TrackID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.Idoperationlog).HasColumnType("int(11)");

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpDate).HasColumnType("date");

                entity.Property(e => e.OpDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.OpTime)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblandondispdet>(entity =>
            {
                entity.HasKey(e => e.Andondispid);

                entity.ToTable("unitworkccs.tblandondispdet", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("FK_tblAndonDispDEt_tblplant");

                entity.HasIndex(e => e.ShopId)
                    .HasName("FK_tblAndonDispDEt_tblshop");

                entity.Property(e => e.Andondispid)
                    .HasColumnName("ANDONDISPID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblandondispdet)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAndonDispDEt_tblplant");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblandondispdet)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_tblAndonDispDEt_tblshop");
            });

            modelBuilder.Entity<UnitworkccsTblandondisplayrotate>(entity =>
            {
                entity.HasKey(e => e.AndOnDisplId);

                entity.ToTable("unitworkccs.tblandondisplayrotate", "unitworksccs");

                entity.Property(e => e.AndOnDisplId)
                    .HasColumnName("AndOnDisplID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RefCounter)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitworkccsTblandonimagetextscheduleddisplay>(entity =>
            {
                entity.HasKey(e => e.TextImageAndonId);

                entity.ToTable("unitworkccs.tblandonimagetextscheduleddisplay", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("FK_tblAndonImageTextScheduledDisplay_tblplant");

                entity.HasIndex(e => e.ShopId)
                    .HasName("FK_tblAndonImageTextScheduledDisplay_tblshop");

                entity.Property(e => e.TextImageAndonId).HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefaultScreenVisible).HasColumnType("int(11)");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.FlagEnd).HasColumnType("int(11)");

                entity.Property(e => e.FlagStart).HasColumnType("int(11)");

                entity.Property(e => e.ImageName).HasColumnType("longtext");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScreenType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.TextToDisplay).HasColumnType("longtext");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblandonimagetextscheduleddisplay)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK_tblAndonImageTextScheduledDisplay_tblplant");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblandonimagetextscheduleddisplay)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_tblAndonImageTextScheduledDisplay_tblshop");
            });

            modelBuilder.Entity<UnitworkccsTblappPaths>(entity =>
            {
                entity.HasKey(e => e.AppPathsId);

                entity.ToTable("unitworkccs.tblapp_paths", "unitworksccs");

                entity.Property(e => e.AppPathsId)
                    .HasColumnName("AppPathsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AppName)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.AppPath)
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitworkccsTblatccounter>(entity =>
            {
                entity.HasKey(e => e.Atcid);

                entity.ToTable("unitworkccs.tblatccounter", "unitworksccs");

                entity.HasIndex(e => e.Atcid)
                    .HasName("tblatccounter$ATCID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Atcid)
                    .HasColumnName("ATCID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Counter).HasColumnType("int(11)");

                entity.Property(e => e.CycleEndTime).HasColumnType("datetime(3)");

                entity.Property(e => e.CycleStartTime).HasColumnType("datetime(3)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ToolNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblbookstock>(entity =>
            {
                entity.HasKey(e => e.BookStockId);

                entity.ToTable("unitworkccs.tblbookstock", "unitworksccs");

                entity.Property(e => e.BookStockId)
                    .HasColumnName("bookStockId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BookStockDesc)
                    .HasColumnName("bookStockDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BookStockName)
                    .HasColumnName("bookStockName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.SapBatch)
                    .HasColumnName("sapBatch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SapLoaction)
                    .HasColumnName("sapLoaction")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolSapCode)
                    .HasColumnName("toolSapCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblbottelneck>(entity =>
            {
                entity.HasKey(e => e.Bid);

                entity.ToTable("unitworkccs.tblbottelneck", "unitworksccs");

                entity.HasIndex(e => e.Cpid)
                    .HasName("cpid");

                entity.HasIndex(e => e.PlantId)
                    .HasName("PlantID");

                entity.HasIndex(e => e.ShopId)
                    .HasName("ShopID");

                entity.Property(e => e.Bid).HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Cpid)
                    .HasColumnName("cpid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PartNo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.UnitworkccsTblbottelneck)
                    .HasForeignKey(d => d.Cpid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("cpid");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblbottelneck)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PlantID");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblbottelneck)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ShopID");
            });

            modelBuilder.Entity<UnitworkccsTblbreakdown>(entity =>
            {
                entity.HasKey(e => e.BreakdownId);

                entity.ToTable("unitworkccs.tblbreakdown", "unitworksccs");

                entity.HasIndex(e => e.BreakDownCode)
                    .HasName("breakDownIdFK_idx");

                entity.Property(e => e.BreakdownId)
                    .HasColumnName("BreakdownID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakDownCode).HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblbreakdownReportdetails>(entity =>
            {
                entity.ToTable("unitworkccs.tblbreakdown_reportdetails", "unitworksccs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.BreakdownTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DryRunTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ElectricalMaintenance).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ElectricalMaintenance1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.HumanResource).HasColumnType("decimal(18,2)");

                entity.Property(e => e.HumanResource1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.IsCreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.LoadUnloadTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.LossOrIdleTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.MachineId).HasColumnType("int(11)");

                entity.Property(e => e.MechanicalMaintenance).HasColumnType("decimal(18,2)");

                entity.Property(e => e.MechanicalMaintenance1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.OperatingTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Planning).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Planning1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.PowerOffOrDataLossTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Production).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Production1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Quality).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Quality1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.SetUpTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ToolingStoppage).HasColumnType("decimal(18,2)");

                entity.Property(e => e.ToolingStoppage1).HasColumnType("decimal(18,2)");

                entity.Property(e => e.TotalTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Utilization).HasColumnType("decimal(18,2)");
            });

            modelBuilder.Entity<UnitworkccsTblbreakdowncodes>(entity =>
            {
                entity.HasKey(e => e.BreakdownId);

                entity.ToTable("unitworkccs.tblbreakdowncodes", "unitworksccs");

                entity.Property(e => e.BreakdownId)
                    .HasColumnName("BreakdownID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakdownCode)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BreakdownDesc)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.BreakdownLevel).HasColumnType("int(11)");

                entity.Property(e => e.BreakdownLevel1Id)
                    .HasColumnName("BreakdownLevel1ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakdownLevel2Id)
                    .HasColumnName("BreakdownLevel2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContributeTo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.EndCode).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ServerTabCheck)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerTabFlagSync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetPercent)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.01");
            });

            modelBuilder.Entity<UnitworkccsTblbreakdowntickect>(entity =>
            {
                entity.ToTable("unitworkccs.tblbreakdowntickect", "unitworksccs");

                entity.HasIndex(e => e.ReasonId)
                    .HasName("BreakdownCodesFk_idx");

                entity.HasIndex(e => e.WoId)
                    .HasName("WoidFk_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AcceptFlage)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.BdTktDateTime)
                    .HasColumnName("bdTktDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaintFinished)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaintFlage)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaintRejId)
                    .HasColumnName("maintRejId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MntAcpRejDateTime)
                    .HasColumnName("mntAcp/RejDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.MntClosureOpId)
                    .HasColumnName("mntClosureOpId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MntOpId)
                    .HasColumnName("mntOpId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MntRemarks)
                    .HasColumnName("mntRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MntRrejectReason)
                    .HasColumnName("mntRrejectReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MntStatus)
                    .HasColumnName("mntStatus")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProdAcpRejDateTime)
                    .HasColumnName("prodAcp/RejDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProdFinished)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ProdOpId)
                    .HasColumnName("prodOpId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProdRejId)
                    .HasColumnName("prodRejId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProdRemarks)
                    .HasColumnName("prodRemarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdStatus)
                    .HasColumnName("prodStatus")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TktClosingTime)
                    .HasColumnName("tktClosingTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.WoId)
                    .HasColumnName("woId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblbusinessdetails>(entity =>
            {
                entity.HasKey(e => e.BusinessId);

                entity.ToTable("unitworkccs.tblbusinessdetails", "unitworksccs");

                entity.Property(e => e.BusinessId).HasColumnType("int(11)");

                entity.Property(e => e.BusinessDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Createdby).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblcategory>(entity =>
            {
                entity.HasKey(e => e.ControlPlanCatId);

                entity.ToTable("unitworkccs.tblcategory", "unitworksccs");

                entity.Property(e => e.ControlPlanCatId)
                    .HasColumnName("controlPlanCatId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblcategorydetails>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("unitworkccs.tblcategorydetails", "unitworksccs");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CategoryIdDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblcategorymaster>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("unitworkccs.tblcategorymaster", "unitworksccs");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryDesc)
                    .HasColumnName("categoryDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .HasColumnName("categoryName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblcell>(entity =>
            {
                entity.HasKey(e => e.CellId);

                entity.ToTable("unitworkccs.tblcell", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("plantFK_idx");

                entity.HasIndex(e => e.ShopId)
                    .HasName("FK_shopid");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CellName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CelldisplayName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.DefaultFlag)
                    .HasColumnName("defaultFlag")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblcell)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("unitworkccs.tblcell_ibfk_1");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblcell)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_shopid");
            });

            modelBuilder.Entity<UnitworkccsTblcellfinalmaster>(entity =>
            {
                entity.HasKey(e => e.CellFinalId);

                entity.ToTable("unitworkccs.tblcellfinalmaster", "unitworksccs");

                entity.Property(e => e.CellFinalId)
                    .HasColumnName("cellFinalId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellFinalDesc)
                    .HasColumnName("cellFinalDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CellFinalName)
                    .HasColumnName("cellFinalName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblcellpart>(entity =>
            {
                entity.HasKey(e => e.CpId);

                entity.ToTable("unitworkccs.tblcellpart", "unitworksccs");

                entity.Property(e => e.CpId)
                    .HasColumnName("cpID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDefault).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PartDescription)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblchecklistDetails>(entity =>
            {
                entity.HasKey(e => e.CheckListId);

                entity.ToTable("unitworkccs.tblchecklist_details", "unitworksccs");

                entity.Property(e => e.CheckListId)
                    .HasColumnName("checkListId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Date)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderId).HasColumnType("int(11)");

                entity.Property(e => e.How)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved).HasColumnType("int(11)");

                entity.Property(e => e.IsDashBoardEntry).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsEdited)
                    .HasColumnName("isEdited")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsNumeric).HasColumnType("tinyint(1)");

                entity.Property(e => e.IsOk)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrepared).HasColumnType("int(11)");

                entity.Property(e => e.IsText).HasColumnType("tinyint(1)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NumericValue).HasColumnType("int(11)");

                entity.Property(e => e.PartsCount).HasColumnType("int(11)");

                entity.Property(e => e.PeriodFrequency)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousChecklistId)
                    .HasColumnName("previousChecklistId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RunningHrs)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextValue)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WhatToCheck)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblchecklistHeader>(entity =>
            {
                entity.HasKey(e => e.HeaderId);

                entity.ToTable("unitworkccs.tblchecklist_header", "unitworksccs");

                entity.Property(e => e.HeaderId).HasColumnType("int(11)");

                entity.Property(e => e.ApprovedBy).HasColumnType("int(11)");

                entity.Property(e => e.ApprovedByDate).HasColumnType("datetime(6)");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CheckListNo)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.CreationDate).HasColumnType("datetime(6)");

                entity.Property(e => e.IsApproved).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsEditApproved).HasColumnType("int(11)");

                entity.Property(e => e.IsPrepared).HasColumnType("int(11)");

                entity.Property(e => e.LastRevDate).HasColumnType("datetime(6)");

                entity.Property(e => e.MakeId).HasColumnType("int(11)");

                entity.Property(e => e.MakeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId).HasColumnType("int(11)");

                entity.Property(e => e.PlantName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedBy).HasColumnType("int(11)");

                entity.Property(e => e.PreparedByDate).HasColumnType("datetime(6)");

                entity.Property(e => e.PreviousChecklistHeaderId)
                    .HasColumnName("previousChecklistHeaderId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RevNo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblchecklistdetailsnew>(entity =>
            {
                entity.HasKey(e => e.CheckListNewId);

                entity.ToTable("unitworkccs.tblchecklistdetailsnew", "unitworksccs");

                entity.Property(e => e.CheckListNewId)
                    .HasColumnName("checkListNewId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AddEdit)
                    .HasColumnName("addEdit")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CheckListId)
                    .HasColumnName("checkListId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderId)
                    .HasColumnName("headerId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.How)
                    .HasColumnName("how")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsApproved)
                    .HasColumnName("isApproved")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsAssigned)
                    .HasColumnName("isAssigned")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDashBoardEntry)
                    .HasColumnName("isDashBoardEntry")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsNumeric)
                    .HasColumnName("isNumeric")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.IsOk)
                    .HasColumnName("isOk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrepared)
                    .HasColumnName("isPrepared")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsText)
                    .HasColumnName("isText")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.NumericValue)
                    .HasColumnName("numericValue")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartsCount)
                    .HasColumnName("partsCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PeriodFrequency)
                    .HasColumnName("periodFrequency")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RunningHrs)
                    .HasColumnName("runningHrs")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TextValue)
                    .HasColumnName("textValue")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WhatToCheck)
                    .HasColumnName("whatToCheck")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblchildfgpartno>(entity =>
            {
                entity.HasKey(e => e.ChildFgpartId);

                entity.ToTable("unitworkccs.tblchildfgpartno", "unitworksccs");

                entity.Property(e => e.ChildFgpartId)
                    .HasColumnName("childFgpartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChildFgPartNo)
                    .HasColumnName("childFgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ChildPartNoDesc)
                    .HasColumnName("childPartNoDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.FgPartDesc)
                    .HasColumnName("fgPartDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblclassmaster>(entity =>
            {
                entity.HasKey(e => e.ClassId);

                entity.ToTable("unitworkccs.tblclassmaster", "unitworksccs");

                entity.Property(e => e.ClassId)
                    .HasColumnName("classId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassDesc)
                    .HasColumnName("classDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClassName)
                    .HasColumnName("className")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblcontrolplan>(entity =>
            {
                entity.HasKey(e => e.CpId);

                entity.ToTable("unitworkccs.tblcontrolplan", "unitworksccs");

                entity.Property(e => e.CpId)
                    .HasColumnName("cpId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("approvedDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.CellId)
                    .HasColumnName("cellId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChildPartNo)
                    .HasColumnName("childPartNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ControlPlanNo)
                    .HasColumnName("controlPlanNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.FgDesc)
                    .HasColumnName("fgDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RevisionNo)
                    .HasColumnName("revisionNo")
                    .HasColumnType("decimal(8,3)");

                entity.Property(e => e.RoutingNo)
                    .HasColumnName("routingNo")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblcontrolplandetails>(entity =>
            {
                entity.HasKey(e => e.ControlPlanDetId);

                entity.ToTable("unitworkccs.tblcontrolplandetails", "unitworksccs");

                entity.Property(e => e.ControlPlanDetId)
                    .HasColumnName("controlPlanDetId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BallunNo)
                    .HasColumnName("ballunNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ControlPlanId)
                    .HasColumnName("controlPlanId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.CustomerRefCpNo)
                    .HasColumnName("customerRefCpNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dimension)
                    .HasColumnName("dimension")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EvaluationMethod)
                    .HasColumnName("evaluationMethod")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MaxTolerance)
                    .HasColumnName("maxTolerance")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.MinToleranace)
                    .HasColumnName("minToleranace")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OperationNo)
                    .HasColumnName("operationNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperationalDescription)
                    .HasColumnName("operationalDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessId)
                    .HasColumnName("processId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReactionPlan)
                    .HasColumnName("reactionPlan")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RecordingMethod)
                    .HasColumnName("recordingMethod")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionNo)
                    .HasColumnName("revisionNo")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.SpecialCharacterClass)
                    .HasColumnName("specialCharacterClass")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time(6)");
            });

            modelBuilder.Entity<UnitworkccsTblcustomer>(entity =>
            {
                entity.HasKey(e => e.Cid);

                entity.ToTable("unitworkccs.tblcustomer", "unitworksccs");

                entity.Property(e => e.Cid)
                    .HasColumnName("CID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.CpmobileNo)
                    .HasColumnName("CPMobileNO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cpname)
                    .HasColumnName("CPName")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

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

                entity.Property(e => e.Fax).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Landline1).HasColumnType("int(11)");

                entity.Property(e => e.Landline2).HasColumnType("int(11)");

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnType("longblob");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Website)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbldailyprodstatus>(entity =>
            {
                entity.ToTable("unitworkccs.tbldailyprodstatus", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbldaytiming>(entity =>
            {
                entity.ToTable("unitworkccs.tbldaytiming", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndTime).HasColumnType("time(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.StartTime).HasColumnType("time(6)");
            });

            modelBuilder.Entity<UnitworkccsTbldefectcodemaster>(entity =>
            {
                entity.HasKey(e => e.DefectCodeId);

                entity.ToTable("unitworkccs.tbldefectcodemaster", "unitworksccs");

                entity.Property(e => e.DefectCodeId)
                    .HasColumnName("defectCodeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.DefectCodeDesc)
                    .HasColumnName("defectCodeDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCodeName)
                    .HasColumnName("defectCodeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");
            });

            modelBuilder.Entity<UnitworkccsTbldepartmentdetails>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("unitworkccs.tbldepartmentdetails", "unitworksccs");

                entity.Property(e => e.DepartmentId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DepartmentDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTbldirlineinspector>(entity =>
            {
                entity.HasKey(e => e.DirLineInspId);

                entity.ToTable("unitworkccs.tbldirlineinspector", "unitworksccs");

                entity.Property(e => e.DirLineInspId)
                    .HasColumnName("dirLineInspId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("cellId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.DefectCode)
                    .HasColumnName("defectCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefectDescription)
                    .HasColumnName("defectDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNo)
                    .HasColumnName("employeeNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartQrCode)
                    .HasColumnName("partQrCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellId)
                    .HasColumnName("subCellId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkorderNumber)
                    .HasColumnName("workorderNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbldirqualityhead>(entity =>
            {
                entity.HasKey(e => e.DirQhId);

                entity.ToTable("unitworkccs.tbldirqualityhead", "unitworksccs");

                entity.Property(e => e.DirQhId)
                    .HasColumnName("dirQhId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CompletedOn)
                    .HasColumnName("completedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.EmployeeNo)
                    .HasColumnName("employeeNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpenTracker)
                    .HasColumnName("openTracker")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReworkOrReject)
                    .HasColumnName("reworkOrReject")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RouteCause)
                    .HasColumnName("routeCause")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetDate)
                    .HasColumnName("targetDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.TrackerNo)
                    .HasColumnName("trackerNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber)
                    .HasColumnName("workOrderNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbldowntimecategory>(entity =>
            {
                entity.HasKey(e => e.DtcId);

                entity.ToTable("unitworkccs.tbldowntimecategory", "unitworksccs");

                entity.Property(e => e.DtcId)
                    .HasColumnName("DTC_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

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

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTbldowntimedetails>(entity =>
            {
                entity.HasKey(e => e.DtId);

                entity.ToTable("unitworkccs.tbldowntimedetails", "unitworksccs");

                entity.HasIndex(e => e.DtcategoryId)
                    .HasName("tbldowntimedetails$tbldowntimedetails_ibfk_1");

                entity.Property(e => e.DtId)
                    .HasColumnName("DT_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DtcategoryId)
                    .HasColumnName("DTCategoryID")
                    .HasColumnType("int(11)");

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

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.HasOne(d => d.Dtcategory)
                    .WithMany(p => p.UnitworkccsTbldowntimedetails)
                    .HasForeignKey(d => d.DtcategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbldowntimedetails$tbldowntimedetails_ibfk_1");
            });

            modelBuilder.Entity<UnitworkccsTbldryrun>(entity =>
            {
                entity.HasKey(e => e.DryRunId);

                entity.ToTable("unitworkccs.tbldryrun", "unitworksccs");

                entity.Property(e => e.DryRunId)
                    .HasColumnName("dryRunId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("endDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.FgPartId)
                    .HasColumnName("fgPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartCount)
                    .HasColumnName("partCount")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblemailescalation>(entity =>
            {
                entity.HasKey(e => e.EmailEscalationId);

                entity.ToTable("unitworkccs.tblemailescalation", "unitworksccs");

                entity.HasIndex(e => e.EmailEscalationId)
                    .HasName("tblemailescalation$EMailEscalationID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.PlantId)
                    .HasName("tblemailescalation$PlantIDFK");

                entity.HasIndex(e => e.ReasonLevel1)
                    .HasName("tblemailescalation$ReasonLevel1FK");

                entity.HasIndex(e => e.ReasonLevel2)
                    .HasName("tblemailescalation$ReasonLevel2FK");

                entity.HasIndex(e => e.ReasonLevel3)
                    .HasName("tblemailescalation$ReasonLevel3FK");

                entity.HasIndex(e => e.ShopId)
                    .HasName("tblemailescalation$ShopIDFK");

                entity.Property(e => e.EmailEscalationId)
                    .HasColumnName("EMailEscalationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CcList).HasColumnType("longtext");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.EmailEscalationName)
                    .HasColumnName("EMailEscalationName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Hours)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Minutes)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReasonLevel1).HasColumnType("int(11)");

                entity.Property(e => e.ReasonLevel2).HasColumnType("int(11)");

                entity.Property(e => e.ReasonLevel3).HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToList).HasColumnType("longtext");

                entity.Property(e => e.WorkCenterId)
                    .HasColumnName("WorkCenterID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblemailescalation)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblemailescalation$PlantIDFK");

                entity.HasOne(d => d.ReasonLevel1Navigation)
                    .WithMany(p => p.UnitworkccsTblemailescalationReasonLevel1Navigation)
                    .HasForeignKey(d => d.ReasonLevel1)
                    .HasConstraintName("tblemailescalation$ReasonLevel1FK");

                entity.HasOne(d => d.ReasonLevel2Navigation)
                    .WithMany(p => p.UnitworkccsTblemailescalationReasonLevel2Navigation)
                    .HasForeignKey(d => d.ReasonLevel2)
                    .HasConstraintName("tblemailescalation$ReasonLevel2FK");

                entity.HasOne(d => d.ReasonLevel3Navigation)
                    .WithMany(p => p.UnitworkccsTblemailescalationReasonLevel3Navigation)
                    .HasForeignKey(d => d.ReasonLevel3)
                    .HasConstraintName("tblemailescalation$ReasonLevel3FK");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblemailescalation)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblemailescalation$ShopIDFK");
            });

            modelBuilder.Entity<UnitworkccsTblemployeeshiftdetails>(entity =>
            {
                entity.ToTable("unitworkccs.tblemployeeshiftdetails", "unitworksccs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EmployeeId).HasColumnType("int(11)");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineIds)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");
            });

            modelBuilder.Entity<UnitworkccsTblendcodes>(entity =>
            {
                entity.HasKey(e => e.EndCodeId);

                entity.ToTable("unitworkccs.tblendcodes", "unitworksccs");

                entity.Property(e => e.EndCodeId)
                    .HasColumnName("EndCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

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

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblescalationlog>(entity =>
            {
                entity.HasKey(e => e.Elid);

                entity.ToTable("unitworkccs.tblescalationlog", "unitworksccs");

                entity.HasIndex(e => e.Elid)
                    .HasName("tblescalationlog$ELID_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.LossCodeId)
                    .HasName("tblescalationlog$EscalationLossCodeID");

                entity.Property(e => e.Elid)
                    .HasColumnName("ELID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EscalationId)
                    .HasColumnName("EscalationID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EscalationSentOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsIdle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LossCodeId)
                    .HasColumnName("LossCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Wcid)
                    .HasColumnName("WCID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.UnitworkccsTblescalationlog)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("tblescalationlog$EscalationLossCodeID");
            });

            modelBuilder.Entity<UnitworkccsTblescalationmatrix>(entity =>
            {
                entity.HasKey(e => e.EscalationId);

                entity.ToTable("unitworkccs.tblescalationmatrix", "unitworksccs");

                entity.Property(e => e.EscalationId)
                    .HasColumnName("escalationId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CellId)
                    .HasColumnName("cellId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("employeeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employeeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineName)
                    .HasColumnName("machineName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shiftId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SmsPriority)
                    .HasColumnName("smsPriority")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubCell)
                    .HasColumnName("subCell")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellId)
                    .HasColumnName("subCellId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TimeToBeTriggered)
                    .HasColumnName("timeToBeTriggered")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblescalationprioritydetails>(entity =>
            {
                entity.HasKey(e => e.Epid);

                entity.ToTable("unitworkccs.tblescalationprioritydetails", "unitworksccs");

                entity.Property(e => e.Epid)
                    .HasColumnName("EPId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CellId).HasColumnType("int(11)");

                entity.Property(e => e.CellName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EmployeeId).HasColumnType("int(11)");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.SmspriorityLevel)
                    .HasColumnName("SMSPriorityLevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubCellId).HasColumnType("int(11)");

                entity.Property(e => e.SubCellName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblescalationtiming>(entity =>
            {
                entity.ToTable("unitworkccs.tblescalationtiming", "unitworksccs");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId).HasColumnType("int(11)");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.FirstEscalation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FourthEscalation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.SecondEscalation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdEscalation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblfgandcellallocation>(entity =>
            {
                entity.HasKey(e => e.FgAndCellAllocationId);

                entity.ToTable("unitworkccs.tblfgandcellallocation", "unitworksccs");

                entity.Property(e => e.FgAndCellAllocationId)
                    .HasColumnName("fgAndCellAllocationId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellFinalId)
                    .HasColumnName("cellFinalId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.DmcCodeStatus)
                    .HasColumnName("dmcCodeStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SubCellFinalId)
                    .HasColumnName("subCellFinalId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblfgpartnodet>(entity =>
            {
                entity.HasKey(e => e.FgPartId);

                entity.ToTable("unitworkccs.tblfgpartnodet", "unitworksccs");

                entity.Property(e => e.FgPartId)
                    .HasColumnName("fgPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActaulValue)
                    .HasColumnName("actaulValue")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Availibility).HasColumnName("availibility");

                entity.Property(e => e.ClosedDate)
                    .HasColumnName("closedDate")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdealCycleTime)
                    .HasColumnName("idealCycleTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.IsClosed)
                    .HasColumnName("isClosed")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("char(10)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.NoOfPartsPerCycle)
                    .HasColumnName("noOfPartsPerCycle")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Oee).HasColumnName("oee");

                entity.Property(e => e.OperationNo)
                    .HasColumnName("operationNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartCountMethod)
                    .HasColumnName("partCountMethod")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartId)
                    .HasColumnName("partId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Performance).HasColumnName("performance");

                entity.Property(e => e.PlanLinkageId)
                    .HasColumnName("planLinkageId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlannedEndTime)
                    .HasColumnName("plannedEndTime")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.PlannedStartTime)
                    .HasColumnName("plannedStartTime")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.RoutingId)
                    .HasColumnName("routingId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduledQty)
                    .HasColumnName("scheduledQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("startDate")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.TargetQty)
                    .HasColumnName("targetQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderCompletedQty)
                    .HasColumnName("workOrderCompletedQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderNo)
                    .HasColumnName("workOrderNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblgeneraldefectcodes>(entity =>
            {
                entity.HasKey(e => e.GeneralDefectCodeId);

                entity.ToTable("unitworkccs.tblgeneraldefectcodes", "unitworksccs");

                entity.Property(e => e.GeneralDefectCodeId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.DefectCodeDesc)
                    .HasColumnName("defectCodeDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCodeName)
                    .HasColumnName("defectCodeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblgenericworkcodes>(entity =>
            {
                entity.HasKey(e => e.GenericWorkId);

                entity.ToTable("unitworkccs.tblgenericworkcodes", "unitworksccs");

                entity.Property(e => e.GenericWorkId)
                    .HasColumnName("GenericWorkID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.EndCode).HasColumnType("int(11)");

                entity.Property(e => e.GenericWorkCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenericWorkDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.GwcodesLevel)
                    .HasColumnName("GWCodesLevel")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GwcodesLevel1Id)
                    .HasColumnName("GWCodesLevel1ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.GwcodesLevel2Id)
                    .HasColumnName("GWCodesLevel2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblgenericworkentry>(entity =>
            {
                entity.HasKey(e => e.GwentryId);

                entity.ToTable("unitworkccs.tblgenericworkentry", "unitworksccs");

                entity.HasIndex(e => e.GwcodeId)
                    .HasName("tblgenericworkentry$GenericWorkID");

                entity.Property(e => e.GwentryId)
                    .HasColumnName("GWEntryID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Gwcode)
                    .HasColumnName("GWCode")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.GwcodeDesc)
                    .HasColumnName("GWCodeDesc")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.GwcodeId)
                    .HasColumnName("GWCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime(6)");

                entity.HasOne(d => d.GwcodeNavigation)
                    .WithMany(p => p.UnitworkccsTblgenericworkentry)
                    .HasForeignKey(d => d.GwcodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblgenericworkentry$GenericWorkID");
            });

            modelBuilder.Entity<UnitworkccsTblhistpms>(entity =>
            {
                entity.ToTable("unitworkccs.tblhistpms", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cellid).HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Machineid).HasColumnType("int(11)");

                entity.Property(e => e.Pmchecklistname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Pmcheckpointid).HasColumnType("int(11)");

                entity.Property(e => e.Pmsid)
                    .HasColumnName("pmsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Workdone)
                    .HasColumnName("workdone")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitworkccsTblholdcodes>(entity =>
            {
                entity.HasKey(e => e.HoldCodeId);

                entity.ToTable("unitworkccs.tblholdcodes", "unitworksccs");

                entity.Property(e => e.HoldCodeId)
                    .HasColumnName("HoldCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContributeTo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.EndCode).HasColumnType("int(11)");

                entity.Property(e => e.HoldCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoldCodeDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HoldCodesLevel).HasColumnType("int(11)");

                entity.Property(e => e.HoldCodesLevel1Id)
                    .HasColumnName("HoldCodesLevel1ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HoldCodesLevel2Id)
                    .HasColumnName("HoldCodesLevel2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ServerTabCheck)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerTabFlagSync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitworkccsTblholidaymanagment>(entity =>
            {
                entity.HasKey(e => e.HolidayManagmentId);

                entity.ToTable("unitworkccs.tblholidaymanagment", "unitworksccs");

                entity.Property(e => e.HolidayManagmentId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DaysDuration)
                    .HasColumnName("daysDuration")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.FromDate).HasColumnType("datetime(6)");

                entity.Property(e => e.HolidayManagmentDesc)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayManagmentName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayType).HasColumnType("int(11)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("isDelete")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ToDate).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblholidays>(entity =>
            {
                entity.HasKey(e => e.HolidayId);

                entity.ToTable("unitworkccs.tblholidays", "unitworksccs");

                entity.Property(e => e.HolidayId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.HolidayDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Reason)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblholidaytypemasters>(entity =>
            {
                entity.HasKey(e => e.HolidayTypeId);

                entity.ToTable("unitworkccs.tblholidaytypemasters", "unitworksccs");

                entity.Property(e => e.HolidayTypeId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.HolidayTypeColorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayTypeName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblipaddress>(entity =>
            {
                entity.HasKey(e => e.IpAddressId);

                entity.ToTable("unitworkccs.tblipaddress", "unitworksccs");

                entity.Property(e => e.IpAddressId)
                    .HasColumnName("ipAddressId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.HostName)
                    .HasColumnName("hostName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ipAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MacAddress)
                    .HasColumnName("macAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblissuedreceived>(entity =>
            {
                entity.ToTable("unitworkccs.tblissuedreceived", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BarCodeNo)
                    .HasColumnName("barCodeNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BatchNumber)
                    .HasColumnName("batchNumber")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.GrnNo)
                    .HasColumnName("grnNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InspLotNo)
                    .HasColumnName("inspLotNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsCheck)
                    .HasColumnName("isCheck")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsReDisplay)
                    .HasColumnName("isReDisplay")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsReturn)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSapgenerated)
                    .HasColumnName("isSAPGenerated")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issueDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpAcceptanceFlag)
                    .HasColumnName("opAcceptanceFlag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.OpId)
                    .HasColumnName("opId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReasonLvl1Id)
                    .HasColumnName("reasonLvl1Id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReceiptDate)
                    .HasColumnName("receiptDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnedOpId)
                    .HasColumnName("returnedOpId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.SapCode)
                    .HasColumnName("sapCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SapGeneratedDate)
                    .HasColumnName("sapGeneratedDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SapRefDate)
                    .HasColumnName("sapRefDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SapReferenceNo)
                    .HasColumnName("sapReferenceNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shiftId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SlipNo)
                    .HasColumnName("slipNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolBatchNo)
                    .HasColumnName("toolBatchNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToolGribUserFlag)
                    .HasColumnName("toolGribUserFlag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ToolGribUserId)
                    .HasColumnName("toolGribUserId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolLifeActual)
                    .HasColumnName("toolLifeActual")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName)
                    .HasColumnName("toolName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UniqueBatchNo)
                    .HasColumnName("uniqueBatchNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbllivedailyprodstatus>(entity =>
            {
                entity.ToTable("unitworkccs.tbllivedailyprodstatus", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Status)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbllivemode>(entity =>
            {
                entity.HasKey(e => e.ModeId);

                entity.ToTable("unitworkccs.tbllivemode", "unitworksccs");

                entity.HasIndex(e => e.BreakdownId)
                    .HasName("breakDwonIdFk_idx");

                entity.HasIndex(e => e.LossCodeId)
                    .HasName("losscodeIDFK_idx");

                entity.HasIndex(e => e.MachineId)
                    .HasName("machineId_fk_idx");

                entity.HasIndex(e => new { e.ModeId, e.MachineId, e.MacMode, e.CorrectedDate, e.StartTime, e.EndTime, e.ColorCode, e.IsCompleted, e.DurationInSec, e.LossCodeId, e.BreakdownId, e.ModeType, e.ModeTypeEnd, e.StartIdle, e.TotalPartsCount })
                    .HasName("LivemodeIndexer")
                    .IsUnique();

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakDownCodeId)
                    .HasColumnName("breakDownCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakdownId)
                    .HasColumnName("BreakdownID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CuttingDuration).HasColumnType("int(11)");

                entity.Property(e => e.DurationInSec).HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsInserted).HasColumnType("int(11)");

                entity.Property(e => e.IsShiftEnd).HasColumnType("int(11)");

                entity.Property(e => e.LossCodeEnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeEnteredTime).HasColumnType("datetime(3)");

                entity.Property(e => e.LossCodeId)
                    .HasColumnName("LossCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MacMode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeEnd).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartIdle).HasColumnType("int(11)");

                entity.Property(e => e.TotalPartsCount).HasColumnType("int(11)");

                entity.HasOne(d => d.Breakdown)
                    .WithMany(p => p.UnitworkccsTbllivemode)
                    .HasForeignKey(d => d.BreakdownId)
                    .HasConstraintName("FK_breakdown");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.UnitworkccsTbllivemode)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("FK_losscodeID");

                entity.HasOne(d => d.Machine)
                    .WithMany(p => p.UnitworkccsTbllivemode)
                    .HasForeignKey(d => d.MachineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("machineId_fk");
            });

            modelBuilder.Entity<UnitworkccsTbllossescodes>(entity =>
            {
                entity.HasKey(e => e.LossCodeId);

                entity.ToTable("unitworkccs.tbllossescodes", "unitworksccs");

                entity.Property(e => e.LossCodeId)
                    .HasColumnName("LossCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContributeTo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.EndCode).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.LossCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodesLevel).HasColumnType("int(11)");

                entity.Property(e => e.LossCodesLevel1Id)
                    .HasColumnName("LossCodesLevel1ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LossCodesLevel2Id)
                    .HasColumnName("LossCodesLevel2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ServerTabCheck)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerTabFlagSync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TargetPercent)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.01");
            });

            modelBuilder.Entity<UnitworkccsTbllossofentry>(entity =>
            {
                entity.HasKey(e => e.LossId);

                entity.ToTable("unitworkccs.tbllossofentry", "unitworksccs");

                entity.HasIndex(e => e.MessageCodeId)
                    .HasName("tbllossofentry$LossCodeID");

                entity.Property(e => e.LossId)
                    .HasColumnName("LossID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.DoneWithRow)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndDateTime).HasColumnType("datetime(6)");

                entity.Property(e => e.EntryTime).HasColumnType("datetime(6)");

                entity.Property(e => e.ForRefresh)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hmiid)
                    .HasColumnName("HMIID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsScreen).HasColumnType("int(11)");

                entity.Property(e => e.IsStart).HasColumnType("int(11)");

                entity.Property(e => e.IsUpdate)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MessageCodeId)
                    .HasColumnName("MessageCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartDateTime).HasColumnType("datetime(6)");

                entity.HasOne(d => d.MessageCodeNavigation)
                    .WithMany(p => p.UnitworkccsTbllossofentry)
                    .HasForeignKey(d => d.MessageCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tbllossofentry$LossCodeID");
            });

            modelBuilder.Entity<UnitworkccsTblmachineaxisdetails>(entity =>
            {
                entity.HasKey(e => e.MacAxisId);

                entity.ToTable("unitworkccs.tblmachineaxisdetails", "unitworksccs");

                entity.HasIndex(e => e.MacAxisId)
                    .HasName("tblmachineaxisdetails$MacAxisID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.MacAxisId)
                    .HasColumnName("MacAxisID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AxisName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.AxisNo).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblmachinecategory>(entity =>
            {
                entity.ToTable("unitworkccs.tblmachinecategory", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblmachinecategorynames>(entity =>
            {
                entity.HasKey(e => e.MachineCategoryId);

                entity.ToTable("unitworkccs.tblmachinecategorynames", "unitworksccs");

                entity.Property(e => e.MachineCategoryId)
                    .HasColumnName("machineCategoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineCategoryName)
                    .HasColumnName("machineCategoryName")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NodifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.PlantId).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblmachinedetails>(entity =>
            {
                entity.HasKey(e => e.MachineId);

                entity.ToTable("unitworkccs.tblmachinedetails", "unitworksccs");

                entity.HasIndex(e => e.CellId)
                    .HasName("celIdFK_idx");

                entity.HasIndex(e => e.PlantId)
                    .HasName("PlantIdFK_idx");

                entity.HasIndex(e => e.ShopId)
                    .HasName("shopId_idx");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellOrderNo).HasColumnType("int(11)");

                entity.Property(e => e.ChuckOrRodSize)
                    .HasColumnName("chuckOrRodSize")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ControllerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(3)");

                entity.Property(e => e.CurrentControlAxis).HasColumnType("int(11)");

                entity.Property(e => e.DedicatedOrShared)
                    .HasColumnName("dedicatedOrShared")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(3)");

                entity.Property(e => e.EnableLockLogic)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EnableToolLife)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IotgatewayIp)
                    .HasColumnName("IOTGatewayIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsBottelNeck).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDlversion)
                    .HasColumnName("IsDLVersion")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsFirstMachine).HasColumnType("int(11)");

                entity.Property(e => e.IsLastMachine).HasColumnType("int(11)");

                entity.Property(e => e.IsLevel).HasColumnType("int(11)");

                entity.Property(e => e.IsNormalWc)
                    .HasColumnName("IsNormalWC")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsParameters).HasColumnType("int(11)");

                entity.Property(e => e.IsPcb)
                    .HasColumnName("IsPCB")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsShiftWise)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsWimerasys)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LoggerType)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.LossFlag)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MacConnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MacType)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCategoryId).HasColumnType("int(11)");

                entity.Property(e => e.MachineDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MachineDisplayName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MachineIdleBit).HasColumnType("int(11)");

                entity.Property(e => e.MachineIdleMin).HasColumnType("int(11)");

                entity.Property(e => e.MachineLockBit).HasColumnType("int(11)");

                entity.Property(e => e.MachineMaintBit).HasColumnType("int(11)");

                entity.Property(e => e.MachineMake)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineModelType)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.MachineName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.MachinePockets)
                    .HasColumnName("machinePockets")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachinePort).HasColumnType("int(11)");

                entity.Property(e => e.MachineSetupBit).HasColumnType("int(11)");

                entity.Property(e => e.MachineSpec)
                    .HasColumnName("machineSpec")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MachineToolLifeBit).HasColumnType("int(11)");

                entity.Property(e => e.MachineType).HasColumnType("int(11)");

                entity.Property(e => e.MachineUnlockBit).HasColumnType("int(11)");

                entity.Property(e => e.ManualWcid)
                    .HasColumnName("ManualWCID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Mmmgroup)
                    .HasColumnName("MMMGroup")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModelType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.NoOfAxis).HasColumnType("int(11)");

                entity.Property(e => e.NoOfAxisId)
                    .HasColumnName("noOfAxisId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfPartsPerCycle)
                    .HasColumnName("noOfPartsPerCycle")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NoOfToolStation)
                    .HasColumnName("noOfToolStation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NodeId)
                    .HasColumnName("NodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NumOfAxis).HasColumnType("int(11)");

                entity.Property(e => e.NumberOfCurrent).HasColumnType("int(11)");

                entity.Property(e => e.NumberOfLevel).HasColumnType("int(11)");

                entity.Property(e => e.NumberOfPresure).HasColumnType("int(11)");

                entity.Property(e => e.NumberOfTemperature).HasColumnType("int(11)");

                entity.Property(e => e.OperationNumber).HasColumnType("int(11)");

                entity.Property(e => e.PalletId)
                    .HasColumnName("palletId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimaryOrSecondary)
                    .HasColumnName("primaryOrSecondary")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProgDbit)
                    .HasColumnName("ProgDBit")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramNum)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServerTabCheck)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerTabFlagSync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SpindleAxis)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TabIpaddress)
                    .HasColumnName("TabIPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TableSize)
                    .HasColumnName("tableSize")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TallStockAvailId)
                    .HasColumnName("tallStockAvailId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolGroupNum).HasColumnType("int(11)");

                entity.Property(e => e.TransmissionFrequency).HasColumnType("int(11)");

                entity.HasOne(d => d.Cell)
                    .WithMany(p => p.UnitworkccsTblmachinedetails)
                    .HasForeignKey(d => d.CellId)
                    .HasConstraintName("celIdFK");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblmachinedetails)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("PlantIdFK");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblmachinedetails)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("FK_shopidMachineId");
            });

            modelBuilder.Entity<UnitworkccsTblmailids>(entity =>
            {
                entity.HasKey(e => e.MailIdsId);

                entity.ToTable("unitworkccs.tblmailids", "unitworksccs");

                entity.HasIndex(e => e.MailIdsId)
                    .HasName("tblmailids$MailIDsID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.MailIdsId)
                    .HasColumnName("MailIDsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EmailId)
                    .HasColumnName("EmailID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeContactNum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeDesignation)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblmasterpartsStSw>(entity =>
            {
                entity.HasKey(e => e.Partsstswid);

                entity.ToTable("unitworkccs.tblmasterparts_st_sw", "unitworksccs");

                entity.Property(e => e.Partsstswid)
                    .HasColumnName("PARTSSTSWID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.InputWeight).HasColumnType("decimal(10,2)");

                entity.Property(e => e.InputWeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaterialRemovedQty).HasColumnType("decimal(10,2)");

                entity.Property(e => e.MaterialRemovedQtyUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.OpNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OutputWeight).HasColumnType("decimal(10,2)");

                entity.Property(e => e.OutputWeightUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StdChangeoverTime).HasColumnType("decimal(10,2)");

                entity.Property(e => e.StdChangeoverTimeUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StdCuttingTime).HasColumnType("decimal(10,2)");

                entity.Property(e => e.StdCuttingTimeUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StdSetupTime).HasColumnType("decimal(10,2)");

                entity.Property(e => e.StdSetupTimeUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblmastervalue>(entity =>
            {
                entity.HasKey(e => e.MasterValueId);

                entity.ToTable("unitworkccs.tblmastervalue", "unitworksccs");

                entity.Property(e => e.MasterValueId)
                    .HasColumnName("masterValueId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.MasterValue)
                    .HasColumnName("masterValue")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.MasterValueDesc)
                    .HasColumnName("masterValueDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MasterValueName)
                    .HasColumnName("masterValueName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblmaterialmaster>(entity =>
            {
                entity.HasKey(e => e.MaterialmasterId);

                entity.ToTable("unitworkccs.tblmaterialmaster", "unitworksccs");

                entity.Property(e => e.MaterialmasterId)
                    .HasColumnName("materialmasterId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MaterialDescription)
                    .HasColumnName("materialDescription")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName)
                    .HasColumnName("materialName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialType)
                    .HasColumnName("materialType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PartCode)
                    .HasColumnName("partCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblmimics>(entity =>
            {
                entity.HasKey(e => e.Mid);

                entity.ToTable("unitworkccs.tblmimics", "unitworksccs");

                entity.Property(e => e.Mid)
                    .HasColumnName("mid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakdownTime).HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdleTime).HasColumnType("int(11)");

                entity.Property(e => e.IsSync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineOffTime).HasColumnType("int(11)");

                entity.Property(e => e.MachineOnTime).HasColumnType("int(11)");

                entity.Property(e => e.OperatingTime).HasColumnType("int(11)");

                entity.Property(e => e.SetupTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblmode>(entity =>
            {
                entity.HasKey(e => e.ModeId);

                entity.ToTable("unitworkccs.tblmode", "unitworksccs");

                entity.HasIndex(e => e.BreakdownId)
                    .HasName("breakdownIdFK_idx");

                entity.HasIndex(e => e.LossCodeId)
                    .HasName("LosscodeIDFK_idx");

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakdownId)
                    .HasColumnName("BreakdownID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.DurationInSec)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsInserted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPiWeb).HasColumnType("int(11)");

                entity.Property(e => e.LossCodeEnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeEnteredTime).HasColumnType("datetime(3)");

                entity.Property(e => e.LossCodeId)
                    .HasColumnName("LossCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MacMode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModeMonth).HasColumnType("int(11)");

                entity.Property(e => e.ModeQuarter).HasColumnType("int(11)");

                entity.Property(e => e.ModeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeEnd)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModeWeekNumber).HasColumnType("int(11)");

                entity.Property(e => e.ModeYear).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.StartIdle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Breakdown)
                    .WithMany(p => p.UnitworkccsTblmodeBreakdown)
                    .HasForeignKey(d => d.BreakdownId)
                    .HasConstraintName("breakdownIdFK");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.UnitworkccsTblmodeLossCode)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("LosscodeIDFK");
            });

            modelBuilder.Entity<UnitworkccsTblmodetemp>(entity =>
            {
                entity.HasKey(e => e.ModeId);

                entity.ToTable("unitworkccs.tblmodetemp", "unitworksccs");

                entity.HasIndex(e => e.BreakdownId)
                    .HasName("FK_BreakdownID");

                entity.HasIndex(e => e.LossCodeId)
                    .HasName("FK_LosscodesId");

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakdownId)
                    .HasColumnName("BreakdownID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ColorCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.DurationInSec)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsInserted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LossCodeEnteredBy).HasColumnType("int(11)");

                entity.Property(e => e.LossCodeEnteredTime).HasColumnType("datetime(3)");

                entity.Property(e => e.LossCodeId)
                    .HasColumnName("LossCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MacMode)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModeType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModeTypeEnd)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.StartIdle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TabModeId)
                    .HasColumnName("TabModeID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Breakdown)
                    .WithMany(p => p.UnitworkccsTblmodetemp)
                    .HasForeignKey(d => d.BreakdownId)
                    .HasConstraintName("FK_BreakdownID");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.UnitworkccsTblmodetemp)
                    .HasForeignKey(d => d.LossCodeId)
                    .HasConstraintName("FK_LosscodesId");
            });

            modelBuilder.Entity<UnitworkccsTblmodulehelper>(entity =>
            {
                entity.ToTable("unitworkccs.tblmodulehelper", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsAdded)
                    .IsRequired()
                    .HasColumnType("binary(1)");

                entity.Property(e => e.IsAll)
                    .IsRequired()
                    .HasColumnType("binary(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsEdited)
                    .IsRequired()
                    .HasColumnType("binary(1)");

                entity.Property(e => e.IsHidden)
                    .IsRequired()
                    .HasColumnType("binary(1)");

                entity.Property(e => e.IsReadonly)
                    .IsRequired()
                    .HasColumnType("binary(1)");

                entity.Property(e => e.IsRemoved)
                    .IsRequired()
                    .HasColumnType("binary(1)");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblmodulemaster>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("unitworkccs.tblmodulemaster", "unitworksccs");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EnableAdd).HasColumnType("binary(1)");

                entity.Property(e => e.EnableDelete).HasColumnType("binary(1)");

                entity.Property(e => e.EnableEdit).HasColumnType("binary(1)");

                entity.Property(e => e.EnableReport).HasColumnType("binary(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSuperAdmin).HasColumnType("binary(1)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblmodules>(entity =>
            {
                entity.HasKey(e => e.ModuleId);

                entity.ToTable("unitworkccs.tblmodules", "unitworksccs");

                entity.Property(e => e.ModuleId).HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleDispName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblmultipleworkorder>(entity =>
            {
                entity.HasKey(e => e.Mwoid);

                entity.ToTable("unitworkccs.tblmultipleworkorder", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("tblmultipleworkorder$PlantIDtblMWO");

                entity.HasIndex(e => e.ShopId)
                    .HasName("tblmultipleworkorder$ShopIdtblMWO");

                entity.Property(e => e.Mwoid)
                    .HasColumnName("MWOID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsEnabled)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.MultipleWodesc)
                    .HasColumnName("MultipleWODesc")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MultipleWoname)
                    .IsRequired()
                    .HasColumnName("MultipleWOName")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Wcid)
                    .HasColumnName("WCID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblmultipleworkorder)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblmultipleworkorder$PlantIDtblMWO");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblmultipleworkorder)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblmultipleworkorder$ShopIdtblMWO");
            });

            modelBuilder.Entity<UnitworkccsTblncprogramtransfermain>(entity =>
            {
                entity.HasKey(e => e.NcProgramTransferId);

                entity.ToTable("unitworkccs.tblncprogramtransfermain", "unitworksccs");

                entity.Property(e => e.NcProgramTransferId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.FromCnc)
                    .HasColumnName("FromCNC")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.McId).HasColumnType("int(11)");

                entity.Property(e => e.ProgramData).HasColumnType("longtext");

                entity.Property(e => e.ProgramNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblnoofaxis>(entity =>
            {
                entity.HasKey(e => e.NoOfAxisId);

                entity.ToTable("unitworkccs.tblnoofaxis", "unitworksccs");

                entity.Property(e => e.NoOfAxisId)
                    .HasColumnName("noOfAxisId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.NoOfAxis)
                    .HasColumnName("noOfAxis")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbloeedashboardfinalvariables>(entity =>
            {
                entity.HasKey(e => e.OeedashboardId);

                entity.ToTable("unitworkccs.tbloeedashboardfinalvariables", "unitworksccs");

                entity.HasIndex(e => e.OeedashboardId)
                    .HasName("tbloeedashboardfinalvariables$OEEDashboardID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeedashboardId)
                    .HasColumnName("OEEDashboardID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Availability).HasColumnType("decimal(6,2)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndDate).HasColumnType("datetime(6)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsOverallCellWise)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsOverallPlantWise)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsOverallShopWise)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsOverallWcwise)
                    .HasColumnName("IsOverallWCWise")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsToday)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Loss1Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss1Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss2Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss2Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss3Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss3Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss4Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss4Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss5Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss5Value).HasColumnType("int(11)");

                entity.Property(e => e.Oee)
                    .HasColumnName("OEE")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.Performance).HasColumnType("decimal(6,2)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quality).HasColumnType("decimal(6,2)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("datetime(6)");

                entity.Property(e => e.Wcid)
                    .HasColumnName("WCID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbloeedashboardvariables>(entity =>
            {
                entity.HasKey(e => e.OeevariablesId);

                entity.ToTable("unitworkccs.tbloeedashboardvariables", "unitworksccs");

                entity.HasIndex(e => e.OeevariablesId)
                    .HasName("tbloeedashboardvariables$OEEVariablesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeevariablesId)
                    .HasColumnName("OEEVariablesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Blue).HasColumnType("decimal(10,2)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DownTimeBreakdown).HasColumnType("decimal(10,2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime(6)");

                entity.Property(e => e.Green).HasColumnType("decimal(10,2)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Loss1Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss1Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss2Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss2Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss3Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss3Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss4Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss4Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss5Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss5Value).HasColumnType("int(11)");

                entity.Property(e => e.MinorLosses).HasColumnType("decimal(10,2)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReWotime)
                    .HasColumnName("ReWOTime")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Roalossess)
                    .HasColumnName("ROALossess")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.ScrapQtyTime).HasColumnType("decimal(10,2)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(10,2)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("datetime(6)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Wcid)
                    .HasColumnName("WCID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbloeedashboardvariablestoday>(entity =>
            {
                entity.HasKey(e => e.OeevariablesId);

                entity.ToTable("unitworkccs.tbloeedashboardvariablestoday", "unitworksccs");

                entity.HasIndex(e => e.OeevariablesId)
                    .HasName("tbloeedashboardvariablestoday$OEEVariablesID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.OeevariablesId)
                    .HasColumnName("OEEVariablesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Blue).HasColumnType("decimal(6,2)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DownTimeBreakdown).HasColumnType("decimal(6,2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime(6)");

                entity.Property(e => e.Green).HasColumnType("decimal(6,2)");

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsToday)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Loss1Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss1Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss2Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss2Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss3Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss3Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss4Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss4Value).HasColumnType("int(11)");

                entity.Property(e => e.Loss5Name)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Loss5Value).HasColumnType("int(11)");

                entity.Property(e => e.MinorLosses).HasColumnType("decimal(6,2)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReWotime)
                    .HasColumnName("ReWOTime")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.Roalossess)
                    .HasColumnName("ROALossess")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.ScrapQtyTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(6,2)");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("datetime(6)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("decimal(6,2)");

                entity.Property(e => e.Wcid)
                    .HasColumnName("WCID")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbloperatordashboard>(entity =>
            {
                entity.HasKey(e => e.OperatorDashboardId);

                entity.ToTable("unitworkccs.tbloperatordashboard", "unitworksccs");

                entity.Property(e => e.OperatorDashboardId)
                    .HasColumnName("OperatorDashboardID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MessageCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MessageDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.MessageEndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.MessageStartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.SlNo).HasColumnType("int(11)");

                entity.Property(e => e.TotalDurationinMin).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbloperatordetails>(entity =>
            {
                entity.HasKey(e => e.OpId);

                entity.ToTable("unitworkccs.tbloperatordetails", "unitworksccs");

                entity.Property(e => e.OpId)
                    .HasColumnName("opId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BusinessId).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("cellId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime(6)");

                entity.Property(e => e.DateOfJoing).HasColumnType("datetime(6)");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("departmentId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DirectOrIndirect)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MachineIds)
                    .HasColumnName("machineIds")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatorEmailId)
                    .HasColumnName("operatorEmailId")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorMobileNo)
                    .HasColumnName("operatorMobileNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasColumnName("operatorName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoId).HasColumnType("int(11)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellId)
                    .HasColumnName("subCellId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("userName")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbloperatorheader>(entity =>
            {
                entity.HasKey(e => e.OperatorId);

                entity.ToTable("unitworkccs.tbloperatorheader", "unitworksccs");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("OperatorID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineMode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ServerConnecStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TabConnecStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbloperatorlogindetails>(entity =>
            {
                entity.HasKey(e => e.OperatorLoginId);

                entity.ToTable("unitworkccs.tbloperatorlogindetails", "unitworksccs");

                entity.HasIndex(e => e.RoleId)
                    .HasName("FK_tblOperatorLoginDetails_tblroles");

                entity.Property(e => e.OperatorLoginId)
                    .HasColumnName("operatorLoginId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.NumOfMachines).HasColumnType("int(11)");

                entity.Property(e => e.OperatorEmailId)
                    .HasColumnName("operatorEmailId")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperatorMobileNo)
                    .HasColumnName("operatorMobileNo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasColumnName("operatorName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorPwd)
                    .HasColumnName("operatorPwd")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorUserName)
                    .HasColumnName("operatorUserName")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Reasons)
                    .HasColumnName("reasons")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UnitworkccsTbloperatorlogindetails)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_tblOperatorLoginDetails_tblroles");
            });

            modelBuilder.Entity<UnitworkccsTbloperatormachinedetails>(entity =>
            {
                entity.HasKey(e => e.OpertorMacDetId);

                entity.ToTable("unitworkccs.tbloperatormachinedetails", "unitworksccs");

                entity.HasIndex(e => e.OperatorLoginId)
                    .HasName("FK_tblOperatorMachineDetails_tblOperatorLoginDetails");

                entity.Property(e => e.OpertorMacDetId)
                    .HasColumnName("opertorMacDetId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OperatorLoginId)
                    .HasColumnName("operatorLoginId")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.OperatorLogin)
                    .WithMany(p => p.UnitworkccsTbloperatormachinedetails)
                    .HasForeignKey(d => d.OperatorLoginId)
                    .HasConstraintName("FK_tblOperatorMachineDetails_tblOperatorLoginDetails");
            });

            modelBuilder.Entity<UnitworkccsTblpallet>(entity =>
            {
                entity.HasKey(e => e.PalletId);

                entity.ToTable("unitworkccs.tblpallet", "unitworksccs");

                entity.Property(e => e.PalletId)
                    .HasColumnName("palletId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PalletName)
                    .HasColumnName("palletName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblpartlearningreport>(entity =>
            {
                entity.HasKey(e => e.PlreportId);

                entity.ToTable("unitworkccs.tblpartlearningreport", "unitworksccs");

                entity.HasIndex(e => e.PlreportId)
                    .HasName("tblworeport$PLReportID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.PlreportId)
                    .HasColumnName("PLReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AvgCuttingTime).HasColumnType("decimal(8,2)");

                entity.Property(e => e.Breakdown).HasColumnType("decimal(8,2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Hmiid)
                    .HasColumnName("HMIID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idle).HasColumnType("decimal(8,2)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLoss).HasColumnType("decimal(6,2)");

                entity.Property(e => e.OpNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PowerOff).HasColumnType("decimal(8,2)");

                entity.Property(e => e.ScrapQty).HasColumnType("int(11)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(8,2)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.StdCycleTime).HasColumnType("decimal(8,2)");

                entity.Property(e => e.StdMinorLoss).HasColumnType("decimal(10,2)");

                entity.Property(e => e.TargetQty).HasColumnType("int(11)");

                entity.Property(e => e.TotalNccuttingTime)
                    .HasColumnName("TotalNCCuttingTime")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.TotalQty).HasColumnType("int(11)");

                entity.Property(e => e.TotalStdCycleTime).HasColumnType("decimal(8,2)");

                entity.Property(e => e.TotalStdMinorLoss).HasColumnType("decimal(18,2)");

                entity.Property(e => e.Woefficiency)
                    .HasColumnName("WOEfficiency")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.YieldQty).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblparts>(entity =>
            {
                entity.HasKey(e => e.PartId);

                entity.ToTable("unitworkccs.tblparts", "unitworksccs");

                entity.Property(e => e.PartId)
                    .HasColumnName("PartID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.DeletedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.DrawingNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fgcode)
                    .IsRequired()
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdealCycleTime).HasColumnType("decimal(18,2)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PartsPerCycle).HasColumnType("int(11)");

                entity.Property(e => e.PlanLinkageId)
                    .HasColumnName("planLinkageId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resourceId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingId)
                    .HasColumnName("routingId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StdLoadUnloadTime)
                    .HasColumnName("Std_Load_UnloadTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.StdLoadingTime).HasColumnType("decimal(8,3)");

                entity.Property(e => e.StdMinorLoss)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StdSetupTime)
                    .HasColumnName("Std_SetupTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.StdUnLoadingTime).HasColumnType("decimal(8,3)");

                entity.Property(e => e.TargetPerHr)
                    .HasColumnName("targetPerHr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetPerShift)
                    .HasColumnName("targetPerShift")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UnitDesc).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblpartscountandcutting>(entity =>
            {
                entity.HasKey(e => e.Pcid);

                entity.ToTable("unitworkccs.tblpartscountandcutting", "unitworksccs");

                entity.Property(e => e.Pcid)
                    .HasColumnName("pcid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActualQty)
                    .HasColumnName("actualQty")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CuttingTime).HasColumnType("int(11)");

                entity.Property(e => e.CuttingTimeInSec).HasColumnType("int(11)");

                entity.Property(e => e.DryRunQty)
                    .HasColumnName("dryRunQty")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Isdeleted).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.OkQty)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PartCount).HasColumnType("int(11)");

                entity.Property(e => e.PartsPerCyscleEnteredTime).HasColumnType("datetime(3)");

                entity.Property(e => e.RejectionQty)
                    .HasColumnName("rejectionQty")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReworkQty)
                    .HasColumnName("reworkQty")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetQuantity).HasColumnType("int(11)");

                entity.Property(e => e.WoPartCount)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WoTargetQty)
                    .HasColumnName("woTargetQty")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<UnitworkccsTblpir>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("unitworkccs.tblpir", "unitworksccs");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BallunNo)
                    .HasColumnName("ballunNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Freq)
                    .HasColumnName("freq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdAndLocation)
                    .HasColumnName("prodAndLocation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdQuality)
                    .HasColumnName("prodQuality")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RejarctionQuality)
                    .HasColumnName("rejarctionQuality")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialChar)
                    .HasColumnName("specialChar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblpirminmax>(entity =>
            {
                entity.HasKey(e => e.Pmid);

                entity.ToTable("unitworkccs.tblpirminmax", "unitworksccs");

                entity.Property(e => e.Pmid)
                    .HasColumnName("pmid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Pirmax)
                    .HasColumnName("pirmax")
                    .HasColumnType("decimal(8,3)");

                entity.Property(e => e.Pirmin)
                    .HasColumnName("pirmin")
                    .HasColumnType("decimal(8,3)");

                entity.Property(e => e.Pirstatus)
                    .HasColumnName("pirstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblplanlinkagemaster>(entity =>
            {
                entity.HasKey(e => e.PlanLinkageId);

                entity.ToTable("unitworkccs.tblplanlinkagemaster", "unitworksccs");

                entity.Property(e => e.PlanLinkageId)
                    .HasColumnName("planLinkageId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.FgPartNo)
                    .HasColumnName("fgPartNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdealCycleTime)
                    .HasColumnName("idealCycleTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("lastUpdate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.LastUpdatedUse)
                    .HasColumnName("lastUpdatedUse")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.NumUpdates)
                    .HasColumnName("numUpdates")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedEndTime)
                    .HasColumnName("plannedEndTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlannedStartTime)
                    .HasColumnName("plannedStartTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductionOrder)
                    .HasColumnName("productionOrder")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceId)
                    .HasColumnName("resourceId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RoutingId)
                    .HasColumnName("routingId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SapDateTimeStamp)
                    .HasColumnName("sapDateTimeStamp")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ScheduleDate)
                    .HasColumnName("scheduleDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ScheduleId)
                    .HasColumnName("scheduleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ScheduledQty)
                    .HasColumnName("scheduledQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SetUpTime)
                    .HasColumnName("setUpTime")
                    .HasColumnType("decimal(18,2)");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("shiftId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TargetPerHr)
                    .HasColumnName("targetPerHr")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderCompletedQty)
                    .HasColumnName("workOrderCompletedQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.WorkOrderQty)
                    .HasColumnName("workOrderQty")
                    .HasColumnType("decimal(18,6)");
            });

            modelBuilder.Entity<UnitworkccsTblplannedbreak>(entity =>
            {
                entity.HasKey(e => e.BreakId);

                entity.ToTable("unitworkccs.tblplannedbreak", "unitworksccs");

                entity.HasIndex(e => e.ShiftId)
                    .HasName("tblplannedbreak$shiftbreak");

                entity.Property(e => e.BreakId)
                    .HasColumnName("BreakID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakDuration).HasColumnType("int(11)");

                entity.Property(e => e.BreakReason)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndTime).HasColumnType("time(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("time(6)");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.UnitworkccsTblplannedbreak)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("tblplannedbreak$shiftbreak");
            });

            modelBuilder.Entity<UnitworkccsTblplant>(entity =>
            {
                entity.HasKey(e => e.PlantId);

                entity.ToTable("unitworkccs.tblplant", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("plantid");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantCode)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PlantDisplayName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlantLocation)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblpmsdetails>(entity =>
            {
                entity.HasKey(e => e.Pmsid);

                entity.ToTable("unitworkccs.tblpmsdetails", "unitworksccs");

                entity.Property(e => e.Pmsid)
                    .HasColumnName("pmsid")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSubmitted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PmendDate)
                    .HasColumnName("PMEndDate")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PmstartDate)
                    .HasColumnName("PMStartDate")
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblprecentcolour>(entity =>
            {
                entity.HasKey(e => e.ColourId);

                entity.ToTable("unitworkccs.tblprecentcolour", "unitworksccs");

                entity.Property(e => e.ColourId)
                    .HasColumnName("ColourID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Colour)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.Max).HasColumnType("int(11)");

                entity.Property(e => e.Min).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblpresenttool>(entity =>
            {
                entity.HasKey(e => e.PreToolId);

                entity.ToTable("unitworkccs.tblpresenttool", "unitworksccs");

                entity.Property(e => e.PreToolId)
                    .HasColumnName("PreToolID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PresentToolNum).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblpriorityalarms>(entity =>
            {
                entity.HasKey(e => e.AlarmId);

                entity.ToTable("unitworkccs.tblpriorityalarms", "unitworksccs");

                entity.Property(e => e.AlarmId)
                    .HasColumnName("AlarmID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlarmNumber).HasColumnType("int(11)");

                entity.Property(e => e.AxisNo)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsMailSent)
                    .HasColumnName("isMailSent")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.PriorityNumber).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblprocess>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.ToTable("unitworkccs.tblprocess", "unitworksccs");

                entity.Property(e => e.ProcessId)
                    .HasColumnName("processId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProcessName)
                    .HasColumnName("processName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblprodplanmasters>(entity =>
            {
                entity.HasKey(e => e.ProdPlanId);

                entity.ToTable("unitworkccs.tblprodplanmasters", "unitworksccs");

                entity.Property(e => e.ProdPlanId)
                    .HasColumnName("ProdPlanID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Fgcode)
                    .IsRequired()
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OrderQty).HasColumnType("int(11)");

                entity.Property(e => e.ProdOrderNo)
                    .IsRequired()
                    .HasColumnName("Prod_Order_No")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtyUnit)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SplitOrderQty).HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenter)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblproduct>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("unitworkccs.tblproduct", "unitworksccs");

                entity.Property(e => e.ProductId)
                    .HasColumnName("productId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblproductwisedefectcodes>(entity =>
            {
                entity.HasKey(e => e.ProductWiseDefectCodeId);

                entity.ToTable("unitworkccs.tblproductwisedefectcodes", "unitworksccs");

                entity.Property(e => e.ProductWiseDefectCodeId)
                    .HasColumnName("productWiseDefectCodeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.DefectCodeId)
                    .HasColumnName("defectCodeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Trim)
                    .HasColumnName("trim")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblprogramtransferhistory>(entity =>
            {
                entity.HasKey(e => e.Pthid);

                entity.ToTable("unitworkccs.tblprogramtransferhistory", "unitworksccs");

                entity.Property(e => e.Pthid)
                    .HasColumnName("PTHID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDesc).HasColumnType("longtext");

                entity.Property(e => e.ReturnStatus).HasColumnType("int(11)");

                entity.Property(e => e.ReturnTime).HasColumnType("datetime(6)");

                entity.Property(e => e.UploadedTime).HasColumnType("datetime(6)");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Version).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblraisedticket>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.ToTable("unitworkccs.tblraisedticket", "unitworksccs");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticketId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlarmId)
                    .HasColumnName("alarmId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ClassId)
                    .HasColumnName("classId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartId)
                    .HasColumnName("partId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("roleId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketClosedDate)
                    .HasColumnName("ticketClosedDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.TicketNo)
                    .HasColumnName("ticketNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.TicketOpenDate)
                    .HasColumnName("ticketOpenDate")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblrejectiondetails>(entity =>
            {
                entity.HasKey(e => e.RejectionId);

                entity.ToTable("unitworkccs.tblrejectiondetails", "unitworksccs");

                entity.Property(e => e.RejectionId)
                    .HasColumnName("rejectionId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.DefectCodeId)
                    .HasColumnName("defectCodeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefectQty)
                    .HasColumnName("defectQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DmcCodeStatus)
                    .HasColumnName("dmcCodeStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FgPartId)
                    .HasColumnName("fgPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDirLineInsp)
                    .HasColumnName("isDirLineInsp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDirQualityHead)
                    .HasColumnName("isDirQualityHead")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QrCodeNo)
                    .HasColumnName("qrCodeNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForRejection).HasColumnType("longtext");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblrejectqty>(entity =>
            {
                entity.HasKey(e => e.Rqid);

                entity.ToTable("unitworkccs.tblrejectqty", "unitworksccs");

                entity.HasIndex(e => e.Rid)
                    .HasName("tblrejectqty_ibfk_1");

                entity.HasIndex(e => e.Woid)
                    .HasName("tblrejectqty_ibfk_2");

                entity.Property(e => e.Rqid)
                    .HasColumnName("RQID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsFinished)
                    .HasColumnName("isFinished")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.RejectQty)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Woid)
                    .HasColumnName("WOID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.R)
                    .WithMany(p => p.UnitworkccsTblrejectqty)
                    .HasForeignKey(d => d.Rid)
                    .HasConstraintName("tblrejectqty_ibfk_1");

                entity.HasOne(d => d.Wo)
                    .WithMany(p => p.UnitworkccsTblrejectqty)
                    .HasForeignKey(d => d.Woid)
                    .HasConstraintName("tblrejectqty_ibfk_2");
            });

            modelBuilder.Entity<UnitworkccsTblrejectreason>(entity =>
            {
                entity.HasKey(e => e.Rid);

                entity.ToTable("unitworkccs.tblrejectreason", "unitworksccs");

                entity.Property(e => e.Rid)
                    .HasColumnName("RID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Cellid).HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsMaint)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsProd)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Machineid).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.RejectName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RejectNameDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblreportholder>(entity =>
            {
                entity.HasKey(e => e.Rhid);

                entity.ToTable("unitworkccs.tblreportholder", "unitworksccs");

                entity.Property(e => e.Rhid)
                    .HasColumnName("RHID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FromDate).HasColumnType("datetime(6)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("datetime(6)");

                entity.Property(e => e.WorkCenter)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblreworkdetails>(entity =>
            {
                entity.HasKey(e => e.ReworkId);

                entity.ToTable("unitworkccs.tblreworkdetails", "unitworksccs");

                entity.Property(e => e.ReworkId)
                    .HasColumnName("reworkId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.DefectCodeId)
                    .HasColumnName("defectCodeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefectQty)
                    .HasColumnName("defectQty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DmcCodeStatus)
                    .HasColumnName("dmcCodeStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FgPartId)
                    .HasColumnName("fgPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDirLineInsp)
                    .HasColumnName("isDirLineInsp")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDirQualityHead)
                    .HasColumnName("isDirQualityHead")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QrCodeNo)
                    .HasColumnName("qrCodeNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonForRework).HasColumnType("longtext");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblreworkreasons>(entity =>
            {
                entity.HasKey(e => e.ReWorkId);

                entity.ToTable("unitworkccs.tblreworkreasons", "unitworksccs");

                entity.Property(e => e.ReWorkId)
                    .HasColumnName("ReWorkID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.ReworkName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblrolemodulelink>(entity =>
            {
                entity.HasKey(e => e.Mrmlid);

                entity.ToTable("unitworkccs.tblrolemodulelink", "unitworksccs");

                entity.HasIndex(e => e.InsertedBy)
                    .HasName("tblrolemodulelink$InsertedBy_Id");

                entity.HasIndex(e => e.ModuleId)
                    .HasName("FK_tblrolemodulelink_tblroles");

                entity.Property(e => e.Mrmlid)
                    .HasColumnName("MRMLID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnableAdd).HasColumnType("smallint(6)");

                entity.Property(e => e.EnableDelete).HasColumnType("smallint(6)");

                entity.Property(e => e.EnableEdit).HasColumnType("smallint(6)");

                entity.Property(e => e.EnableReadOnly).HasColumnType("smallint(6)");

                entity.Property(e => e.EnableReport).HasColumnType("smallint(6)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSuperAdmin).HasColumnType("smallint(6)");

                entity.Property(e => e.IsVisible).HasColumnType("smallint(6)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ModuleId)
                    .HasColumnName("ModuleID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.InsertedByNavigation)
                    .WithMany(p => p.UnitworkccsTblrolemodulelink)
                    .HasForeignKey(d => d.InsertedBy)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tblrolemodulelink$InsertedBy_Id");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.UnitworkccsTblrolemodulelink)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_tblrolemodulelink_tblmodules");

                entity.HasOne(d => d.ModuleNavigation)
                    .WithMany(p => p.UnitworkccsTblrolemodulelink)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_tblrolemodulelink_tblroles");
            });

            modelBuilder.Entity<UnitworkccsTblroles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("unitworkccs.tblroles", "unitworksccs");

                entity.Property(e => e.RoleId)
                    .HasColumnName("Role_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.RoleDesc)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.RoleDisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblroutingno>(entity =>
            {
                entity.ToTable("unitworkccs.tblroutingno", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("cellId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChildFgPartId)
                    .HasColumnName("childFgPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FgPartId)
                    .HasColumnName("fgPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoutingNo)
                    .HasColumnName("routingNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellId)
                    .HasColumnName("subCellId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblsapinput>(entity =>
            {
                entity.HasKey(e => e.SapInputId);

                entity.ToTable("unitworkccs.tblsapinput", "unitworksccs");

                entity.Property(e => e.SapInputId)
                    .HasColumnName("SapInputID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PathLocation)
                    .IsRequired()
                    .HasColumnType("longtext");

                entity.Property(e => e.PathType).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblsar>(entity =>
            {
                entity.HasKey(e => e.Sid);

                entity.ToTable("unitworkccs.tblsar", "unitworksccs");

                entity.Property(e => e.Sid).HasColumnType("int(11)");

                entity.Property(e => e.BallunNo)
                    .HasColumnName("ballunNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Freq)
                    .HasColumnName("freq")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasColumnName("partNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdAndLocation)
                    .HasColumnName("prodAndLocation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProdQuality)
                    .HasColumnName("prodQuality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RejarctionQuality)
                    .HasColumnName("rejarctionQuality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpecialChar)
                    .HasColumnName("specialChar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Specification)
                    .HasColumnName("specification")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblsarminmax>(entity =>
            {
                entity.HasKey(e => e.Smid);

                entity.ToTable("unitworkccs.tblsarminmax", "unitworksccs");

                entity.Property(e => e.Smid).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Sarmax)
                    .HasColumnName("sarmax")
                    .HasColumnType("decimal(8,3)");

                entity.Property(e => e.Sarmin).HasColumnType("decimal(8,3)");

                entity.Property(e => e.Sarstatus)
                    .HasColumnName("sarstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sid)
                    .HasColumnName("sid")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblsendermailid>(entity =>
            {
                entity.HasKey(e => e.SeId);

                entity.ToTable("unitworkccs.tblsendermailid", "unitworksccs");

                entity.Property(e => e.SeId)
                    .HasColumnName("SE_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AutoEmailType).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryMailId)
                    .IsRequired()
                    .HasColumnName("PrimaryMailID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblsetupmaint>(entity =>
            {
                entity.HasKey(e => e.SetMainId);

                entity.ToTable("unitworkccs.tblsetupmaint", "unitworksccs");

                entity.HasIndex(e => e.LossCodeId)
                    .HasName("FK_tblSetupMaint_tbllossescodes");

                entity.Property(e => e.SetMainId)
                    .HasColumnName("SetMainID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DurationInSec)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.IsCompleted).HasColumnType("int(11)");

                entity.Property(e => e.IsSetup).HasColumnType("int(11)");

                entity.Property(e => e.IsStarted).HasColumnType("int(11)");

                entity.Property(e => e.LossCodeId)
                    .HasColumnName("LossCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLossTime)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModeId)
                    .HasColumnName("ModeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ServerSetMainId)
                    .HasColumnName("ServerSetMainID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Sync).HasColumnType("int(11)");

                entity.HasOne(d => d.LossCode)
                    .WithMany(p => p.UnitworkccsTblsetupmaint)
                    .HasForeignKey(d => d.LossCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblSetupMaint_tbllossescodes");
            });

            modelBuilder.Entity<UnitworkccsTblshiftBreaks>(entity =>
            {
                entity.HasKey(e => e.BreakId);

                entity.ToTable("unitworkccs.tblshift_breaks", "unitworksccs");

                entity.Property(e => e.BreakId)
                    .HasColumnName("BreakID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BreakDuration).HasColumnType("int(11)");

                entity.Property(e => e.BreakReason)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndTime).HasColumnType("time(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartTime).HasColumnType("time(6)");
            });

            modelBuilder.Entity<UnitworkccsTblshiftMstr>(entity =>
            {
                entity.HasKey(e => e.ShiftId);

                entity.ToTable("unitworkccs.tblshift_mstr", "unitworksccs");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("time(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ServerTabCheck)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ServerTabFlagSync)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("time(6)");
            });

            modelBuilder.Entity<UnitworkccsTblshiftdetails>(entity =>
            {
                entity.HasKey(e => e.ShiftDetailsId);

                entity.ToTable("unitworkccs.tblshiftdetails", "unitworksccs");

                entity.HasIndex(e => e.ShiftMethodId)
                    .HasName("tblshiftdetails$ShiftMethodIDshiftmethod");

                entity.Property(e => e.ShiftDetailsId)
                    .HasColumnName("ShiftDetailsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsGshift)
                    .HasColumnName("IsGShift")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsShiftDetailsEdited)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NextDay).HasColumnType("int(11)");

                entity.Property(e => e.ShiftDetailsDesc)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftDetailsEditedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.ShiftDetailsName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftEndTime).HasColumnType("time(6)");

                entity.Property(e => e.ShiftMethodId)
                    .HasColumnName("ShiftMethodID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShiftStartTime).HasColumnType("time(6)");

                entity.HasOne(d => d.ShiftMethod)
                    .WithMany(p => p.UnitworkccsTblshiftdetails)
                    .HasForeignKey(d => d.ShiftMethodId)
                    .HasConstraintName("tblshiftdetails$ShiftMethodIDshiftmethod");
            });

            modelBuilder.Entity<UnitworkccsTblshiftdetailsMachinewise>(entity =>
            {
                entity.HasKey(e => e.ShiftDetailsMacId);

                entity.ToTable("unitworkccs.tblshiftdetails_machinewise", "unitworksccs");

                entity.Property(e => e.ShiftDetailsMacId)
                    .HasColumnName("ShiftDetailsMacID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShiftDetailsId)
                    .HasColumnName("ShiftDetailsID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShiftName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTblshiftmethod>(entity =>
            {
                entity.HasKey(e => e.ShiftMethodId);

                entity.ToTable("unitworkccs.tblshiftmethod", "unitworksccs");

                entity.Property(e => e.ShiftMethodId)
                    .HasColumnName("ShiftMethodID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EditedDate).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsShiftMethodEdited)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.NoOfShifts).HasColumnType("int(11)");

                entity.Property(e => e.ShiftMethodDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftMethodName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblshiftplanner>(entity =>
            {
                entity.HasKey(e => e.ShiftPlannerId);

                entity.ToTable("unitworkccs.tblshiftplanner", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("tblshiftplanner$PlantIDshiftplanner");

                entity.HasIndex(e => e.ShopId)
                    .HasName("tblshiftplanner$ShopIDshiftplanner");

                entity.Property(e => e.ShiftPlannerId)
                    .HasColumnName("ShiftPlannerID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPlanRemoved)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPlanStopped)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlanStoppedDate).HasColumnType("date");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShiftMethodId)
                    .HasColumnName("ShiftMethodID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShiftPlannerDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftPlannerName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblshiftplanner)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("tblshiftplanner$PlantIDshiftplanner");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.UnitworkccsTblshiftplanner)
                    .HasForeignKey(d => d.ShopId)
                    .HasConstraintName("tblshiftplanner$ShopIDshiftplanner");
            });

            modelBuilder.Entity<UnitworkccsTblshop>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.ToTable("unitworkccs.tblshop", "unitworksccs");

                entity.HasIndex(e => e.PlantId)
                    .HasName("FK_tblshop_tblplant_idx");

                entity.Property(e => e.ShopId)
                    .HasColumnName("ShopID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("PlantID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShopDesc)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Shopdisplayname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.UnitworkccsTblshop)
                    .HasForeignKey(d => d.PlantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblshop_tblplant");
            });

            modelBuilder.Entity<UnitworkccsTblsmsdetails>(entity =>
            {
                entity.HasKey(e => e.SmsId);

                entity.ToTable("unitworkccs.tblsmsdetails", "unitworksccs");

                entity.Property(e => e.SmsId)
                    .HasColumnName("smsId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CellId)
                    .HasColumnName("cellId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasColumnName("contactNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employeeName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdleResponseId)
                    .HasColumnName("idleResponseId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IdleSms)
                    .HasColumnName("idleSms")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.OpNo)
                    .HasColumnName("opNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ResponseId)
                    .HasColumnName("responseId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmsPriority)
                    .HasColumnName("smsPriority")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellId)
                    .HasColumnName("subCellId")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticketId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TimeToBeTriggered)
                    .HasColumnName("timeToBeTriggered")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblsourcemaster>(entity =>
            {
                entity.HasKey(e => e.SourceId);

                entity.ToTable("unitworkccs.tblsourcemaster", "unitworksccs");

                entity.Property(e => e.SourceId)
                    .HasColumnName("sourceId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SourceDescription)
                    .HasColumnName("sourceDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceName)
                    .HasColumnName("sourceName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblstatusmaster>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("unitworkccs.tblstatusmaster", "unitworksccs");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.StatusDesc)
                    .HasColumnName("statusDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StatusName)
                    .HasColumnName("statusName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblstdtoollife>(entity =>
            {
                entity.HasKey(e => e.StdToolLifeId);

                entity.ToTable("unitworkccs.tblstdtoollife", "unitworksccs");

                entity.Property(e => e.StdToolLifeId).HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

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

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StdToolLife).HasColumnType("int(11)");

                entity.Property(e => e.ToolName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ToolNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblstoppage>(entity =>
            {
                entity.HasKey(e => e.StoppagesId);

                entity.ToTable("unitworkccs.tblstoppage", "unitworksccs");

                entity.Property(e => e.StoppagesId)
                    .HasColumnName("stoppagesId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AlramDesc)
                    .HasColumnName("alramDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AlramNo)
                    .HasColumnName("alramNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.SourceId)
                    .HasColumnName("sourceId")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblsubcellfinalmaster>(entity =>
            {
                entity.HasKey(e => e.SubCellFinalId);

                entity.ToTable("unitworkccs.tblsubcellfinalmaster", "unitworksccs");

                entity.Property(e => e.SubCellFinalId)
                    .HasColumnName("subCellFinalId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellFinalId)
                    .HasColumnName("cellFinalId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SubCellFinalDesc)
                    .HasColumnName("subCellFinalDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellFinalName)
                    .HasColumnName("subCellFinalName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblsystemconfig>(entity =>
            {
                entity.HasKey(e => e.SystemConfigId);

                entity.ToTable("unitworkccs.tblsystemconfig", "unitworksccs");

                entity.Property(e => e.SystemConfigId)
                    .HasColumnName("systemConfigId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PcHostName)
                    .HasColumnName("pcHostName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PcIpAddress)
                    .HasColumnName("pcIpAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PcMacAddress)
                    .HasColumnName("pcMacAddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbltallstockavailibility>(entity =>
            {
                entity.HasKey(e => e.TallStockAvailId);

                entity.ToTable("unitworkccs.tbltallstockavailibility", "unitworksccs");

                entity.Property(e => e.TallStockAvailId)
                    .HasColumnName("tallStockAvailId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.TallStockAvailName)
                    .HasColumnName("tallStockAvailName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblticketraiseddet>(entity =>
            {
                entity.HasKey(e => e.TicketRaisedDetId);

                entity.ToTable("unitworkccs.tblticketraiseddet", "unitworksccs");

                entity.Property(e => e.TicketRaisedDetId)
                    .HasColumnName("ticketRaisedDetId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CommentsByOperator)
                    .HasColumnName("commentsByOperator")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IfOperatorAccepts)
                    .HasColumnName("ifOperatorAccepts")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IfSupportTeamOpen)
                    .HasColumnName("ifSupportTeamOpen")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsStatus)
                    .HasColumnName("isStatus")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MntAcceptReason)
                    .HasColumnName("mntAcceptReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MntRejectReason)
                    .HasColumnName("mntRejectReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OpAcceptReson)
                    .HasColumnName("opAcceptReson")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OpRejectReason)
                    .HasColumnName("opRejectReason")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorAcceptRejectDate)
                    .HasColumnName("operatorAcceptRejectDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.OperatorId)
                    .HasColumnName("operatorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SupportTeamAckDate)
                    .HasColumnName("supportTeamAckDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SupportTeamClosureDate)
                    .HasColumnName("supportTeamClosureDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.SupportTeamId)
                    .HasColumnName("supportTeamId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticketId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketNo)
                    .HasColumnName("ticketNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblticketreason>(entity =>
            {
                entity.HasKey(e => e.TktReasonId);

                entity.ToTable("unitworkccs.tblticketreason", "unitworksccs");

                entity.Property(e => e.TktReasonId)
                    .HasColumnName("tktReasonId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("categoryId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ReasonDesc)
                    .HasColumnName("reasonDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbltoolandsocketdetails>(entity =>
            {
                entity.HasKey(e => e.SocketId);

                entity.ToTable("unitworkccs.tbltoolandsocketdetails", "unitworksccs");

                entity.Property(e => e.SocketId)
                    .HasColumnName("socketId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ActaulToolLife)
                    .HasColumnName("actaulToolLife")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Qrcode)
                    .HasColumnName("qrcode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SocketNo)
                    .HasColumnName("socketNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StandardToolLife)
                    .HasColumnName("standardToolLife")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolInsertedDateTime)
                    .HasColumnName("toolInsertedDateTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ToolNumber)
                    .HasColumnName("toolNumber")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolRemovedDateTime)
                    .HasColumnName("toolRemovedDateTime")
                    .HasColumnType("datetime(6)");
            });

            modelBuilder.Entity<UnitworkccsTbltoolbrdnreasonlvl1>(entity =>
            {
                entity.ToTable("unitworkccs.tbltoolbrdnreasonlvl1", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbltoolbrkdnreason>(entity =>
            {
                entity.HasKey(e => e.ReasonId);

                entity.ToTable("unitworkccs.tbltoolbrkdnreason", "unitworksccs");

                entity.Property(e => e.ReasonId)
                    .HasColumnName("reasonId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ForResharpening)
                    .HasColumnName("forResharpening")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReasonName)
                    .HasColumnName("reasonName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbltoolcounter>(entity =>
            {
                entity.HasKey(e => e.ToolCounterId);

                entity.ToTable("unitworkccs.tbltoolcounter", "unitworksccs");

                entity.Property(e => e.ToolCounterId)
                    .HasColumnName("ToolCounterID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsReset).HasColumnType("int(11)");

                entity.Property(e => e.LifeCounter).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ResetCounter).HasColumnType("int(11)");

                entity.Property(e => e.ToolNum)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TotalLifeCounter).HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbltoollifeoperator>(entity =>
            {
                entity.HasKey(e => e.ToolLifeId);

                entity.ToTable("unitworkccs.tbltoollifeoperator", "unitworksccs");

                entity.Property(e => e.ToolLifeId)
                    .HasColumnName("ToolLifeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hmiid)
                    .HasColumnName("HMIID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedBy).HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsCompleted)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsCycleStart)
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDeleted).HasColumnType("int(11)");

                entity.Property(e => e.IsReset).HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ResetCounter).HasColumnType("int(11)");

                entity.Property(e => e.ResetReason)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StandardToolLife).HasColumnType("int(11)");

                entity.Property(e => e.Sync).HasColumnType("int(11)");

                entity.Property(e => e.ToolCtcode)
                    .HasColumnName("ToolCTCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolIdadmin)
                    .HasColumnName("ToolIDAdmin")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToolNo)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Toollifecounter)
                    .HasColumnName("toollifecounter")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTbltools>(entity =>
            {
                entity.HasKey(e => e.ToolId);

                entity.ToTable("unitworkccs.tbltools", "unitworksccs");

                entity.Property(e => e.ToolId)
                    .HasColumnName("toolId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.GrnNo)
                    .HasColumnName("grnNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InspLotNo)
                    .HasColumnName("inspLotNo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SapCode)
                    .HasColumnName("sapCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SlipNo)
                    .HasColumnName("slipNo")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ToolBatchNo)
                    .HasColumnName("toolBatchNo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolDesc)
                    .HasColumnName("toolDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolInsert)
                    .HasColumnName("toolInsert")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolLocation)
                    .HasColumnName("toolLocation")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName)
                    .HasColumnName("toolName")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolSapCode)
                    .HasColumnName("toolSapCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolType)
                    .HasColumnName("toolType")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Uom)
                    .HasColumnName("UOM")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbltosapfilepath>(entity =>
            {
                entity.HasKey(e => e.ToSapfilePathId);

                entity.ToTable("unitworkccs.tbltosapfilepath", "unitworksccs");

                entity.Property(e => e.ToSapfilePathId)
                    .HasColumnName("toSAPFilePathID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

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

            modelBuilder.Entity<UnitworkccsTbltosapshopnames>(entity =>
            {
                entity.HasKey(e => e.ToSapshopNamesId);

                entity.ToTable("unitworkccs.tbltosapshopnames", "unitworksccs");

                entity.Property(e => e.ToSapshopNamesId)
                    .HasColumnName("toSAPShopNamesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSetupShown)
                    .HasColumnName("isSetupShown")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.ShopId).HasColumnType("int(11)");

                entity.Property(e => e.ShopName)
                    .HasMaxLength(65)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTbltrialpartcount>(entity =>
            {
                entity.HasKey(e => e.TrialPartId);

                entity.ToTable("unitworkccs.tbltrialpartcount", "unitworksccs");

                entity.Property(e => e.TrialPartId)
                    .HasColumnName("trialPartId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate)
                    .HasColumnName("correctedDate")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("machineId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TicketCloseDate)
                    .HasColumnName("ticketCloseDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticketId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TicketOpenDate)
                    .HasColumnName("ticketOpenDate")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.TrialPartCount)
                    .HasColumnName("trialPartCount")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsTblunit>(entity =>
            {
                entity.HasKey(e => e.UId);

                entity.ToTable("unitworkccs.tblunit", "unitworksccs");

                entity.HasIndex(e => e.UId)
                    .HasName("tblunit$U_ID_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.UId)
                    .HasColumnName("U_ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblusers>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("unitworkccs.tblusers", "unitworksccs");

                entity.HasIndex(e => e.PrimaryRole)
                    .HasName("tblusers$PrimaryRole");

                entity.HasIndex(e => e.SecondaryRole)
                    .HasName("tblusers$SecondaryRole");

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PrimaryRole).HasColumnType("int(11)");

                entity.Property(e => e.SecondaryRole).HasColumnType("int(11)");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.PrimaryRoleNavigation)
                    .WithMany(p => p.UnitworkccsTblusersPrimaryRoleNavigation)
                    .HasForeignKey(d => d.PrimaryRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblusers$PrimaryRole");

                entity.HasOne(d => d.SecondaryRoleNavigation)
                    .WithMany(p => p.UnitworkccsTblusersSecondaryRoleNavigation)
                    .HasForeignKey(d => d.SecondaryRole)
                    .HasConstraintName("tblusers$SecondaryRole");
            });

            modelBuilder.Entity<UnitworkccsTblvendor>(entity =>
            {
                entity.HasKey(e => e.VendorId);

                entity.ToTable("unitworkccs.tblvendor", "unitworksccs");

                entity.Property(e => e.VendorId)
                    .HasColumnName("vendorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(3)");

                entity.Property(e => e.Vendor)
                    .HasColumnName("vendor")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasColumnName("vendorName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblwolossess>(entity =>
            {
                entity.HasKey(e => e.WolossesId);

                entity.ToTable("unitworkccs.tblwolossess", "unitworksccs");

                entity.Property(e => e.WolossesId)
                    .HasColumnName("WOLossesID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Hmiid)
                    .HasColumnName("HMIID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Level).HasColumnType("int(11)");

                entity.Property(e => e.LossCodeLevel1Id)
                    .HasColumnName("LossCodeLevel1ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LossCodeLevel1Name)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.LossCodeLevel2Id)
                    .HasColumnName("LossCodeLevel2ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LossCodeLevel2Name)
                    .HasMaxLength(145)
                    .IsUnicode(false);

                entity.Property(e => e.LossDuration).HasColumnType("decimal(8,2)");

                entity.Property(e => e.LossId)
                    .HasColumnName("LossID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LossName)
                    .HasMaxLength(145)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblworeport>(entity =>
            {
                entity.HasKey(e => e.WoreportId);

                entity.ToTable("unitworkccs.tblworeport", "unitworksccs");

                entity.Property(e => e.WoreportId)
                    .HasColumnName("WOReportID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Blue)
                    .HasColumnType("decimal(8,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Breakdown).HasColumnType("decimal(8,2)");

                entity.Property(e => e.CorrectedDate)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.CuttingTime).HasColumnType("decimal(8,2)");

                entity.Property(e => e.DeliveredQty).HasColumnType("int(11)");

                entity.Property(e => e.EndTime).HasColumnType("datetime(6)");

                entity.Property(e => e.Hmiid)
                    .HasColumnName("HMIID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HoldReason)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                entity.Property(e => e.Idle).HasColumnType("decimal(8,2)");

                entity.Property(e => e.InsertedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.IsHold).HasColumnType("int(11)");

                entity.Property(e => e.IsMultiWo)
                    .HasColumnName("IsMultiWO")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsNormalWc)
                    .HasColumnName("IsNormalWC")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPf)
                    .HasColumnName("IsPF")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MinorLoss)
                    .HasColumnType("decimal(6,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.Mrweight)
                    .HasColumnName("MRWeight")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.NccuttingTimePerPart)
                    .HasColumnName("NCCuttingTimePerPart")
                    .HasColumnType("decimal(8,2)");

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
                    .HasColumnType("decimal(8,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.RejectedQty).HasColumnType("int(11)");

                entity.Property(e => e.RejectedReason)
                    .HasMaxLength(245)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapQtyTime)
                    .HasColumnType("decimal(8,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.SelfInspection).HasColumnType("decimal(8,2)");

                entity.Property(e => e.SettingTime).HasColumnType("decimal(8,2)");

                entity.Property(e => e.Shift)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SplitWo)
                    .HasColumnName("SplitWO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime(6)");

                entity.Property(e => e.SummationOfSctvsPp)
                    .HasColumnName("SummationOfSCTvsPP")
                    .HasColumnType("decimal(8,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TargetQty).HasColumnType("int(11)");

                entity.Property(e => e.TotalNccuttingTime)
                    .HasColumnName("TotalNCCuttingTime")
                    .HasColumnType("decimal(8,2)");

                entity.Property(e => e.Type)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Woefficiency)
                    .HasColumnName("WOEfficiency")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblworkcenter>(entity =>
            {
                entity.HasKey(e => e.WorkCenterId);

                entity.ToTable("unitworkccs.tblworkcenter", "unitworksccs");

                entity.Property(e => e.WorkCenterId)
                    .HasColumnName("workCenterId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CostCenter)
                    .HasColumnName("costCenter")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("tinyint(1)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plantCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plantId")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.WoCode)
                    .HasColumnName("woCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterDescription)
                    .HasColumnName("workCenterDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.WorkCenterName)
                    .HasColumnName("workCenterName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsTblworkorderentry>(entity =>
            {
                entity.HasKey(e => e.Hmiid);

                entity.ToTable("unitworkccs.tblworkorderentry", "unitworksccs");

                entity.Property(e => e.Hmiid)
                    .HasColumnName("HMIID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellId)
                    .HasColumnName("CellID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CorrectedDate).HasColumnType("date");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HoldCodeId)
                    .HasColumnName("HoldCodeID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.HoldDuration).HasColumnType("int(11)");

                entity.Property(e => e.HoldTime).HasColumnType("datetime(6)");

                entity.Property(e => e.IsFinished).HasColumnType("int(11)");

                entity.Property(e => e.IsFlag).HasColumnType("int(11)");

                entity.Property(e => e.IsHold).HasColumnType("int(11)");

                entity.Property(e => e.IsMultiWo)
                    .HasColumnName("IsMultiWO")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsPartialFinish).HasColumnType("int(11)");

                entity.Property(e => e.IsReWork)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSplit)
                    .HasColumnName("isSplit")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IsStarted).HasColumnType("int(11)");

                entity.Property(e => e.IsWorkOrder)
                    .HasColumnName("isWorkOrder")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MachineId)
                    .HasColumnName("MachineID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OperationNo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .IsRequired()
                    .HasColumnName("OperatorID")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartNo)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.PartsPerCycle)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PestartTime)
                    .HasColumnName("PEStartTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ProcessQty).HasColumnType("int(11)");

                entity.Property(e => e.ProdOrderNo)
                    .IsRequired()
                    .HasColumnName("Prod_Order_No")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.ProdOrderQty).HasColumnType("int(11)");

                entity.Property(e => e.ReWorkEnd)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReWorkReasonId)
                    .HasColumnName("ReWorkReasonID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReWorkStart)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ReworkEndTime)
                    .HasColumnName("reworkEndTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ReworkStartTime)
                    .HasColumnName("reworkStartTime")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.ScrapQty).HasColumnType("int(11)");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status).HasColumnType("int(11)");

                entity.Property(e => e.SyncInsert).HasColumnType("int(11)");

                entity.Property(e => e.TotalQty)
                    .HasColumnName("Total_Qty")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Woend)
                    .HasColumnName("WOEnd")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.Wostart)
                    .HasColumnName("WOStart")
                    .HasColumnType("datetime(6)");

                entity.Property(e => e.YieldQty)
                    .HasColumnName("Yield_Qty")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<UnitworkccsToolnamemaster>(entity =>
            {
                entity.HasKey(e => e.ToolId);

                entity.ToTable("unitworkccs.toolnamemaster", "unitworksccs");

                entity.Property(e => e.ToolId)
                    .HasColumnName("toolId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnName("createdOn");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("isDeleted")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedBy)
                    .HasColumnName("modifiedBy")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnName("modifiedOn");

                entity.Property(e => e.ToolDesc)
                    .HasColumnName("toolDesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName)
                    .HasColumnName("toolName")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UnitworkccsWeekdata>(entity =>
            {
                entity.HasKey(e => e.WeekId);

                entity.ToTable("unitworkccs.weekdata", "unitworksccs");

                entity.Property(e => e.WeekId)
                    .HasColumnName("WeekID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CreatedBy).HasColumnType("int(11)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Isdeleted)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedBy).HasColumnType("int(11)");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime(6)");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<WimerasysControlplan>(entity =>
            {
                entity.ToTable("wimerasys.controlplan", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApprovedBy)
                    .HasColumnName("approvedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate)
                    .HasColumnName("approvedDate")
                    .HasColumnType("date");

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChildPartNumber)
                    .HasColumnName("childPartNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlPlanNumber)
                    .IsRequired()
                    .HasColumnName("controlPlanNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlPlanType)
                    .HasColumnName("controlPlanType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CoreTeam)
                    .HasColumnName("coreTeam")
                    .HasColumnType("longtext");

                entity.Property(e => e.CustomerApprovalDate)
                    .HasColumnName("customerApprovalDate")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerRefNumber)
                    .HasColumnName("customerRefNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerRevNumber)
                    .HasColumnName("customerRevNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Days)
                    .HasColumnName("days")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FgDescription)
                    .HasColumnName("fgDescription")
                    .HasColumnType("longtext");

                entity.Property(e => e.FgNumber)
                    .HasColumnName("fgNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCheck)
                    .HasColumnName("firstCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FirstCheckedBy)
                    .HasColumnName("firstCheckedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstCheckedDate)
                    .HasColumnName("firstCheckedDate")
                    .HasColumnType("date");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.KeyContactDetails)
                    .HasColumnName("keyContactDetails")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MppPartNumber)
                    .HasColumnName("mppPartNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostToCheck)
                    .HasColumnName("postToCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PreparedBy)
                    .HasColumnName("preparedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PreparedDate)
                    .HasColumnName("preparedDate")
                    .HasColumnType("date");

                entity.Property(e => e.RevisionDate)
                    .HasColumnName("revisionDate")
                    .HasColumnType("date");

                entity.Property(e => e.RevisionNumber)
                    .HasColumnName("revisionNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RoutingNumber)
                    .HasColumnName("routingNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCheck)
                    .HasColumnName("secondCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SecondCheckedBy)
                    .HasColumnName("secondCheckedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondCheckedDate)
                    .HasColumnName("secondCheckedDate")
                    .HasColumnType("date");

                entity.Property(e => e.SubCell)
                    .HasColumnName("subCell")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasColumnName("supplierCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdCheck)
                    .HasColumnName("thirdCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ThirdCheckedBy)
                    .HasColumnName("thirdCheckedBy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ThirdCheckedDate)
                    .HasColumnName("thirdCheckedDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<WimerasysCpdetails>(entity =>
            {
                entity.ToTable("wimerasys.cpdetails", "unitworksccs");

                entity.HasIndex(e => e.CpId)
                    .HasName("FK_cpDetails_ControlPlan");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Approved)
                    .HasColumnName("approved")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BallunNumber)
                    .HasColumnName("ballunNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasColumnType("longtext");

                entity.Property(e => e.CpId)
                    .HasColumnName("cp_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Datem)
                    .HasColumnName("datem")
                    .HasColumnType("longtext");

                entity.Property(e => e.Dimensions)
                    .HasColumnName("dimensions")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EvalutionMathod)
                    .HasColumnName("evalutionMathod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Freqency)
                    .HasColumnName("freqency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LisEvalutionMethod)
                    .HasColumnName("lisEvalutionMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LisRecordingMethod)
                    .HasColumnName("lisRecordingMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LisTime)
                    .HasColumnName("lisTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lisfreqency)
                    .HasColumnName("lisfreqency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Machines)
                    .HasColumnName("machines")
                    .HasColumnType("longtext");

                entity.Property(e => e.MaxTolerance)
                    .HasColumnName("maxTolerance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinTolerance)
                    .HasColumnName("minTolerance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpDescription)
                    .HasColumnName("opDescription")
                    .HasColumnType("longtext");

                entity.Property(e => e.OperationNumber)
                    .HasColumnName("operationNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PcEvalutionMathod)
                    .HasColumnName("pcEvalutionMathod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcFreqency)
                    .HasColumnName("pcFreqency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcQuantity)
                    .HasColumnName("pcQuantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessChar)
                    .HasColumnName("processChar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCheck)
                    .HasColumnName("processCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProductChar)
                    .HasColumnName("productChar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCheck)
                    .HasColumnName("productCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QaNumber1)
                    .HasColumnName("qaNumber1")
                    .HasColumnType("longtext");

                entity.Property(e => e.QaNumber2)
                    .HasColumnName("qaNumber2")
                    .HasColumnType("longtext");

                entity.Property(e => e.QaNumber3)
                    .HasColumnName("qaNumber3")
                    .HasColumnType("longtext");

                entity.Property(e => e.QualityCheck)
                    .HasColumnName("qualityCheck")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Rcnnumber)
                    .HasColumnName("RCNNumber")
                    .HasColumnType("longtext");

                entity.Property(e => e.ReactionPlan)
                    .HasColumnName("reactionPlan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordingMethod)
                    .HasColumnName("recordingMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SettingSubGroup)
                    .HasColumnName("settingSubGroup")
                    .HasColumnType("longtext");

                entity.Property(e => e.SpclCharClass)
                    .HasColumnName("spclCharClass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StageDrawingNumber)
                    .HasColumnName("stageDrawingNumber")
                    .HasColumnType("longtext");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolLayoutNumber)
                    .HasColumnName("toolLayoutNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkInstructionNumber1)
                    .HasColumnName("workInstructionNumber1")
                    .HasColumnType("longtext");

                entity.Property(e => e.WorkInstructionNumber2)
                    .HasColumnName("workInstructionNumber2")
                    .HasColumnType("longtext");

                entity.Property(e => e.WorkInstructionNumber3)
                    .HasColumnName("workInstructionNumber3")
                    .HasColumnType("longtext");

                entity.HasOne(d => d.Cp)
                    .WithMany(p => p.WimerasysCpdetails)
                    .HasForeignKey(d => d.CpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cpDetails_ControlPlan");
            });

            modelBuilder.Entity<WimerasysDir>(entity =>
            {
                entity.ToTable("wimerasys.dir", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Action)
                    .HasColumnName("action")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveDirRidate)
                    .HasColumnName("approveDirRIDate")
                    .HasColumnType("date");

                entity.Property(e => e.ApproveDirRiverify)
                    .HasColumnName("approveDirRIVerify")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("cardNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cell)
                    .HasColumnName("cell")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDirHoddate)
                    .HasColumnName("checkDirHODDate")
                    .HasColumnType("date");

                entity.Property(e => e.CheckDirHodverify)
                    .HasColumnName("checkDirHODVerify")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDirQhdate)
                    .HasColumnName("checkDirQHDate")
                    .HasColumnType("date");

                entity.Property(e => e.CheckDirQhverify)
                    .HasColumnName("checkDirQHVerify")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckDirRidate)
                    .HasColumnName("checkDirRIDate")
                    .HasColumnType("date");

                entity.Property(e => e.CheckDirRiverify)
                    .HasColumnName("checkDirRIVerify")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompeletedDate)
                    .HasColumnName("compeletedDate")
                    .HasColumnType("date");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DefectCode)
                    .HasColumnName("defectCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectDescription)
                    .HasColumnName("defectDescription")
                    .HasColumnType("longtext");

                entity.Property(e => e.Machine)
                    .HasColumnName("machine")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OkParts)
                    .HasColumnName("okParts")
                    .HasColumnType("int(11)");

                entity.Property(e => e.OpenTracker)
                    .HasColumnName("openTracker")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operator)
                    .HasColumnName("operator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartDescription)
                    .HasColumnName("partDescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionHeadVerification)
                    .HasColumnName("productionHeadVerification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductionHeadVerificationDate)
                    .HasColumnName("productionHeadVerificationDate")
                    .HasColumnType("date");

                entity.Property(e => e.QrCode)
                    .HasColumnName("qrCode")
                    .HasColumnType("longtext");

                entity.Property(e => e.QtyHeadVerification)
                    .HasColumnName("qtyHeadVerification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtyHeadVerificationDate)
                    .HasColumnName("qtyHeadVerificationDate")
                    .HasColumnType("date");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RejectId)
                    .HasColumnName("rejectId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RejectOrRework)
                    .HasColumnName("rejectOrRework")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReworkId)
                    .HasColumnName("reworkId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReworkParts)
                    .HasColumnName("reworkParts")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Riverification)
                    .HasColumnName("RIVerification")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RiverificationDate)
                    .HasColumnName("RIVerificationDate")
                    .HasColumnType("date");

                entity.Property(e => e.RootCause)
                    .HasColumnName("rootCause")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapOrRework)
                    .HasColumnName("scrapOrRework")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapParts)
                    .HasColumnName("scrapParts")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasColumnType("char(10)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StorageLocation)
                    .HasColumnName("storageLocation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCell)
                    .HasColumnName("subCell")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetDate)
                    .HasColumnName("targetDate")
                    .HasColumnType("date");

                entity.Property(e => e.TrackerNumber)
                    .HasColumnName("trackerNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderNumber)
                    .HasColumnName("workOrderNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysDocuments>(entity =>
            {
                entity.ToTable("wimerasys.documents", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("documentNumber")
                    .HasColumnType("longtext");

                entity.Property(e => e.DocumentType)
                    .HasColumnName("documentType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("documentUrl")
                    .HasColumnType("longtext");

                entity.Property(e => e.OperationNumber)
                    .HasColumnName("operationNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionDate)
                    .HasColumnName("revisionDate")
                    .HasColumnType("date");

                entity.Property(e => e.RevisionNumber)
                    .HasColumnName("revisionNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionReason)
                    .HasColumnName("revisionReason")
                    .HasColumnType("longtext");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serialNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDate)
                    .HasColumnName("uploadedDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<WimerasysEmployeedetails>(entity =>
            {
                entity.ToTable("wimerasys.employeedetails", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("department_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DivisionId)
                    .HasColumnName("division_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DivisionName)
                    .HasColumnName("division_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeCode)
                    .HasColumnName("employee_code")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmployeeEmail)
                    .HasColumnName("employee_email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasColumnName("employee_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeNumber)
                    .HasColumnName("employee_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasColumnName("grade")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantCode)
                    .HasColumnName("plant_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlantId)
                    .HasColumnName("plant_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlantName)
                    .HasColumnName("plant_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysEvaluation>(entity =>
            {
                entity.ToTable("wimerasys.evaluation", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characteristic)
                    .HasColumnName("characteristic")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysFgandcellallocationdetails>(entity =>
            {
                entity.ToTable("wimerasys.fgandcellallocationdetails", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CellFinal)
                    .HasColumnName("cellFinal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmcorQrcodeStatus)
                    .HasColumnName("DMCOrQRCodeStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasColumnName("material")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialDescription)
                    .HasColumnName("materialDescription")
                    .HasColumnType("longtext");

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubCellFinal)
                    .HasColumnName("subCellFinal")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysProcess>(entity =>
            {
                entity.ToTable("wimerasys.process", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characteristic)
                    .IsRequired()
                    .HasColumnName("characteristic")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysProduct>(entity =>
            {
                entity.ToTable("wimerasys.product", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characteristic)
                    .IsRequired()
                    .HasColumnName("characteristic")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysProductwisedefectdetails>(entity =>
            {
                entity.ToTable("wimerasys.productwisedefectdetails", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DefectCode)
                    .HasColumnName("defectCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectDescription)
                    .HasColumnName("defectDescription")
                    .HasColumnType("longtext");

                entity.Property(e => e.PartName)
                    .HasColumnName("partName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartNumber)
                    .HasColumnName("partNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plant)
                    .HasColumnName("plant")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trim)
                    .HasColumnName("trim")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysRevisiondetails>(entity =>
            {
                entity.ToTable("wimerasys.revisiondetails", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.BallunNumber)
                    .HasColumnName("ballunNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Capacity)
                    .HasColumnName("capacity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlPlanNumber)
                    .IsRequired()
                    .HasColumnName("controlPlanNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dimensions)
                    .HasColumnName("dimensions")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EvalutionMathod)
                    .HasColumnName("evalutionMathod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Freqency)
                    .HasColumnName("freqency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LisEvalutionMethod)
                    .HasColumnName("lisEvalutionMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LisRecordingMethod)
                    .HasColumnName("lisRecordingMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LisTime)
                    .HasColumnName("lisTime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lisfreqency)
                    .HasColumnName("lisfreqency")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Machines)
                    .HasColumnName("machines")
                    .HasColumnType("longtext");

                entity.Property(e => e.MaxTolerance)
                    .HasColumnName("maxTolerance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinTolerance)
                    .HasColumnName("minTolerance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpDescription)
                    .HasColumnName("opDescription")
                    .HasColumnType("longtext");

                entity.Property(e => e.OperationNumber)
                    .HasColumnName("operationNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PcEvalutionMathod)
                    .HasColumnName("pcEvalutionMathod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcFreqency)
                    .HasColumnName("pcFreqency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PcQuantity)
                    .HasColumnName("pcQuantity")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessChar)
                    .HasColumnName("processChar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductChar)
                    .HasColumnName("productChar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QaNumber1)
                    .HasColumnName("qaNumber1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QaNumber2)
                    .HasColumnName("qaNumber2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QaNumber3)
                    .HasColumnName("qaNumber3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rcnnumber)
                    .HasColumnName("RCNNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReactionPlan)
                    .HasColumnName("reactionPlan")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordingMethod)
                    .HasColumnName("recordingMethod")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Responsibility)
                    .HasColumnName("responsibility")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevisionNumber)
                    .HasColumnName("revisionNumber")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SettingSubGroup)
                    .HasColumnName("settingSubGroup")
                    .HasColumnType("longtext");

                entity.Property(e => e.SpclCharClass)
                    .HasColumnName("spclCharClass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StageDrawingNumber)
                    .HasColumnName("stageDrawingNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolLayoutNumber)
                    .HasColumnName("toolLayoutNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkInstructionNumber1)
                    .HasColumnName("workInstructionNumber1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkInstructionNumber2)
                    .HasColumnName("workInstructionNumber2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkInstructionNumber3)
                    .HasColumnName("workInstructionNumber3")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WimerasysScc>(entity =>
            {
                entity.ToTable("wimerasys.scc", "unitworksccs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Characteristic)
                    .IsRequired()
                    .HasColumnName("characteristic")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
