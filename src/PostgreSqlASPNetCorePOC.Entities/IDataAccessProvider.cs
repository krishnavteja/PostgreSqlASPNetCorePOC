using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSqlASPNetCorePOC.Entities
{
    public interface IDataAccessProvider
    {
        void AddProduct(Product dataEventRecord);

        void UpdateProduct(Guid id, Product product);

        void DeleteProduct(Guid id);

        Product GetProduct(Guid id);

        List<Product> GetProducts();

        List<Order> GetOrders(bool withChildren);

    }
}
