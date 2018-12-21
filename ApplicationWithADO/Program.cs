using ADODataConnection;
using ClassesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithADO
{
    class Program
    {
        static void Main(string[] args)
        {            
            SqlConnection dbCon = ConnectionDB.DBConOpen();

            SqlCommand command = new SqlCommand("SELECT * FROM tblPRODUCT", dbCon);
            SqlDataReader reader = command.ExecuteReader();
            List<Products> products = new List<Products>();
            int position = 0;
            while(reader.Read())
            {
                Products product = new Products();
                
                product.Id = reader.GetGuid(0);
                product.ProductCode = reader.GetString(1);
                product.Status = reader.GetBoolean(2);
                product.Manufacturer = reader.GetString(3);
                product.FrenchDesc = reader.GetString(4);
                product.EnglishDesc = reader.GetString(5);
                product.ImageFileName = reader.GetString(6);
                if (!reader.IsDBNull(7))
                {
                    product.DocumentFileName = reader.GetString(7);
                }
                else
                {
                    product.DocumentFileName = "";
                }
                if (!reader.IsDBNull(8))
                {
                    product.InventoryQuantity = reader.GetInt32(8);
                }
                else
                {
                    product.InventoryQuantity = 0;
                }
                product.Price = reader.GetDouble(9);
                product.LastUpdateDate = reader.GetDateTime(10);
                product.PromotionFlag = reader.GetBoolean(11);
                product.Taxable = reader.GetBoolean(12);

                products.Add(product);

                position++;
            }

            foreach(IProducts product in products)
            {
                Console.WriteLine(product.Id);
            }
            
            Console.ReadKey();            
        }
    }
}
