using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.Event;

namespace CQRSSandBox
{
    public class EventStore : IEventStore
    {
        private ICollection<BusinessEvent> businessEvents = new List<BusinessEvent>();

        public void Publish(BusinessEvent businessEvent)
        {
            this.businessEvents.Add(businessEvent);
        }
    }
}
