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
        public Employee[] Employees
        {
            get => _employees;
        }
        private Student[] _students = new Student[0];
        public Student[] Students
        {
            get => _students;
        }


    }
}
