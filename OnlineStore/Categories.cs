using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore
{
    public abstract class ProductCategory
    {
        int ID { get; set; }

    }

    public class Clothing : ProductCategory
    {

    }

    public class Shoes : ProductCategory
    {

    }

    public class Accessories : ProductCategory
    {

    }
}
