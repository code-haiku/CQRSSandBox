using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSSandBox.CommandPart.Handler
{
    public interface EventHandler<TEvent>
    {
        void Process(TEvent businessEvent);
    }
}
