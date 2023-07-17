using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "IndiGames/Quest System/Quest")]
    public class QuestDefinition : ScriptableObject
    {
        public string Title;
        public string Description;
        public bool Completed;

        public bool HasCompleted => _tasks.Length == 0 || Array.TrueForAll(_tasks, task => task.Completed);

        [SerializeField] private int _id;
        [SerializeField] private TaskDefinition[] _tasks = Array.Empty<TaskDefinition>();
    }
}