using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

namespace EndlessRunner.CreateandJoin
{
    public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
    {
        [SerializeField] private InputField m_CreateInput;
        [SerializeField] private InputField m_JoinInput;

        public void CreateRooms()
        {
            PhotonNetwork.CreateRoom(m_CreateInput.text);
        }
        public void JoinRoom()
        {
            PhotonNetwork.JoinRoom(m_JoinInput.text);
        }
        public override void OnJoinedRoom()
        {
            PhotonNetwork.LoadLevel("GamePlay");
        }

    }
}