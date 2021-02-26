using MicCheck.Core.Repositories.Interfaces;
using MicCheck.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Repositories
{
    public class FanRepository : Repository<Fan>, IFanRepository
    {
        private ApplicationDbContext _context;
        public FanRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
