using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_6
{
    public class Motor
    {
        private string merek;
        private int tahun;
        private int harga;
        private string warna;


        public string Merek
        {
            get { return merek; }
            set { merek = value; }
        }
        public int Tahun
        {
            get { return tahun; }
            set { tahun = value; }
        }
        public string Warna
        {
            get { return warna; }
            set { warna = value; }
        }
        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public void InfoMotor()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(" Merek Motor : {0}", Merek);
            Console.WriteLine(" Tahun Produksi : {0}", Tahun);
            Console.WriteLine(" Warna Motor : {0}", Warna);
            Console.WriteLine(" Harga Motor : {0} juta", Harga);
        }
    }
}
