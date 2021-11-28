namespace BubbleSort
{
    //User will define the type when it will create object.
    public class Bubble_Sort<T> 
    {
        //User array will be saved here.
        private readonly T[] _array;  
        public Type GetCurrentType
        {
            get
            {
                return typeof(T);
            }
        } 

        //Constructor.
        public Bubble_Sort(T[] array)
        {
            this._array = array;
        }

        private static int[] IncreasingOrderBubbleSort(int[] array)
        {
            bool not_sorted = true;
            while(not_sorted)
            {
                not_sorted = false;
                for(int i = 0; i < array.Length - 1; i ++)
                {
                    if(array[i] > array[i + 1])
                    {
                        not_sorted = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        private static decimal[] IncreasingOrderBubbleSort(decimal[] array)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        not_sorted = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        private static long[] IncreasingOrderBubbleSort(long[] array)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        not_sorted = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        private static double[] IncreasingOrderBubbleSort(double[] array)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        not_sorted = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        private static uint[] IncreasingOrderBubbleSort(uint[] array)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        not_sorted = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        private static ulong[] IncreasingOrderBubbleSort(ulong[] array)
        {
            bool not_sorted = true;
            while (not_sorted)
            {
                not_sorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        not_sorted = true;
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }

        public dynamic Sort()
        {
            switch(_array)
            {
                case int[] _:
                case byte[] _:
                case short[] _:
                    return IncreasingOrderBubbleSort(_array.Select(x => Convert.ToInt32(x)).ToArray());
                case float[] _:
                case decimal[] _:
                    return IncreasingOrderBubbleSort(_array.Select(x => Convert.ToDecimal(x)).ToArray());
                case long[] _:
                    return IncreasingOrderBubbleSort(_array.Select(x => Convert.ToInt64(x)).ToArray());
                case double[] _:
                    return IncreasingOrderBubbleSort(_array.Select(x => Convert.ToDouble(x)).ToArray());
                case uint[] _:
                case ushort[] _:
                    return IncreasingOrderBubbleSort(_array.Select(x => Convert.ToUInt32(x)).ToArray());
                case ulong[] _:
                    return IncreasingOrderBubbleSort(_array.Select(x => Convert.ToUInt64(x)).ToArray());
                default:
                    throw new Exception("Input array can't have datatype that can't be compared.");
            }
        }
    }
}
