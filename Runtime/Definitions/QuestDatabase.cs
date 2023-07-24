using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "Indi Games/Quest System/Quest Database")]
    public class QuestDatabase : ScriptableObject
    {
        [SerializeField] private QuestDefinition[] _quests = Array.Empty<QuestDefinition>();
        public QuestDefinition[] Quests => _quests;
    }
}