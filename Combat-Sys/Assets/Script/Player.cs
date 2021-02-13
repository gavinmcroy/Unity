using UnityEngine;

namespace Script
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PulsatingCircle pulsatingCircle;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                var position = transform.position;
                Instantiate(pulsatingCircle,new Vector3(position.x+.20f,
                    position.y,position.z),Quaternion.identity);
            }
        }

        private void MyFunction()
        {
            
        }
    }
}
