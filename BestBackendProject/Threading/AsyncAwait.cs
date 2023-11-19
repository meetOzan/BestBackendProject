namespace BestBackendProject.Threading;

public class AsyncAwait
{
    /**
        Async - Await

        • Senkron uygulama
        • Asenkron uygulama
        • Async - await
        • Task sınıfı
        • Delay
        • Wait
    */

    private static List<int> list = new List<int>();

    private static async Task<int> AddShow()
    {
        await Task.Run(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.WriteLine(i);
                Task.Delay(250).Wait();
            }
        });
        return 0;
    }
    
/**
• Main async olmalı
• Await edebilmesi için Task döndürmeli
*/

    public static void AsyncFunc()
    {
        AddShow();
        Thread.Sleep(1000);
        Console.WriteLine("Total: " + list.Sum());
    }

    public static async void AsyncAwaitFunc()
    {
        await AddShow();
        Thread.Sleep(1000);
        Console.WriteLine("Total: " + list.Sum());
    }
}