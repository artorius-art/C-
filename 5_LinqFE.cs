using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TrainingEntities2())
            {
                var query = from a in db.Suppliers
                            select a;
                Console.WriteLine("Menampilkan Table Suppliers : ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.sup_id + "   " + item.sup_nama + "   " + item.stsrc + "   " + item.created_by + "   " + item.date_created);
                }
                Console.WriteLine(" ");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
