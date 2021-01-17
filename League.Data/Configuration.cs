namespace League.Data
{
    internal static class Configuration
    {
        internal static string SqlServerConnectionString
            => "Server=.;Database=League;Integrated Security=True;";

        internal static string MySQLConnectionString
            => "server=localhost;user=root;password=pass;database=league";
    }
}
