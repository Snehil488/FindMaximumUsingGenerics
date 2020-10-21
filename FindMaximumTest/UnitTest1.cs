using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximumUsingGenerics;

namespace FindMaximumTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC1.1
        [TestMethod]
        public void Maximum_Value_PassedAt_First_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 30.5f, secondValue = 20.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            FindMaximum find = new FindMaximum();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 20.5f, secondValue = 30.5f, thirdValue = 10.5f;
            float expected = 30.5f;
            FindMaximum find = new FindMaximum();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            float firstValue = 20.5f, secondValue = 10.5f, thirdValue = 30.5f;
            float expected = 30.5f;
            FindMaximum find = new FindMaximum();
            float actual = find.MaximumFloatNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
