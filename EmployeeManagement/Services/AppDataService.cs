using EmployeeManagement.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    public class AppDataService
    {
        private readonly ApiDbContextFactory _apiDbContextFactory;
        public AppDataService(ApiDbContextFactory apiDbContextFactory)
        {
            _apiDbContextFactory = apiDbContextFactory;
        }



    }
}
