
using System.Diagnostics.CodeAnalysis;

int[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };

var sum = 0;
var count = 0.0;

for(int idx = 0; idx < 10; idx++)
{
    if (nbrs[idx] % 2 == 1)
    {
        sum = sum + (nbrs[idx] * nbrs[idx]);
        count++;
    }
        // sum = sum + nbrs[idx];
}
Console.WriteLine($"The answer is {sum}");
Console.WriteLine($"The average is {sum / count}");