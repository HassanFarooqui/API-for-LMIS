//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class bkpTbl_BP
    {
        public int bp_Id { get; set; }
        public Nullable<int> systolic { get; set; }
        public Nullable<int> diastolic { get; set; }
        public string Diagnosis { get; set; }
        public Nullable<bool> Diabetes { get; set; }
        public Nullable<bool> HeartAttackInLast3Year { get; set; }
        public Nullable<bool> Stroke { get; set; }
        public Nullable<bool> KindneyDisease { get; set; }
        public Nullable<int> CheckUp_Id { get; set; }
        public string name { get; set; }
        public Nullable<bool> is_Active { get; set; }
        public Nullable<bool> is_Deleted { get; set; }
        public string created_On { get; set; }
        public string created_By { get; set; }
        public string update_On { get; set; }
        public string updated_By { get; set; }
        public Nullable<int> patient_Id { get; set; }
        public string insertion_Timestamp { get; set; }
    }
}
