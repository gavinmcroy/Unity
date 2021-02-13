using System;
using UnityEngine;

namespace Script
{
    public class PulsatingCircle : Spell, IDamage
    {
        [SerializeField] private double circleMaxDiameter = 2d;
        [SerializeField] private double circleMinDiameter = 1d;
        [SerializeField] private double currentCircleDiameter = 1.5d;-
        
        private Rigidbody2D _rigidBody;
        

        private void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
            _rigidBody.velocity = new Vector2(1f, 1f);
        }

        private void FixedUpdate()
        {
            /* Make circle pulsate from small to big (Time.DeltaTime) */
            if ( /* circle reaches min , increase*/) ;
            else if ( /* cricle reaches max, decrease */) ;
        }


        public void DealDamage(int amount)
        {
            throw new System.NotImplementedException();
        }

        public void TakeDamage(int amount)
        {
            throw new System.NotImplementedException();
        }
    }
}