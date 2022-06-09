using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.DataManager
{
    public class VMInstanceSsmCommandIdMappingDataService : IVMInstanceSsmCommandIdMappingDataService
    {
        private readonly SchoolContext _context;
        public VMInstanceSsmCommandIdMappingDataService(SchoolContext _context)
        {
            _context = _context;
        }
        public IEnumerable<VMInstanceSSMCommandIdMappings> Search(Func<VMInstanceSSMCommandIdMappings, bool> func)
        {
            return _context.VMInstanceSSMCommandIdMappings.AsEnumerable().Where(func).ToList();
        }
    }
}
