using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(fileName = "QuestDatabase", menuName = "IndiGames/Quest System/Database", order = 0)]
    public class QuestDatabase : ScriptableObject
    {
        [SerializeField] private QuestScriptableObject[] _quests = Array.Empty<QuestScriptableObject>();
        public QuestScriptableObject[] Quests => _quests;
    }
}