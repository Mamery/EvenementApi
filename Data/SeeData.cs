using EvenementApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenementApi.Data
{
    public class SeeData
    {

        internal static async Task InitializeAsync(IServiceProvider services)
        {
            using var db = new EvenementApiContext(services.GetRequiredService<DbContextOptions<EvenementApiContext>>());

            if (!await db.EvenementDays.AnyAsync()) //så länge vi inte har något

            {
                await db.EvenementDays.AddAsync(new EvenementDay()
                {
                    Name = "NA21",
                    EvenementDate = new DateTime(2020, 12, 18),
                    Location = new Location()
                    {
                        Address = "Storgatan 12",
                        CityTown = "Stockholm",
                        StateProvince = "Stockholm",
                        PostalCode = "12345",
                        Country = "Sweden"
                    },
                    Length = 1,
                    //Lectures = new List<Lecture>()
                    Lectures = new Lecture[]
                        {
                            new Lecture
                            {
                              Title = "Entity Framework From Scratch",
                              Level = 100,
                              Speaker = new Speaker
                              {
                                FirstName = "Kalle",
                                LastName = "Anka",
                                BlogUrl = "http://KalleAnka.com",
                                Company = "´Disney",
                                CompanyUrl = "http://Disney.com",
                                GitHub = "KalleKodar"
                              }
                          },
                            new Lecture
                            {
                              Title = "Writing Sample Data Made Easy",
                              Level = 200,
                              Speaker = new Speaker
                              {
                                FirstName = "Knatte",
                                LastName = "Anka",
                                BlogUrl = "http://Knatte.com",
                                Company = "Slangbellan",
                                CompanyUrl = "http://Disney.com",
                                GitHub = "Knatte",
                              }
                            }
                           }
                }
            );
                await db.SaveChangesAsync();
            }
        }
    }
}
