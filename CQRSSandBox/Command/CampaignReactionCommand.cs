using CQRSSandBox.Dto;
using CQRSSandBox.Event;

namespace CQRSSandBox.Command
{
    public class CampaignReactionCommand : ICampaignReactionCommand
    {
        private IEventStore eventStore;

        public CampaignReactionCommand()
        {
            this.eventStore = new EventStore();
        }

        public void Import(CampaignReactionDto campaignReactionDto)
        {
            BusinessEvent campaignReactionEvent;

            //if(true)
            //{
                campaignReactionEvent = new CreateCampaignReactionEvent(campaignReactionDto);
            //}
            //else
            //{
            //    campaignReactionEvent = new UpdateCampaignReactionEvent()
            //}

            eventStore.Publish(campaignReactionEvent);
        }
    }
}
