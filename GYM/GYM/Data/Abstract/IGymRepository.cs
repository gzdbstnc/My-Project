using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GYM.Models;

namespace GYM.Data.Abstract
{
    public interface IGymRepository
    {
        IEnumerable<Student> Students { get; }
        IEnumerable<User> Users { get; }
        IEnumerable<PreRegisterationForm> PreRegisterationForms { get; }

    }
}
