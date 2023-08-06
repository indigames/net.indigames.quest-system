using IndiGames.QuestSystem.Definitions;

namespace IndiGames.QuestSystem.Specifications
{
    public class Quest : IQuestSpecification
    {
        private IQuestDefinition _definition;
        string IQuestSpecification.Id => _definition.Id;

        public Quest(IQuestDefinition definition)
        {
            _definition = definition;
        }
    }
}