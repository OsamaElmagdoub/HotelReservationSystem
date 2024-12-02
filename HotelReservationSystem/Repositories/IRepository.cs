using HotelReservationSystem.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq.Expressions;

namespace HotelReservationSystem.Repositories;

public interface IRepository<T> where T : BaseModel
{
    IQueryable<T> GetAll();
    T GetByID(int id);
    T GetWithTrackinByID(int id);
    IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    T Add(T entity);
    T Update(T entity);
    void Delete(T entity);
    void Delete(int id);
    T First(Expression<Func<T, bool>> predicate);
    void SaveChanges();
}
