// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int a = 4;

void Stairs (int n)
{
    List<string> arr = new List<string> (4) {};
    foreach (var i in arr)
    {
        arr.Add(" ");
    }
        while ( n>0 )
    {
        arr[n-1] = "#";    
        foreach (var item in arr)
        {
            Console.Write(item);
        }
        n--;
        Console.WriteLine(string.Empty);
    }
}
Stairs(a);


