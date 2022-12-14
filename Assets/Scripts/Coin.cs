using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Interactable;
using EndlessRunner.Manager;

namespace EndlessRunner.Interactable
{
    public class Coin : MonoBehaviour
    {

        [SerializeField] private float turnSpeed = 90f;

        private void Update()
        {
            transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.GetComponent<Obstacle>() != null)
            {
                Destroy(gameObject);
                return;
            }

            // Check that the object we collided with is the player
            if (other.gameObject.name != "Player")
            {
                return;
            }

            // Add to the player's score
            GameManager.Instance.IncrementScore();

            // Destroy this coin object
            Destroy(gameObject);
        }


    }
}