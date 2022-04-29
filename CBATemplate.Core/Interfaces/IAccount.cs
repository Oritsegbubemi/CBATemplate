using CBATemplate.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBATemplate.Core.Interfaces
{
    public interface IAccount
    {
        string Name { get; set; }
        string Number { get; set; }
        AccountStatus AccountStatus { get; set; } 
    }
}
