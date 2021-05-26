using System.Collections.Generic;

namespace CoreConsoleExample.Model
{
    public class Campaign
    {
        public int Id { get; set; }
        public IEnumerable<CampaignProduct> CampaignProducts { get; set; }
        public Campaign()
        {
        }
    }
}