class Program
{
    public static void Main()
    {
        int[,] array1 = { 
	        { 3, 8, 1 },
	        { 7, 4, 9 },
	    	{ 2, 5, 6 } 
        };

        LargerNum(array1);



        int[,] array2 = { 
	        { 1, 2, 3 },
	        { 4, 5, 6 },
	        { 7, 8, 9 } 
        };

        PlusNumbers1(array2);



        int[,] array3 = { 
	        { 1, 2, 3 },
	        { 4, 5, 6 },
	        { 7, 8, 9 } 
        };

        PlusNumbers2(array3);



        int[,] array = { 
	        { 2, 5, 7 },
	        { 4, 1, 8 },
	        { 6, 3, 9 }
        };

        DiagonalPlusNum(array);



        int[,] array = {
	        { 1, 2, 3 },
	        { 4, 5, 6 },
	        { 7, 8, 9 }
        };

        Tranzpose(array);



        int[,] array = {
	        { -1, 2, -3 },
	        { 4, -5, 6 },
	        { -7, 8, -9 }
        };

        PositiveNum(array);



        int[,] array = { 
	        { 10, 15, 5 },
	        { 7, 20, 30 },
	        { 25, 3, 12 }
        };

        SmallNum(array);



        int[,] array = {
	        { 1, 2, 3 },
	        { 4, 5, 6 },
	        { 7, 8, 9 }
        };

        ReversedNum(array);



        int[,] array = {
	        { 2, 3, 4 },
	        { 5, 6, 7 },
	        { 8, 9, 10 }
        };

        EvenNum(array);



        int[,] array = {
	        { 1, 2, 3 },
	        { 4, 5, 6 },
	        { 7, 8, 9 }
        };

        Num(array);
    }


    private static void Num(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write((array[i, j]*0) + " ");
            }
            Console.WriteLine();
        }
    }


    private static void EvenNum(int[,] array)
    {
        int EvenNum1 = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] % 2 == 1)
                {
                    EvenNum1++;
                }
            }
        }
        Console.Write($"Toq sonlar soni: " + EvenNum1);
    }


    private static void ReversedNum(int[,] array)
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = array.GetLength(1) - 1; j >= 0; j--)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    private static void SmallNum(int[,] array)
    {
        int SmallNum1 = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i, j] < 10)
                {
                    SmallNum1++;
                }
            }
        }
        Console.Write("Eng kichik element: " + SmallNum1);
    }


    private static void PositiveNum(int[,] array)
    {
        int PosNum = 0;
        for(int i = 0; i < array.GetLength(1); i++)
        {
            for(int j = 0; j < array.GetLength(0); j++)
            {
                if(array[i, j] > 0)
                {
                    PosNum++;
                }
            }
        }
        Console.Write("Musbat elementlar soni: " + PosNum);
    }


    private static void Tranzpose(int[,] array)
    {
        for(int i = 0; i < array.GetLength(1); i++)
        {
            for(int j = 0; j < array.GetLength(0); j++)
            {
                Console.Write(array[j, i] + " ");
            }
            Console.WriteLine();
        }
    }


    private static void DiagonalPlusNum(int[,] array)
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {

            for(int j = 0; j < array.GetLength(1); j++)
            {
                if(i == 0 && j == 0)
                {
                    sum+=array[i, j];
                }
                if(i == 1 && j == 1)
                {
                    sum+=array[i, j];
                }
                if(i == 2 && j == 2)
                {
                    sum+=array[i, j];
                }
            }
        }
        Console.WriteLine("Diagonal yig'indisi: " + sum);
    }


    private static void PlusNumbers2(int[,] array3)
    {
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        for(int i = 0; i < array3.GetLength(0); i++)
        {
            for(int j = 0; j < array3.GetLength(1); j++)
            {
                if(i == 0)
                {
                    sum1+=array3[j, i];
                }
                if(i == 1)
                {
                    sum2+=array3[j, i];
                }
                if(i == 2)
                {
                    sum3+=array3[j, i];
                }
            }
        }
        Console.WriteLine($"Ustunlar yig'indisi: [{sum1}, {sum2}, {sum3}]");
    }


    private static void PlusNumbers1(int[,] array)
    {
        int sum1 = 0;
        int sum2 = 0;
        int sum3 = 0;
        Console.Write("Qatorlar yig'indisi: [");
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int b = 0; b < array.GetLength(1); b++)
            {
                if(i == 0)
                {
                    sum1+=array[i, b];
                }
                if(i == 1)
                {
                    sum2+=array[i, b];
                }
                if(i == 2)
                {
                    sum3+=array[i, b];
                }
            }
        }
        Console.WriteLine($"{sum1}, {sum2}, {sum3}]");
    }


    private static void LargerNum(int[,] array)
    {
        int maxNum = array[0, 0];
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int a = 0; a < array.GetLength(0); a++)
            {
                if(maxNum < array[i, a])
                {
                    maxNum = array[i, a];
                }
            }
        }
        Console.WriteLine("Eng katta son: " + maxNum);
    }
}

