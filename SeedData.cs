using System.Collections.Generic;
using CoreConsoleExample.Model;

namespace CoreConsoleExample
{
    public class SeedData
    {
        public List<Product> products;
        public List<Campaign> campaigns;
        public SeedData()
        {

            products = new List<Product>
        {
            new Product { id = 1, name = "Dimes", price = 4.3m },
            new Product { id= 2, name= "Coca Cola", price= 8m},
            new Product { id= 3, name= "Sprite", price= 7.4m},
            new Product { id= 4, name= "Crackers", price= 2.9m},
            new Product { id= 5, name= "Pınar Su", price= 1m },
            new Product { id= 6, name= "Fanta", price= 3.7m },
            new Product { id= 7, name= "Popkek", price= 0.8m },
            new Product { id= 8, name= "Çubuk Kraker", price= 1.2m },
            new Product { id= 9, name= "Enerji İçeceği", price= 6.4m },
            new Product { id= 10, name= "Kahve", price= 2 },
            new Product { id= 11, name= "Soğuk Çay", price= 4.8m },
            new Product { id= 12, name= "Cips", price= 3.1m }
        };

            campaigns = new List<Campaign>
        {
            new Campaign {
                id = 1,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 1,
                        campaignPrice = 4m
                    },
                    new CampaignProduct {
                        id = 2,
                        campaignPrice = 6m
                    }
                }
            },
             new Campaign {
                id = 2,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 3,
                        campaignPrice = 5m
                    },
                    new CampaignProduct {
                        id = 7,
                        campaignPrice = 0.5m
                    },
                    new CampaignProduct {
                        id = 11,
                        campaignPrice = 2m
                    }
                }
            },
             new Campaign {
                id = 3,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 9,
                        campaignPrice = 6m
                    },
                    new CampaignProduct {
                        id = 4,
                        campaignPrice = 2m
                    }
                }
            },
             new Campaign {
                id = 4,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 1,
                        campaignPrice = 3m
                    },
                    new CampaignProduct {
                        id = 4,
                        campaignPrice = 1.8m
                    }
                }
            },
             new Campaign {
                id = 5,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 1,
                        campaignPrice = 3.2m
                    },
                    new CampaignProduct {
                        id = 7,
                        campaignPrice = 0.7m
                    }
                }
            },
             new Campaign {
                id = 6,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 7,
                        campaignPrice = 0.4m
                    },
                    new CampaignProduct {
                        id = 11,
                        campaignPrice = 3.9m
                    }
                }
            },
             new Campaign {
                id = 7,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 3,
                        campaignPrice = 5.8m
                    },
                    new CampaignProduct {
                        id = 1,
                        campaignPrice = 2.9m
                    }
                }
            },
             new Campaign {
                id = 8,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 4,
                        campaignPrice = 2.1m
                    },
                    new CampaignProduct {
                        id = 9,
                        campaignPrice = 5.4m
                    },
                    new CampaignProduct {
                        id = 11,
                        campaignPrice = 3.7m
                    }
                }
            },
             new Campaign {
                id = 8,
                campaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        id = 7,
                        campaignPrice =0m
                    },
                    new CampaignProduct {
                        id = 3,
                        campaignPrice = 7m
                    }
                }
            }
        };

        }
    }
}