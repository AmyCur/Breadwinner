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
            yield return new WaitForSeconds(0.2f);
            Player.pc.canMove = true;

        }
        public static void Dash()
        {
            Vector2 mousePos = Player.playerTransform.distance().normalized;
            Debug.Log(mousePos);
            Player.rb.AddForce(new Vector2(mousePos.x, mousePos.y) * Player.pc.dashForce);
            Player.pc.StartCoroutine(DashRoutine());

        }
    }
}
