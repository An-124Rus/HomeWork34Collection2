internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfClients = 10;

        Queue<int> purchase = new Queue<int>();

        LoadClientPurchaseSum(purchase, numberOfClients);

        ServiceOfQueue(purchase, numberOfClients);
    }

    static void LoadClientPurchaseSum(Queue<int> purchase, int numberOfClients)
    {
        int minValue = 100;
        int maxValue = 1000;

        Random random = new Random();

        for (int i = 0; i < numberOfClients; i++)
            purchase.Enqueue(random.Next(minValue, maxValue));
    }

    static void ServiceOfQueue(Queue<int> purchase, int numberOfClients)
    {
        int shopAccountSum = 0;

        for (int i = 1; i < numberOfClients + 1; i++)
        {
            int clientPurchaseSum = purchase.Peek();

            Console.CursorVisible = false;

            Console.WriteLine($"Обслуживание {i} клиента.\n");
            Console.WriteLine($"Клиент {i} купил товаров на сумму - {clientPurchaseSum} руб.\n");
            Console.WriteLine($"Сумма счёта в магазине до обслуживания {i} клиента - {shopAccountSum} руб.");

            shopAccountSum += purchase.Dequeue();

            Console.WriteLine($"Сумма счёта в магазине после обслуживания {i} клиента - {shopAccountSum} руб.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}