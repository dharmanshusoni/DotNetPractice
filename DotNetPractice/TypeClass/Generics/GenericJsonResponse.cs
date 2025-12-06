using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace DotNetPractice.TypeClass.Generics
{
    // 1. Data Model
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserEmail { get; set; }
    }

    // 2. Generic Wrapper Class
    // This class can hold ANY type of data (T)
    public class ServiceResponse<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; } = string.Empty;
        public T Data { get; set; } // The generic payload
    }
    internal class GenericJsonResponse
    {
        public static void RunExampleProduct()
        {
            // The JSON string received from a web service (e.g., an API)
            string jsonString = @"{
              ""Success"": true,
              ""Message"": ""Product fetched successfully."",
              ""Data"": {
                ""Id"": 101,
                ""Name"": ""Laptop"",
                ""Price"": 1200.50
              }
            }";

            // 3. Deserialization Step

            // We specify the EXACT generic type we want to deserialize into:
            // ServiceResponse<Product>
            try
            {
                var response = JsonSerializer.Deserialize<ServiceResponse<Product>>(jsonString);

                // 4. Accessing the Data
                if (response != null && response.Success)
                {
                    Console.WriteLine("Deserialization Successful!");
                    Console.WriteLine($"Response Message: {response.Message}");

                    // The 'Data' property is now strongly typed as 'Product'
                    Product product = response.Data;

                    Console.WriteLine($"--- Product Details ---");
                    Console.WriteLine($"ID: {product.Id}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Price: {product.Price:C}");
                }
                else
                {
                    Console.WriteLine($"Deserialization failed or request was unsuccessful: {response?.Message}");
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
            }
        }

        public static void RunExampleUser()
        {
            // The JSON string received from a web service (e.g., an API)
            string jsonString = @"{
              ""Success"": true,
              ""Message"": ""User fetched successfully."",
              ""Data"": {
                ""Id"": 101,
                ""Name"": ""Laptop"",
                ""UserEmail"": ""User@gmail.com""
              }
            }";

            // 3. Deserialization Step

            // We specify the EXACT generic type we want to deserialize into:
            // ServiceResponse<Product>
            try
            {
                var response = JsonSerializer.Deserialize<ServiceResponse<User>>(jsonString);

                // 4. Accessing the Data
                if (response != null && response.Success)
                {
                    Console.WriteLine("Deserialization Successful!");
                    Console.WriteLine($"Response Message: {response.Message}");

                    // The 'Data' property is now strongly typed as 'Product'
                    User product = response.Data;

                    Console.WriteLine($"--- Product Details ---");
                    Console.WriteLine($"ID: {product.Id}");
                    Console.WriteLine($"Name: {product.Name}");
                    Console.WriteLine($"Price: {product.UserEmail:C}");
                }
                else
                {
                    Console.WriteLine($"Deserialization failed or request was unsuccessful: {response?.Message}");
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error during deserialization: {ex.Message}");
            }
        }

        public static void Main(string[] args)
        {
            RunExampleProduct();
            RunExampleUser();
            Console.ReadKey();
        }
    }
}
