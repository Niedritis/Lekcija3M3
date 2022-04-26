using M3;

Product Prece = new Product();

Console.WriteLine("Lūdzu, ievadi produkta augstumu");
string ProductHeight = Console.ReadLine();

double Height = double.Parse(ProductHeight);


Console.WriteLine("Lūdzu, ievadi produkta platumu");
string ProductWidth = Console.ReadLine();

double Width = double.Parse(ProductWidth);


Console.WriteLine("Lūdzu, ievadi produkta svaru");
string ProductWeight = Console.ReadLine();

double Weight = double.Parse(ProductWeight);


Prece.Apraksts();






