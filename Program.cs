namespace Multithreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadEx obj = new ThreadEx();
            Thread t = new Thread(obj.Display);  //init state
            t.Start();
        }
    }
}
