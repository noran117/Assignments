using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignmet37
{

    public class RigidBodyCharacterController : MonoBehaviour
    {
        public float speed = 5.0f;
        public float jumpForce = 5.0f;
        public float highSpeed = 10.0f;
        public LayerMask groundLayer;

        public float factor = 1.2f;  
        private Vector3 originalScale;
        public Color[] colorOptions;
        private int colorIndex = 0;

        Rigidbody _rg;
        Vector3 moveInput;

        bool isJump;
        private bool isGrounded;

        void Awake()
        {
            _rg = GetComponent<Rigidbody>();
        }

        void Start()
        {
            _rg.mass = 5f;
            _rg.freezeRotation = true;
            _rg.constraints = RigidbodyConstraints.FreezeRotation;
            originalScale = transform.localScale;
        }

        void Update()
        {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            //float tempSpeed = speed;
            float tempSpeed = (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) ? highSpeed : speed;


            //if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            //{
            //    tempSpeed = highSpeed;
            //}
      
            //moveInput = new Vector3(x, 0, z);
            //moveInput = moveInput.normalized * tempSpeed;
            moveInput = new Vector3(x, 0, z).normalized * tempSpeed;
            moveInput.y = _rg.velocity.y;

            isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f, groundLayer);

            //if (Input.GetButtonDown("Jump") && Mathf.Abs(_rg.velocity.y) < 0.01f)
            //{
            //    isJump = true;
            //}
            if(Input.GetButtonDown("Jump") && isGrounded)
            {
                isJump = true;
            }

        }

        void FixedUpdate()
        {

            _rg.velocity = Vector3.Lerp(_rg.velocity, moveInput, 0.1f);

            if (isJump)
            {
                _rg.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isJump = false;
            }

        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Collectible")) 
            {
                transform.localScale *= factor;
                GetComponent<Renderer>().material.color = colorOptions[Random.Range(0,colorOptions.Length)];
                Destroy(other.gameObject);  
            }
        }

    }
}