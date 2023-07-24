using IndiGames.QuestSystem.Definitions;
using IndiGames.QuestSystem.Specifications;
using NUnit.Framework;
using UnityEngine;

namespace IndiGamesEditor.QuestSystem.Tests
{
    [TestFixture]
    public class TaskTests
    {
        private TaskDefinition _taskDef;
        private Task _task;

        [SetUp]
        public void Setup()
        {
            _taskDef = ScriptableObject.CreateInstance<TaskDefinition>();
            _task = new Task(_taskDef);
        }

        [Test]
        public void Create()
        {
            Assert.AreEqual(_taskDef, _task.Definition);
        }

        [Test]
        public void IsCompleted_ShouldBeFalse()
        {
            Assert.IsFalse(_task.Definition.IsCompleted);
        }
        
        [Test]
        public void Complete_ShouldBeTrue()
        {
            _task.Complete();
            Assert.IsTrue(_task.Definition.IsCompleted);
        }
        
        [Test]
        public void IsCompleted_ShouldBeTrue()
        {
            _taskDef.IsCompleted = true;
            Assert.IsTrue(_task.IsCompleted);
        }
    }
}