class Program
{
    private static bool LinearSearch<T>( IEnumerable<T> array, T number) where T : IComparable
    {
        foreach(T item in array)
        {
            if (Equals(item , number) )
            {
                return true;
            }
        }
        return false;
    }
    public static void Main()
    {
    }
}
