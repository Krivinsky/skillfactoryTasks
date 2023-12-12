namespace OnlineStore
{
    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        /* ... */
    }

    class PickPointDelivery : Delivery
    {
        /* ... */
    }

    class ShopDelivery : Delivery
    {
        /* ... */
    }

    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        static long serialNomber;
        
        public TDelivery Delivery;

        public int Number;

        public string Description;

        public Product<ProductCategory> product;

        public double weight;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }
    }

    class Product<T> where T : ProductCategory  //описания товара
    {
        public T productCategory;

        public double Price { get; set; }

        public string Name { get; set; }

        //изготовитель
    }

    class Сustomer  // покупатель
    {
        private string name;
        private string surename;
        private string adress;

        public Сustomer(string name,  string surename, string adress)
        {
            this.name = name;
            this.surename = surename;
            this.adress = adress;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}