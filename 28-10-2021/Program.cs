using System;

namespace _28_10_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Assignment-2
            Product product1 = new Product
            {
                Name = "Sud",
                brandName = "Milla",
                price = 1.2
            };

            Product product2 = new Product
            {
                Name = "Cay",
                brandName = "Berqa",
                price = 8.6
            };

            Product product3 = new Product
            {
                Name = "Corek",
                brandName = "Nur",
                price = 3.5
            };

            Product product4 = new Product
            {
                Name = "Chaviar",
                brandName = "Gold",
                price = 15.9
            };

            Product[] productArray = { product1, product2, product3, product4 };
            Product[] checkedProduct = checkPrice(productArray, 1.1, 7.0);

            for (int i = 0; i < checkedProduct.Length; i++)
            {
                Console.WriteLine($"Name: {checkedProduct[i].Name}\nBrand name: {checkedProduct[i].brandName}\nPrice: {checkedProduct[i].price}\n******************************************");
            }
            #endregion

            #region Assignment-3
            //Car car1 = new Car();
            //car1.Name = "Car";
            //car1.Color = "Black";
            //car1.Brand = "Wolksvagen";
            //car1.Model = "Touareg";

            //Console.WriteLine($"Name: {car1.Name}\nColor: {car1.Color}\nBrand: {car1.Brand}\nModel:{car1.Model}\n*************************");
            #endregion
        }

        #region Assignment-2 Method

        static Product[] checkPrice(Product[] Product , double minPrice , double maxPrice)
        {
            int counter = 0;
          
            foreach (var product in Product)
            {
                if (product.price > minPrice && product.price < maxPrice)
                {
                    counter++;
                }
            }

            int k = 0;

            Product[] newProductArr = new Product[counter];

            foreach (var product in Product)
            {
                if (product.price > minPrice && product.price < maxPrice)
                {
                    newProductArr[k++] = product;
                }
            }
            
            return newProductArr;
        }

        #endregion
    }
}
