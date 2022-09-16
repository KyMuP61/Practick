Console.WriteLine("Helo");



int [] ar = new int[] {1, 1, 0, -1, -1};
List<int> arr = ar.ToList();

void Function ( List<int> arr)
{   
    double negativNum = 0;
    double positivNum = 0;
    double zeroNum = 0;
    foreach (var i in arr)
    {
        if ( i < 0 ) {negativNum += 1;}
        else if ( i > 0 ) {positivNum += 1;}
        else  {zeroNum += 1;}
    }
    negativNum = System.Math.Abs(negativNum);
    
  



    Console.WriteLine(string.Format("{0:0.000000}", positivNum/arr.Count));
    Console.WriteLine(string.Format("{0:0.000000}", negativNum/arr.Count));
    Console.WriteLine(string.Format("{0:0.000000}", zeroNum/arr.Count));
    
}


Function(arr);


