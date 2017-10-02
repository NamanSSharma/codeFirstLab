using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstDev.Models.Juristiction
{
    public class City
    {
        public int CityId { get; set; }
        [Display(Name = "City")]
        public string CityName { get; set; }
        public int Population { get; set; }

        [Display(Name = "Province")]
        public string ProvinceCode { get; set; }
        public Province Province { get; set; }

    }
}