namespace TracknBill_Backend
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 31 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}
