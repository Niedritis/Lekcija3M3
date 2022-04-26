namespace M3
{
    public class Product
    {


        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Weight { get; private set; }
        public Product(double height)
        {
            Height = height;
        }
        public void Apraksts()
        {

            Console.WriteLine($"Preces augstums ir {Height}");


        }
        //public Product CreateNewProduct(double productHeight)
        //{
        //    Product myNewProduct = new Product(productHeight);
        //    return myNewProduct;
        //}




    }
}
