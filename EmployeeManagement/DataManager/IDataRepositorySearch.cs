using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.DataManager
{
    public interface IDataRepositorySearch<TEntity>
    {
        /// <summary>
        /// Search
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> Search(Func<TEntity, bool> func);
    }
}
