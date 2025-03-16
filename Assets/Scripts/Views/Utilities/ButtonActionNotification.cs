using System;
using UnityEngine;

namespace Views.Utilities
{
    public class ButtonActionNotification : MonoBehaviour
    {
        [SerializeField]
        private ButtonActionHubEnum _codeAction;

        public Action<ButtonActionHubEnum> ButtonAction;

        public void ButtonActionInvoke()
        {
            ButtonAction?.Invoke(_codeAction);
        }
    }
}