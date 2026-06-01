using UnityEngine;
using System.Collections;

namespace Player
{
    public static class JumpController
    {

        public static Coroutine graceRoutine;
        public static bool hasGrace = true;
        public static float graceTime => Player.pc.jumpGraceTime;

        public static IEnumerator GravityGrace()
        {
            hasGrace = true;
            yield return new WaitForSeconds(graceTime);
            hasGrace = false;
        }
        public static bool isGround(this object obj)
        {
            if (obj is Collider2D) return (obj as Collider2D).CompareTag("Ground");
            return false;
        }

        public static void Jump()
        {
            if (graceRoutine != null) Player.pc.StopCoroutine(graceRoutine);
            graceRoutine = Player.pc.StartCoroutine(GravityGrace());


            Player.rb.linearVelocity = new Vector2(Player.rb.linearVelocity.x, Player.pc.jumpForce);
        }
    }
}
