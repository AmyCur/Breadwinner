// using UnityEngine;
//
// namespace Gameplay.Platforming
// {
//     public class SemiSolidPlatformController : MonoBehaviour
//     {
//         float playerPosition => Player.Player.playerPosition.y;
//
//         public bool IsPlayerBeneath()
//         {
//             return playerPosition < transform.position.y + (transform.localScale.y / 2f);
//         }
//
//         void Update()
//         {
//             if (IsPlayerBeneath())
//             {
//                 Physics2D.IgnoreCollision()
//
//             }
//         }
//     }
// }
