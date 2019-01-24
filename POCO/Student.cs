using POCO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace POCO
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public IEnumerable<Pet> pets { get; set; }
        public Gender gender { get; set; }
    }
}
