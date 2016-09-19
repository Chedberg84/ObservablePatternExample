using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IObserverProject
{
    public static class Class1
    {
        public static void Main(string[] args)
        {
            ObservableA Event = new ObservableA();
            ObserverA observer = new ObserverA();

            Event.Subscribe(observer);

            Event.Execute(new DataA() { ID = 1, Name = "Chris", Desc = "Test A" });
            Event.EndExecute();
            
            //Pause console to read line.
            Console.ReadLine();
        }
    }
}
