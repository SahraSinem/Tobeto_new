using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Order : Entity<int>
    {
        public string OrderName { get; set; }
    }
}
