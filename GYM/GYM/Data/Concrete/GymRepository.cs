using GYM.Data.Abstract;
using GYM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GYM.Models;

namespace GYM.Data.Concrete
{

    public class GymRepository : IGymRepository
    {
        private GymContext context;
        public GymRepository(GymContext _context)
        {
            context = _context;
        }

        public IEnumerable<Student> Students => context.Students;

        public IEnumerable<User> Users => context.Users;

        public IEnumerable<PreRegisterationForm> PreRegisterationForms => context.PreRegisterationForms;
    }
}