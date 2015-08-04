using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.Event;

namespace CQRSSandBox
{
    public interface IEventStore
    {
        void Publish(BusinessEvent businessEvent);
    }
}
