using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IObserverProject
{
    public class ObserverA : IObserver<DataA>
    {
        public void OnCompleted()
        {
            Console.WriteLine("ObserverA has Completed.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("ObserverA received an Error: " + error.Message);
        }

        public void OnNext(DataA value)
        {
            Console.WriteLine("ObserverA OnNext() Name =  " + value.Name);
        }
    }
}
