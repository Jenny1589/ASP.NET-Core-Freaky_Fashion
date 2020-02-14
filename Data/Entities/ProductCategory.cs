namespace FreakyFashion.Data.Entities
{
    public class ProductCategory
    {
        public int ProductId { get; protected set; }
        public Product Product { get; set; }

        public int CategoryId { get; protected set; }
        public Category Category { get; set; }

        public ProductCategory(int productId, int categoryId)
        {
            ProductId = productId;
            CategoryId = categoryId;
        }

        public ProductCategory(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
}
