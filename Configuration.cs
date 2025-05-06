namespace Blog
{
    public static class Configuration
    {
        public static string JwtKey = "YVn7z7Q3EgjFl2jYxLBzUFK/3MPh3Ztu5Ds1YTib4x8=";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "password_api_hash";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }

        }
    }
}
