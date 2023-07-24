using IndiGames.QuestSystem.Definitions;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace IndiGamesEditor.QuestSystem.Definitions
{
    [CustomEditor(typeof(QuestDefinition))]
    public class QuestDefinitionEditor : Editor
    {
        public VisualTreeAsset QuestDefinitionEditorUxml;

        public override VisualElement CreateInspectorGUI()
        {
            VisualElement root = new VisualElement();

            InspectorElement.FillDefaultInspector(root, serializedObject, this);

            QuestDefinitionEditorUxml.CloneTree(root);

            return root;
        }
    }
}