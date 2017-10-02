using CodeFirstDev.Models.Juristiction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstLab.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Province> getProvinces()
        {
            List<Province> Provinces = new List<Province>{
                new Province()
                {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                new Province()
                {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta"
                },
                new Province()
                {
                    ProvinceCode = "SK",
                    ProvinceName = "Saskatchwen"
                },
        };
            return Provinces;
        }

        public static System.Collections.Generic.List<City> getCities(Models.ApplicationDbContext context)
        {
            List<City> Cities = new List<City>{
                new City()
                {
                    CityName = "Surrey",
                    Population = 2000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC").ProvinceCode
                },
                new City()
                {
                    CityName = "Richmond",
                    Population = 1000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC").ProvinceCode
                },
                new City()
                {
                    CityName = "Port Moody",
                    Population = 500,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "BC").ProvinceCode
                },
                new City()
                {
                    CityName = "Calgary",
                    Population = 2000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB").ProvinceCode
                },
                new City()
                {
                    CityName = "Edmonton",
                    Population = 5000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB").ProvinceCode
                },
                new City()
                {
                    CityName = "Calgary",
                    Population = 500,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB").ProvinceCode
                },
                new City()
                {
                    CityName = "LethBridge",
                    Population = 2000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "AB").ProvinceCode
                },
                new City()
                {
                    CityName = "Saskatoon",
                    Population = 2000,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "SK").ProvinceCode
                },
                new City()
                {
                    CityName = "Prarie",
                    Population = 8,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "SK").ProvinceCode
                },
                new City()
                {
                    CityName = "Wheat",
                    Population = 4,
                    ProvinceCode = context.Provinces.FirstOrDefault(p => p.ProvinceCode == "SK").ProvinceCode
                },
        };
            return Cities;
        }
    }
}