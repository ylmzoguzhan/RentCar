using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions
{
    public static class ClaimExtensions
    {
        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim("name", name));
        }

        public static void AddId(this ICollection<Claim> claims, int id)
        {
            claims.Add(new Claim("id", id.ToString()));
        }
        public static void AddRoles(this ICollection<Claim> claims, string[] roles)
        {
            roles.ToList().ForEach(role => claims.Add(new Claim("roles", role)));
        }
    }
}
