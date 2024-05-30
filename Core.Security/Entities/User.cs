using Core.Persistance.Repositories;
using Core.Security.Enums;

namespace Core.Security.Entities;

public class User : Entity<int>
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public byte[] PasswordSalt { get; set; }
    public byte[] PasswordHash { get; set; }
    public bool Status { get; set; }
    public AuthenticatorType AuthenticatorType { get; set; }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = null!;
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = null!;
    public virtual ICollection<OtpAuthenticator> OtpAuthenticators { get; set; } = null!;
    public virtual ICollection<EmailAuthenticator> EmailAuthenticators { get; set; } = null!;

    public User()
    {
        Firstname = string.Empty;
        Lastname = string.Empty;
        Email = string.Empty;
        PasswordHash = Array.Empty<byte>();
        PasswordSalt = Array.Empty<byte>();
    }

    public User(string firstname, string lastname, string email, byte[] passwordSalt, byte[] passwordHash, bool status)
    {
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
    }

    public User(int id, string firstname, string lastname, string email, byte[] passwordSalt, byte[] passwordHash, bool status) : base(id)
    {
        Firstname = firstname;
        Lastname = lastname;
        Email = email;
        PasswordSalt = passwordSalt;
        PasswordHash = passwordHash;
        Status = status;
    }
}
