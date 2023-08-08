using IndiGames.QuestSystem.Definitions;
using IndiGames.QuestSystem.Specifications;
using UnityEngine;
using UnityEngine.Assertions;

namespace IndiGames.QuestSystem.Components
{
    [AddComponentMenu("Indi Games/Quest System/Quest Manager")]
    [DisallowMultipleComponent]
    public class QuestManager : MonoBehaviour
    {
        [SerializeField] private QuestDatabase _database;
        [SerializeField] private QuestScriptableObject _startingQuest;

        [SerializeField] private Quest _currentActiveQuest;

        private void Awake()
        {
            InitQuests();
        }

        private void InitQuests()
        {
            Assert.IsNotNull(_database, "Quest database is null.");
            Assert.IsNotNull(_startingQuest, "Starting quest is null.");

            foreach (var quest in _database.Quests)
            {
                if (quest == _startingQuest)
                {
                    _currentActiveQuest = new Quest(quest);
                }
            }
        }
    }
}