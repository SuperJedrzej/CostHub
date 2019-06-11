using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Core.Domain
{
    public class Test
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }


        public Test(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void SetName(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new Exception("nie podales imienia durniu");

            Name = name;
        }
    }
}
