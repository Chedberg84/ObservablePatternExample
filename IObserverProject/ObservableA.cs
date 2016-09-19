using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IObserverProject
{
    public class ObservableA : IObservable<DataA>
    {
        private List<IObserver<DataA>> observers;

        public ObservableA()
        {
            observers = new List<IObserver<DataA>>();
        }

        public IDisposable Subscribe(IObserver<DataA> observer)
        {
            if (!observers.Contains(observer))
                observers.Add(observer);
            return new Unsubscriber(observers, observer);
        }

        public void Execute(DataA data) //(Nullable<DataA> data)
        {
            foreach (var observer in observers)
            {
                if (data == null)
                    observer.OnError(new Exception());
                else
                    observer.OnNext(data);

                //if (!data.HasValue)
                //    observer.OnError(new Exception());
                //else
                //    observer.OnNext(data.Value);
            }
        }

        public void EndExecute()
        {
            foreach (var observer in observers.ToArray())
            {
                if (observers.Contains(observer))
                {
                    observer.OnCompleted();
                }
            }

            observers.Clear();
        }


        //Nested class
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<DataA>> _observers;
            private IObserver<DataA> _observer;

            public Unsubscriber(List<IObserver<DataA>> observers, IObserver<DataA> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
