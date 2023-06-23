namespace Sober.Application.Contracts
{
    public interface ICurrentUserService
    {
        Guid? UserId { get; }
    }
}
