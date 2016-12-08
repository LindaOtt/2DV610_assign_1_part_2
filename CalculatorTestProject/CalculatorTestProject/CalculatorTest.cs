using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CalculatorTestProject
{
   
    public class CalculatorTest
    {
        [Fact]
        public void startProgram()
        {
            Controller c = new Controller();

            bool DoIsRun = c.Do();

            Assert.Equal(DoIsRun, true);
        }
    }
}
