using System.Collections.Generic;
using DoctorWho.Db.DataModels;

namespace DoctorWho.Db
{
    class SeedData
    {

        public List<Author> AuthorTableData()
        {
            return new List<Author> {
                  new Author {
                    AuthorId= 1,
                    AuthorName="Ahmad"
                },
                new Author {
                    AuthorId= 2,
                    AuthorName="Osama"
                },
                new Author {
                    AuthorId= 3,
                    AuthorName="Jamil"
                },
                new Author {
                    AuthorId= 4,
                    AuthorName="Tareq"
                },
                new Author {
                    AuthorId= 5,
                    AuthorName="Rami"
                }

            };
        }

        public List<Companion> CompanionTableData()
        {
            return new List<Companion> {
                  new Companion {
                      CompanionId=1,
                        CompanionName ="Thor"
                    },
                  new Companion {
                      CompanionId=2,
                        CompanionName ="Dr. Strange"
                    },
                  new Companion {
                      CompanionId=3,
                        CompanionName ="Captain"
                    },
                  new Companion {
                      CompanionId=4,
                        CompanionName ="Ironman"
                    },
                  new Companion {
                      CompanionId=5,
                        CompanionName ="Back Widow"
                    }
            };
        }
        public List<Enemy> EnemyTableData()
        {
            return new List<Enemy> {
                  new Enemy {
                       EnemyId=1,
                        EnemyName ="Thanos",
                        Description="Mind Control"
                    },
                  new Enemy {
                      EnemyId=2,
                        EnemyName ="Hela",
                        Description="Shapeshifting"
                    },
                  new Enemy {
                      EnemyId=3,
                        EnemyName ="Loki",
                        Description="Invisibility"
                    },
                  new Enemy {
                      EnemyId=4,
                        EnemyName ="Glactus",
                        Description="Immortality"
                    },
                  new Enemy {
                      EnemyId=5,
                        EnemyName ="DoomsDay",
                        Description="Time travel"
                    }
            };
        }

        public List<Doctor> DoctorTableData()
        {
            return new List<Doctor> {
                  new Doctor {
                      DoctorId=1,
                        DoctorNumber = 0599154866,
                        DoctorName ="Hazem",
                        BirthDate ="14/02/1999",
                        FirstEpisodeDate="05/12/2010",
                        LastEpisodeDate="06/02/2015"
                    },
                   new Doctor {
                        DoctorId=2,
                        DoctorNumber = 0598264767,
                        DoctorName ="Malak",
                        BirthDate ="29/07/1990",
                        FirstEpisodeDate="01/01/2015",
                        LastEpisodeDate="16/03/2017"
                    },
                    new Doctor {
                         DoctorId=3,
                        DoctorNumber = 0597965571,
                        DoctorName ="Rayyan",
                        BirthDate ="22/10/1998",
                        FirstEpisodeDate="09/02/2013",
                        LastEpisodeDate="06/06/2018"
                    },
                     new Doctor {
                          DoctorId=4,
                        DoctorNumber = 0597050633,
                        DoctorName ="Lujain",
                        BirthDate ="26/06/2000",
                        FirstEpisodeDate="15/04/2017",
                        LastEpisodeDate="12/12/2020"
                    },
                      new Doctor {
                           DoctorId=5,
                        DoctorNumber = 0599856299,
                        DoctorName ="Fatima",
                        BirthDate ="25/09/1977",
                        FirstEpisodeDate="15/12/2013",
                        LastEpisodeDate="11/03/2015"
                    }
            };
        }

        public List<Episode> EpisodeTableData()
        {
            return new List<Episode> {
                  new Episode {
                      EpisodeId=1,
                        SeriesNumber = 5,
                        EpisodeNumber = 1,
                        EpisodeType ="Horror",
                        Title="",
                        EpisodeDate="06/02/2015",
                        DoctorId=1,
                        AuthorId =1
                    },
                   new Episode {
                        EpisodeId=2,
                        SeriesNumber = 16,
                        EpisodeNumber = 100,
                        EpisodeType ="Drama",
                        Title="Legally Blonde",
                        EpisodeDate="25/04/2021",
                         DoctorId=3,
                        AuthorId =4
                    },
                    new Episode {
                         EpisodeId=3,
                        SeriesNumber = 5,
                        EpisodeNumber = 1,
                        EpisodeType ="Sci-Fi",
                        Title="Star Wars",
                        EpisodeDate="08/03/2019",
                         DoctorId=2,
                        AuthorId =4
                    },
                     new Episode {
                          EpisodeId=4,
                        SeriesNumber = 6,
                        EpisodeNumber = 22,
                        EpisodeType ="Thriller",
                        Title="Fast and Furious",
                        EpisodeDate="22/10/2018",
                         DoctorId=5,
                        AuthorId =1
                    },
                      new Episode {
                           EpisodeId=5,
                        SeriesNumber = 3,
                        EpisodeNumber = 2,
                        EpisodeType ="Comedy",
                        Title="Dumb and Dumber",
                        EpisodeDate="16/12/2015",
                         DoctorId=2,
                        AuthorId =3
                    },
            };
        }

        public List<EpisodeCompanion> EpisodeCompanionTableData()
        {
            return new List<EpisodeCompanion> {
                  new EpisodeCompanion {
                      EpisodeId=1,
                      CompanionId=2
                  },
                   new EpisodeCompanion {
                      EpisodeId=3,
                      CompanionId=5
                  },
                    new EpisodeCompanion {
                      EpisodeId=2,
                      CompanionId=2
                  },
                     new EpisodeCompanion {
                      EpisodeId=4,
                      CompanionId=1
                  },
                      new EpisodeCompanion {
                      EpisodeId=5,
                      CompanionId=4
                  }
            };
        }
        public List<EpisodeEnemy> EpisodeEnemyTableData()
        {
            return new List<EpisodeEnemy> {
                  new EpisodeEnemy {
                      EpisodeId=4,
                      EnemyId=3
                  },
                  new EpisodeEnemy {
                      EpisodeId=4,
                      EnemyId=5
                  },
                  new EpisodeEnemy {
                      EpisodeId=4,
                      EnemyId=1
                  },
                  new EpisodeEnemy {
                      EpisodeId=2,
                      EnemyId=5
                  },
                  new EpisodeEnemy {
                      EpisodeId=1,
                      EnemyId=1
                  },
            };
        }
    }
}
