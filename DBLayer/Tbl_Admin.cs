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
    
    public partial class Tbl_Admin
    {
        public int admin_Id { get; set; }
        public string phoneNo { get; set; }
        public string email { get; set; }
        public string encrypted_Password { get; set; }
        public string reset_Password_Token { get; set; }
        public Nullable<int> sign_In_Count { get; set; }
        public string Current_Sign_In_at { get; set; }
        public Nullable<System.DateTime> last_Sign_In_at { get; set; }
        public Nullable<int> failed_attempts { get; set; }
        public string locked_at { get; set; }
        public string role { get; set; }
        public string name { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public string Created_On { get; set; }
        public string Created_By { get; set; }
        public string Update_On { get; set; }
        public string Update_By { get; set; }
    }
}