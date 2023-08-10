using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Authoring
{
    [CreateAssetMenu(menuName = "IndiGames/Quest System/Or Objectives")]
    public class OrObjectives : Objective
    {
        public Objective[] Objectives;

        public override int CompareTo(Objective other)
        {
            foreach (var objective in Objectives)
            {
                if (objective.CompareTo(other) == 0)
                {
                    return 0;
                }
            }
            return base.CompareTo(other);
        }
    }
}