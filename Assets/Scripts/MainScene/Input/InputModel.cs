using UnityEngine;
using UnityEngine.UI;

namespace MainScene.Input
{
    public class InputModel : MonoBehaviour
    {
        [Header("Main buttom")]
        [SerializeField] private Button m_accelButton = null;
        [SerializeField] private Button m_stopButton = null;
        
        public Button AccelButton => m_accelButton;
        public Button StopButton => m_stopButton;
    }
}
