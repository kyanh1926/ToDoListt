namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList list1 = new ToDoList();
            Task task1 = new Task("Go to school");
            Task task2 = new Task("Sleep");
            list1.insertTask(task1);
            list1.insertTask(task2);
            list1.displayTasks();
        }
    }
}
