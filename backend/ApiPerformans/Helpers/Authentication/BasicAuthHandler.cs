using EntityLayer.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace ApiPerformans.Helper.Authentication
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly OraContext _context;

        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, OraContext context) : base(options, logger, encoder, clock)
        {
            _context = context;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("No Header Found");

            string authHeader = Request.Headers["Authorization"]!;
            if (authHeader == null || !authHeader.StartsWith("Basic "))
                return AuthenticateResult.Fail("Invalid Authorization Header");

            string[] credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader.Substring("Basic ".Length))).Split(':');
            string username = credentials[0];
            string password = credentials[1];

            //var user = await _context..FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
            //if (user == null)
            //    return AuthenticateResult.Fail("Invalid Username or Password");

            //var claims = new[]
            //{
            //    new Claim(ClaimTypes.Name, user.Username!),
            //    new Claim(ClaimTypes.Role, user.Role.ToString())
            //};
            //var identity = new ClaimsIdentity(claims, Scheme.Name);
            //var principal = new ClaimsPrincipal(identity);
            //var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return null;//AuthenticateResult.Success(ticket);
        }
    }
}