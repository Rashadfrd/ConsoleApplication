using ClassLibrary.MyClasses;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            University BDU = new University();

            string input;
            do
            {
                Console.WriteLine("1.1 Studentlerin siyahisini gostermek");
                Console.WriteLine("1.2 Student yaratmaq");
                Console.WriteLine("1.3 Studentde deyisiklik etmek");
                Console.WriteLine("1.4 Studentlerin ortalama qiymetini gostermek");
                Console.WriteLine("2.1 Iscilerin siyahisini gostermek");
                Console.WriteLine("2.2 Universitydeki iscilerin siyahisini gostermek");
                Console.WriteLine("2.3 Isci elave etmek");
                Console.WriteLine("2.4 Isci uzerinde deyisiklik etmek");
                Console.WriteLine("2.5  Universityden isci silinmesi");
                Console.WriteLine("2.6 Axtaris edin");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1.1":


                        break;
                    case "1.2":


                        break;                    
                    case "1.3":


                        break;
                    case "1.4":


                        break;
                    case "2.1":


                        break;
                    case "2.2":


                        break;
                    case "2.3":


                        break;
                    case "2.4":


                        break;
                    case "2.5":


                        break;
                    case "2.6":


                        break;

                }
            } while (input != "3");


            static Student CreateStudent()
            {
                Console.WriteLine("Studentin tam adini daxil edin:");
                string fullname = Console.ReadLine();

                BaliYenidenDaxilEtmek:
                string pointStr;
                int point;
                do
                {
                    Console.WriteLine("Studentin balini daxil edin:");
                    pointStr = Console.ReadLine();

                } while (int.TryParse(pointStr,out point));

                if (point>100)
                {
                    Console.WriteLine("Studentin bali 100den asagi ola bilmez");
                }
                goto BaliYenidenDaxilEtmek;

                Console.WriteLine("Qrup adini daxil edin:");




            }





        }
    }
}
