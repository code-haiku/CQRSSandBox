using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.Dto;

namespace CQRSSandBox.Event
{
    public class UpdateCampaignReactionEvent : BusinessEvent
    {
        public UpdateCampaignReactionEvent(Guid campaignReactionId, CampaignReactionDto campaignReactionDto)
        {
            this.CampaignReactionId = campaignReactionId;
            this.CampaignReactionDto = campaignReactionDto;
        }

        public Guid CampaignReactionId { get; private set; }

        public CampaignReactionDto CampaignReactionDto { get; private set; }
    }
}
