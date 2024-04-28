﻿using CarWorkshop.Domain.Inferfaces;
using CarWorkshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CarWorkshop.Infrastructure.Repositories
{
    public class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;
        public CarWorkshopRepository(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Commit()
            =>_dbContext.SaveChangesAsync();
        public async Task Create(Domain.Entities.CarWorkshop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Domain.Entities.CarWorkshop>> GetAll()
        => await _dbContext.CarWorkshops.ToListAsync();

        public async Task<Domain.Entities.CarWorkshop> GetByEncodedName(string encodedName)
            => await _dbContext.CarWorkshops.FirstAsync(c => c.EncodedName == encodedName);

        public async Task<Domain.Entities.CarWorkshop?> GetByName(string name)
            => await _dbContext.CarWorkshops
            .FirstOrDefaultAsync(cw => cw.Name.ToLower() == name.ToLower());
    }
}
