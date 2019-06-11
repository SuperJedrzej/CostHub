using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Core.Domain
{
    public class ProductCategory
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public bool Locked { get; protected set; }
        public DateTime DateCreated { get; protected set; }
        public ProductCategory(int id, string name)
        {
            Id = id;
            Name = name;
            Locked = false;
            DateCreated = DateTime.UtcNow;
        }
        public void SetLocked(bool locked)
        {
            Locked = locked;
        }
    }
}
