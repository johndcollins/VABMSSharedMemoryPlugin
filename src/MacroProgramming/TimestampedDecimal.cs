using System;

namespace Common.MacroProgramming
{
    [Serializable]
    public struct TimestampedDecimal
    {
        public DateTime Timestamp;
        public double Value;
        public double CorrelatedValue;
    }
}
