using System;
using CQRSSandBox.CommandPart.Repository;
using CQRSSandBox.CommandRepository.Repository;
using CQRSSandBox.Event;
using Model = CQRSSandBox.CommandPart.Model;

namespace CQRSSandBox.EventHandler.Handler
{
    public class UpdateCampaignReactionEventHandler : CQRSSandBox.CommandPart.Handler.EventHandler<UpdateCampaignReactionEvent>
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