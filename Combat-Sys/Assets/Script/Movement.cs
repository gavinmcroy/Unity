using UnityEngine;

namespace Script
{
    public class Movement : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5;
        /// <summary>
        /// The position the player is travelling on the x axis. Either -1, 0, or 1
        /// </summary>
        private float _xMove;
        /// <summary>
        /// The position the player is travelling on the y axis. Either -1, 0, or 1
        /// </summary>
        private float _yMove;
        private Rigidbody2D _rigidBody2D;

        private void Awake()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            ReadInput();
        }

        private void FixedUpdate()
        {
            Move();
        }

        /// <summary>
        /// Reads input from the Input Manager Axis. (1,0) is to right and (0,-1) is down. Data can only be either
        /// -1, 0, or 1
        /// </summary>
        /// 
        /// <returns>
        /// Nothing.
        /// </returns>
        private void ReadInput()
        {
            _xMove = Input.GetAxisRaw("Horizontal");
            _yMove = Input.GetAxisRaw("Vertical");
        }

        /// <summary>
        /// Determines which direction the player
        /// is travelling with a pair of coordinates. For example (1,0) is to the right. The players velocity attribute
        /// inside rigid body is updated therefore this method must be placed inside FixedUpdate in order to work.
        /// Players diagonal position is normalized.
        /// </summary>
        /// 
        /// <returns>
        /// Nothing.
        /// </returns>
        private void Move()
        {
            var move = new Vector2(_xMove, _yMove);
            if (move.magnitude * moveSpeed > moveSpeed)
            {
                _rigidBody2D.velocity = move.normalized * moveSpeed;
            }
            else
            {
                _rigidBody2D.velocity = moveSpeed * move;
            }
        }

        /// <summary>
        /// This function does something nifty
        /// </summary>
        /// <param name = "alpha"> This is a parameter named a </param>
        /// <param name = "beta"> This is a parameter named b </param>
        /// <returns>
        /// The sum of two integers.
        /// </returns>
        /// <c> Math.getMyName() </c>
        private void AnotherDebugFunction(int alpha, int beta)
        {
        }
    }
}