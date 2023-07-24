using IndiGames.QuestSystem.Definitions;

namespace IndiGames.QuestSystem.Specifications
{
    public class Task
    {
        public TaskDefinition Definition { get; }
        public bool IsCompleted;

        public Task(TaskDefinition wakeUpTaskDef)
        {
            Definition = wakeUpTaskDef;
        }

        public void Complete()
        {
            Definition.IsCompleted = true;
        }
    }
}