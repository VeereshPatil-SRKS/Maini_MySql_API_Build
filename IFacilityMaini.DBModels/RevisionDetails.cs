using System;
using System.Collections.Generic;

namespace IFacilityMaini.DBModels
{
    public partial class RevisionDetails
    {
        public int Id { get; set; }
        public string ControlPlanNumber { get; set; }
        public int? RevisionNumber { get; set; }
        public string ToolLayoutNumber { get; set; }
        public int? OperationNumber { get; set; }
        public string BallunNumber { get; set; }
        public string ProcessChar { get; set; }
        public string SpclCharClass { get; set; }
        public string ProductChar { get; set; }
        public string Dimensions { get; set; }
        public string MinTolerance { get; set; }
        public string MaxTolerance { get; set; }
        public string RecordingMethod { get; set; }
        public string Responsibility { get; set; }
        public string ReactionPlan { get; set; }
        public string Freqency { get; set; }
        public string Time { get; set; }
        public string Capacity { get; set; }
        public string EvalutionMathod { get; set; }
        public string OpDescription { get; set; }
        public string Machines { get; set; }
        public string Rcnnumber { get; set; }
        public string WorkInstructionNumber1 { get; set; }
        public string WorkInstructionNumber2 { get; set; }
        public string WorkInstructionNumber3 { get; set; }
        public string QaNumber1 { get; set; }
        public string QaNumber2 { get; set; }
        public string QaNumber3 { get; set; }
        public string StageDrawingNumber { get; set; }
        public string LisEvalutionMethod { get; set; }
        public string LisRecordingMethod { get; set; }
        public string LisTime { get; set; }
        public int? Lisfreqency { get; set; }
        public string SettingSubGroup { get; set; }
        public string PcEvalutionMathod { get; set; }
        public string PcFreqency { get; set; }
        public int? PcQuantity { get; set; }
    }
}
