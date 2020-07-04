using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Model;

namespace DBServices
{
    public interface ITestService
    {
        List<Test> GetTestList();
        int AddTest(Test tst);
        List<Test> GetTestRecById(int tst_Id);
        int AddPackageMaster(PackageMater pkg);
        bool AddPackageDetail(List<PackaDetail> pkgD, int PackageMasterID);
    }
}
