namespace BerkayÖZTEMEL_Final.DL
{
    internal class MySqlCommand
    {
        private string v;
        private MySqlConnection conn;

        public MySqlCommand(string v, MySqlConnection conn)
        {
            this.v = v;
            this.conn = conn;
        }

        public object Parameters { get; internal set; }
    }
}