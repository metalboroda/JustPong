using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace Game
{
    public class MobileMove : MonoBehaviour
    {
        private Rigidbody2D _rb;
        private float _dirY;
        public float moveSpeed = 8f;

        private void Start()
        {
            _rb = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            _dirY = CrossPlatformInputManager.GetAxis("Vertical") * moveSpeed;
            // rb.velocity = new Vector2(0, dirx);
            _rb.AddForce(new Vector2(0, _dirY));
        }
    }
}