﻿using AutoMapper;
using FuelPriceWizard.DataAccess.Entities;
using PriceModel = FuelPriceWizard.Domain.Models.PriceReading;

namespace FuelPriceWizard.DataAccess.Implementation
{
    public class PriceRepository : BaseRepository<PriceReading, PriceModel>, IPriceRepository
    {
        public PriceRepository(FuelPriceWizardDbContext context, Mapper mapper) : base(context, mapper)
        {
        }
    }
}