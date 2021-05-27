using System.Collections.Generic;

namespace CoreConsoleExample.Model
{
    public class Campaign
    {
        public int id { get; set; }
        public List<CampaignProduct> campaignProducts { get; set; }
        public Campaign()
        {
        }
    }
}