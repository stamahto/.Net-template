namespace PROJECT.Infrastructure.Providers.Interfaces
{
    public interface IUserProvider
    {
        /// <summary>
        /// Get username with employeeId in format: "username (userId)"
        /// </summary>
        string Get();
        string GetName();
        string GetId();
    }
}
