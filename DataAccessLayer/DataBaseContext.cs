using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class DataBaseContext : DbContext
    {
        public DbSet<UserModel> user { get; set; }

        public DbSet<Patient> patient { get; set; }

        public DbSet<PatientReferrelTypeModel> patientReferrelType { get; set; }

        public DbSet<PartnerName> partner_Name { get; set; }

        public DbSet<GenderModel> gender_Name { get; set; }

        public DbSet<PanelMasterModel> Panel_Master { get; set; }
    }
}
