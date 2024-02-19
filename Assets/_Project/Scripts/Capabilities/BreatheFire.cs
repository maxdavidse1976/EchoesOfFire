using System;
using UnityEngine;

namespace DragonspiritGames.EchoesOfFire
{
    [RequireComponent(typeof(Controller))]
    public class BreatheFire : MonoBehaviour
    {
        [SerializeField] ParticleSystem _particleSystem;
        [SerializeField] AudioSource _audioSource;
        bool _desireFire;
        Controller _controller;
        ObjectController _objectController;

        void Awake()
        {
            _controller = GetComponent<Controller>();
            _objectController = FindObjectOfType<ObjectController>();
        }

        void Update()
        {
            _desireFire = _controller.input.RetrieveFireInput(this.gameObject);
        }

        void FixedUpdate()
        {
            if (_desireFire)
            {
                _particleSystem.Play();
                _audioSource.Play();
            }
        }
    }
}
