using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3_4
{
    public delegate void SampleDelegate();
    public interface ISampleEvents
    {
        event SampleDelegate SampleEvent;
        void Invoke();
    }

    class SampleClass : ISampleEvents 
    {
        public event SampleDelegate SampleEvent;

        public void Invoke()
        {
            //throw new NotImplementedException();
            SampleEvent();
        }
    }
}
