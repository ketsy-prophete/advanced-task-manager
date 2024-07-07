List<Task> tasklist = new List<Task>();

bool continueProgram = true;
while (continueProgram)
{
    Console.WriteLine("\n");

    displayOptions();

    Console.Write("_________________\nEnter your choice: ");
    string choice = Console.ReadLine() ?? "";

    switch (choice)
    {
        case "1":
            Console.Write("\"Create a Task\" has been selected.\n");
            Console.WriteLine(createTask());
            break;
        case "2":
            Console.Write("\"View All Tasks\" has been selected. Here is your list of tasks: \n");
            Console.WriteLine("\n");
            Console.WriteLine(displayTask());
            break;
        case "3":
            Console.Write("\"Complete a Task\" has been selected. \n");
            Console.WriteLine(completeTask());
            break;
        case "4":
            Console.Write("Goodbye!");
            continueProgram = false;
            break;
    }
}


void displayOptions()
{
    string list = "1. Create a Task\n2. View All Tasks\n3. Complete a Task\n4. Quit";
    Console.WriteLine(list);
}

string createTask()
{
    Console.Write("What is the name of the task to create? ");
    string taskName = Console.ReadLine() ?? "";

    Console.Write("How long will the task take to complete? ");
    string taskDuration = Console.ReadLine() ?? "";

    Task newTask = new Task(taskName, taskDuration);
    tasklist.Add(newTask);

    Console.WriteLine("\n");
    string message = $"\"{taskName}\" has been added!";
    return message;
}


string displayTask()
{
    string result = "";

    foreach (Task task in tasklist)
    {
        result += $"{task.getTaskName()}, {task.getDuration()}\n";
    }
    return result;
}

string completeTask()
{
    Console.Write("Which task have you completed? ");
    string completedTask = Console.ReadLine() ?? "";
    return $"\"{completedTask}\" is now complete!";
}
