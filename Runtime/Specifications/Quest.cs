using System;
using IndiGames.QuestSystem.Definitions;
using UnityEngine;

namespace IndiGames.QuestSystem.Specifications
{
    [Serializable]
    public class Quest
    {
        [SerializeField] private QuestScriptableObject _questDefinition;
        public Quest(QuestScriptableObject quest)
        {
            _questDefinition = quest;
        }
    }
}