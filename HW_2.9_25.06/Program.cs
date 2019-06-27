using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 9.	 Известны сопротивления двух несоединенных друг с другом 
 участков электрической цепи и напряжение на каждом из них. 
 По какому участку протекает меньший ток?*/

namespace HW_2._9_25._06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сопротивлениe R1, Oм:");
            var resistance1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сопротивлениe R2, Oм:");
            var resistance2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите наприжение U1, Вольт:");
            var voltage1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите наприжение U2, Вольт:");
            var voltage2 = Convert.ToDouble(Console.ReadLine());

            var amperage1 = voltage1 / resistance1;
            var amperage2 = voltage2 / resistance2;

            Console.Write("Ток первого участка электрической цепи: ");
            Console.WriteLine(amperage1);
            Console.Write("Ток второго участка электрической цепи: ");
            Console.WriteLine(amperage2);

            if (amperage1 > amperage2) Console.WriteLine("Во втором участке протекает меньший ток, чем в первом.");
            else if (amperage1 < amperage2) Console.WriteLine("В первом участке протекает меньший ток, чем во втором.");
            else Console.WriteLine("Сила тока в обоих участках равна.");
            Console.ReadKey();
        }
    }
}
