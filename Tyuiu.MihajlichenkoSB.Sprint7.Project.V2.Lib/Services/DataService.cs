using Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Services
{
    public class DataService
    {
        private List<Owner> owners = new List<Owner>();
        private List<Store> stores = new List<Store>();

        // Методы для работы с владельцами
        public void AddOwner(Owner owner)
        {
            owners.Add(owner);
        }

        public List<Owner> GetOwners()
        {
            return owners;
        }

        // Методы для магазинов
        public void AddStore(Store store)
        {
            stores.Add(store);
        }

        public List<Store> GetStores()
        {
            return stores;
        }

        // Статистика
        public int GetStoreCount()
        {
            return stores.Count;
        }

        public decimal GetTotalCapital()
        {
            return owners.Sum(o => o.Capital);
        }

        public int GetTotalStores()
        {
            return stores.Count;
        }

        public int GetTotalOwners()
        {
            return owners.Count;
        }

        // ВРЕМЕННО закомментируй или измени этот класс
        public class StoreStats
        {
            public int Count { get; set; }
            public decimal TotalRevenue { get; set; }
            public decimal AverageRevenue { get; set; }
            public decimal MaxRevenue { get; set; }
            public decimal MinRevenue { get; set; }
        }

        // ВРЕМЕННО закомментируй этот метод или сделай проще
        public StoreStats CalculateStoreStats()
        {
            return new StoreStats
            {
                Count = stores.Count,
                // Пока оставь нули, пока не добавишь MonthlyRevenue
                TotalRevenue = 0, // stores.Sum(s => s.MonthlyRevenue),
                AverageRevenue = 0, // stores.Average(s => s.MonthlyRevenue),
                MaxRevenue = 0, // stores.Max(s => s.MonthlyRevenue),
                MinRevenue = 0 // stores.Min(s => s.MonthlyRevenue)
            };
        }
    }
}