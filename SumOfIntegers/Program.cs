
int[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };


int index = 0;

double sum = nbrs[index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index]
    + nbrs[++index];

double sumAvg;
sumAvg = sum / 10;
Console.WriteLine($"The sum id {sum}");
Console.WriteLine(sumAvg);
