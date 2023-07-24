using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "Indi Games/Quest System/Quest")]
    public class QuestDefinition : ScriptableObject
    {
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private TaskDefinition[] _tasks;
        [SerializeField] private bool _isCompleted;
    }
}