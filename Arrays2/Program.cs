int[] n = { 2, 5, 7 };

Console.WriteLine("The array stored is: ");
foreach (var item in n)
{
    Console.Write(item.ToString() + " ");
}

Console.WriteLine();
Console.WriteLine("The array in reverse is: ");

Array.Reverse(n);
Console.WriteLine(String.Join(" ", n));
