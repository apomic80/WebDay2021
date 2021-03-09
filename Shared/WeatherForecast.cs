using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace webday2021.Shared
{
    public class WeatherForecast
    {
        [DisplayFormat(DataFormatString="{0:dd-MM-yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name="Temp (C)")]
        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        [Display(Name="Temp (F)")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
