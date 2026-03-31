public class UserAuth // Fixed critical authentication bug
{
    public bool Login(string username, string password)
    {
        return username == "admin" && password == "1234";
    }
}