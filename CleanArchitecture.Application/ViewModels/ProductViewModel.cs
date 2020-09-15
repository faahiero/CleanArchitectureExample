namespace CleanArchitecture.Application.ViewModels
{
    public class ProductViewModel
    {
        public ProductViewModel(decimal price, string title)
        {
            Price = price;
            Title = title;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}