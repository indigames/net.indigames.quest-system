using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "Indi Games/Quest System/Quest")]
    public class Quest : ScriptableObject
    {
        public string ID;
        public string Name;
        public string Description;
        public QuestType Type;
        public Task[] Tasks;
    }
}