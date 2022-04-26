namespace M3
{
    public class Product
    {


        public double Height { get; private set; }
        public double Width { get; private set; }
        public double Weight { get; private set; }


        public void Apraksts()
        {

            Console.WriteLine($"Preces augstums ir {Height}, Preces platums ir {Width}, Preces svars ir {Weight}");

       
        }
        //public Product CreateNewProduct(double productHeight)
        //{
        //    Product myNewProduct = new Product(productHeight);
        //    return myNewProduct;
        //}




    }
}
