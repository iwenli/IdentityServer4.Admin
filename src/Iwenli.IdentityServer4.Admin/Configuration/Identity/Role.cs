using System.Collections.Generic;

namespace Iwenli.IdentityServer4.Admin.Configuration.Identity
{
    public class Role
    {
        public string Name { get; set; }
        public List<Claim> Claims { get; set; } = new List<Claim>();
    }
}






