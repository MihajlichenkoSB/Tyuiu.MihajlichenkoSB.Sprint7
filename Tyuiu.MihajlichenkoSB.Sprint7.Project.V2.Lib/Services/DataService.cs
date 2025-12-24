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
        private List<Supplier> suppliers = new List<Supplier>();

        // Методы для работы с владельцами
        public void AddOwner(Owner owner)
        {
            owners.Add(owner);
        }

        public List<Owner> GetOwners()
        {
            return owners;
        }

        public Owner GetOwnerById(int id)
        {
            return owners.FirstOrDefault(o => o.Id == id);
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

        public Store GetStoreById(int id)
        {
            return stores.FirstOrDefault(s => s.Id == id);
        }

        // Методы для поставщиков
        public void AddSupplier(Supplier supplier)
        {
            suppliers.Add(supplier);
        }

        public List<Supplier> GetSuppliers()
        {
            return suppliers;
        }

        public Supplier GetSupplierById(int id)
        {
            return suppliers.FirstOrDefault(s => s.Id == id);
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

        public int GetTotalSuppliers()
        {
            return suppliers.Count;
        }

        // Класс для статистики магазинов
        public class StoreStats
        {
            public int Count { get; set; }
            public decimal TotalRevenue { get; set; }
            public decimal AverageRevenue { get; set; }
            public decimal MaxRevenue { get; set; }
            public decimal MinRevenue { get; set; }
        }

        // Метод для расчета статистики магазинов
        public StoreStats CalculateStoreStats()
        {
            if (stores.Count == 0)
            {
                return new StoreStats
                {
                    Count = 0,
                    TotalRevenue = 0,
                    AverageRevenue = 0,
                    MaxRevenue = 0,
                    MinRevenue = 0
                };
            }

            return new StoreStats
            {
                Count = stores.Count,
                TotalRevenue = stores.Sum(s => s.MonthlyRevenue),
                AverageRevenue = stores.Average(s => s.MonthlyRevenue),
                MaxRevenue = stores.Max(s => s.MonthlyRevenue),
                MinRevenue = stores.Min(s => s.MonthlyRevenue)
            };
        }

        // Новые методы для поиска
        public List<Owner> SearchOwners(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return owners;

            return owners.Where(o =>
                o.FullName.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                o.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                o.Phone.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<Store> SearchStores(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return stores;

            return stores.Where(s =>
                s.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                s.Address.Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                s.Phone.Contains(searchText, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Методы для удаления
        public bool RemoveStore(int id)
        {
            var store = stores.FirstOrDefault(s => s.Id == id);
            if (store != null)
            {
                stores.Remove(store);
                return true;
            }
            return false;
        }

        public bool RemoveOwner(int id)
        {
            var owner = owners.FirstOrDefault(o => o.Id == id);
            if (owner != null)
            {
                owners.Remove(owner);
                return true;
            }
            return false;
        }

        public bool RemoveSupplier(int id)
        {
            var supplier = suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier != null)
            {
                suppliers.Remove(supplier);
                return true;
            }
            return false;
        }
    }
}