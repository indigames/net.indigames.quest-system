using IndiGames.QuestSystem.Definitions;

namespace IndiGames.QuestSystem.Specifications
{
    public class Quest
    {
        public QuestDefinition Definition { get; }
        public Task ActiveTask { get; }

        public Quest(QuestDefinition definition)
        {
            Definition = definition;
        }
    }
}