using IndiGames.QuestSystem.Definitions;
using UnityEngine;

namespace IndiGamesEditor.QuestSystem.Definitions
{
    [UnityEditor.CustomEditor(typeof(TaskDefinition))]
    public class TaskDefinitionEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            GUI.enabled = Application.isPlaying;

            var taskDef = target as TaskDefinition;
            if (GUILayout.Button($"Complete {taskDef.name}"))
                taskDef.Complete();
        }
    }
}