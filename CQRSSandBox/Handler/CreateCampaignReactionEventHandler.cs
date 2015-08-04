using System;
using CQRSSandBox.Event;
using CQRSSandBox.Repository;

namespace CQRSSandBox.Handler
{
    public class CreateCampaignReactionEventHandler : EventHandler<CreateCampaignReactionEvent>
    {
        private ICampaignReactionRepository campaignReactionRepository;

        public CreateCampaignReactionEventHandler()
        {
            this.campaignReactionRepository = new CampaignReaktionCommandRepository();
        }

        public void Process(CreateCampaignReactionEvent createCampaignReactionEvent)
        {
            var campaignReaction = new Model.CampaignReaction(Guid.NewGuid(),
                                                              createCampaignReactionEvent.CampaignReactionDto.EventName,
                                                              createCampaignReactionEvent.CampaignReactionDto.ParticipantFirstName,
                                                              createCampaignReactionEvent.CampaignReactionDto.ParticipantSecondName);
            this.campaignReactionRepository.Create(campaignReaction);
        }
    }
}
