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
            int firstValue = 30, secondValue = 20, thirdValue = 10;
            int expected = 30;
            FindMaximum find = new FindMaximum();
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.2
        [TestMethod]
        public void Maximum_Value_PassedAt_Second_Parameter_Should_Return_Maximum_Value()
        {
            int firstValue = 20, secondValue = 30, thirdValue = 10;
            int expected = 30;
            FindMaximum find = new FindMaximum();
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
        //TC1.3
        [TestMethod]
        public void Maximum_Value_PassedAt_Third_Parameter_Should_Return_Maximum_Value()
        {
            int firstValue = 20, secondValue = 10, thirdValue = 30;
            int expected = 30;
            FindMaximum find = new FindMaximum();
            int actual = find.MaximumIntegerNumber(firstValue, secondValue, thirdValue);
            Assert.AreEqual(expected, actual);
        }
    }
}
