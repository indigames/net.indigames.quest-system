﻿using IndiGames.QuestSystem.Definitions;
using UnityEngine;

namespace IndiGames.QuestSystem.Components
{
    public class GameObjectActivator : MonoBehaviour
    {
        [SerializeField] private bool _isActivated;
        [SerializeField] private bool _statusToActivate;
        [SerializeField] private QuestScriptableObject _questDefinition;
        [SerializeField] private GameObject _target;

        private void OnEnable()
        {
            _questDefinition.StatusChanged += QuestStatusChanged;
        }

        private void OnDisable()
        {
            _questDefinition.StatusChanged -= QuestStatusChanged;
        }

        public void CheckQuestStatus()
        {
            QuestStatusChanged(_questDefinition.Completed);
        }

        private void QuestStatusChanged(bool hasCompleted)
        {
            if (hasCompleted == _statusToActivate)
            {
                _target.SetActive(_isActivated);
            }
        }
    }
}