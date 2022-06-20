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

                        Console.WriteLine("Hansi qrupun studentlerine baxmaq isteyirsiniz? Qeyd: Hecne qeyd etmeseniz butun studentler gosterilecek");
                        string option = Console.ReadLine();

                        if (option == "" || option == " ")
                            BDU.ShowStudents();
                        else
                        {
                            BDU.ShowSpecificStudents(option);
                        }

                        break;
                    case "1.2":
                        BDU.AddStudent(CreateStudent());

                        break;                    
                    case "1.3":
                        Console.WriteLine("Deyisiklik etmek istediyiniz studentin qrup nomresini daxil edin");
                        string oldGroupNo = Console.ReadLine();
                        Console.WriteLine("Yeni qrup npmresini elave edin");
                        string newGroupNo = Console.ReadLine();

                        BDU.StudentUpdate(oldGroupNo, newGroupNo);

                        break;
                    case "1.4":
                        Console.WriteLine("Hansi qrupun studentlerinin ortalamasina baxmaq isteyirsiniz? Qeyd: Hecne qeyd etmeseniz butun studentlerin ortalamasi gosterilecek");
                        string option2 = Console.ReadLine();

                        if (option2 == "" || option2 == " ")
                            BDU.CalcStudentsAverage();
                        else
                        {
                            BDU.SpecificStudentsCalcAverage(option2);
                        }
                        break;
                    case "2.1":

                        BDU.ShowEmployees();
                        break;
                    case "2.2":
                        Console.WriteLine("Iscilerine baxmaq istediyiniz department adini daxil edin");
                        string option3 = Console.ReadLine();

                        BDU.ShowSpecificEmployee(option3);

                        break;
                    case "2.3":

                        BDU.AddEmployee(CreateEmployee());
                        break;
                    case "2.4":

                        Console.WriteLine("Deyisiklik etmek istediyiniz iscinin nomresinin qeyd edin");
                        string option4 = Console.ReadLine();

                        BDU.EmployeeUpdate(option4);

                        break;
                    case "2.5":

                        Console.WriteLine("Silinmesini istediyiniz iscinin nomresini daxil edin");
                        string option5 = Console.ReadLine();

                        BDU.DeleteEmployee(option5);
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

                } while (!int.TryParse(pointStr,out point));

                if (point<100)
                {
                    Console.WriteLine("Studentin bali 100den asagi ola bilmez");
                    goto BaliYenidenDaxilEtmek;
                }
                
                QrupuYenidenDaxilEtmek:
                Console.WriteLine("Qrup adini daxil edin:");
                string groupNo = Console.ReadLine();

                if (!char.IsLetter(groupNo[0]))
                {
                    Console.WriteLine("Qrup adinin ilk deyeri herf olmalidir");
                    goto QrupuYenidenDaxilEtmek;
                }

                else if (!char.IsUpper(groupNo[0]))
                {
                    Console.WriteLine("Qrup adinin ilk deyeri boyukle yazilmalidir");
                    goto QrupuYenidenDaxilEtmek;
                }

                else if (groupNo.Length != 4)
                {
                    Console.WriteLine("Qrup adi yalniz 4 deyerden ibaret olmalidir");
                    goto QrupuYenidenDaxilEtmek;
                }


                Student std = new Student();
                std.Fullname = fullname;
                std.GroupNo = groupNo;
                std.Point = point;

                return std;
            }


            static Employee CreateEmployee()
            {
                AdiYenidenDaxilEtmek:
                Console.WriteLine("Iscinin tam adini daxil edin");
                string fullname = Console.ReadLine();

                Console.WriteLine("Iscinin pozisiyasini daxil edin");
                string position = Console.ReadLine();

                Console.WriteLine("Iscinin hansi departamentde islediyini qeyd edin");
                string departmentName = Console.ReadLine();
                IscideMaasiYenidenDaxilEtmek:
                string salaryStr;
                double salary;
                do
                {
                    Console.WriteLine("Iscinin maasini daxil edin:");
                    salaryStr = Console.ReadLine();

                } while (!double.TryParse(salaryStr, out salary));

                if (salary<250)
                {
                    Console.WriteLine("Daxil edilen maas 250-dan asagi olmamalidir");
                    goto IscideMaasiYenidenDaxilEtmek;
                }

                Employee emp = new Employee(departmentName);
                emp.Fullname = fullname;
                emp.Position = position;
                emp.Salary = salary;

                return emp;
            }

            

            
        }
    }
}
