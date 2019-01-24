using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository.Interface
{
    public interface IStudentRepo
    {
        Student GetStudent();
        IEnumerable<Student> GetStudents();
    }
}
