class Solution
{
    static int SolveMeFirst(int a, int b)
    {
        if (a >= 1 && b <= 1000)
        {
            return (a + b);
        }
        return 0;
    }

    static void Main(String[] args)
    {
        int val1 = Convert.ToInt32(Console.ReadLine());
        int val2 = Convert.ToInt32(Console.ReadLine());
        int sum = SolveMeFirst(val1, val2);
        Console.WriteLine(sum);
    }
}
