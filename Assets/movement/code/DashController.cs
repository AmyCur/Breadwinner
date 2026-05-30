using Mouse;
using UnityEngine;

namespace Player
{
    public static class DashController
    {
        public static void Dash()
        {
            Vector2 mousePos = Player.playerObject.transform.distance().normalized;
            Debug.Log(mousePos);
            Player.rb.linearVelocity = new Vector2(mousePos.x - 0.5f, mousePos.y - 0.5f) * Player.pc.dashForce;

        }
    }
}
