using UnityEngine;
using System.Collections;

namespace Player
{
    public static class GravityController
    {
        public static float gravityIncreaseRate => Player.pc.gravityIncreaseRate;
        public static float maxGravityScale => Player.pc.maxGravityScale;

        public static Coroutine currentGravityRoutine;

        public const float defaultGravityScale = 4;

        public static IEnumerator IncreaseGravity()
        {
            while (!Player.pc.Grounded())
            {
                Debug.Log("I");
                yield return 0;
                Player.rb.gravityScale *= gravityIncreaseRate;
                Player.rb.gravityScale = Mathf.Clamp(Player.rb.gravityScale, 1f, maxGravityScale);
            }
            Player.rb.gravityScale = defaultGravityScale;
            currentGravityRoutine = null;
        }
        // [RuntimeInitializeOnLoadMethod]
        // public static void Start()
        // {
        //     defaultGravityScale = Player.rb.gravityScale;
        // }
    }
}
