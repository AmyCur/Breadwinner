using UnityEngine;

namespace Player
{
    public class PlayerController : MonoBehaviour
    {

        float hInput => Input.GetAxis("Horizontal");
        float vInput => Input.GetAxis("Vertical");
        float hInputRaw => Input.GetAxisRaw("Horizontal");
        float vInputRaw => Input.GetAxisRaw("Vertical");

        [SerializeField] bool canJump = true;


        bool shouldJump => canJump && Input.GetKeyDown(KeyCode.Space) && Grounded();

        [Header("Game Objects")]
        [SerializeField] GameObject groundChecker;

        [Header("Movement Parameters")]
        public float speed = 12f;
        public float jumpForce = 12f;

        Rigidbody2D rb;

        bool Grounded()
        {
            Vector2 groundCheckerPos = groundChecker.transform.position;
            Vector2 groundCheckerScale = groundChecker.transform.localScale;
            Collider2D[] groundCheckerTouching = Physics2D.OverlapBoxAll(groundCheckerPos, groundCheckerScale, 0);
            foreach (Collider2D col in groundCheckerTouching)
            {
                Debug.Log(col.name);
                if (col.isGround()) return true;
            }
            return false;
        }


        void FixedUpdate()
        {
            rb.linearVelocity = new Vector2(hInput * speed, rb.linearVelocity.y);
        }

        void Update()
        {
            Debug.Log($"{canJump} && {Input.GetKeyDown(KeyCode.Space)} && {Grounded()}");


            if (shouldJump)
            {
                JumpController.Jump();
            }
        }

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

    }
}
