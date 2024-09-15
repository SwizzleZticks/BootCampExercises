using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise56
{
    public class Student : Person
    {
        public int StudentID { get; set; }
        public string Major { get; set; }
        public Student(string name, string address, int studentID, string major) : base(name, address)
        {
            StudentID = studentID;
            Major = major;
        }
    }
}
