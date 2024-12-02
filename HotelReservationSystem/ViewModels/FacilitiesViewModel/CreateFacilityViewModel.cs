namespace HotelReservationSystem.ViewModels.FacilitiesViewModel;

public class CreateFacilityViewModel
{
    public string Name { get; set; } = string.Empty;
    public double price { get; set; }
    public List<int> FacilitiesIds { get; set; }
}
public class UpdateFacilityViewModel
{
    public List<int> FacilitiesIds { get; set; }
}
