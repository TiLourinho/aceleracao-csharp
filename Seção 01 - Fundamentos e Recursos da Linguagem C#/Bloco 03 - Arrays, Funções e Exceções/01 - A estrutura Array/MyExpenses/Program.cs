class Program
{
    static void Main(string[] args)
    {
        int[] expensesCost;

        int numberOfExpenses = GetNumberOfExpenses();
        expensesCost = new int[numberOfExpenses];

        for (int i = 0; i < numberOfExpenses; i++)
        {
            expensesCost[i] = GetExpenseCostFromUser(i + 1);
        }

        int totalCost = expensesCost.Sum();

        Console.WriteLine($"O seu total de gastos é de: R$ {totalCost},00.");
    }

    public static int GetNumberOfExpenses()
    {
        Console.WriteLine("Entre com o número de despesas:");
        int entry = Convert.ToInt32(Console.ReadLine());

        return entry;
    }

    public static int GetExpenseCostFromUser(int number)
    {
        Console.WriteLine($"Entre com a despesa {number}:");
        int entry = Convert.ToInt32(Console.ReadLine());

        return entry;
    }
}
