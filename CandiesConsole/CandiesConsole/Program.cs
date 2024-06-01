using LAB3_THI;


namespace CandiesConsole
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("Введите количество типов привезенных товаров: ");
            int n = int.Parse(Console.ReadLine());
            double TheStoreCounter = 0;
            double totalPrice = 0;
            string[] Names = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите данные о названии товара, его цену за кг, вес и тип: ");
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                double weight = double.Parse(Console.ReadLine());
                string type = Console.ReadLine();
                if (type == "Sweet")
                {
                    SweetCandies ConctereCandiesSweet = new SweetCandies();
                    ConctereCandiesSweet.Name = name;
                    ConctereCandiesSweet.Price = price;
                    ConctereCandiesSweet.Weight = weight;
                    TheStoreCounter += ConctereCandiesSweet.Weight;
                    Names.Append(ConctereCandiesSweet.Name);
                }
                else
                {
                    SourCandies ConctereCandiesSour = new SourCandies();
                    ConctereCandiesSour.Name = name;
                    ConctereCandiesSour.Price = price;
                    ConctereCandiesSour.Weight = weight;
                    TheStoreCounter += ConctereCandiesSour.Weight;

                    Names.Append(ConctereCandiesSour.Name);
                }
            }
            Console.WriteLine("Общий вес: ");
            Console.WriteLine(TheStoreCounter);
        }
    }
}