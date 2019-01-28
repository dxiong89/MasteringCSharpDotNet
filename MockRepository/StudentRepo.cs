using MockRepository.Interface;
using POCO;
using POCO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository
{
    public class StudentRepo : IStudentRepo
    {
        public Student GetStudent()
        {
            return new Student()
            {
                firstName = "Bob",
                lastName = "London",
                age = 12,
                gender = Gender.MALE 
            };
        }

        public List<Student> GetStudents()
        {
            //object initializer
            return new List<Student>() {
                new Student { firstName = "Emily", lastName = "Smith", age = 13, gender = Gender.FEMALE },
                new Student { firstName = "Madison", lastName = "Johnson", age = 14, gender = Gender.FEMALE },
                new Student { firstName = "Emma", lastName = "Williams", age = 15, gender = Gender.FEMALE },
                new Student { firstName = "Hannah", lastName = "Brown", age = 16, gender = Gender.FEMALE },
                new Student { firstName = "Olivia", lastName = "Miller", age = 16, gender = Gender.FEMALE },
                new Student { firstName = "Abigail", lastName = "Wilson", age = 17, gender = Gender.FEMALE },
                new Student { firstName = "Isabella", lastName = "Duran", age = 14, gender = Gender.FEMALE },
                new Student { firstName = "Noah", lastName = "Sutton", age = 18, gender = Gender.MALE },
                new Student { firstName = "Liam", lastName = "Watkins", age = 12, gender = Gender.MALE },
                new Student { firstName = "William", lastName = "Edwards", age = 11, gender = Gender.MALE },
                new Student { firstName = "Benjamin", lastName = "Carter", age = 14, gender = Gender.MALE },
                new Student { firstName = "Alexander", lastName = "Osborne", age = 13, gender = Gender.MALE },
                new Student { firstName = "Ethan", lastName = "Craig", age = 13, gender = Gender.MALE },
                new Student { firstName = "Jacob", lastName = "Frank", age = 10, gender = Gender.MALE },
                new Student { firstName = "Danny", lastName = "Luna", age = 15, gender = Gender.MALE }
            };
        }
    }
}
