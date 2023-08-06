using IndiGames.QuestSystem.Definitions;
using IndiGames.QuestSystem.Specifications;
using NSubstitute;
using NUnit.Framework;

[TestFixture]
public class QuestCreationTests
{
    [Test]
    public void NewQuest_WithQuestDefinitionHaveId_ShouldReturnCorrectId()
    {
        IQuestDefinition q = Substitute.For<IQuestDefinition>();
        q.Id.Returns("Quest1");
        IQuestSpecification quest = new Quest(q);
        Assert.That(quest.Id, Is.EqualTo("Quest1"));
    }

    [Test]
    public void NewQuest_WithScriptableObjectQuest_ShouldReturnCorrectId()
    {
        
    }
}