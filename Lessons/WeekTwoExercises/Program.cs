// See https://aka.ms/new-console-template for more information
/*
*INCREMENT/DECREMENT** 
i++
i += 2: - This expression would add two to the loop variable instead of 1.
i --: - This expression would subtract one, allowing you to loop through a collection in a last-to-first order.
i *= 4: - This expression would multiply the value by 4. (You probably wouldn't ever do this, but again, any expression is permitted)
Example:
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
Output:
0
1
2
3
4
*/

/*
*NESTING LOOPS* 
(Loop code blocks can contain other loops. When this occurs, we refer to it as a nested loop. In a nested loop, the inner loop will run to completion for each pass of the outer loop. As an example, here is some code that prints a 4x5 grid of asterisks, separated by tab characters:)
Example:
for(int i=0; i<4; i++)
{
    for(int j=0; j<5; j++)
    {
        Console.Write("*\t");
    }
    Console.WriteLine();
}
Output:
*     *     *     *     *
*     *     *     *     *
*     *     *     *     *
*     *     *     *     *
*/

/*
*While Loop
(While loops are more prone to infinite loops if the condition is not properly managed.
The question to ask when designing your applications is, "Do I know how many times I need to loop?". If the answer is yes, then the for loop is likely your best choice. If the answer is no, then the while loop is likely appropriate. It is important to note that you can use a while loop to accomplish the same task as a for loop if you handle the loop variable. The code below is the while equivalent of a for loop:)
Example:
int i = 0;
while (i < 6)
{
    Console.WriteLine(i);
    i++;
}
Output:
0
1
2
3
4
5
*/

// class multiTable
// {
//     static void Main()
//         {
//         int startRow, endRow, startCol, endCol;

//         // Get user input for rows
//         Console.Write("Enter starting value for rows: ");
//         while (!int.TryParse(Console.ReadLine(), out startRow))
//         {
//             Console.Write("Please enter a valid integer for starting rows: ");
//         }

//         Console.Write("Enter ending value for rows: ");
//         while (!int.TryParse(Console.ReadLine(), out endRow))
//         {
//             Console.Write("Please enter a valid integer for ending rows: ");
//         }

//         // Get user input for columns
//         Console.Write("Enter starting value for columns: ");
//         while (!int.TryParse(Console.ReadLine(), out startCol))
//         {
//             Console.Write("Please enter a valid integer for starting columns: ");
//         }

//         Console.Write("Enter ending value for columns: ");
//         while (!int.TryParse(Console.ReadLine(), out endCol))
//         {
//             Console.Write("Please enter a valid integer for ending columns: ");
//         }

//         // Print header
//         Console.WriteLine();
//         for (int col = startCol; col <= endCol; col++)
//         {
//             Console.Write($"\t{col}");
//         }
//         Console.WriteLine();
//         Console.WriteLine(new string('=', 50));

//         // Generate and print the multiplication table
//         for (int row = startRow; row <= endRow; row++)
//         {
//             Console.Write($"{row}\t");
//             for (int col = startCol; col <= endCol; col++)
//             {
//                 Console.Write($"{row * col}\t");
//             }
//             Console.WriteLine();
//         }
//     }
// }

using System.Net;

namespace PracticeMinis
{
    public class LoopExercises
    {
        public static string Yak(string str)
        {
            return System.Text.RegularExpressions.Regex.Replace(str, "y.a.k", "");
        }
    }
}
