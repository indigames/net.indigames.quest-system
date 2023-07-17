using IndiGames.QuestSystem.Definitions;
using UnityEngine;

namespace IndiGames.QuestSystem.Components
{
    [AddComponentMenu("IndiGames/Quest System/Quest Manager")]
    [DisallowMultipleComponent]
    public class QuestManager : MonoBehaviour
    {
        [SerializeField] private QuestDatabase _questDatabase;
        
        // [Header("Runtime")]
        // [SerializeField] private Quest _currentQuest;
        
        private void Awake()
        {
            if (_questDatabase == null)
            {
                Debug.LogError("Quest Database is null");
            }

            InitializeQuests();
        }

        private void InitializeQuests()
        {
        }
    }
}