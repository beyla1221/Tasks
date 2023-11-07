using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskProject.Models;
using TaskProject.Services;

namespace TaskProject.Controllers
{      
    [ApiController]
    [Route("api/[controller]")]
    public class TasksController : Controller

    {
        TasksService tasksService = new TasksService();
        [HttpGet("getAllTask")]
        public ActionResult getAllTask()
        {
            var res = tasksService.getAllTask();
            return Ok(res);
        }
        // POST: TasksController/Create
        [HttpPost("createTask")]
        public ActionResult createTask( MyTask task)
        {
            var res=tasksService.createTask(task);
            return Ok(res);
        }
        
        [HttpDelete("deleteTask")]
        public ActionResult deleteTask(string task)
        {
            var res = tasksService.deleteTask(task);
            return Ok(res);
        }

        [HttpPost("updateTask")]
        public ActionResult updateTask(MyTask task,string id)
        {
            var res = tasksService.updateTask(task,id);
            return Ok(res);
        }

        //// GET: TasksController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: TasksController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: TasksController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: TasksController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }

    }
}
