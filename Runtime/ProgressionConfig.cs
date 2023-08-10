using System;
using IndiGames.QuestSystem.Authoring;

namespace IndiGames.QuestSystem
{
    [Serializable]
    public class ProgressionConfig
    {
        public Quest TargetQuest;
        public Objective TargetObjective;
    }
}