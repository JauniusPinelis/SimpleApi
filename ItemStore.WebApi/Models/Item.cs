namespace ItemStore.WebApi.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; } = 0;

        public bool Delete { get; set; } = false;
    }
}
