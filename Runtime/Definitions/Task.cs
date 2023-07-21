using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "Indi Games/Quest System/Task")]
    public class Task : ScriptableObject
    {
        /// <summary>
        /// Which actor that associated with this task
        /// </summary>
        [SerializeField] private Actor _actor;
        public Actor Actor => _actor;
        [SerializeField] private TaskType _type;
    }
}