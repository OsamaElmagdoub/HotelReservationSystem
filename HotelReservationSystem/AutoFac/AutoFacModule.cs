
using Autofac;
using HotelReservationSystem.Mediators.ReservationMediator;
using HotelReservationSystem.Services.ReservationService;
using Module = Autofac.Module;

namespace HotelReservationSystem.AutoFac;
public class AutoFacModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

        builder.RegisterAssemblyTypes(typeof(IRoomRepository).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
       
        builder.RegisterAssemblyTypes(typeof(IRoomMediator).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(typeof(IFacilityMediator).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
		builder.RegisterAssemblyTypes(typeof(IReservationMediator).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
      
        builder.RegisterAssemblyTypes(typeof(IRoomService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(typeof(IFacilitiesService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
        builder.RegisterAssemblyTypes(typeof(IReservationService).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();

	}
}
