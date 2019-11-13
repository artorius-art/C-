using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.Common;

namespace Link_FEJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TrainingEntities())
            {
                var query = from sp in db.Suppliers
                            join ph in db.Pengadaan_Header
                            on sp.sup_id equals ph.supplier_id
                            join pd in db.Pengadaan_Detail
                            on ph.peng_id equals pd.peng_id
                            group pd by sp.sup_nama into temp
                            select new
                            {
                               Nama = temp.Key,
                               Total = temp.Sum(pd => pd.pengd_harga*pd.pengd_jumlah)
                            };
                foreach(var tabel in query)
                {
                    Console.WriteLine(tabel.Nama + "            " + tabel.Total);
                }
                Console.WriteLine("Tekan Untuk Keluar");
                Console.ReadKey();
            }
        }
    }
}
