using UnityEngine;
using Mouse;
using Util;

namespace Combat
{
    public static class RaycastUtilities
    {
        public static RaycastHit2D ShootAtCursor(this GameObject obj, float range)
        {
            Vector2 mousePosition = MouseData.screenToWorldMousePosition;
            Vector2 objPos = obj.transform.position;
            RaycastHit2D[] hits = Physics2D.RaycastAll(objPos, mousePosition - objPos, range);

            foreach (RaycastHit2D hit in hits)
            {
                Debug.Log($"{hit.collider.name}");
                if (!hit.collider.gameObject.isObjectOrChild(obj)) return hit;
            }

            return new RaycastHit2D();
        }
    }
}
