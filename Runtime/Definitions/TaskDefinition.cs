using UnityEngine;
using UnityEngine.Events;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "Indi Games/Quest System/Task")]
    public class TaskDefinition : ScriptableObject
    {
        /// <summary>
        /// Which actor that associated with this task
        /// </summary>
        public Actor TaskActor;

        [SerializeField] private bool _isCompleted;

        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                Completed?.Invoke();
                _isCompleted = value;
            }
        }

        public event UnityAction Completed;

        public void Complete()
        {
        }
    }
}