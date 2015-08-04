using CQRSSandBox.QueryPart.Repository;

namespace CQRSSandBox.QueryRepository
{
    public class CampaignReactionRepository : ICampaignReactionRepository
    {
        public bool IsExist(string eventName, string participantFirstName, string participantSecondName)
        {
//            CampaignReactionStaticStore.CampaignReactions.Any<Model.CampaignReaction(_ => )
            return false;
        }
    }
}
