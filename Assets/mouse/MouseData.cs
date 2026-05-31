using UnityEngine;

namespace Mouse
{
    public static class MouseData
    {
        public static Vector2 position => Input.mousePosition;
        public static Vector2 screenToWorldMousePosition => Camera.main.ScreenToWorldPoint(new Vector3(position.x, position.y, -10));
        public static Vector2 distance(this Transform pos) => screenToWorldMousePosition - new Vector2(pos.position.x, pos.position.y);
        public static Vector2 positiveDistance(this Transform pos) => new Vector2(Mathf.Abs(pos.distance().x), Mathf.Abs(pos.distance().y));
    }
}
