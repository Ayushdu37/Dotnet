using System;
using System.Collections.Generic;
using System.Text;
using Evencode.Feature;

namespace EvenTestProj
{
    [TestClass]
    public class EvenTest
    {
        [TestMethod]
        public void Even_GiveInput_ResultBool()
        {
            var even = new Even();
            bool result = even.IsEven(4);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(4)]
        [DataRow(6)]
        public void Even_Parameterized(int num)
        {
            var even = new Even();
            //bool result = even.IsEven(num);
            Assert.IsTrue(even.IsEven(num));
        }
    }
}
