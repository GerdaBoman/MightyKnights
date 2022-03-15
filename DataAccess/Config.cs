using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

/// <summary>
/// Summary description for Config
/// </summary>
public class Config
{
    public int CarSize { get; set; }
    public int McSize { get; set; }
    public int CarPriceHour { get; set; }
    public int McPriceHour { get; set; }
    public int ParkingSpotSize { get; set; }
    public int ParkingLotSize { get; set; }

    public void ReadFromJson()
    {
        var appSettingsPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appSettings.json");

        var config = new ConfigurationBuilder()
            .AddJsonFile(appSettingsPath).Build();

        var section = config.GetSection(nameof(Config));
        var values = section.Get<Config>();

        CarPriceHour = values.CarPriceHour;
        McPriceHour = values.McPriceHour;
        ParkingSpotSize = values.ParkingSpotSize;
        ParkingLotSize = values.ParkingLotSize;

        //var json = File.ReadAllText(appSettingsPath);

        //var jsonString = JObject.Parse(json);
        ////var values = jsonString["Values"].ToString();

        //Config value = new Config
        //{
        //    CarPriceHour = (int)jsonString["Values"]["CarPriceHour"],
        //    McPriceHour = (int)jsonString["Values"]["McPriceHour"],
        //    ParkingLotSize = (int)jsonString["Values"]["ParkingLotSize"]
        //};
    }
    //public static Config ReadSettingsFromJson(string filePath = "../../../Datafiles/Config.json")
    //    {
    //       string settingsJson = File.ReadAllText(filePath);
    //       Config config = JsonConvert.DeserializeObject<Config>(settingsJson);
        
    //    return config;
    //    }

}
