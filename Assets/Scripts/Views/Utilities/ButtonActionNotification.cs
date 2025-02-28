using System;
using UnityEngine;

namespace Views.Utilities
{
    public class ButtonActionNotification : MonoBehaviour
    {
        [SerializeField]
        private ButtonActionHubEnum _codeAction;

        public Action<ButtonActionHubEnum> _buttonAction;

        public void ButtonAction()
        {
            _buttonAction?.Invoke(_codeAction);
        }
    }
}