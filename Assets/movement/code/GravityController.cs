using UnityEngine;
using System.Collections;

namespace Player
{
    public static class GravityController
    {
        public const float gravityIncreaseRate = 1.01f;
        public static Coroutine currentGravityRoutine;
        public const float defaultGravityScale = 4;

        public static IEnumerator IncreaseGravity()
        {
            while (!Player.pc.Grounded())
            {
                yield return 0;
                Player.rb.gravityScale *= gravityIncreaseRate;
            }
            Player.rb.gravityScale = defaultGravityScale;
        }
        // [RuntimeInitializeOnLoadMethod]
        // public static void Start()
        // {
        //     defaultGravityScale = Player.rb.gravityScale;
        // }
    }
}
