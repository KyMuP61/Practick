




List<int> lang3 = new List<int> ()  {9, 8, 9};





List<int> lang1 = new List<int> ()  {1, 2, 3};
List<int> lang2 = new List<int> ()  {4, 5, 6};

List<List<int>> langM = new List<List<int>> () {lang1, lang2, lang3 };

foreach (var i in langM)
{
    Console.WriteLine(String.Join(" ", i));
}


Console.WriteLine();




int ListSum ( List<List<int>> langM)
{   
    int resultOne = 0;
    int resultTwo = 0;
    int dif = 0;
    resultOne = langM [0][0] + langM[1][1] + langM[2][2];
    resultTwo = langM [0][2] + langM[1][2] + langM[2][1];
    dif = resultOne - resultTwo;
    
    
    
    return dif;
    



    // foreach (var i in langM)
    // {
    //   foreach (var k in i)
    //   {
        
    //   }
    // }

}

Console.WriteLine(ListSum(langM));



// void PrintMatrix(List<int> matrix1, List<int> matrix2, )
// {
//     for (int i = 0; i < matrix1.Count; i++)
//     {
//         for (int j = 0; j < matrix2.Count; j++)
//         {
            
//         }
//         Console.WriteLine();
//     }
// }              

// PrintMatrix(langM);

