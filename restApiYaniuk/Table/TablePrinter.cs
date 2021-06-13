using System;
using System.Collections.Generic;

namespace restApiYaniuk
{
   public class TablePrinter
    {
        public void Print(OverallData responseDeserialize)
        {
            string prod = "Product name";
            string cat = "Category name";
            int catId;
            var table = new Table();

            table.SetHeaders(prod, cat);

            Dictionary<int, string> categoryData = new Dictionary<int, string>();

            foreach (var categoryItem in responseDeserialize.Categories)
            {
                categoryData.Add(categoryItem.Id, categoryItem.Name);
            }
            
           foreach (var productItem in responseDeserialize.Products)
            {
                prod = productItem.Name;
                catId = productItem.CategoryId;
                cat = categoryData[catId];
                table.AddRow(prod, cat);
            }
            Console.WriteLine(table);

            Console.WriteLine();
            Console.WriteLine("Table complete!");
            Console.WriteLine();
            Console.Write("Press any button to continue: ");
            Console.ReadKey();
            Console.WriteLine();
        }            
    }      
}

