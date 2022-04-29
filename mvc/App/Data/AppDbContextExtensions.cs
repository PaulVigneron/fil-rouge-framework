using App.Models;

namespace App.Data
{
    public static class AddDbContextExtensions
    {
        public static void Seed(this AppDbContext dbContext)
        {
            if(!dbContext.ResultItem.Any())
            {
                var resultItems = new List<ResultItem>()
                    {
                        new ResultItem()
                        {
                            Id=1,
                            DriverName="Jean Louis",
                            Rank=1
                        },
                        new ResultItem()
                        {
                            Id=2,
                            DriverName="Jean Eude",
                            Rank=2
                        },
                        new ResultItem()
                        {
                            Id=3,
                            DriverName="Jean Pierre",
                            Rank=3
                        }
                    };

                dbContext.ResultItem.AddRange(resultItems);
                dbContext.SaveChanges();
            }

            if(!dbContext.Races.Any())
            {
                var races = new List<Race>()
                    {
                        new Race()
                        {
                            Id=1,
                            Name="Super première course",
                            EventDate= new DateTime(2022, 05, 26, 12, 40, 00),
                            FreePlaces=10,
                            NumberParticipants=7
                        },
                        new Race()
                        {
                            Id=2,
                            Name="Deuxième course",
                            EventDate= new DateTime(2022, 05, 02, 11, 00, 00),
                            FreePlaces=15,
                            NumberParticipants=0
                        },
                        new Race()
                        {
                            Id=3,
                            Name="Circuit Toad",
                            EventDate= new DateTime(2022, 05, 09, 21, 30, 00),
                            FreePlaces=12,
                            NumberParticipants=12
                        },
                        new Race()
                        {
                            Id=4,
                            Name="Route arc-en-ciel",
                            EventDate= new DateTime(2022, 05, 15, 08, 00, 00),
                            FreePlaces=8,
                            NumberParticipants=6
                        }
                    };

                dbContext.Races.AddRange(races);
                dbContext.SaveChanges();
            }

            var vehiculeCat = new List<VehiculeCat>();

            if(!dbContext.VehiculeCats.Any())
            {
                vehiculeCat = new List<VehiculeCat>()
                {
                    new VehiculeCat()
                    {
                        Id = 1,
                        Name = "Super Car",
                        Description = "Super Car"
                    },
                    new VehiculeCat()
                    {
                        Id = 2,
                        Name = "Italian Classic",
                        Description = "italian Classic"
                    },
                    new VehiculeCat()
                    {
                        Id = 3,
                        Name = "Muscle Car",
                        Description = "Muscle Car"
                    },
                    new VehiculeCat()
                    {
                        Id = 4,
                        Name = "American Legend",
                        Description = "American Legend"
                    },
                    new VehiculeCat()
                    {
                        Id = 5,
                        Name = "Hyper Car",
                        Description = "Hyper Car"
                    },
                    new VehiculeCat()
                    {
                        Id = 6,
                        Name = "Japan Race Car",
                        Description = "Japan Race Car"
                    },
                    new VehiculeCat()
                    {
                        Id = 7,
                        Name = "Sport Car",
                        Description = "Sport Car"
                    },
                    new VehiculeCat()
                    {
                        Id = 8,
                        Name = "German Classics",
                        Description = "German Classics"
                    },
                    new VehiculeCat()
                    {
                        Id = 9,
                        Name = "High Performance Sport Car",
                        Description = "High Performance Sport Car"
                    },
                };
                dbContext.VehiculeCats.AddRange(vehiculeCat);
                dbContext.SaveChanges();
            }

            var vehicule = new List<Vehicule>();

            if(!dbContext.Vehicules.Any())
            {
                vehicule = new List<Vehicule>()
                {
                    new Vehicule()
                    {
                        Id = 1,
                        DateBuild = 1987,
                        Brand = "Ferrari",
                        Model = "F40",
                        Power = 7,
                        Image = "https://cdn.motor1.com/images/mgl/wNZyG/s1/ferrari-f40-1989.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(vc => vc.Name == "Super Car" || vc.Name == "Italian Classic").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 2,
                        DateBuild = 2014,
                        Brand = "Lamborghini",
                        Model = "Huracan",
                        Power = 7,
                        Image = "https://photos.tf1.fr/940/531/lamborghini-huracan-2014-6f6fd9-0@1x.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(vc => vc.Name == "Super Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 3,
                        DateBuild = 1967,
                        Brand = "Ford",
                        Model = "Mustang",
                        Power = 3,
                        Image = "https://m.media-amazon.com/images/I/71Svaa+lUCL._AC_SL1500_.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "Muscle Car" || v.Name == "American Legend").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 4,
                        DateBuild = 2021,
                        Brand = "Dodge",
                        Model = "Charger R/T",
                        Power = 5,
                        Image = "https://medias.fcacanada.ca/jellies/renditions/2021/800x510/CC21_LDDR48_2DV_PX8_APA_XXX_XXX_XXX.db2cd1f86af2227ee2682a80156e63a7.png",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "Muscle Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 5,
                        DateBuild = 2018,
                        Brand = "Pagani",
                        Model = "Huayra R",
                        Power = 9,
                        Image = "https://www.turbo.fr/sites/default/files/2021-03/100%20Pagani%20Huayra%20R.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "Hyper Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 6,
                        DateBuild = 2019,
                        Brand = "Bugatti",
                        Model = "Chiron",
                        Power = 10,
                        Image = "https://sf2.auto-moto.com/wp-content/uploads/sites/9/2019/02/bugatti-chiron-sport-110-ans-bugatti-2019-6.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "Hyper Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 7,
                        DateBuild = 1995,
                        Brand = "Toyota",
                        Model = "Supra Yakuza Edition",
                        Power = 7,
                        Image = "https://www.topgear.com/sites/default/files/images/inline-galleries/2019/06/9e6b8faaf5605cadc73500c29fe96be8/dsc07551.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "Japan Race Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 8,
                        DateBuild = 2009,
                        Brand = "Honda",
                        Model = "S2000 Racing",
                        Power = 6,
                        Image = "https://images.hgmsites.net/hug/2009-honda-s2000-driving-on-a-racetrack_100177825_h.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "Japan Race Car" || v.Name == "Sport Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 9,
                        DateBuild = 1991,
                        Brand = "BMW",
                        Model = "E30",
                        Power = 6,
                        Image = "https://www.automobile-sportive.com/guide/bmw/325ise30/bmw-325is-e30.jpg",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "German Classics" || v.Name == "Sport Car").ToList()
                    },
                    new Vehicule()
                    {
                        Id = 10,
                        DateBuild = 2007,
                        Brand = "Porsche",
                        Model = "911 GT3",
                        Power = 7,
                        Image = "https://www.classicdriver.com/sites/default/files/styles/two_third_slider/public/cars_images/feed_387856/2007-porsche-911-gt3-rs",
                        Categories = (List<VehiculeCat>)vehiculeCat.Where(v => v.Name == "German Classics" || v.Name == "High Performance Sport Car").ToList()
                    },
                };
                dbContext.Vehicules.AddRange(vehicule);
                dbContext.SaveChanges();
            }
        }
    }
}