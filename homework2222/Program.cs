class Program
{
    static void Main(string[] args)
    {
        CircularLinkedList<char> circularLinkedList = new CircularLinkedList<char>();
        Queue<char> queue = new Queue<char>();
        int end = 1;
        int counter = -1;
        int stopLoop = 0;
        int n = 0;
        
        Console.WriteLine("Input Fruit Size : ");
        do
        {
            counter++;
            circularLinkedList.Add(char.Parse(Console.ReadLine()));
            if(circularLinkedList.Get(counter) != 'S' && circularLinkedList.Get(counter) != 'M' && circularLinkedList.Get(counter) !=  'L')
            {
                end = 1; //clear wrong
            }
            else if(circularLinkedList.Get(counter) == 'S') //small
            {
                queue.Push('3');
                end = 2;
            }
            else if(circularLinkedList.Get(counter) == 'M') //medium
            {
                queue.Push('2');
                end = 2;
            }
            else if(circularLinkedList.Get(counter) == 'L') //large
            {
                queue.Push('1');
                end = 2;
            }
        }
        while(end == 2); //countdown
        while(stopLoop == 0) //stop input
        {
            for(n = 0; n < queue.GetLength(); n++) //convert to smaller size
            {
                if(queue.Get(n) == '2')
                {
                queue.Push('3');
                queue.Push('3');
                queue.Push('3');
                }
                    if(queue.Get(n) == '1')
                {
                queue.Push('2');
                queue.Push('2');
                }
            }
            for( n = 0; n < queue.GetLength(); n++) //write all output
            
                {
                    Console.Write(queue.Get(n));
                }
                    if(n == queue.GetLength())
                {
                    stopLoop = 1;
                }
        }
    }
}