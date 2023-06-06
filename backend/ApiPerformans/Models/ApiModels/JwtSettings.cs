namespace ApiPerformans.Models.ApiModels
{
    public class JwtSettings
    {
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string? SecurityKey { get; set; }
    }
}