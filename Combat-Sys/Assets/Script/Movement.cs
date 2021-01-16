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

        /// <summary>
        /// This class does something.
        /// </summary>
        /// <param name = "a"> This is a parameter named a </param>
        /// 
        /// <param name = "b"> This is a parameter named b </param>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        /// <c> Math.getMyName() </c>
        private void MyGarbageFunction(int a, int b)
        {
            
        }
    }
}