using System;
using UnityEngine;

namespace DragonspiritGames.EchoesOfFire
{
    public class Explanation : MonoBehaviour
    {
        bool _hasBeenActivated;
        ObjectController _objectController;
        SpriteRenderer _spriteRenderer;

        void Awake()
        {
            _objectController = FindObjectOfType<ObjectController>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player") && !_hasBeenActivated)
            {
                _objectController.ObjectHasBeenIdentified();
                _spriteRenderer.color = Color.black;
                _hasBeenActivated = true;
            }
        }
    }
}
