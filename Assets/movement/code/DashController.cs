using Mouse;
using UnityEngine;
using System.Collections;

namespace Player
{
    public static class DashController
    {

        static IEnumerator DashRoutine()
        {
            Player.pc.canMove = false;
            Vector2 mousePos = Player.playerTransform.distance().normalized;

            for (int i = 0; i < 20; i++)
            {
                Player.rb.AddForce(new Vector2(mousePos.x, mousePos.y) * Player.pc.dashForce);
                yield return new WaitForSeconds(0.2f / 20);
            }
            Player.pc.canMove = true;

        }
        public static void Dash()
        {
            // Debug.Log(mousePos);
            Player.pc.StartCoroutine(DashRoutine());

        }
    }
}
