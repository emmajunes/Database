namespace Database
{
    internal partial class Program
    {
        public class Oracle : DbConnection
        {
            public override bool isRunning { get; set; }

            public Oracle(string connectionString) : base(connectionString)
            {

            }

            

            public override void Close()
            {
                if (!isRunning)
                {
                    throw new InvalidOperationException("Oracle connection already closed");
                }
                isRunning = false;

                Console.WriteLine("Oracle closed");
            }

            public override void Open()
            {
                if (isRunning)
                {
                    throw new InvalidOperationException("Oracle connection already open");
                }
                isRunning= true;
                Console.WriteLine("Oracle open");
            }
        }
    }
}