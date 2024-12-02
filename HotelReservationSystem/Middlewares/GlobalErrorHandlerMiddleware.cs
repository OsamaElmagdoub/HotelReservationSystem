﻿using HotelReservationSystem.Exceptions.Error;
using HotelReservationSystem.Exceptions;
using HotelReservationSystem.ViewModels.ResultViewModel;
using System.Net;
using System.Text.Json;

namespace HotelReservationSystem.Middlewares;

public class GlobalErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;
    private readonly IHostEnvironment _env;
    private readonly ILogger<GlobalErrorHandlerMiddleware> _logger;

    public GlobalErrorHandlerMiddleware(RequestDelegate next,
                                        IHostEnvironment env,
                                        ILogger<GlobalErrorHandlerMiddleware> logger)
    {
        _next = next;
        _logger = logger;
        _env = env;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next.Invoke(context);
        }
        catch (Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = "Error Occured -- InternalServerError";
            ErrorCode errorCode = ErrorCode.InternalserverError;

            if (ex is BusinessException businessException)
            {
                message = businessException.Message;
                errorCode = businessException.ErrorCode;
            }
            else
            {
                _logger.LogError(ex, $"Error happened : {ex.Message}");
                File.WriteAllText("E:\\Log.txt", $"Error happened: {ex.Message}\n,{ex.StackTrace!.ToString()}");
            }

            var result = ResultViewModel<bool>.Faliure(errorCode, message);

            var options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var JsonResponse = JsonSerializer.Serialize(result, options);
            await context.Response.WriteAsJsonAsync(JsonResponse);
        }
    }
}
