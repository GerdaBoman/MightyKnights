using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Dynamic;

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
    public int BusSize { get; set; }    
    public int BikeSize { get; set; }

    string appSettingsPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appSettings.json");

    public void ReadFromJson()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile(appSettingsPath).Build();

        var section = config.GetSection(nameof(Config));
        var values = section.Get<Config>();

        CarPriceHour = values.CarPriceHour;
        McPriceHour = values.McPriceHour;
        ParkingSpotSize = values.ParkingSpotSize;
        ParkingLotSize = values.ParkingLotSize;
    }
    public void UpdateJson(string carPrice, string mcPrice, string parkingSize)
    {
        var json = File.ReadAllText(appSettingsPath);

        var jsonSettings = new JsonSerializerSettings();
        jsonSettings.Converters.Add(new ExpandoObjectConverter());
        jsonSettings.Converters.Add(new StringEnumConverter());

        dynamic config = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSettings);

        config.DebugEnabled = true;
        config.Config.CarPriceHour = carPrice;
        config.Config.McPriceHour = mcPrice;
        config.Config.ParkingLotSize = parkingSize;

        var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);
        File.WriteAllText(appSettingsPath, newJson);
    }

    
    //public static Config ReadSettingsFromJson(string filePath = "../../../Datafiles/Config.json")
    //    {
    //       string settingsJson = File.ReadAllText(filePath);
    //       Config config = JsonConvert.DeserializeObject<Config>(settingsJson);
        
    //    return config;
    //    }

}
