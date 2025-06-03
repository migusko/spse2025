namespace WeatherApp;

using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void buttonFetch_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(textBoxLat.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double lat) ||
            !double.TryParse(textBoxLon.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double lon))
        {
            textBoxResult.Text = "Please enter valid numbers for latitude and longitude (use dot as decimal separator).";
            return;
        }
        textBoxResult.Text = "Fetching weather data...";
        _ = FetchWeatherAsync(lat, lon);
    }

    private async Task FetchWeatherAsync(double lat, double lon)
    {
        string url = $"https://api.met.no/weatherapi/locationforecast/2.0/compact?lat={lat}&lon={lon}";
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "WeatherApp/1.0 martin@example.com");
        try
        {
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            textBoxResult.Text = ParseWeather(json);
        }
        catch (Exception ex)
        {
            textBoxResult.Text = $"Error: {ex.Message}";
        }
    }

    private string ParseWeather(string json)
    {
        try
        {
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;
            var timeseries = root.GetProperty("properties").GetProperty("timeseries");
            if (timeseries.GetArrayLength() > 0)
            {
                var first = timeseries[0];
                var time = first.GetProperty("time").GetString();
                var details = first.GetProperty("data").GetProperty("instant").GetProperty("details");
                double temp = details.GetProperty("air_temperature").GetDouble();
                double wind = details.GetProperty("wind_speed").GetDouble();
                double humidity = details.GetProperty("relative_humidity").GetDouble();
                return $"Time: {time}\r\nTemperature: {temp} °C\r\nWind: {wind} m/s\r\nHumidity: {humidity} %";
            }
            return "No weather data found.";
        }
        catch
        {
            return "Failed to parse weather data.";
        }
    }
}
