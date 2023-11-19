namespace BestBackendProject.Threading;

public class Threading
{

    /**

    Parametresiz

    • Senkronizasyon yok
    • Parametre almaz
    • Değer döndürmez

    */

    public static object lockKey = false;

    public static void PrintFunc(object number)
    {
        Console.WriteLine(new Random().Next(1,(int)number));
        Console.WriteLine(new Random().Next(1,(int)number));
        Console.WriteLine(new Random().Next(1,(int)number));
    }

    public static void Main()
    {
        Thread thread = new Thread(PrintFunc);
        thread.Start();
        Console.WriteLine("After Thread");
    }
    
/**

Parametreli
     
• Senkronizasyon yok
• Parametre alır
• Değer döndürmez

*/
    
    public static void MainWithThread()
    {
        lock (lockKey)
        {
            Thread thread = new Thread(PrintFunc);
            Thread threadLambda = new Thread(x => Console.WriteLine(new Random().Next(1,(int)x)));
            thread.Start(20);
            Thread.Sleep(new Random().Next(500,2200)); // Like Delay
            Console.WriteLine("After Thread");
            
        }
    }
    
/**
Mutex
• Lock mekanizması yerine kullanılabilir

Sephamore
• Başlangıç ve maksimum thread belirler
• Senkronizasyon sağlamaz
 */
}