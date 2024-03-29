﻿using UnitTestScenarios.Mvc.Entity;

namespace UnitTestScenarios.Mvc.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();

        Task<Product> GetAsync(int id);

        void Add(Product entity);

        void Update(Product entity);

        void Delete(Product entity);
    }
}
