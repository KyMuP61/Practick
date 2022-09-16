
// var someList = new List<int>() {1, 2, 3};
// int simpleArray (List<int> ar)
// {
//     int sum = 0;
//     foreach (var item in ar)
//     {
//      sum += item;
//     }
//     return sum;
// }

// Console.WriteLine(simpleArray(someList));


List<long> array = new List<long>() { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };

  // int count = ar.Count;
    // long [] result = new long [count];
    //   for (int i = 0; i < ar.Count; i++)
    // {
    //     result [i] = ar [i];
    // }


long aVeryBigSum (List <long> ar)
{
    long sum = 0;
  
    foreach (long i in ar)
    {
      sum += (i);
    }
    
    return sum;
}


Console.WriteLine(aVeryBigSum(array));



