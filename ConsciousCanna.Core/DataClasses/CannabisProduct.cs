using System.Reflection.Metadata.Ecma335;

namespace ConsciousCanna.Core.DataClasses;

public static class Species
{
    public static IEnumerable<string> Values => 
    [
        None,
        Indica,
        Sativa,
        Hybrid 
    ]; 

    public static readonly string None = "None";
    public static readonly string Indica = "Indica";
    public static readonly string Sativa = "Sativa";
    public static readonly string Hybrid = "Hybrid";
}

public static class Chemotype
{
    public static IEnumerable<string> Values =>
    [
        THC,
        THCCBD,
        CBD
    ];

    public static readonly string THC = "1 (THC)";
    public static readonly string THCCBD = "2 (THC + CBD)";
    public static readonly string CBD = "3 (CBD)";
}

public static class ProductType
{
    public static IEnumerable<string> Values =>
    [
        Flower,
        Cartridge,
        Concentrate,
        Edibles,
        Tincture,
        Topical
    ];

    public static readonly string None = "None";
    public static readonly string Flower = "Flower";
    public static readonly string Cartridge = "Cartridge";
    public static readonly string Concentrate = "Concentrate";
    public static readonly string Edibles = "Edible";
    public static readonly string Tincture = "Tincture";
    public static readonly string Topical = "Topical";
}

public class CannabisProduct
{
    public required string ProductName { get; set; }

    public string? ProductBrand { get; set; }

    public string? Grower { get; set; }

    public string? Strain { get; set; }

    public string? ProductSpecies { get; set; }

    public string? ProductChemotype { get; set; }

    public string? PurchaseLocation { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public DateTime? HarvestDate { get; set; }

    public double Cost { get; set; }

    public string? Notes { get; set; }

    public TestingData? TestingData { get; set; }
}