using ClassLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.MyClasses
{
    public class Employee
    {   
        public Employee(string departmentName)
        {
            this.DepartmentName = departmentName;
            _totalCount++;
            No = DepartmentName.Substring(0, 2).ToUpper() + _totalCount;
        }
        private static int _totalCount = 1000;
        public static int TotalCount { get => _totalCount; }
        public string No;
        public string Fullname;
        private string _position;
        public string Position
        {
            get => _position;
            set
            {
                if (value.Length>2)
                {
                    _position = value;
                }
                
            }
        }
        private double _salary;
        public double Salary
        {
            get => _salary;
            set
            {
                if (value>=250)
                {
                    _salary = value;
                }
            }
        }
        public string DepartmentName;
        public EmployeeType EmployeeType;

    }
}
