using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.MyClasses
{
    public class Student
    {
        public string Fullname;
        private string _groupNo;
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (char.IsLetter(value[0])&&char.IsUpper(value[0])&&value.Length == 4)
                {
                    _groupNo = value;
                }
            }
        }
        private int _point;
        public int Point
        {
            get => _point;
            set
            {
                if (value>100)
                {
                    _point = value; 
                }
            }
        }


       
    }
}
