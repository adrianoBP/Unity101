using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraView : MonoBehaviour
{
    private Camera camera;

    private Controller LSBScript;
    private Controller RSBScript;

    // Start is called before the first frame update
    void Start()
    {
        camera = GetComponent<Camera>();
        LSBScript = GameObject.Find("LSB").GetComponent<Controller>();
        RSBScript = GameObject.Find("RSB").GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {

        //camera.transform.position = new Vector3(
        //    camera.transform.position.x + (float)(LSBScript.currentXValue * .1),
        //    camera.transform.position.y,
        //    camera.transform.position.z + (float)(LSBScript.currentZValue * .1));

        //camera.transform.rotation = Quaternion.Euler(
        //    camera.transform.rotation.eulerAngles.x + (float)(RSBScript.currentZValue * .3 * -1),
        //    camera.transform.rotation.eulerAngles.y + (float)(RSBScript.currentXValue * .3),
        //    camera.transform.rotation.eulerAngles.z);
    }
}
