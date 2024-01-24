using Microsoft.AspNetCore.Server.Kestrel.Transport.Quic;

namespace BlazorApp3.Common;

public class CountryData
{

    public CountryData()
    {
        Name = "";
        ISO = "";
    }
    
    public CountryData(string n, string iso)
    {
        Name = n;
        ISO = iso;
    }
    
    public string Name { get; set; }
    public string ISO { get; set; }
}

public class CountryService()
{
    public async Task<List<CountryData>> GetCountryDataAsync()
    {
        await Task.Delay(2);

        return new()
        {
            new("Canada", "CA"), new("United States", "USA"), new("Mexico", "MX")
        };
    }
}