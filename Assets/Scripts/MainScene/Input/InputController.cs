using System;

namespace MainScene.Input
{
    public class InputController 
    {
        private InputModel m_viewModel = null;
        public InputController(InputModel viewModel)
        {
            m_viewModel = viewModel;
        }
        public void Initialize()
        {
            InitializeButtons();
        }
        private void InitializeButtons()
        {
            m_viewModel.AccelButton.onClick.AddListener(AccelButton);
            m_viewModel.StopButton.onClick.AddListener(StopButton);
        }
        private void AccelButton()
        {
            ApplicationContainer.Instance.EventHolder.OnFront();
        }
        private void StopButton()
        {
            ApplicationContainer.Instance.EventHolder.OnStop();
        }
        private void DisposeButtons()
        {
            m_viewModel.AccelButton.onClick.RemoveListener(AccelButton);
            m_viewModel.StopButton.onClick.RemoveListener(StopButton);
        }
        public void Dispose()
        {
            DisposeButtons();
        }
    }
}
