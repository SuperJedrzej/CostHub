using CostHub.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Infrastructure.Services
{
    public class TestServices : IService
    {
        public List<Test> BrowseTests()
            => new List<Test>
                    {
                        new Test(1,"Kamcio"),
                        new Test(2,"DżejDżej")
                    };
    }
}