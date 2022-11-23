namespace Database
{
    internal partial class Program
    {
        public abstract class DbConnection
        {
            public abstract bool isRunning { get; set; }
            public string ConnectionString { get; set; }
            public TimeSpan Timeout { get; set; }

            public DbConnection(string connectionString)
            {
                if (String.IsNullOrWhiteSpace(connectionString))
                {
                    throw new ArgumentNullException(nameof(connectionString));
                }

                this.ConnectionString = connectionString;
            }

            public abstract void Open();

            public abstract void Close();
           
        }
    }
}