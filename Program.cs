namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList list1 = new ToDoList();

            Task task1 = new Task("Go to school");
            Task task2 = new Task("Sleep");
            Task task3 = new Task();

            list1.insertTask(task1);
            list1.insertTask(task2);
            list1.insertTask(task3);    
            list1.displayTasks();
            Console.WriteLine("-----------------------");

            list1.UpdateTask(0, "Wake up");
            list1.displayTasks();
            Console.WriteLine("-----------------------");

            list1.RemoveTask(1);
            list1.displayTasks();
            Console.WriteLine("-----------------------");
        }
    }
}
