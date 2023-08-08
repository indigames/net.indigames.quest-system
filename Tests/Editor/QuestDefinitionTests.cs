using IndiGames.QuestSystem.Definitions;
using NUnit.Framework;

[TestFixture]
public class QuestDefinitionTests
{
    [Test]
    public void QuestDefinition_NewInstance_HasCompletedShouldBeFalseByDefault()
    {
        IQuestDefinition definition = new QuestDefinition();

        Assert.IsFalse(definition.Completed);
    }

    [Test]
    public void Completed_Changed_StatusChangedEventShouldRaised()
    {
        IQuestDefinition definition = new QuestDefinition();

        var raised = false;
        definition.StatusChanged += _ => raised = true;
        definition.Completed = true;

        Assert.IsTrue(raised);
    }
}