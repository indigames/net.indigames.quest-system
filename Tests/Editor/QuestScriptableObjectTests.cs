using IndiGames.QuestSystem.Definitions;
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class QuestScriptableObjectTests
{
    private QuestScriptableObject _questSO;

    [SetUp]
    public void SetUp()
    {
        _questSO = ScriptableObject.CreateInstance<QuestScriptableObject>();
    }

    [TearDown]
    public void TearDown()
    {
        Object.DestroyImmediate(_questSO);
    }

    [Test]
    public void NewQuestScriptableObject_DefinitionShouldBeCreated()
    {
        Assert.IsNotNull(_questSO.Definition);
    }

    [Test]
    public void NewQuestScriptableObject_CompletedShouldBeFalseByDefault()
    {
        Assert.IsFalse(_questSO.Completed);
    }

    [Test]
    public void Completed_Changed_StatusChangedEventShouldRaised()
    {
        var raised = false;
        _questSO.StatusChanged += _ => raised = true;
        _questSO.Completed = true;

        Assert.IsTrue(raised);
    }
}