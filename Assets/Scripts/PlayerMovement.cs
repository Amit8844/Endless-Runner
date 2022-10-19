using UnityEngine;
using Photon.Pun;
using EndlessRunner.Manager;


namespace EndlessRunner.Player
{
    public class PlayerMovement : MonoBehaviour
    {

        private bool b_Alive = true;
        private float f_HorizontalInput;
        private PhotonView p_View;

        [Header("Speeds")]
        public float speed = 5;
        //public float speedIncreasePerPoint = 0.01f;

        [Header("My")]
        [SerializeField] private Rigidbody m_RigidBody;
        [SerializeField] private float f_HorizontalMultiplier = 2;

        private void Start()
        {
            p_View = GetComponent<PhotonView>();
        }


        private void FixedUpdate()
        {
            if (!b_Alive) return;

            Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
            Vector3 horizontalMove = transform.right * f_HorizontalInput * speed * Time.fixedDeltaTime * f_HorizontalMultiplier;
            m_RigidBody.MovePosition(m_RigidBody.position + forwardMove + horizontalMove);
        }

        private void Update()
        {
            if (p_View.IsMine)
            {
                f_HorizontalInput = Input.GetAxis("Horizontal");
            }


            if (transform.position.y < -5)
            {
                Die();
            }
        }

        public void Die()
        {
            b_Alive = false;
            
            GameManager.Instance.GameOver();
        }


    }
}