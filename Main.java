package LinearSearch;

public class Main
{
    private static boolean LinearSearch(int[] numbers, int number)
    {
        for(int i : numbers)
        {
            if(i == number)
            {
                return true;
            }
        }
        return  false;
    }

    public static void main(String[] args)
    {
        //Call Linear search here.
    }
}
