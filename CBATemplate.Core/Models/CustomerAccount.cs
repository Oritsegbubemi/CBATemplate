using CBATemplate.Core.Enums;
using CBATemplate.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Core.Models
{
    [Serializable]
    public class CustomerAccount : BaseEntity, IAccount
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public AccountStatus AccountStatus { get; set; }
    }
}
