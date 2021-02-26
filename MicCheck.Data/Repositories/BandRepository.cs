using MicCheck.Data.Repositories.Interfaces;
using MicCheck.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Repositories
{
    public class BandRepository : Repository<Band>, IBandRepository
    {
        private ApplicationDbContext _context;
        public BandRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
