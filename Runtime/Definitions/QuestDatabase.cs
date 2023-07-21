using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Definitions
{
    [CreateAssetMenu(menuName = "Indi Games/Quest System/Quest Database")]
    public class QuestDatabase : ScriptableObject
    {
        [SerializeField] private Quest[] _quests = Array.Empty<Quest>();
        public Quest[] Quests => _quests;
    }
}