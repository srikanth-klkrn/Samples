using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class VMInstanceSSMCommandIdMappings
    {
        [Key]
        public int Id { get; set; }
        public string SSMCommandId { get; set; }
        public string SSMCommandDescription { get; set; }
        public string InstanceId { get; set; }
    }
}
