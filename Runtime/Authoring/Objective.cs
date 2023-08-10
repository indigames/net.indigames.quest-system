using System;
using UnityEngine;

namespace IndiGames.QuestSystem.Authoring
{
    public abstract class Objective : ScriptableObject, IComparable<Objective>
    {
        [field: SerializeField] public string Id { get; set; }

        public virtual int CompareTo(Objective other)
        {
            return this == other ? 0 : -1;
        }
    }
}