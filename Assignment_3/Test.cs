using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Test
    {
        public string TestName { get; set; }
        public int TestScore { get; set; }

        //override ToString method to display test name and score
        public override string ToString()
        {
            return TestName + " : " + TestScore;
        }
    }
}
