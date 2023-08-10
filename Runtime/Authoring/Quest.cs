using System;
using System.Collections.Generic;
using UnityEngine;

namespace IndiGames.QuestSystem.Authoring
{
    [Serializable]
    [CreateAssetMenu(fileName = "Quest", menuName = "IndiGames/Quest System/Quest")]
    public class Quest : ScriptableObject
    {
        [SerializeField] private string _id;

        /// <summary>
        /// Only check objectives if this is false..
        /// </summary>
        public bool Completed;

        [Header("Details")]
        public int CurrentObjectiveIndex;

        public List<ObjectiveContainer> Objectives = new();

        private void OnEnable()
        {
            StatusChanged += OnStatusChanged;
        }

        private void OnDisable()
        {
            StatusChanged -= OnStatusChanged;
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

        [Serializable]
        public class ObjectiveContainer
        {
            public bool Completed;
            public Objective Objective;
        }

        public bool HasObjectiveCompleted(Objective objective)
        {
            return false;
        }

        public bool CanCompleteObjective(Objective objective)
        {
            for (var index = 0; index < Objectives.Count; index++)
            {
                var configObjective = Objectives[index];
                if (configObjective.Objective.CompareTo(objective) != 0) continue;

                if (index <= 0) continue;

                var previousObjective = Objectives[index - 1];
                if (!previousObjective.Completed)
                {
                    return false;
                }
            }

            return true;
        }

        public void CompleteObjective(Objective objective)
        {
            for (var index = 0; index < Objectives.Count; index++)
            {
                var configObjective = Objectives[index];
                if (configObjective.Objective.CompareTo(objective) != 0) continue;
                configObjective.Completed = true;

                if (index == Objectives.Count - 1)
                {
                    Completed = true;
                }

                break;
            }
        }
    }
}