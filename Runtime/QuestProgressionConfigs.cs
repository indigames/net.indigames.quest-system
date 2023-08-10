using System;
using IndiGames.QuestSystem.Authoring;

namespace IndiGames.QuestSystem
{
    [Serializable]
    public class QuestProgressionConfigs
    {
        public Quest Quest;
        public TalkToNpcObjective Objective;
        public string YarnNode => Objective.YarnNode;

        public bool CanProgress()
        {
            if (Quest.Completed) return false;
            if (!Quest.CanCompleteObjective(Objective)) return false;
            if (Quest.HasObjectiveCompleted(Objective)) return false;

            return true;
        }
        
        public void Progress()
        {
            if (!CanProgress()) return;
            
            Quest.CompleteObjective(Objective);
        }
    }
}