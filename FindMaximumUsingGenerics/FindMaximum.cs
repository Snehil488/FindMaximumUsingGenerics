using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumUsingGenerics
{
    public class FindMaximum<dataType> where dataType : IComparable
    {
        public dataType[] array;
        public FindMaximum(dataType[] array)
        {
            this.array = array;
        }
        public dataType[] Sort(dataType[] values)
        {
            Array.Sort(values);
            return values;
        }
        public dataType FindMaxValue()
        {
            dataType[] sortedArray = Sort(this.array);
            return sortedArray[sortedArray.Length - 1];
        }
    }
}
