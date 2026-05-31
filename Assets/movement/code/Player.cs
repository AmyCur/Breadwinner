using UnityEngine;

namespace Player
{
    public static class Player
    {
        public static GameObject playerObject;
        public static Transform playerTransform => playerObject.transform;
        public static Vector3 playerPosition => playerTransform.position;
        public static PlayerController pc;
        public static Rigidbody2D rb;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            playerObject = GameObject.Find("Player");
            pc = playerObject.GetComponent<PlayerController>();
            rb = playerObject.GetComponent<Rigidbody2D>();
        }
    }
}
