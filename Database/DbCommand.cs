using System.Reflection.Metadata.Ecma335;

namespace Database
{

    internal partial class Program
    {
        public class DbCommand
        {
            public DbConnection dbConnection { get; set; }

            public string Instruction { get; set; } 
            public DbCommand(DbConnection dbConnection, string instruction)
            {
                if (dbConnection == null)
                {
                    throw new ArgumentNullException(nameof(dbConnection));
                }
                if (String.IsNullOrWhiteSpace(instruction))
                {
                    throw new ArgumentNullException(nameof(instruction));
                }
                this.dbConnection = dbConnection;
                this.Instruction = instruction;
            }

            public void Execute()
            {
                dbConnection.Open();

                Console.WriteLine("Instruction added to database: " + Instruction);

                dbConnection.Close();
            }


        }

    }
}