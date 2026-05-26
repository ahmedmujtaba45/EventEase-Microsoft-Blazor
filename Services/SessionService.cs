namespace EventEase.Services
{
    public class SessionService
    {
        public string? CurrentUser { get; private set; }
        public bool IsLoggedIn => !string.IsNullOrEmpty(CurrentUser);

        public void Login(string userName)
        {
            CurrentUser = userName;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
}
