using HotelReservationSystem.Consts;
using Microsoft.AspNetCore.Identity;

namespace HotelReservationSystem.Data.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<ApplicationIdentityUserRole>
{
    public void Configure(EntityTypeBuilder<ApplicationIdentityUserRole> builder)
    {
        builder.HasData(new IdentityUserRole<string>
        {
            UserId = DefaultUsers.AdminId,
            RoleId = DefaultRoles.AdminRoleId
        });
    }
}