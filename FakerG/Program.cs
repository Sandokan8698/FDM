using Data.Abstract;
using System;
using Data;
using Data.Implementations;
using Domain.Entities;
using Faker;
using Faker.Generator;

namespace FakerG
{
    class Program
    {
        static void Main(string[] args)
        {
            var athleteFactory = new Faker<Athlete>();
            var athletes = athleteFactory.CreateMany(1000, v =>
            {
                v.Name = new NameGenerator().Get();
                v.FatherSurName = new NameGenerator().Get(1);
                v.MotherSurName = new NameGenerator().Get(1);
                v.Sexo = new IntegerGenerator().Get(1,2);
                v.BirthDate = GetDate(200, 2004);
                v.CI = new IntegerGenerator().Get(1000000000,2000000000);
                v.SportId = new IntegerGenerator().Get(1,6);
                v.Sport = null;
                v.HomeTown = new StringGenerator().Get(1,100);
                v.Representant = null;
                v.CelularPhone = new IntegerGenerator().Get(1000000000,1000000059).ToString();
                v.HomePhone = new IntegerGenerator().Get(1000000000, 1000000059).ToString();
                v.RepresentantId = null;

            });

            using (var uw = new UnitOfWork(new FDMContext()))
            {
                uw.AthleteRepository.AddRange(athletes);
                uw.Complete();
            }
        }

        static DateTime GetDate(int Begin, int End)
        {
            Random r = new Random();
            DateTime rDate = new DateTime(r.Next(Begin, End), r.Next(1, 12), r.Next(1, 28)).Date;
            return rDate;
        }
    }
}
