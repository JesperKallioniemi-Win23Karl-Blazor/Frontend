namespace Frontend.Data
{
    public class UserAdress
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string AddressLine_1 { get; set; } = null!;
        public string AddressLine_2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Zip { get; set; } = null!;
    }

}
