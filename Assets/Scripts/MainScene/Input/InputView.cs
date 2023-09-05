using UnityEngine;
using UnityEngine.EventSystems;

namespace MainScene.Input
{
    public class InputView : MonoBehaviour
    {
        [SerializeField] private InputModel m_viewModel = null;
        private InputController m_controller = null;

        private void Start()
        {
            m_controller = new InputController(m_viewModel);
            m_controller.Initialize();
        }

        private void OnDestroy()
        {
            m_controller.Dispose();
        }
    }
}
