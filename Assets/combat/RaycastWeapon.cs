using UnityEngine;
using Combat.Entities;

namespace Combat
{

    [CreateAssetMenu(fileName = "New Raycast Weapon", menuName = "Create/Raycast Weapon")]
    public class RaycastWeapon : Weapon
    {
        public override void OnClick()
        {
            RaycastHit2D hit = Player.Player.playerObject.ShootAtCursor(range);
            Debug.Log($"shot  {hit.collider.name}");
            if (hit.collider != null && hit.IsEntity(EntityTypes.enemy)) hit.TakeDamage(damage);
            base.OnClick();
        }
    }
}

