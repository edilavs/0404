using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class Student
    {
        public Student(string fullName,string groupNo,byte age)
        {
            this.FullName = fullName;
            this.GroupNo = groupNo;
            this.Age = age;
        }
        public string FullName { get; set; }
        private string _groupNo;
        public byte Age { get; set; }
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (value.CheckGroupNo())
                    _groupNo = value;
            }
        }

    }
}
