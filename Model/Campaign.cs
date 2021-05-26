using System.Collections.Generic;

namespace CoreConsoleExample.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public List<CampaignProduct> CampaignProducts { get; set; }
        public Campaign()
        {
        }
    }
}