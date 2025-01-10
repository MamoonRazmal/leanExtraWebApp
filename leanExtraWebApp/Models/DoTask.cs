namespace leanExtraWebApp
{
    public class DoTask
    {
        public int taskId{  get; set; }
        required
     public  string? taskName{  get; set; }="";
     public  bool TaskFinished{  get; set; }  
     public string? CompletedAt{get;set;}
    }
}