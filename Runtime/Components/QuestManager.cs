using IndiGames.QuestSystem.Definitions;
using IndiGames.QuestSystem.Specifications;
using UnityEngine;

namespace IndiGames.QuestSystem.Components
{
    [AddComponentMenu("Indi Games/Quest System/Quest Manager")]
    [DisallowMultipleComponent]
    public class QuestManager : MonoBehaviour
    {
        [SerializeField] private QuestDatabase _questDatabase;

        private Quest _activeQuest;

        private void Awake()
        {
            if (_questDatabase == null)
            {
                Debug.LogError("Quest Database is null");
            }

            InitializeQuests();
        }

        private void InitializeQuests() { }
    }
}