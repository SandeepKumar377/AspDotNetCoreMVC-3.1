namespace BookLibrary.Service
{
    public interface IUserService
    {
        string GetUserId();
        bool IsAuthencated();
    }
}