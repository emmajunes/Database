namespace Database
{

    internal partial class Program
    {
        static void Main(string[] args)
        {


            //var sql = new Sql("Hej");

            //var oracle = new Oracle("Hej");

            var command = new DbCommand(new Sql("goddag"), "Hej");
            var command2 = new DbCommand(new Oracle("hejsvejs"), "Hej");

            command.Execute();
            command2.Execute();


           
          

           

            
        }
    }
}