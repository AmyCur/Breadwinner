using UnityEngine;

namespace Util
{
    public static class GameObjectUtils
    {
        public static bool isObjectOrChild(this GameObject obj, GameObject target)
        {
            return (obj == target || obj.transform.IsChildOf(target.transform));
        }
    }
}
