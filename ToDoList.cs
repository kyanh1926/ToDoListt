using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class ToDoList
    {
        List<Task> tasks =  new List<Task>();
        public void insertTask(Task task)
        {
            tasks.Add(task);
        }

        public void displayTasks()
        {
            int i = 1;
            foreach (var task in tasks)
            {

                Console.Write(i+": ");
                Console.WriteLine(task.getDescription());
                i++;
            }
        }

        public Task UpdateTask(int i, string updateDescription)
        {
            tasks[i].setDescription(updateDescription);
            return tasks[i];    
        }

        public void RemoveTask(int i)
        {
            tasks.RemoveAt(i);  
        }
    }
}
