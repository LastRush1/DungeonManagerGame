using UnityEngine;

namespace Views.Hub
{
    public class HubPanelView : MonoBehaviour
    {
        [SerializeField]
        private GameObject _mainPanel;

        [SerializeField]
        private GameObject _forgePanel;
        
        [SerializeField]
        private GameObject _charactersPoolPanel;
        
        [SerializeField]
        private GameObject _missionsPanel;

        [SerializeField]
        private HubButtonView _hubButtonView;
        
        public GameObject MainPanel => _mainPanel;
        
        public GameObject ForgePanel => _forgePanel;
        
        public GameObject CharactersPoolPanel => _charactersPoolPanel;
        
        public GameObject MissionsPanel => _missionsPanel;

        public HubButtonView HubButtonView => _hubButtonView;
    }
}