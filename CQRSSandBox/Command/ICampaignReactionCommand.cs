using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRSSandBox.Dto;

namespace CQRSSandBox.Command
{
    public interface ICampaignReactionCommand
    {
        void Import(CampaignReactionDto campaignReactionDto);
    }
}
