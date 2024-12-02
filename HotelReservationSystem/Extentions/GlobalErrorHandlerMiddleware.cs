namespace HotelReservationSystem.Extentions;

public static class CustomGlobalErrorHandlerMiddleware
{
    public static IApplicationBuilder GlobalErrorHandlerMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<GlobalErrorHandlerMiddleware>();
    }
}
