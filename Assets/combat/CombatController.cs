using UnityEngine;

namespace Combat
{
    public class CombatController : MonoBehaviour
    {
        public Weapon currentWeapon;

        bool shouldAttack => currentWeapon.canAttack && Input.GetKeyDown(KeyCode.Mouse0);

        void Update()
        {
            if (shouldAttack)
            {
                currentWeapon.OnClick();
            }
        }

        void OnDrawGizmos()
        {
            // Draw a yellow sphere at the transform's position
            Gizmos.color = Color.yellow;
            Gizmos.DrawLine(transform.position, Mouse.MouseData.screenToWorldMousePosition);
        }
    }
}
