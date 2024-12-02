
namespace HotelReservationSystem.Data.Configurations;

public class ReservationConfig : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.Property(R => R.ReservationStatus)
              .HasConversion(

              dbStatus => dbStatus.ToString(),

              Status => (ReservationStatus)Enum.Parse(typeof(ReservationStatus), Status)

              );
    }
}
