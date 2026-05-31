using UnityEngine;

namespace Combat.Entities
{
    public class EntityController : MonoBehaviour
    {
        public float health = 100f;
        public float maxHealth = 100f;

        public void TakeDamage(float damage)
        {
            health -= damage;
        }
    }
}
