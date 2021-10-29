using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Photon.Pun.Demo.Asteroids
{
    public class StartCheckpoint : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            GameSystem.Instance.ResetTimer();
            GameSystem.Instance.StartTimer();
            Destroy(gameObject);
        }
    }
}