namespace Tyuiu.MihajlichenkoSB.Sprint7.Project.V2.Lib.Models
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public decimal MonthlyRevenue { get; set; } = 0;  // Значение по умолчанию
        public int OwnerId { get; set; } = 0;  // ID владельца
    }
}