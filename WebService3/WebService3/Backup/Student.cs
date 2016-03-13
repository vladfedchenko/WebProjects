using System;
using System.Collections.Generic;
using System.Text;

namespace WebService3
{
    public class Student     
    {
        public Student() 
        {
            this.Name = "";
            this.AverageMark = 0.0;
            this.Sex = Sex.Male;
        }

        public Student(String name, double mark, Sex sex)
        {
            this.Name = name;
            this.AverageMark = mark;
            this.Sex = sex;
        }

        public String Name
        {
            get;
            set;
        }

        public double AverageMark
        {
            get;
            set;
        }

        public Sex Sex
        {
            get;
            set;
        }
    }

    public enum Sex
    {
        Male,
        Female
    }
}