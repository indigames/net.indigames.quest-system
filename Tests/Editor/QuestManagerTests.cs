using System;
using IndiGames.QuestSystem.Definitions;
using NSubstitute;
using NUnit.Framework;

[TestFixture]
public class QuestManagerTests
{
    [Test]
    public void Test()
    {
        var database = Substitute.For<IDatabase>();
        database.Quests.Returns(Array.Empty<IQuestDefinition>());

        var questManager = new QuestManager(database);
    }
}

public interface IDatabase
{
    public IQuestDefinition[] Quests { get; }
}

public class QuestManager
{
    private IDatabase _database;

    public QuestManager(IDatabase database)
    {
        _database = database;
    }
}