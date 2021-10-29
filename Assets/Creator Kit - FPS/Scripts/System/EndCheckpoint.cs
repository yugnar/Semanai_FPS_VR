using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Photon.Pun.Demo.Asteroids
{
    public class EndCheckpoint : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.GetComponent<Controller>() == null)
                return;


            GameSystem.Instance.StopTimer();
            GameSystem.Instance.FinishRun();
            Destroy(gameObject);
        }
    }
}