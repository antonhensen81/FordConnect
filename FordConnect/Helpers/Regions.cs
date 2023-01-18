namespace FordConnect.Helpers;

internal class Regions
{
    public enum Region
    {
        US,
        CA,
        EU,
        AU
    }

    private static readonly Dictionary<Region, string?> RegionAppIdentifier = new()
    {
        { Region.US, "71A3AD0A-CF46-4CCF-B473-FC7FE5BC4592" },
        { Region.CA, "71A3AD0A-CF46-4CCF-B473-FC7FE5BC4592" },
        { Region.EU, "1E8C7794-FF5F-49BC-9596-A1E0C86C5B19" },
        { Region.AU, "5C80A6BB-CF0D-4A30-BDBF-FC804B5C1A98" }
    };


    private static readonly Dictionary<Regions.Region, string> CountryCodes = new()
    {
        { Regions.Region.US, "USA" },
        { Regions.Region.CA, "CAN" },
        { Regions.Region.EU, "EUR" },
        { Regions.Region.AU, "AUS" }
    };

    public static string GetRegionCountryCode(Region region)
    {
        if (CountryCodes.TryGetValue(region, out var countryCode))
        {
            return countryCode!;
        }
        throw new Exception("Invalid region");
    }


    public static string GetRegionApplicationIdentifier(Region region)
    {
        if (RegionAppIdentifier.TryGetValue(region, out var clientId))
        {
            return clientId!;
        }
        throw new Exception("Invalid region");
    }
}