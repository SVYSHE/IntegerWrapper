using System;

namespace IntegerWrapper
{
    public class TInteger
    {
        #region Eigenschaften
        public int IntValue { get; set; }
        #endregion

        #region Konstruktoren
        public TInteger()
        {
            IntValue = 0;
        }

        public TInteger(int value)
        {
            IntValue = value;
        }
        #endregion

        #region Worker
        public TInteger Addition(TInteger value)
        {
            TInteger result = new TInteger();
            result.IntValue = IntValue + value.IntValue;
            return result;
        }

        public TInteger Subtraktion(TInteger value)
        {
            TInteger result = new TInteger();
            result.IntValue = IntValue - value.IntValue;
            return result;
        }

        public TInteger Multiplikation(TInteger value)
        {
            TInteger result = new TInteger();
            result.IntValue = IntValue * value.IntValue;
            return result;
        }

        public TInteger Division(TInteger value)
        {
            TInteger result = new TInteger();
            result.IntValue = IntValue / value.IntValue;
            return result;
        }
        #endregion
    }
}
