using System;


namespace Assignment_14_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            Lock mylock = new Lock();

            mylock.OpenLock();

            CombinationLock c = new CombinationLock("055");
            c.CloseLock();
            c.OpenLock("005");
            //System.Threading.Thread.Sleep(5000);
        }
    }
}
