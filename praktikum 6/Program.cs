using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace praktikum_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor motor1 = new Motor();
            motor1.Merek=("Vario");
            motor1.Tahun=(2022);
            motor1.Warna=("Hitam");
            motor1.Harga=(28);

            Motor motor2 = new Motor();
            motor2.Merek=("Nmax");
            motor2.Tahun=(2020);
            motor2.Warna=("Hitam");
            motor2.Harga=(34);  

            motor1.InfoMotor();
            motor2.InfoMotor();
            Console.ReadLine();

        }
    }
}
