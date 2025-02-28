using System.Collections.Generic;
using UnityEngine;
using Views.Utilities;

namespace Views.Hub
{
    public class HubButtonView : MonoBehaviour
    {
        [SerializeField] private List<ButtonActionNotification> _buttonActionsList;

        public List<ButtonActionNotification> ButtonActionsListList => _buttonActionsList;
    }
}