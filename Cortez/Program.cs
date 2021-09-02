using System;

namespace Cortez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your student no. : ");
            string studentNo = Console.ReadLine();
            Console.WriteLine("Welcome:" + studentNo);
            Console.WriteLine("Subject Code         Section                    Description                           Units           Days            Time            Room"); 
            Console.WriteLine("NCP 2101               1CPE         Logic Circuits and Design Lecture                   3             TTH           1300-1430         EN103");
            Console.WriteLine("NCP 2102               1CPE         Logic Circuits and Design Laboratory                1             TTH           1440-1610         EN ECEL4");
            Console.WriteLine("NCP 2103               1CPE         Objected Oriented Programming                       2             MW            0730-1030         EN CLR2");
            Console.WriteLine("NCP 2104               1CPE         Differential Equations                              3             MWF           1430-1530         EN407");
            Console.WriteLine("NCP 2105               1CPE         Engineering Data Analysis                           3             MWF           1540-1640         EN407");
            Console.WriteLine("NEC 1205               1CPE         Fundamentals of Electronic Circuits Lecture         3             MW            1240-1410         EN113");
            Console.WriteLine("NEC 1206               1CPE         Fundamentals of Electronic Circuits Laboratory      1             TTH           0730-0900         EN ECEL4");
            Console.WriteLine("PEN 4311               1CPE         Arnis                                               2             TTH           1050-1150         GYM N");
            Console.WriteLine("ZGE 1107               1CPE         Science, Technology, and Society                    3             TTH           0910-1040         EN405");
            Console.WriteLine("ZPD 1101               1CPE         Personality Development                             1             FRI           1320-1420         EN402");
            Console.WriteLine("                                    TOTAL UNITS                                        22.00");
        }

    }
}
