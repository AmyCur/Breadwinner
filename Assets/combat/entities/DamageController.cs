using UnityEngine;

namespace Combat.Entities
{
    public static class DamageController
    {
        public static void TakeDamage(this object obj, float damage)
        {
            if (obj is GameObject) (obj as GameObject).GetComponent<EntityController>().TakeDamage(damage);
            if (obj is EntityController) (obj as EntityController).TakeDamage(damage);
            if (obj is RaycastHit2D ray) ray.collider.GetComponent<EntityController>().TakeDamage(damage);

        }
    }
}
