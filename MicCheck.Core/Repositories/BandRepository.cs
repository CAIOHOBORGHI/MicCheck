using MicCheck.API.Repositories;
using MicCheck.API.Repositories.Interfaces;
using MicCheck.Core.Repositories.Interfaces;
using MicCheck.Data;
using MicCheck.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MicCheck.Core.Repositories
{
    public class BandRepository : Repository<Band>, IBandRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public BandRepository(ApplicationDbContext context) : base(context)
        {
            _dbContext = context;
        }
    }
}
