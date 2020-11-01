//Использование объекта Mutex для создания приложения, исполняемого в единственном экземпляре
using System;
using System.Threading;

namespace prak8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex oneMutex = null;
            const String MutexName = "RUNMEONCE";
            try
            {
                oneMutex = Mutex.OpenExisting(MutexName);
            }
            catch (WaitHandleCannotBeOpenedException)
            {
            }
            if (oneMutex == null)
            {
                oneMutex = new Mutex(true, MutexName);
            }
            else
            {
                oneMutex.Close();
                return;
            }
            Console.WriteLine("Our Application");
            Console.Read();
        }
    }
}