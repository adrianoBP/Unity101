using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody BeanBody;             // Bean body 

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

        var buttonA = Input.GetButtonDown("Button A");
        var buttonW = Input.GetAxisRaw("Vertical");

        Debug.Log($"X: {rsbX}  -  Y: {rsbY}  -  A: {buttonA}  -  W: {buttonW}");

    }

    void FixedUpdate()
    {

    }
}
