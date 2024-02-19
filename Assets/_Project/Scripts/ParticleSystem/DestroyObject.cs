using System;
using Cinemachine;
using UnityEngine;

namespace DragonspiritGames.EchoesOfFire
{
    public class DestroyObject : MonoBehaviour
    {
        ObjectController _objectController;

        void Awake()
        {
            _objectController = FindObjectOfType<ObjectController>();
        }

        void OnParticleCollision(GameObject other)
        {
            if (_objectController.HasObjectBeenIdentified())
            {
                Destroy(other.gameObject);
            }
        }

    }
}
