using System.Collections.Generic;
using CoreConsoleExample.Model;

namespace CoreConsoleExample
{
    public class SeedData
    {
        public IEnumerable<Product> Products;
        public IEnumerable<Campaign> Campaigns;
        public SeedData()
        {

            Products = new List<Product>
        {
            new Product { Id = 1, Name = "Dimes", Price = 4.3m },
            new Product { Id= 2, Name= "Coca Cola", Price= 8m},
            new Product { Id= 3, Name= "Sprite", Price= 7.4m},
            new Product { Id= 4, Name= "Crackers", Price= 2.9m},
            new Product { Id= 5, Name= "Pınar Su", Price= 1m },
            new Product { Id= 6, Name= "Fanta", Price= 3.7m },
            new Product { Id= 7, Name= "Popkek", Price= 0.8m },
            new Product { Id= 8, Name= "Çubuk Kraker", Price= 1.2m },
            new Product { Id= 9, Name= "Enerji İçeceği", Price= 6.4m },
            new Product { Id= 10, Name= "Kahve", Price= 2 },
            new Product { Id= 11, Name= "Soğuk Çay", Price= 4.8m },
            new Product { Id= 12, Name= "Cips", Price= 3.1m }
        };

            Campaigns = new List<Campaign>
        {
            new Campaign {
                Id = 1,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 1,
                        PromotionalPrice = 4m
                    },
                    new CampaignProduct {
                        Id = 2,
                        PromotionalPrice = 6m
                    }
                }
            },
             new Campaign {
                Id = 2,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 3,
                        PromotionalPrice = 5m
                    },
                    new CampaignProduct {
                        Id = 7,
                        PromotionalPrice = 0.5m
                    },
                    new CampaignProduct {
                        Id = 11,
                        PromotionalPrice = 2m
                    }
                }
            },
             new Campaign {
                Id = 3,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 9,
                        PromotionalPrice = 6m
                    },
                    new CampaignProduct {
                        Id = 4,
                        PromotionalPrice = 2m
                    }
                }
            },
             new Campaign {
                Id = 4,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 1,
                        PromotionalPrice = 3m
                    },
                    new CampaignProduct {
                        Id = 4,
                        PromotionalPrice = 1.8m
                    }
                }
            },
             new Campaign {
                Id = 5,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 1,
                        PromotionalPrice = 3.2m
                    },
                    new CampaignProduct {
                        Id = 7,
                        PromotionalPrice = 0.7m
                    }
                }
            },
             new Campaign {
                Id = 6,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 7,
                        PromotionalPrice = 0.4m
                    },
                    new CampaignProduct {
                        Id = 11,
                        PromotionalPrice = 3.9m
                    }
                }
            },
             new Campaign {
                Id = 7,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 3,
                        PromotionalPrice = 5.8m
                    },
                    new CampaignProduct {
                        Id = 1,
                        PromotionalPrice = 2.9m
                    }
                }
            },
             new Campaign {
                Id = 8,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 4,
                        PromotionalPrice = 2.1m
                    },
                    new CampaignProduct {
                        Id = 9,
                        PromotionalPrice = 5.4m
                    },
                    new CampaignProduct {
                        Id = 11,
                        PromotionalPrice = 3.7m
                    }
                }
            },
             new Campaign {
                Id = 8,
                CampaignProducts = new List<CampaignProduct>{
                    new CampaignProduct {
                        Id = 7,
                        PromotionalPrice =0m
                    },
                    new CampaignProduct {
                        Id = 3,
                        PromotionalPrice = 7m
                    }
                }
            }
        };

        }
    }
}