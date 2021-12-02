namespace Course2
{
    public class SendEmail : Workflow
    {
        public override void Execute()
        {
            Console.WriteLine("Sending Email");
            Thread.Sleep(2000);
            Console.WriteLine("Email Sent");
        }
    }

}