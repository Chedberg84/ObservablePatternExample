using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IObserverProject
{
    public class ObserverB : IObserver<DataB>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(DataB value)
        {
            throw new NotImplementedException();
        }
    }
}
