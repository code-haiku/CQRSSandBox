using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSSandBox.Model
{
    public class CampaignReaction
    {
        public CampaignReaction(Guid id, string eventName, string participantFirstName, string participantSecondName)
        {
            this.Id = id;
            this.EventName = eventName;
            this.ParticipantFirstName = participantFirstName;
            this.ParticipantSecondName = participantSecondName;
        }

        public Guid Id { get; private set; }

        public string EventName { get; private set; }

        public string ParticipantFirstName { get; private set; }

        public string ParticipantSecondName { get; private set; }
    }
}
