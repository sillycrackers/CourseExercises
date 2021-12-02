namespace Course2
{
    public class CallWebService : Workflow
    {
        public override void Execute()
        {
            Console.WriteLine("Calling Webservice");
            Thread.Sleep(2000);
            Console.WriteLine("Webservice connected");
        }
    }



}