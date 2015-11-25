using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Nandoso.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]

    public class NandosoContext : DbContext
    {
       //You can add custom code to this file.Changes will not be overwritten.

       //If you want Entity Framework to drop and regenerate your database
       //automatically whenever you change your model schema, please use data migrations.
       //For more information refer to the documentation:
       //http://msdn.microsoft.com/en-us/data/jj591621.aspx
        public class MyConfiguration : DbMigrationsConfiguration<NandosoContext>
        {
            public MyConfiguration()
            {
                //enables migration so db can update after model update
                this.AutomaticMigrationsEnabled = true;
                this.AutomaticMigrationDataLossAllowed = true;
            }

            // seed db with dummy data
            protected override void Seed(NandosoContext context)
            {
            }
        }

        public NandosoContext() : base("name=NandosoContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NandosoContext, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<Nandoso.Models.Order> Orders { get; set; }

        public System.Data.Entity.DbSet<Nandoso.Models.Special> Specials { get; set; }

        public System.Data.Entity.DbSet<Nandoso.Models.User> Users { get; set; }

        public System.Data.Entity.DbSet<Nandoso.Models.Review> Reviews { get; set; }
    }
}
