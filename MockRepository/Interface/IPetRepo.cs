using POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockRepository.Interface
{
    public interface IPetRepo
    {
        Pet GetPet();
        IEnumerable<Pet> GetPets();
    }
}
