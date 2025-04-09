namespace FlatRentService.Data;

public class Flat
{
    public int Id { get; set; }
    public string Location { get; set; }
    public string BuildingName { get; set; }
    public string BuildingNumber { get; set; }
    public int Floor { get; set; }
    public int NumberOfBedRoom { get; set; }
    public int NumberOfBathRoom { get; set; }
    public int FlatSize { get; set; }
    public bool IsLiftAvailable { get; set; }
}