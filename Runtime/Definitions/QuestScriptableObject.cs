using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [Serializable]
    [CreateAssetMenu(fileName = "Quest", menuName = "IndiGames/Quest System/Quest")]
    public class QuestScriptableObject : ScriptableObject, IQuestDefinition
    {
        [SerializeField] private string _id;
        [SerializeField] private QuestDefinition _definition = new();
        public QuestDefinition Definition => _definition;

        public bool Completed
        {
            get => _definition.Completed;
            set => _definition.Completed = value;
        }


        private void OnEnable()
        {
            _definition.StatusChanged += OnStatusChanged;
        }

        private void OnDisable()
        {
            _definition.StatusChanged -= OnStatusChanged;
        }

        public event IQuestDefinition.StatusChangedEvent StatusChanged;

        private void OnStatusChanged(bool completed)
        {
            if (StatusChanged == null)
            {
                Debug.LogWarning("Quest status changed, but no listeners were found.");
                return;
            }

            StatusChanged(completed);
        }
    }
}