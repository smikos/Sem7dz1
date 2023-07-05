 
 
double [,] GenerateArray2DDD(int rows, int columns,int min, int max)
{
    
    double [,] numbers = new double [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = Math.Round(min + rnd.NextDouble() * ( max), 2); ;
          
           
        }
        
    }
    
    return numbers;
}

void PrintArray2D(double [,] numbers)
{

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
         
         System.Console.Write($"{numbers[i,j]}\t"); 

        }
        System.Console.WriteLine();
       
        
    }

}

double[,] array = GenerateArray2DDD(4,4,0,6);

PrintArray2D(array);