﻿using Core.Persistance.Repositories;

namespace Core.Security.Entities;

public class RefreshToken : Entity<int>
{
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public string CreatedByIp { get; set; }
    public DateTime? Revoked { get; set; } //iptal etmek. --> Refresh token bilgisi için iptal etmemiz açısından 
    public string? RevokedByIp { get; set; }
    public string? ReplacedByToken { get; set; }
    public string? ReasonRevoked { get; set; }

    public virtual User User { get; set; } = null!; //User nesnemizin refresh tokenları da olabilir.

    public RefreshToken()
    {
        Token = string.Empty;
        CreatedByIp = string.Empty;
    }
    public RefreshToken(int userId, string token, DateTime expires, string createdByIp)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
    }

    public RefreshToken(int id, int userId, string token, DateTime expires, string createdByIp) : base(id)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
    }
}