using System;
using System.Data;

namespace BerkayÖZTEMEL_Final.DL
{
    internal class MySqlConnection
    {
        private object connectionString;

        public MySqlConnection(object connectionString)
        {
            this.connectionString = connectionString;
        }

        public ConnectionState State { get; internal set; }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}