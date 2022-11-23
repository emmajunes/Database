namespace Database
{
    internal partial class Program
    {
        public class Sql : DbConnection
        {

            public override bool isRunning { get; set; }

            public Sql(string connectionString) : base(connectionString)
            {

            }

            
            public override void Close()
            {
                if (!isRunning)
                {
                    throw new InvalidOperationException("Sql connection already closed");
                }
                isRunning = false;

                Console.WriteLine("Sql closed");
            }

            public override void Open()
            {
                if (isRunning)
                {
                    throw new InvalidOperationException("Sql connection already open");
                }
                isRunning = true;

                Console.WriteLine("Sql open");
            }
        }
    }
}