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
    }
}
