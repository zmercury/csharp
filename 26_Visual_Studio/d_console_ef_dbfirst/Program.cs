using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace d_console_ef_dbfirst
{
  internal class Program
  {
    static void Main(string[] args)
    {
      using (var db = new db_dbfirstEntities1())
      {
        var query = from b in db.Students orderby b.FirstName select b;
        Console.WriteLine("All Student in the databse: ");
                foreach(var item in query)
                {
                    Console.WriteLine(item.FirstName + " " + item.LastName);
                }
                Console.WriteLine("Press to exit...");
                Console.ReadKey();
      }
    }
  }
}
