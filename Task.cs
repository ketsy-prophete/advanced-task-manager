class Task
{
    private string? taskName;

    private Boolean taskComplete;

    private string? taskDuration;

    public Boolean isComplete()
    {
        return taskComplete;
    }

    public string? getTaskName()
    {
        return taskName;
    }

    public string? getDuration()
    {
        return taskDuration;
    }

    public void setComplete()
    {
        taskComplete = true;
    }

    public void setTaskName()
    {
        taskName = "";
    }

    public void setDuration()
    {
        taskDuration = "";
    }

    public Task(string? name, string? duration)
    {
        taskName = name;
        taskDuration = duration;
        taskComplete = false;
    }
}