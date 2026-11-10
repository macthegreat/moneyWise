public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public Users(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}