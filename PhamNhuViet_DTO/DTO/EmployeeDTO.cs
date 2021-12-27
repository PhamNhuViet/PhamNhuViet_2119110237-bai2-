using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamNhuViet_DTO.DTO
{
    public class EmployeeDTO
    {
        public string IdEmployee { get; set; }
        public string Name { get; set; }
        public string DateBirth { get; set; }
        public string Gender { get; set; }
        public string PlaceBirth { get; set; }
        public string IdDepartment { get; set; }
    }
}
