using System;
using UnityEngine;

namespace DragonspiritGames.EchoesOfFire
{
    public class ObjectController : MonoBehaviour
    {
        BoxCollider2D _boxCollider;
        SpriteRenderer _spriteRenderer;
        [SerializeField] AudioClip _unknownObjectClip;
        [SerializeField] AudioClip _itIsATree;
        [SerializeField] Sprite _treeSprite;

        bool _hasBeenIdentified;
        
        void Awake()
        {
            _boxCollider = GetComponent<BoxCollider2D>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player") && !_hasBeenIdentified)
            {
                AudioManager.Instance.PlayClip(_unknownObjectClip);
            }
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player") && _hasBeenIdentified)
            {
                AudioManager.Instance.PlayClip(_itIsATree);
            }
        }

        public void ObjectHasBeenIdentified()
        {
            _spriteRenderer.sprite = _treeSprite;
            _spriteRenderer.color = Color.white;
            _boxCollider.isTrigger = true;
            _hasBeenIdentified = true;
        }
    }
}
