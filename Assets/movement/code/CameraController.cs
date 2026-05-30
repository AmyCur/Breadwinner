using UnityEngine;

namespace Player
{
    public class CameraController : MonoBehaviour
    {
        GameObject player => Player.playerObject;
        public float lerpSpeed = 3f;

        void FixedUpdate()
        {
            transform.position = Vector2.Lerp(transform.position, player.transform.position, Time.deltaTime * lerpSpeed);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }
}
