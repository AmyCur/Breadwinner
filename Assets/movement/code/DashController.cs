using Mouse;
using UnityEngine;

namespace Player
{
    public static class DashController
    {
        public static void Dash()
        {
            Vector2 mousePos = Player.playerTransform.distance().normalized;
            Debug.Log(mousePos);
            Player.rb.AddForce(new Vector2(Mathf.Sign(mousePos.x - 0.5f), Mathf.Sign(mousePos.y - 0.5f)) * Player.pc.dashForce);

        }
    }
}
