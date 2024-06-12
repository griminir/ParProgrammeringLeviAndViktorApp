namespace ParProgrammeringLeviAndViktor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ISellable> InventoryStock = new List<ISellable>
            {
                new ClothingItem("Girl T-shirt", 100, 2000, "large", "Pink"),
                new ClothingItem("Men's T-shirt", 4, 500, "large", "Green"),
                new ElectronicItem("iphone 5", 3, 500, "5 years", 42),
                new ElectronicItem("iphone 14", 200, 10000, "1 years", 32)
            };

            foreach (var item in InventoryStock)
            {
                item.DisplayItem();
                Console.WriteLine();
            }
        }
    }
}
