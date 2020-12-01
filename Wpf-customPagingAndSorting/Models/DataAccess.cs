using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace Wpf_customPagingAndSorting.Models
{
    /// <summary>

    /// Class that simulates a DataAccess module.

    /// </summary>

    public static class DataAccess

    {

        /// <summary>

        /// A list of products. This should be replaced by a database.

        /// </summary>

        private static ObservableCollection<Product> products = new ObservableCollection<Product>

    {

        new Product(1, "Book"),

        new Product(2, "Desktop Computer"),

        new Product(3, "Notebook"),

        new Product(4, "Netbook"),

        new Product(5, "Business Software"),

        new Product(6, "Antivirus Software"),

        new Product(7, "Game Console"),

        new Product(8, "Handheld Game Console"),

        new Product(9, "Mobile Phone"),

        new Product(10, "Multimedia Software"),

        new Product(11, "PC Game")

    };



        /// <summary>

        /// Gets the products.

        /// </summary>

        /// <param name="start">Zero-based index that determines the start of the products to be returned.</param>

        /// <param name="itemCount">Number of products that is requested to be returned.</param>

        /// <param name="sortColumn">Name of column or member that is the basis for sorting.</param>

        /// <param name="ascending">Indicates the sort direction to be used.</param>

        /// <param name="totalItems">Total number of products.</param>

        /// <returns>List of products.</returns>

        public static ObservableCollection<Product> GetProducts(int start, int itemCount, string sortColumn, bool ascending, out int totalItems)

        {

            totalItems = products.Count;



            ObservableCollection<Product> sortedProducts = new ObservableCollection<Product>();



            // Sort the products. In reality, the items should be stored in a database and

            // use SQL statements for sorting and querying items.

            switch (sortColumn)

            {

                case ("Id"):

                    sortedProducts = new ObservableCollection<Product>

                    (

                        from p in products

                        orderby p.Id

                        select p

                    );

                    break;

                case ("Name"):

                    sortedProducts = new ObservableCollection<Product>

                    (

                        from p in products

                        orderby p.Name

                        select p

                    );

                    break;

            }



            sortedProducts = ascending ? sortedProducts : new ObservableCollection<Product>(sortedProducts.Reverse());



            ObservableCollection<Product> filteredProducts = new ObservableCollection<Product>();



            for (int i = start; i < start + itemCount && i < totalItems; i++)

            {

                filteredProducts.Add(sortedProducts[i]);

            }



            return filteredProducts;

        }

    }
}
