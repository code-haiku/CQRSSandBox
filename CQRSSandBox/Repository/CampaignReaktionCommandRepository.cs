using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSSandBox.Repository
{
    public class CampaignReaktionCommandRepository : ICampaignReactionRepository
    {
        private static List<Model.CampaignReaction> campaignReactions = new List<Model.CampaignReaction>();

        public void Create(Model.CampaignReaction campaignReaktion)
        {
            campaignReactions.Add(campaignReaktion);
        }

        public void Update(Guid id, Model.CampaignReaction campaignReaction)
        {
             var index = campaignReactions.FindIndex(_ => _.Id == id);
             campaignReactions[index] = campaignReaction;
        }
    }
}
