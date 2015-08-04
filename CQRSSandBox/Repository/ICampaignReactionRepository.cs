using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.CommandPart.Model;

namespace CQRSSandBox.CommandPart.Repository
{
    public interface ICampaignReactionRepository
    {
        void Create(CampaignReaction campaignReaktion);

        void Update(Guid id, CampaignReaction campaignReaction);
    }
}
