using UnityEngine;

namespace MainScene.Car
{
    public class CarModel : MonoBehaviour
    {
        [Header("Rigidbody Car")] 
        [SerializeField] private Rigidbody2D m_frontTireRB;
        [SerializeField] private Rigidbody2D m_backTireRB;
        [SerializeField] private Rigidbody2D m_carRB;
        [Header("Speed info")]
        [SerializeField] private float m_speed = 150f;
        [SerializeField] private float m_rotationSpeed = 300f;
        
        
        public Rigidbody2D FrontTireRB => m_frontTireRB;
        public Rigidbody2D BackTireRB => m_backTireRB;
        public Rigidbody2D CarRB => m_carRB;
        public float Speed => m_speed;
        public float RotationSpeed => m_rotationSpeed;
    }
}
