using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDooAPI.Domain.Entities
{
    public abstract class Base
    {
        public Guid Id { get; private set; }
    }
}
