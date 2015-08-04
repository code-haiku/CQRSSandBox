using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.Dto;

namespace CQRSSandBox.Event
{
    public class CreateCampaignReactionEvent : BusinessEvent
    {
        public CreateCampaignReactionEvent(CampaignReactionDto campaignReactionDto)
        {
            this.CampaignReactionDto = campaignReactionDto;
        }

        public CampaignReactionDto CampaignReactionDto { get; private set; }
    }
}
