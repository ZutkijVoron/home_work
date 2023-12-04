// int n = 10;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine("[" + string.Join(" ", array) + "]");
// int sum = 0;
// for (int i = 0; i < n; i++)
// {
//     sum += array[i];
// }
// System.Console.WriteLine(sum);




int n = 4;
int[,] matrix = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        System.Console.Write(matrix[i, j] + "\t");
    }
    System.Console.WriteLine();
}