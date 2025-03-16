using System;
using UnityEngine;

namespace Views.Utilities
{
    [Serializable]
    public class PanelObject
    {
        [SerializeField] private GameObject _panel;

        public GameObject Panel => _panel;

        [SerializeField] private ButtonActionHubEnum _hubEnum;

        public ButtonActionHubEnum HubEnum => _hubEnum;
    }
}