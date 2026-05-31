using UnityEngine;
using System.Collections;

namespace Combat
{
    public abstract class Weapon : ScriptableObject
    {
        public float damage = 10f;
        public float cooldown = 1f;

        public float range = 10f;

        public bool canAttack = true;

        Coroutine currentAttackCooldown;

        IEnumerator AttackCooldown()
        {
            canAttack = false;
            yield return new WaitForSeconds(cooldown);
            canAttack = true;
        }



        public virtual void OnClick()
        {
            currentAttackCooldown = Player.Player.pc.StartCoroutine(AttackCooldown());
        }
    }
}
