using System.Collections.Generic;
using UnityEngine;
using Views.Utilities;

namespace Views.Hub
{
    public class ButtonView : MonoBehaviour
    {
        [SerializeField] private List<ButtonActionNotification> _buttonActionsList;

        public List<ButtonActionNotification> ButtonActionsListList => _buttonActionsList;
    }
}