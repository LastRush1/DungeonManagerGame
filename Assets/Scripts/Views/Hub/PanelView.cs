using System;
using System.Collections.Generic;
using UnityEngine;
using Views.Utilities;

namespace Views.Hub
{
    public class PanelView : MonoBehaviour
    {
        [SerializeField] private List<PanelObject> _panels = new List<PanelObject>();

        [SerializeField] private ButtonView _buttonView;

        public List<PanelObject> Panels => _panels;

        public ButtonView ButtonView => _buttonView;

        public GameObject GetPanel(ButtonActionHubEnum panelEnum)
        {
            for (int i = 0; i < _panels.Count; i++)
            {
                if (_panels[i].HubEnum == panelEnum)
                {
                    return _panels[i].Panel;
                }
            }

            throw new ArgumentException("There is no such panel");
        }
    }
}