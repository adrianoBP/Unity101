using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanMovement : MonoBehaviour
{

    public float MovementSpeed = 10;        // Bean speed
    private Rigidbody BeanBody;             // Bean body
    private Vector3 MoveInput;              // Where the wants to go
    private Vector3 MoveVelocity;           // What is pushing the bean to the input direction

    //private bool IsVerticalLocked = false;


    // Start is called before the first frame update
    void Start()
    {
        BeanBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var rsbX = Input.GetAxisRaw("RSBX");
        var rsbY = Input.GetAxisRaw("RSBY");

        Debug.Log($"X: {rsbX}  -  Y: {rsbY}");



        //var verticalInput = Input.GetAxisRaw("RightJoystickVertical");

        //Debug.Log($"Current vertical input: {verticalInput}");

        //// Epsilon to compensate controller sensibility
        //if ((verticalInput >= 0 - Mathf.Epsilon && verticalInput <= 0 + Mathf.Epsilon) && IsVerticalLocked)
        //{
        //    IsVerticalLocked = false;
        //    BeanBody.constraints = RigidbodyConstraints.FreezeRotation;
        //}

        //if (Input.GetButtonUp("Joystick Y"))
        //{
        //    RigidbodyConstraints constraints = RigidbodyConstraints.FreezeRotation;
        //    if (!IsVerticalLocked)
        //    {
        //        constraints |= RigidbodyConstraints.FreezePositionY;
        //    }
        //    IsVerticalLocked = !IsVerticalLocked;

        //    BeanBody.constraints = constraints;
        //}

        //if (BeanBody.velocity.y > 0) // If it is going up, increase the drag
        //    BeanBody.drag = 1.5f;
        //else
        //    BeanBody.drag = 0f;

        //var beanVerticalSpeed = verticalInput + BeanBody.velocity.y;
        //MoveInput = new Vector3(Input.GetAxisRaw("Horizontal"), beanVerticalSpeed, Input.GetAxisRaw("Vertical"));
        //MoveVelocity = new Vector3()
        //{
        //    x = MoveInput.x * MovementSpeed,
        //    y = MoveInput.y,
        //    z = MoveInput.z * MovementSpeed,
        //};

        //if (IsVerticalLocked)
        //    BeanBody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
    }

    void FixedUpdate()
    {
        BeanBody.velocity = MoveVelocity;
    }
}