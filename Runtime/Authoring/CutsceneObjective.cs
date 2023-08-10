using UnityEngine;

namespace IndiGames.QuestSystem.Authoring
{
    [CreateAssetMenu(menuName = "IndiGames/Quest System/Stages/Cutscene", fileName = "CutsceneStage")]
    public class CutsceneObjective : Objective
    {
        /// <summary>
        /// Try to play the cut scene as soon as the scene is loaded
        /// </summary>
        public bool PlayOnLoaded = true;
    }
}