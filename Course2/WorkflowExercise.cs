namespace Course2
{
    public static class WorkflowExercise
    {
        public static void Run()
        {
            var workflowEngine = new WorkflowEngine();
            var sendEmail = new SendEmail();
            var updateVideoStatus = new UpdateVideoStatus();
            var uploadVideo = new UploadVideo();
            var callWebService = new CallWebService();

            List<Workflow> workflows = new List<Workflow>();

            workflows.Add(sendEmail);
            workflows.Add(updateVideoStatus);
            workflows.Add(uploadVideo);
            workflows.Add(callWebService);  

            foreach(Workflow workflow in workflows)
            {
                workflowEngine.Run(workflow);
            }
        }
    }
}