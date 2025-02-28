using System;
using Models.Hub;
using UnityEngine;
using Views.Hub;
using Views.Utilities;

namespace Controllers.Hub
{
    public class HubPanelController : MonoBehaviour
    {
        [SerializeField]
        HubPanelView _view;

        private HubPanelModel _model;

        private void Start()
        {
            Instantiation();
        }

        private void Instantiation()
        {
            _model = new HubPanelModel();
            // прописать подписывание на ивенты кнопок _view.HubButtonView.ButtonActionsListList
        }

        private void OpenPanel(ButtonActionHubEnum _actionCode)
        {
            CloseAllPanels();
            
            switch (_actionCode)
            {
                case ButtonActionHubEnum.None:
                    break;
                case ButtonActionHubEnum.OpenMainPanel:
                    PanelState(_view.MainPanel);
                    break;
                case ButtonActionHubEnum.OpenForgePanel:
                    PanelState(_view.ForgePanel);
                    break;
                case ButtonActionHubEnum.OpenCharactersPoolButton:
                    PanelState(_view.CharactersPoolPanel);
                    break;
                case ButtonActionHubEnum.OpenMissionsPanel:
                    PanelState(_view.MissionsPanel);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_actionCode), _actionCode, null);
            }
        }

        private void CloseAllPanels()
        {    
            //Реализовать закрывашку панелей
        }

        private void PanelState(GameObject panel, bool state = true)
        {
            panel.SetActive(state);
        }

        private void OnDisable()
        {
            //реализовать отписку от событий
        }
    }
}