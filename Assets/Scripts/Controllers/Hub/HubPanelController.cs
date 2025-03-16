using Models.Hub;
using UnityEngine;
using Views.Hub;
using Views.Utilities;
using PanelView = Views.Hub.PanelView;

namespace Controllers.Hub
{
    public class HubPanelController : MonoBehaviour
    {
        [SerializeField] PanelView _view;

        private HubPanelModel _model;

        private void Start()
        {
            Instantiation();
        }

        private void Instantiation()
        {
            _model = new HubPanelModel();

            for (int i = 0; i < _view.ButtonView.ButtonActionsListList.Count; i++)
            {
                _view.ButtonView.ButtonActionsListList[i].ButtonAction += OpenPanel;
            }
        }

        private void OpenPanel(ButtonActionHubEnum actionCode)
        {
            CloseAllPanels();

            PanelState(_view.GetPanel(actionCode));
        }

        private void CloseAllPanels()
        {
            for (int i = 0; i < _view.Panels.Count; i++)
            {
                _view.Panels[i].Panel.SetActive(false);
            }
        }

        private void PanelState(GameObject panel, bool state = true)
        {
            panel.SetActive(state);
        }

        private void OnDisable()
        {
            for (int i = 0; i < _view.ButtonView.ButtonActionsListList.Count; i++)
            {
                _view.ButtonView.ButtonActionsListList[i].ButtonAction -= OpenPanel;
            }
        }
    }
}