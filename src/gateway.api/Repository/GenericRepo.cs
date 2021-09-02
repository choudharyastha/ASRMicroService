using gateway.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly Microcontext _dbContext;
        public GenericRepo(Microcontext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<T> ListAll()
        {
            List<T> results = _dbContext.Set<T>().ToList();
            return results;
        }
    }
}
