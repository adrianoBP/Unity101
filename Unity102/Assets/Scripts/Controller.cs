using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody body;
    private Vector3 startPosition;
    private Vector3 startRotation;
    private new Renderer renderer;

    public string ButtonName;
    public ButtonType Type;
    public float Sensitivity = 3;
    public bool Smooth = true;


    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        startPosition = body.position;
        startRotation = body.rotation.eulerAngles;
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //var inputValue = Input.get

        switch (Type)
        {
            case ButtonType.Joystick:

                var directonX = Smooth ? Input.GetAxis($"{ButtonName}X") : Input.GetAxisRaw($"{ButtonName}X");
                var directonY = Smooth ? Input.GetAxis($"{ButtonName}Y") : Input.GetAxisRaw($"{ButtonName}Y");

                //body.transform.Rotate(new Vector3()
                //{
                //    x = startPosition.x + directonX * Sensitivity,
                //    y = startPosition.y,
                //    z = startPosition.z + directonY * Sensitivity
                //}, 0, 0);

                Debug.Log($"Starting Y: {startRotation.y} - Y: {directonY * Sensitivity} - Sensitivity: {Sensitivity}");

                body.transform.rotation = Quaternion.Euler(
                    startRotation.x + directonX * Sensitivity,
                    startRotation.y,
                    startRotation.z + directonY * Sensitivity);

                body.position = new Vector3()
                {
                    x = startPosition.x + directonX * Sensitivity,
                    y = startPosition.y,
                    z = startPosition.z + directonY * Sensitivity
                };

                break;
            case ButtonType.Button:

                var isPressed = Input.GetButton($"{ButtonName}");
                if (isPressed)
                    renderer.material.SetColor("_Color", Color.green);
                else
                    renderer.material.SetColor("_Color", Color.white);

                break;

            case ButtonType.Trigger:

                var direction = Smooth ? Input.GetAxis($"{ButtonName}") : Input.GetAxisRaw($"{ButtonName}");
                body.position = new Vector3()
                {
                    x = startPosition.x + direction * Sensitivity,
                    y = startPosition.y,
                    z = startPosition.z
                };

                break;
        }



    }

    private void FixedUpdate()
    {
    }

    public enum ButtonType
    {
        Button,
        Trigger,
        Joystick
    }
}
