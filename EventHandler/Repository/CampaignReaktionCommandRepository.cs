using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.CommandPart.Repository;
using CQRSSandBox.CommandPart;
using CQRSSandBox.StaticStore;
using Model = CQRSSandBox.CommandPart.Model;

namespace CQRSSandBox.CommandRepository.Repository
{
    public class CampaignReaktionCommandRepository : ICampaignReactionRepository
    {
        public void Create(Model.CampaignReaction campaignReaktion)
        {
            CampaignReactionStaticStore.CampaignReactions.Add(campaignReaktion);
        }

        public void Update(Guid id, Model.CampaignReaction campaignReaction)
        {
            var index = CampaignReactionStaticStore.CampaignReactions.FindIndex(_ => _.Id == id);
            CampaignReactionStaticStore.CampaignReactions[index] = campaignReaction;
        }
    }
}
