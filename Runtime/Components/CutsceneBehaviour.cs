using IndiGames.QuestSystem.Authoring;
using UnityEngine.Events;

namespace IndiGames.QuestSystem.Components
{
    public class CutsceneBehaviour : StageBehaviourBase
    {
        public CutsceneObjective CutsceneObjectiveStage;
        public UnityEvent PlayCutsceneEvent;
        public UnityEvent CutsceneFinishedEvent;

        public override void Execute()
        {
            PlayCutsceneEvent.Invoke();
        }

        public void CutsceneFinished()
        {
            CutsceneFinishedEvent.Invoke();
        }
    }
}