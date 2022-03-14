using Newtonsoft.Json;
using System;

/// <summary>
/// Summary description for Config
/// </summary>
public class Config
{
    

    [JsonProperty("CarSize")]
    public static int CarSize { get; set; }
    [JsonProperty("McSize")]
    public static int McSize { get; set; }
    [JsonProperty("CarPriceHour")]
    public static int CarPriceHour { get; set; }
    [JsonProperty("McPriceHour")]
    public static int McPriceHour { get; set; }
    [JsonProperty("ParkingSpotSize")]
    public static int ParkingSpotSize { get; set; }
    [JsonProperty("ParkingLotSize")]
    public static int ParkingLotSize { get; set; }


      public static Config ReadSettingsFromJson(string filePath = "../../../Datafiles/Config.json")
        {
           string settingsJson = File.ReadAllText(filePath);
           Config config = JsonConvert.DeserializeObject<Config>(settingsJson);
        
        return config;
        }

}
