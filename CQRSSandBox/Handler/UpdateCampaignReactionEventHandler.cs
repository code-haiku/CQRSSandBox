using System;
using CQRSSandBox.Event;
using CQRSSandBox.Repository;

namespace CQRSSandBox.Handler
{
    public class UpdateCampaignReactionEventHandler : EventHandler<UpdateCampaignReactionEvent>
    {
        private ICampaignReactionRepository campaignReactionRepository;

        public UpdateCampaignReactionEventHandler()
        {
            this.campaignReactionRepository = new CampaignReaktionCommandRepository();
        }

        public void Process(UpdateCampaignReactionEvent updateCampaignReactionEvent)
        {
            var campaignReaction = new Model.CampaignReaction(updateCampaignReactionEvent.CampaignReactionId,
                                                              updateCampaignReactionEvent.CampaignReactionDto.EventName,
                                                              updateCampaignReactionEvent.CampaignReactionDto.ParticipantFirstName,
                                                              updateCampaignReactionEvent.CampaignReactionDto.ParticipantSecondName);
            this.campaignReactionRepository.Update(updateCampaignReactionEvent.CampaignReactionId, campaignReaction);
        }
    }
}