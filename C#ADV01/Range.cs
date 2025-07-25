namespace CS_ADV01
{
    public class Range <T> where T: IComparable<T>
    {
        private readonly T MinValue;
        private readonly T MaxValue;
        public Range(T minValue, T maxValue )
        {
            if(minValue.CompareTo(maxValue) > 0)
            {
                T temp = minValue;
                minValue = maxValue;
                maxValue = temp;
            }

            MinValue = minValue;
            MaxValue = maxValue;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(MinValue) >= 0 && value.CompareTo(MaxValue) <= 0;
        }

        public dynamic Length()
        {
            dynamic max = MaxValue;
            dynamic min = MinValue;
            return max - min;
        }

        public override string ToString()
        {
            return $"MinValue = {MinValue} => MaxValue = {MaxValue}";
        }
    }
}
