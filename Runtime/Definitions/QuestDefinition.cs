using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [Serializable]
    public class QuestDefinition : IQuestDefinition
    {
        [SerializeField] private bool _hasCompleted;

        public bool Completed
        {
            get => _hasCompleted;
            set
            {
                if (value == _hasCompleted) return;
                _hasCompleted = value;
                if (StatusChanged == null)
                {
                    Debug.LogWarning("Quest status changed, but no listeners were found.");
                    return;
                }

                StatusChanged(_hasCompleted);
            }
        }

        public event IQuestDefinition.StatusChangedEvent StatusChanged;
    }
}