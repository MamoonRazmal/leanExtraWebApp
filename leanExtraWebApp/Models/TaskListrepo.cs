using System.Data;
using System.Runtime.CompilerServices;

namespace leanExtraWebApp
{
 public class TaskListrepo
 {
    private static List<DoTask> TaskLists = new List<DoTask>()
    {
      new DoTask{taskId=1,taskName="Item1"},
      new DoTask{taskId=2,taskName="Item2"},
      new DoTask{taskId=3,taskName="Item3"}  
    };
    public static void addTask()
    {
        int maxId = TaskLists.Max(x=>x.taskId);
        DoTask newtask =new DoTask{taskId=maxId+1,taskName =$"Item{maxId}"};
        TaskLists.Add(newtask);
       // task.taskId=maxId+1;
       // TaskLists.Add(task);
    }
    public static List<DoTask> getAllTask()=>TaskLists.OrderBy(task => task.TaskFinished).ToList();
    public static void deleteTask(int id)
    {
    var Task = TaskLists.FirstOrDefault(s=>s.taskId ==id);
        if(Task is not null)
        {   TaskLists.Remove(Task);}
     
    }
    public static void EditTask(int id,string? name)
    {
        var task = TaskLists.FirstOrDefault((s)=>s.taskId ==id);
        if(task is not null)
        {
            task.taskName = name;
        }
    }
    public static void FinishTask(int id, bool finish,string finishat )
    {
        var task = TaskLists.FirstOrDefault(s=>s.taskId == id);
        if(task is not null)
        {
            task.TaskFinished = finish ;
            task.CompletedAt = finishat;
        }
    }

 }   
}