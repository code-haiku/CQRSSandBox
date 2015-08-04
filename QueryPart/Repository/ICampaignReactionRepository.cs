using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSSandBox.QueryPart.Repository
{
    public interface ICampaignReactionRepository
    {
        bool IsExist(string eventName, string participantFirstName, string participantSecondName);
    }
}
