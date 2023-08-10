using UnityEngine;

namespace IndiGames.QuestSystem.Authoring
{
    [CreateAssetMenu(menuName = "IndiGames/Quest System/Stages/Talk to NPC", fileName = "TalkToNpcStage", order = 0)]
    public class TalkToNpcObjective : Objective
    {
        [field: SerializeField] public string YarnNode { get; private set; }
    }
}