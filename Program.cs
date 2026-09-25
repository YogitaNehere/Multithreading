namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game obj = new Game();
            Thread t = new Thread(obj.GetScore);  //init state
            t.Name = "Player 1";
            t.Start();

            Thread t1 = new Thread(obj.GetScore);  //init state
            t1.Name = "Player 2";
            t1.Start();


            //ThreadEx obj = new ThreadEx();
            //Thread t = new Thread(obj.Display);  //init state
            //t.Name = "Thread 1";
            //t.Start();
            ////t.Join(); //wait for thread to complete

            //Thread t1 = new Thread(obj.Display); //init state
            //t1.Name = "Thread 2";
            //t1.Start();
        }
    }
}
 