using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;
using DataAccessLayer;
using System.Data;

namespace DBServices
{
   public class Testservice : ITestService
    {
        DataBaseContext DB = new DataBaseContext();
        public List<Test> GetTestList()
        {
            try
            {
                var test = DB.test.Where(x => x.IsActive == true).ToList();
                if (test != null && test.Count() != 0)
                {
                    return test;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        public int AddTest(Test tst)
        {
            tst.CreatedOn = DateTime.Now;
            var Vtest = DB.test.Add(tst);
            DB.SaveChanges();
            if (Vtest != null)
            {
                return Vtest.TestId;
            }
            else
            {
                return 0;
            }
        }

        public List<Test> GetTestRecById(int tst_Id)
        {
            var tstRec = DB.test.Where(x => x.TestId == tst_Id).ToList();
            if (tstRec != null && tstRec.Count() == 1)
            {
                return tstRec;
            }
            else
            {
                return null;
            }
        }



        public Test EditTestRec(int id, Test tst)
        {
            if (id != tst.TestId)
            {
                return null;
            }
            else
            {
                var existingPatient = DB.test.Where(s => s.TestId == id).FirstOrDefault<Test>();
                if (existingPatient != null)
                {
                    existingPatient.TestName = tst.TestName;
                    existingPatient.TestCharges = tst.TestCharges;
                    existingPatient.TestDiscPerc = tst.TestDiscPerc;
                    existingPatient.TestDiscAmount = tst.TestDiscAmount;
                    existingPatient.NetCharges = tst.NetCharges;
                    DB.SaveChanges();
                }
                return tst;
            }

        }


        public int AddPackageMaster( PackageMater pkg)
        {
            pkg.CreatedOn = DateTime.Now;
            var Vpkg = DB.packageMaster.Add(pkg);
            DB.SaveChanges();
            if (Vpkg != null)
            {
                return Vpkg.PackageMasterId;
            }
            else
            {
                return 0;
            }
        }
        public bool AddPackageDetail(PackaDetail TestListItem, int PackageMasterID)
        {

            TestListItem.CreatedOn = DateTime.Now;
            TestListItem.PackageMasterId = PackageMasterID;
            var VTestListItem = DB.packageDetail.Add(TestListItem);
            DB.SaveChanges();
            if (VTestListItem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
