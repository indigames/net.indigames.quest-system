using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Authoring
{
    [CreateAssetMenu(fileName = "QuestDatabase", menuName = "IndiGames/Quest System/Database", order = 0)]
    public class QuestDatabase : ScriptableObject
    {
        [SerializeField] private Quest[] _quests = Array.Empty<Quest>();
        public Quest[] Quests => _quests;
    }
}