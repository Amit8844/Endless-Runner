using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using EndlessRunner.Player;

namespace EndlessRunner.Manager
{
    public class GameManager : MonoBehaviour
    {

        public static GameManager Instance;
        private int i_Score;

        [SerializeField] private Text scoreText;
        [SerializeField] private PlayerMovement m_PlayerMovement;
        [SerializeField] private GameObject GameOverPanel;


        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            GameOverPanel.SetActive(false);
        }
        public void IncrementScore()
        {
            i_Score++;
            scoreText.text = "SCORE: " + i_Score;

            // Increase the player's speed
            // m_PlayerMovement.speed += m_PlayerMovement.speedIncreasePerPoint;
        }

        public void SinglePlayer()
        {
            SceneManager.LoadScene("GamePlay");
        }

        public void MultiPlayer()
        {
            SceneManager.LoadScene("Loading Scene");
        }
        public void MainMenue()
        {
            SceneManager.LoadScene("Main Menue");
        }

        public void Restart()
        {
            SceneManager.LoadScene("GamePlay");
        }

        public void GameOver()
        {
            GameOverPanel.SetActive(true);
        }





    }
}