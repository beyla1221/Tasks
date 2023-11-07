using System.Linq;
using TaskProject.Models;

namespace TaskProject.Services
{
    public interface ITasksService
    {
        public List<MyTask> getAllTask();
        public string createTask(MyTask t) ;
        public string updateTask(MyTask t,string titele);
        public string deleteTask(string t);
    }
    public class TasksService : ITasksService
    {
       static List<MyTask> tasks = new List<MyTask>();
        public string createTask(MyTask t)
        {
            tasks.Add(t);
            return t.titele;
        }
        public string deleteTask(string t)
        {
            MyTask task= tasks.FirstOrDefault(task => task.titele == t);
            
            tasks.Remove(task);
            
            return "daleted";

        }
        public string updateTask(MyTask t,string titele)
        {
            MyTask tt = tasks.FirstOrDefault(task => task.titele == titele);
            tt.titele = t.titele;
            tt.description = t.description;
            tt.targetDate = t.targetDate;
            tt.priority = t.priority;
            return "updated";


        }
        public List<MyTask> getAllTask()
        {
            return tasks;
        }

    }
}
