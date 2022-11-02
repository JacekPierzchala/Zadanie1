using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadanie1.Core;

namespace Zadanie1.Infrastructure
{
    public class DatabaseHandler
    {
        public SQLiteConnection Db { get; set; }

 
        public DatabaseHandler()
        {
            string dbPath = Path.Combine(
          Environment.GetFolderPath(Environment.SpecialFolder.Personal),"Packages.db");

            Db = new SQLiteConnection(dbPath);

            if(Db.GetTableInfo(nameof(Package)).Count==0)
            {
                Db.CreateTable<Package>();
            }
            if(Db.Table<Package>().Count()==0)
            {
                var packages= new List<Package>();
                packages.Add(new Package 
                { 
                    Id = 1,
                    Name="Test1",
                    Description= "Description1",
                    Weight=24.4

                });
                packages.Add(new Package
                {
                    Id = 2,
                    Name = "Test2",
                    Description = "Description2",
                    Weight = 4.4

                });
                packages.Add(new Package 
                {
                    Id = 3,
                    Name = "Test2",
                    Description = "Description3",
                    Weight = 7.5

                });
                Db.InsertAll(packages);
            }

        }


    }
}
