namespace BerkayÖZTEMEL_Final.DL
{
    internal class MySqlConnectionStringBuilder
    {
        public MySqlConnectionStringBuilder()
        {
        }

        public string Server { get; set; }
        public string Database { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public object ConnectionString { get; internal set; }
    }
}