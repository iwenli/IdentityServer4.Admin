using IdentityServer4.Models;
using System.Collections.Generic;
using Client = Iwenli.IdentityServer4.Admin.Configuration.IdentityServer.Client;

namespace Iwenli.IdentityServer4.Admin.Configuration
{
    public class IdentityServerDataConfiguration
    {
        public List<Client> Clients { get; set; } = new List<Client>();
        public List<IdentityResource> IdentityResources { get; set; } = new List<IdentityResource>();
        public List<ApiResource> ApiResources { get; set; } = new List<ApiResource>();
    }
}






