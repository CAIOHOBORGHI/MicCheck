using MicCheck.Data.Entities;
using MicCheck.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Data.Repositories
{
    public class FanBandRepository : Repository<FanBandRelationship>, IFanBandRepository
    {
        private ApplicationDbContext _context;
        public FanBandRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
