namespace BookStore.WebApp.Models
{
    public class AuthorViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly BirthDate { get; set; }
        public string CityName { get; set; }
        public bool IsActive { get; set; }
    }
}
