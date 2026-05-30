using UnityEngine;

namespace Player
{
    public static class JumpController
    {
        public static bool isGround(this object obj)
        {
            Debug.Log($"It is {obj is Collider2D}");
            if (obj is Collider2D) return (obj as Collider2D).CompareTag("Ground");
            return false;
        }

        public static void Jump()
        {
            Player.rb.linearVelocity = new Vector2(Player.rb.linearVelocity.x, Player.pc.jumpForce);
        }
    }
}
