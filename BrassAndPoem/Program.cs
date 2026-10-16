
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "iPhone Duo",
        Price = 2500.0M,
        ProductTypeId = 4
    },
    new Product()
    {
        Name = "Pixel 11",
        Price = 2000.0M,
        ProductTypeId = 4
    },
    new Product()
    {
        Name = "Dell Latitude 7400",
        Price = 500.0M,
        ProductTypeId = 3
    },
    new Product()
    {
        Name = "Macbook Pro 2019",
        Price = 1000.0M,
        ProductTypeId = 3
    },
    new Product()
    {
        Name = "Hp Elitebook 840",
        Price = 500.0M,
        ProductTypeId = 3
    }
};



//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 
List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2
    },
    new ProductType()
    {
       Title = "Laptop",
       Id = 3
    },
    new ProductType()
    {
       Title = "Smartphone",
       Id = 4
    }
};

//put your greeting here
Console.WriteLine("Welcome to Brass and Poem!");



//implement your loop here
bool done = false;
string option = null;
while (!done)
{
    DisplayMenu();
    Console.WriteLine("Enter an Option: ");
    option = Console.ReadLine();
    if (option == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (option == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (option == "3")
    {
        AddProduct(products, productTypes);
    }
    else if (option == "4")
    {
        UpdateProduct(products, productTypes);
    }
    else if (option == "5")
    {
        Console.WriteLine("Goodbye!");
        done = true;
    }
    else
    {
        Console.WriteLine("Enter a valid option!");
    }


}
void DisplayMenu()
{
    //throw new NotImplementedException();
    Console.WriteLine($@"
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    //throw new NotImplementedException();
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productType = productTypes.FirstOrDefault(p => p.Id == product.ProductTypeId);
        Console.WriteLine($"{i + 1}. {product.Name} is a {productType.Title} that costs ${product.Price}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    //throw new NotImplementedException();
    Console.WriteLine("Choose the product to delete:");
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Enter Option:");
    string option = Console.ReadLine();
    if (int.TryParse(option, out int result) && result >= 1 && result <= products.Count)
    {
        products.Remove(products[result - 1]);
    }
    else
    {
        Console.WriteLine("Enter a valid option!");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    //throw new NotImplementedException();
    Product newProduct = new Product() {};
    Console.WriteLine("Enter the name of the new product:");
    string newProductName = Console.ReadLine();
    newProduct.Name = newProductName;
    Console.WriteLine("Enter the price of the new product:");
    
    if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
    {
        newProduct.Price = newPrice;
    }
    else
    {
        Console.WriteLine("Enter a valid price!");
    }

    Console.WriteLine("Choose the Product Type:");
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }

    Console.WriteLine("Enter Option:");
    string option = Console.ReadLine();
    if (int.TryParse(option, out int result) && result >= 1 && result <= productTypes.Count)
    {
        newProduct.ProductTypeId = result;
    }
    else
    {
        Console.WriteLine("Enter a valid option!");
    }

    products.Add(newProduct);
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Choose the product to Update:");
    DisplayAllProducts(products, productTypes);
    Console.WriteLine("Enter Option:");
    string option = Console.ReadLine();
    Product product = null;
    if (int.TryParse(option, out int result) && result >= 1 && result <= products.Count)
    {
        product = products[result - 1];
    }
    else
    {
        Console.WriteLine("Enter a valid option!");
    }
    Console.WriteLine("Update the name of the product:");
    string updatedProductName = Console.ReadLine();
    if (updatedProductName != "")
    {
        product.Name = updatedProductName;
    }
    //newProduct.Name = newProductName;
    Console.WriteLine("Update the price of the product:");
    string input = Console.ReadLine();
    if (input != "")
    {
        if (decimal.TryParse(input, out decimal newPrice))
        {
            product.Price = newPrice;
        }
        else
        {
            Console.WriteLine("Enter a valid price!");
        }
    }

    Console.WriteLine("Choose the Product Type:");
    for (int i = 0; i < productTypes.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {productTypes[i].Title}");
    }

    Console.WriteLine("Enter Option:");
    string index = Console.ReadLine();
    if (index != "")
    {
        if (int.TryParse(index, out int id) && id >= 1 && id <= productTypes.Count)
        {
            product.ProductTypeId = result;
        }
        else
        {
            Console.WriteLine("Enter a valid option!");
        }
    }
}

// don't move or change this!
public partial class Program { }