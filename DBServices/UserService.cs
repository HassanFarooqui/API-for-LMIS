using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using DataAccessLayer;
using DataAccessLayer.Model;
using System.Data.Entity;

namespace DBServices
{
   public class UserService : IUserService
    {
        DataBaseContext DB = new DataBaseContext();
        
        public int GetUserCount()
        {
            var model = new UserModel();
            model.FirstName = "test123";
            model.LastName = "test";
            model.Password = "test";
            model.Email = "test@test.com";
            model.CreatedDate = DateTime.Now;
            model.CreatedBy = 1;
            model.DOB = DateTime.Now;
            model.IsActive = true;
            model.Phone = "12345678";

           // DB.user.Add(model);
            //DB.SaveChanges();
            //var data = DB.user.ToList();
            return 20;
        }

        public UserModel GetUserByEmailByPassword(string Email, string Password)
        {
            var query = DB.user.Where(x => x.Email == Email && x.Password == Password);            
            if(query != null && query.Count() == 1)
            {
                return query.FirstOrDefault();
            }
            else
            {
                return null;
            }            
        }

        public UserModel GetUserByFNameAndLName(string FName, string LName)
        {
            var query = DB.user.Where(x => x.FirstName.Equals(FName, StringComparison.OrdinalIgnoreCase) && x.LastName.Equals(LName, StringComparison.OrdinalIgnoreCase));
            if (query != null && query.Count() == 1)
            {
                return query.FirstOrDefault();
            }
            else
            {
                return null;
            }
        }

        public List<Patient> GetPatientList()
        {
            try
            {
                var pt = DB.patient.Where(x => x.IsActive == true).ToList();

                if (pt != null && pt.Count() != 0)
                {
                    return pt;
                }               
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        public int AddPatient(Patient pt)
        {
            pt.CreatedOn = DateTime.Now;
            var Patient = DB.patient.Add(pt);
            DB.SaveChanges();
            if (Patient != null)
            {
                return Patient.ID;
            }
            else
            {
                return 0;
            }
        }

        public List<PatientReferrelTypeModel> GetReferrelTypeList()
        {
            var RefType = DB.patientReferrelType.Where(x => x.IsActive == true).ToList();
            if (RefType != null && RefType.Count != 0)
            {
                return RefType;
            }
            else
            {
                return null;
            }
        }

        public List<PartnerName> GetPartnerNameList()
        {
            var PartnerName = DB.partner_Name.Where(x => x.IsActive == true).ToList();
            if (PartnerName != null && PartnerName.Count != 0)
            {
                return PartnerName;
            }
            else
            {
                return null;
            }
        }

        public List<GenderModel> GetGenderNameList()
        {
            var GenderName = DB.gender_Name.ToList();
            if (GenderName != null && GenderName.Count() != 0)
            {
                return GenderName;
            }
            else
            {
                return null;
            }
        }

        public List<PanelMasterModel> GetPanelNameList()
        {
            var PanelName = DB.Panel_Master.Where(x => x.IsActive == true).ToList();
            if (PanelName != null && PanelName.Count() != 0)
            {
                return PanelName;
            }
            else
            {
                return null;
            }
        }

        public List<Patient> GetPatientRecById(int pt_Id)
        {
            var query = DB.patient.Where(x => x.ID == pt_Id).ToList();
            if (query != null && query.Count() == 1)
            {
                return query;
            }
            else
            {
                return null;
            }
        }

        public Patient EditPatientRec(int id, Patient pt)
        {
            if (id != pt.ID)
            {
                return null;
            }
            else
            {
                var existingPatient = DB.patient.Where(s => s.ID == id).FirstOrDefault<Patient>();
                if (existingPatient != null)
                {                    
                    existingPatient.FirstName = pt.FirstName;
                    existingPatient.LastName = pt.LastName;
                    existingPatient.GuardianName = pt.GuardianName;
                    existingPatient.Age = pt.Age;
                    existingPatient.GenderID = pt.GenderID;
                    existingPatient.MobileNo = pt.MobileNo;
                    existingPatient.CNIC = pt.CNIC;
                    existingPatient.Address = pt.Address;
                    existingPatient.Diabetes = pt.Diabetes;
                    existingPatient.TB = pt.TB;
                    existingPatient.Hepatitis = pt.Hepatitis;
                    existingPatient.Fever = pt.Fever;
                    existingPatient.Other = pt.Other;
                    existingPatient.DepartmentName = pt.DepartmentName;
                    existingPatient.EmpReferrenceNo = pt.EmpReferrenceNo;
                    existingPatient.ReferredTypeId = pt.ReferredTypeId;
                    existingPatient.ReferringPartnerID = pt.ReferringPartnerID;
                    existingPatient.panelID = pt.panelID;
                    DB.SaveChanges();
                }
                return pt;
            }
        }    
    }
}
