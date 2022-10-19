using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace EndlessRunner.SpawnPlayer
{
    public class SpawnPlayers : MonoBehaviour
    {
        [SerializeField] private GameObject m_PlayerPrefab;
        private GameObject Players;

        public float f_MinX;
        public float f_MaxX;
        public float f_MinY;
        public float f_MaxY;


        public void Start()
        {
            Vector2 randomPosition = new Vector2(Random.Range(f_MinX, f_MaxX), Random.Range(f_MinY, f_MaxY));
            PhotonNetwork.Instantiate(m_PlayerPrefab.name, randomPosition, Quaternion.identity);

        }
    }
}
           