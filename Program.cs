namespace LagerstyringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitializeStorage();
        }

        private static void InitializeStorage()
        {
            Storage myStorage = new Storage();

            Electronics Television = new Electronics("LG OLED 65 G9", 18000, 36);
            Electronics Gpu = new Electronics("NVIDIA RTX4090", 20000, 24);

            Clothes Cap = new Clothes("New Era NY", 350, "L");
            Clothes Shoes = new Clothes("Nike Shoes", 3300, "41");

            Foodstuff DinnerKit = new Foodstuff("Hotdog", 65, 14);
            Foodstuff Drink = new Foodstuff("Monster Energy Drink - Ultra White 0.5l", 23, 365);


            myStorage.AddProduct(Television);
            List<IProduct> list = new List<IProduct>
            { 
                Gpu, Cap, Shoes, DinnerKit, Drink
            };

            myStorage.AddProduct(list);
            //myStorage.RemoveProduct(Cap);
            myStorage.PrintProducts();
            Console.ReadKey();
        }
    }
}