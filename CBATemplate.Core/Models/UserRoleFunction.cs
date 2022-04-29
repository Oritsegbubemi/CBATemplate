using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Core.Models
{
    [Serializable]
    public class UserRoleFunction : BaseEntity
    {
        public string Name { get; set; }
        public string FunctionName { get; set; }
        public string Description { get; set; }
    }
}
