using static System.Environment;

namespace TestApplication.Domain.Constants
{
    public static class EnvironmentConstants
    {
        public static string ConnectionString => GetEnvironmentVariable("TestAppConnectionString", EnvironmentVariableTarget.Machine) ?? string.Empty;
    }
}
