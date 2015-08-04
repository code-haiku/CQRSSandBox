using System;
using CQRSSandBox.CommandPart.Repository;
using CQRSSandBox.CommandRepository.Repository;
using CQRSSandBox.Event;
using Model = CQRSSandBox.CommandPart.Model;

namespace CQRSSandBox.EventHandler.Handler
{
    public class CreateCampaignReactionEventHandler : CQRSSandBox.CommandPart.Handler.EventHandler<CreateCampaignReactionEvent>
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
