using UnityEngine;

namespace Player
{
    public class PlayerController : Combat.Entities.EntityController
    {

        float hInput => Input.GetAxis("Horizontal");
        float vInput => Input.GetAxis("Vertical");
        float hInputRaw => Input.GetAxisRaw("Horizontal");
        float vInputRaw => Input.GetAxisRaw("Vertical");

        public bool canJump = true;
        public bool canDash = true;
        public bool canMove = true;

        bool shouldJump => canJump && Input.GetKeyDown(KeyCode.Space) && Grounded();
        bool shouldDash => canDash && Input.GetKeyDown(KeyCode.LeftShift);
        bool shouldMove => canMove && (hInputRaw != 0);

        [Header("Game Objects")]
        [SerializeField] GameObject groundChecker;

        [Header("Movement Parameters")]
        public float speed = 12f;
        public float maxSpeed = 20f;
        public float jumpForce = 12f;
        public float dashForce = 12f;

        Rigidbody2D rb;

        bool Grounded()
        {
            Vector2 groundCheckerPos = groundChecker.transform.position;
            Vector2 groundCheckerScale = groundChecker.transform.localScale;
            Collider2D[] groundCheckerTouching = Physics2D.OverlapBoxAll(groundCheckerPos, groundCheckerScale, 0);
            foreach (Collider2D col in groundCheckerTouching)
            {
                if (col.isGround()) return true;
            }
            return false;
        }


        void FixedUpdate()
        {
            Move();
            ClampMaxMoveSpeed();
        }

        void ClampMaxMoveSpeed()
        {
            rb.linearVelocity = new Vector2(Mathf.Clamp(rb.linearVelocity.x, -maxSpeed, maxSpeed), rb.linearVelocity.y);
        }

        void Move()
        {
            if (shouldMove)
            {
                rb.linearVelocity = new Vector2(hInput * speed, rb.linearVelocity.y);

            }
        }

        void Update()
        {


            if (shouldJump) JumpController.Jump();

            if (shouldDash) DashController.Dash();
        }

        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

    }
}
