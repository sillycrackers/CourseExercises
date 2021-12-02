namespace Course2
{
    public class UploadVideo : Workflow
    {
        public override void Execute()
        {
            Console.WriteLine("Uploading Video");
            Thread.Sleep(2000);
            Console.WriteLine("Upload complete");
        }
    }
}