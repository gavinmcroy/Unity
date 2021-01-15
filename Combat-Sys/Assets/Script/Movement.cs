using UnityEngine;

namespace Script
{
    public class Movement : MonoBehaviour
    {
        private const int MoveSpeed = 1;
        private Rigidbody2D _rigidBody2D;

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }


        private void Update()
        {
        }
    }
}