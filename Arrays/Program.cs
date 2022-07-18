using System.Collections.Generic;

//Int  of Arrays


//int[] numbers = new int[5];
//numbers[0] = 12;
//numbers[1] = 3;
//numbers[2] = 5;

//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.Write(numbers[i]);
//}

//foreach (int number in numbers)
//{
//    Console.Write(number + ", ");

//}

//Console.ReadKey();

// Lists 
//List<int> numbers = new List<int>();
//numbers.Add(13);
//numbers.Add(4);
//numbers.Add(8);

//for(int i = 0; i < numbers.Count; i++)          // Prints out numbers in array
//{
//    Console.Write(numbers[i] + ", ");
//}
//Console.WriteLine();

//numbers.RemoveAt(1);                            // removes number at (n) position of array
//for(int i = 0; i< numbers.Count; i++)
//{
//    Console.Write(numbers[i] + ", ");
//}
//Console.WriteLine();


//       Multidimensional Arrya


//int[,] grid = new int[8, 8];
//grid[2, 3] = 3;
//for(int x= 0; x < grid.GetLength(0); x++)
//{
//    for(int y= 0; y < grid.GetLength(1); y++)
//    {
//        Console.Write(grid[x, y] + ", ");
//    }
//    Console.WriteLine();
//}


List<string> students = new List<string>() { "Michael", "Morgan", "Jacob", "Garret", "Brennan", "Jacob" };
//for loop with .Count()
for (int i = 0; i < students.Count(); i++)
    {
        Console.WriteLine(students[i]);
    }

//  .IndexOf
int index = students.IndexOf("Jacob");
Console.WriteLine(index);
