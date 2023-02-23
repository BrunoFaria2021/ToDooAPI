using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDooAPI.Domain.Entities
{
    public abstract class Base : IEquatable<Base>
    {
        public Base() 
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }

        public bool Equals(Base other)
        {
            return Id == other.Id;
        }
    }
}
