namespace BestBackendProject;


class Generic
{
    internal void Write<T>(T value)
    {
        Console.WriteLine(value);
    }
}

class NewProgram
{
    public static void Main()
    {
        Generic generic = new Generic();
        generic.Write("String");
        generic.Write(31);
    }
}

class Arrays<T>
{
    
    /**
    • Statik
    • Daha iyi performans
     */
    
    private int value { get; set; }
    private T[] array { get; set; }

    internal void Write()
    {
        for (int i = 0; i <= array.Length; i++)
        {
            value = i;
            Console.WriteLine(value);
        }
    }
}

class Collections
{
    /**
     * Dinamik
     * Farklı ihtiyaçlara çözümler
     * Sınıf - Örnek alınmalı
     */

    class List
    {
        /**
         * Dinamik
         * Dizi
         * Tek türden elemanların listesi
         */
        private List<string> listOfString = new List<string>();

        public List()
        {
            listOfString.Add("Selam");
            Console.WriteLine(listOfString.Count);
            listOfString.Clear();
        }
    }

    class Dictionary<T>
    {
        private int value = 0;
        
        private Dictionary<string, int> values = new Dictionary<string, int>();
        private Dictionary<T, T> valuesGeneric = new Dictionary<T, T>();
        // < Key, Value> 

        public Dictionary()
        {
            values["key"] = value;
            values.Add("Hola!", 2);
            Console.WriteLine(values.ContainsKey("Hola!"));
        }
    }

    class HashSet
    {
        private HashSet<int> set = new HashSet<int>();

        public HashSet()
        {
           bool value = set.Add(1);
           bool isContain = set.Contains(1);
        }
    }

    class SortedList
    {
        private SortedList<int, string> sortedList = new SortedList<int, string>();

        public SortedList()
        {
            sortedList.Add(1,"One");
            sortedList.Add(3,"Two");
            sortedList.Add(2,"Three");
            
            /**
             Console:
              One
              Three
              Two
             */

            List<string> stringList = sortedList.Values.ToList();
            
            foreach (var sorteds in stringList)
            {
                Console.WriteLine(sorteds);
            }
        }
    }

    class Stack
    {
        /**
           • Lifo
           • <T>
           • Kuyruk metotları ile aynı
         */
        
        private Stack<string> stack = new Stack<string>();

        public Stack()
        {
            stack.Push("Hello");
            stack.Pop();
            var count = stack.Count();
            Console.WriteLine(count);
        }
    }

    class Queue
    {
        private Queue<string> queue = new Queue<string>();

        public Queue()
        {
            queue.Enqueue("Enqueue"); // add Value
            var queueValue = queue.Dequeue(); // get Value
            var queueNextValue = queue.Peek(); // get next Value
        }
        
    }
}