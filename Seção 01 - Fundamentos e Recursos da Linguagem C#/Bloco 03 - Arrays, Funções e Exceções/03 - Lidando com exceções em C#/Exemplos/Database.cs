using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Database
    {
        public void Open()
        {
            Console.WriteLine("Conexão com o banco de dados foi aberta.");
        }

        public void Close()
        {
            Console.WriteLine("Conexão com o banco de dados foi fechada.");
        }

        public string IsValid(int productId)
        {
            return productId.ToString();
        }

        public string GetProduct(int productId)
        {
            if (productId.ToString().Length < 8)
            {
                return "Produto não encontrado.";
            }
            else
            {
                return IsValid(productId);
            }
        }
    }
}