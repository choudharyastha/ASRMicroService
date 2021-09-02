using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gateway.api.Repository
{
    public interface IGenericRepo<T> where T : class
    {
        List<T> ListAll();
    }
}
