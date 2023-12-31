﻿namespace SipayApi.Data.Repository;
public interface IGenericRepository<Entity> where Entity : class
{
    void Save();
    Entity GetById(int id);
    void Insert (Entity entity);
    void Update (Entity entity);
    void Delete (Entity entity);
    void DeleteById(int id);
    List<Entity> GetAll();
    IEnumerable<Entity> Where(Expression<Func<Entity, bool>> expression);
    IQueryable<Entity> GetAllAsQueryable();


}

