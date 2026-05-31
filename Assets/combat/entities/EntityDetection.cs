using UnityEngine;

namespace Combat.Entities
{
    public static class EntityDetection
    {
        public static bool IsEntity(this object obj, EntityTypes eType)
        {
            if (eType == EntityTypes.enemy)
            {
                if (obj is GameObject) return (obj as GameObject).CompareTag(EntityTags.Enemy);
                if (obj is RaycastHit2D ray) return ray.collider.CompareTag(EntityTags.Enemy);
            }


            return false;
        }
    }
}
