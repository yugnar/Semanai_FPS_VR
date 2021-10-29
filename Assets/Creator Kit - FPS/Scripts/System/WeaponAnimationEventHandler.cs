using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Photon.Pun.Demo.Asteroids
{
    public class WeaponAnimationEventHandler : MonoBehaviour
    {
        Weapon m_Owner;

        void Awake()
        {
            m_Owner = GetComponentInParent<Weapon>();
        }

        public void PlayFootstep()
        {
            m_Owner.Owner.PlayFootstep();
        }
    }
}
