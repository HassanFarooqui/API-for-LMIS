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
    
    public partial class Tbl_Patient
    {
        public int patient_Id { get; set; }
        public string full_Name { get; set; }
        public Nullable<int> age { get; set; }
        public string gender { get; set; }
        public string date_Of_Brith { get; set; }
        public string status { get; set; }
        public string address_Id { get; set; }
        public string age_Updated_at { get; set; }
        public string device_Created_at { get; set; }
        public string device_Updated_at { get; set; }
        public Nullable<bool> test_data { get; set; }
        public Nullable<int> registration_facility_id { get; set; }
        public Nullable<int> registration_User_Id { get; set; }
        public Nullable<bool> contacted_By_Counsellor { get; set; }
        public string could_Not_Contact_Reason { get; set; }
        public string recorded_at { get; set; }
        public string name { get; set; }
        public Nullable<bool> is_Active { get; set; }
        public Nullable<bool> is_Deleted { get; set; }
        public Nullable<System.DateTime> created_On { get; set; }
        public string created_By { get; set; }
        public Nullable<System.DateTime> updated_On { get; set; }
        public string updated_By { get; set; }
        public string phone_No { get; set; }
        public string password { get; set; }
        public string Admin_PhoneNo { get; set; }
        public string Enrollment_Date { get; set; }
        public string district_Name { get; set; }
        public Nullable<decimal> insertion_timestamp { get; set; }
        public Nullable<decimal> nexttime_stamp { get; set; }
    }
}
