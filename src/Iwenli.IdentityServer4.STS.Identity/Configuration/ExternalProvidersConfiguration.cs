namespace Iwenli.IdentityServer4.STS.Identity.Configuration
{
    public class ExternalProvidersConfiguration
    {
        public bool UseGitHubProvider { get; set; }
        public string GitHubClientId { get; set; }
        public string GitHubClientSecret { get; set; }

        public string GiteeClientId { get; set; }
        public string GiteeClientSecret { get; set; }

        public string QQClientId { get; set; }
        public string QQClientSecret { get; set; }

        public string WeixinClientId { get; set; }
        public string WeixinClientSecret { get; set; }

        public string GoogleClientId { get; set; }
        public string GoogleClientSecret { get; set; }

        public string MicrosoftClientId { get; set; }
        public string MicrosoftClientSecret { get; set; }
    }
}






