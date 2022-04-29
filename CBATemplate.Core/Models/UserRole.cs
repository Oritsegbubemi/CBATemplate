using CBATemplate.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Core.Models
{
    [Serializable]
    public class UserRole : BaseEntity
    {
        public string Name { get; set; }
        public BaseStatus Status { get; set; }
        public List<UserRoleFunction> UserRoleFunctions { get; set; }
    }
}
