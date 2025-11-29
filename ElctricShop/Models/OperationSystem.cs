namespace ElctricShop.Models
{
    public class OperationSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }

        //Kapcsolat
        public ICollection<Computer> Computers { get; set; } = new List<Computer>();
    }
}
