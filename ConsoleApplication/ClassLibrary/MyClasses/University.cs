using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.MyClasses
{
    public class University
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length>2)
                {
                    _name = value;
                }
            }
        }
        private int _workerLimit;
        public int WorkerLimit
        {
            get => _workerLimit;
            set
            {
                if (value>1)
                {
                    _workerLimit = value;
                }
            }
        }
        private double _salaryLimit;
        public double SalaryLimit
        {
            get => _salaryLimit;
            set
            {
                if (value>250)
                {
                    _salaryLimit = value;
                }
            }
        }
        private Employee[] _employees = new Employee[0];
        public Employee[] Employees { get => _employees; }

        private Student[] _students = new Student[0];
        public Student[] Students { get => _students; }

        public void CalcSalaryAverage()
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                SalaryLimit = _employees[i].Salary;
            }
            Console.WriteLine(SalaryLimit);
        }

        public void CalcStudentsAverage()
        {
            int count = 0;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < _students.Length; i++)
            {
               count++;
               sum+=_students[i].Point;
            }
            average = sum / count;

            Console.WriteLine(average);
        }

        public void SpecificStudentsCalcAverage(string option)
        {
            int count = 0;
            int sum = 0;
            int average = 0;
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].GroupNo == option)
                {
                    count++;
                    sum += _students[i].Point;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bu adda qrup yoxdur");
            }
            else
            {
                average = sum / count;
                Console.WriteLine(average);
            }
        }


        public void AddEmployee(Employee emp)
        {
            Array.Resize(ref _employees, _employees.Length + 1);
            _employees[_employees.Length - 1] = emp;
        }

        public void AddStudent(Student std)
        {
            Array.Resize(ref _students, _students.Length + 1);
            _students[_students.Length - 1] = std;
        }

        public void ShowEmployees()
        {
            for (int i = 0; i < _employees.Length; i++)
            {
                Console.WriteLine($"Tam ad: {_employees[i].Fullname} - Pozisiya: {_employees[i].Position} - No: {_employees[i].No} - Maas: {_employees[i].Salary} - Department: {_employees[i].DepartmentName} ");
            }
        }

        public void ShowSpecificEmployee(string option)
        {
            int count = 0;
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].DepartmentName == option)
                {
                    count++;
                    Console.WriteLine($"Tam ad: {_employees[i].Fullname} - Pozisiya: {_employees[i].Position} - No: {_employees[i].No} - Maas: {_employees[i].Salary}");
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bele bir department yoxdur");
            }
        }
        public void ShowStudents()
        {
            for (int i = 0; i < _students.Length; i++)
            {
                Console.WriteLine($"Tam ad: {_students[i].Fullname} - Qrup Nomresi: {_students[i].GroupNo} - Bali: {_students[i].Point}");
            }
        }

        public void ShowSpecificStudents(string option)
        {
            int count = 0;
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].GroupNo == option)
                {
                    count++;
                    Console.WriteLine($"Tam ad: {_students[i].Fullname} - Qrup Nomresi: {_students[i].GroupNo} - Bali: {_students[i].Point}");
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bu adda qrup yoxdur");
            }
      
        }

        public void StudentUpdate(string oldGroupNo, string newGroupNo)
        {
            int count = 0;
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i].GroupNo == oldGroupNo)
                {
                    count++;
                    _students[i].GroupNo = newGroupNo;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bu adda qrup yoxdur");
            }
        }

        public void EmployeeUpdate(string oldNo)
        {
            int count = 0;
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].No == oldNo)
                {
                    count++;
                    Console.WriteLine("Iscinin yeni pozisiyasini daxil edin");
                    string newPos = Console.ReadLine();

                    IscininYeniMaasi:
                    string newSalaryStr;
                    double newSalary;
                    do
                    {
                        Console.WriteLine("iscinin yeni maasini daxil edin:");
                        newSalaryStr = Console.ReadLine();
                    } while (!double.TryParse(newSalaryStr, out newSalary));

                    if (newSalary < 250)
                    {
                        Console.WriteLine("Maas 250den asagi ola bilmez");
                        goto IscininYeniMaasi;
                    }

                    _employees[i].Position = newPos;
                    _employees[i].Salary = newSalary;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("Bu nomreded isci yoxdur");
            }

        }

        public Employee[] DeleteEmployee(string no)
        {
            Employee temp;
            int count = 0;
            for (int i = 0; i < _employees.Length; i++)
            {
                if (_employees[i].No == no)
                {
                    count++;
                    temp = _employees[_employees.Length - 1];
                    _employees[_employees.Length - 1] = _employees[i];
                    Array.Resize(ref _employees, _employees.Length - 1);
                }
            }
            return _employees;
            

        }
    }
}
