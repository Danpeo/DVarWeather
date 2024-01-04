namespace Danilvar.Calculator.Models;

public class Current
{
    public float Temp_C { get; set; }
    public float Temp_F { get; set; }
    public int Is_Day { get; set; }
    public string Last_Updated { get; set; }
    public WeatherCondition Condition { get; set; }
    public float Wind_Mph { get; set; }
    public float Wind_Kph { get; set; }
    public float Wind_Degree { get; set; }
    public string Wind_Dir { get; set; }
    public float Humidity { get; set; }
    public float Cloud { get; set; }
    public float Feelslike_C { get; set; }
    public float Feelslike_F { get; set; }
}