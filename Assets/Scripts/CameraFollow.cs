using UnityEngine;

namespace EndlessRunner.Camera
{
    public class CameraFollow : MonoBehaviour
    {

        [SerializeField] private Transform m_Player;

        private Vector3 offset;

        private void Start()
        {

            offset = transform.position - m_Player.position;
        }

        private void Update()
        {
            Vector3 targetPos = m_Player.position + offset;
            targetPos.x = 0;
            transform.position = targetPos;
        }

    }
}