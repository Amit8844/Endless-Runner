using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Player;

namespace EndlessRunner.Interactable
{
    public class Obstacle : MonoBehaviour
    {

        private PlayerMovement playerMovement;

        private void Start()
        {
            playerMovement = FindObjectOfType<PlayerMovement>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.name == "Player")
            {
                // Kill the player
                playerMovement.Die();
            }
        }


    }
}