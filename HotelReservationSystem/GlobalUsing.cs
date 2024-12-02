//global

global using System.Diagnostics;
global using System.Data;
global using static System.Net.Mime.MediaTypeNames;
global using System.Collections.Generic;

global using Microsoft.AspNetCore.Cors.Infrastructure;
global using Microsoft.AspNetCore.Http;
global using Microsoft.AspNetCore.Mvc;

global using Microsoft.EntityFrameworkCore.Metadata.Internal;
global using Microsoft.EntityFrameworkCore.Metadata.Builders;
global using Microsoft.EntityFrameworkCore;

global using AutoMapper;
global using AutoMapper.QueryableExtensions;

global using HotelReservationSystem.Middlewares;

global using HotelReservationSystem.Models;
global using HotelReservationSystem.Data;
global using HotelReservationSystem.Repositories;
global using HotelReservationSystem.Helpers;

global using HotelReservationSystem.Services.RoomService;
global using HotelReservationSystem.Services.FacilitiesServices;

global using HotelReservationSystem.DTO.Room;
global using HotelReservationSystem.DTO.Facility;
global using HotelReservationSystem.DTO.RoomFacility;

global using HotelReservationSystem.Mediators.RoomMediator;
global using HotelReservationSystem.Mediators.FacilityMediator;

global using HotelReservationSystem.ViewModels.Room;
global using HotelReservationSystem.ViewModels.FacilitiesViewModel;

global using HotelReservationSystem.Services.RoomFacilityService;
global using HotelReservationSystem.Services.RoomImages;


