using System;
using UnityEngine;

namespace DragonspiritGames.EchoesOfFire
{
    public class ObjectController : MonoBehaviour
    {
        bool _hasBeenIdentified;
        BoxCollider2D _boxCollider;
        [SerializeField] AudioClip _unknownObjectClip;
        [SerializeField] AudioClip _itIsATree;

        void Awake()
        {
            _boxCollider = GetComponent<BoxCollider2D>();
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                AudioManager.Instance.PlayClip(_unknownObjectClip);
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                AudioManager.Instance.PlayClip(_itIsATree);
            }
        }
    }
}
