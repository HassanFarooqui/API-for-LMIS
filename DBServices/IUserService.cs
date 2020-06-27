using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServices
{
   public interface IUserService
    {
        int GetUserCount();
        UserModel GetUserByEmailByPassword(string Email, string Password);
        List<Patient> GetPatientList();
        int AddPatient(Patient pt);
        List<PatientReferrelTypeModel> GetReferrelTypeList();
        List<PartnerName> GetPartnerNameList();
        List<GenderModel> GetGenderNameList();
        List<PanelMasterModel> GetPanelNameList();
        List<Patient> GetPatientRecById(int pt_Id);
        Patient EditPatientRec(int id, Patient pt);
   
    }
}
