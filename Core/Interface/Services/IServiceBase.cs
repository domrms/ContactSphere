using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface.Services
{
    public interface IServiceBase<in TEntity> where TEntity : class
    {
    }
}
}
