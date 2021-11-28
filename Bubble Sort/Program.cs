using BubbleSort;

int[] arr = { 9, 5, 0, 8, 1, 2, 6 };

Bubble_Sort<int> bubble = new(arr);
Console.WriteLine(bubble.GetCurrentType);

var sorted = bubble.Sort();
foreach(var item in sorted)
{
    Console.WriteLine(item);
}