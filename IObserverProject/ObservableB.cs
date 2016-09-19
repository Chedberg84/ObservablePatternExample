using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IObserverProject
{
    public class ObservableB : IObservable<DataB>
    {

        public IDisposable Subscribe(IObserver<DataB> observer)
        {
            throw new NotImplementedException();
        }
    }
}
