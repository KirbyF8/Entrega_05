using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Movement : MonoBehaviour
{
    Plane_Propeller_Rotation plane_Propeller_Rotation_script;
    [SerializeField] private float speed = 9.5f;
    [SerializeField] private float lateralSpeed = 92.5f;
    private bool win;
    // [SerializeField] private Vector3 offset = new Vector3 (0, 4.1f, 0.6f);
    private float horizontalInput;
    private float verticalInput;

    // Update is called once per frame
    private void Start()
    {
        plane_Propeller_Rotation_script = FindObjectOfType<Plane_Propeller_Rotation>();
    }


    void Update()
    {

        if (transform.position.z > 250 && win)
        {
            win = false;

            Debug.Log("You Win");
            speed = 0; lateralSpeed = 0;

        }
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            speed = speed * 2;
            plane_Propeller_Rotation_script.PropellerSpeed = plane_Propeller_Rotation_script.PropellerSpeed * 2;
            Debug.Log("Aumentando la Velocidad");
        }


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // camera.transform.position = transform.position + offset;

        transform.Translate(new Vector3(0, 0, ((speed * 2) * Time.deltaTime)));

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
            plane_Propeller_Rotation_script.PropellerSpeed = plane_Propeller_Rotation_script.PropellerSpeed * 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = speed / 2;
            plane_Propeller_Rotation_script.PropellerSpeed = plane_Propeller_Rotation_script.PropellerSpeed / 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = speed / 2;
            plane_Propeller_Rotation_script.PropellerSpeed = plane_Propeller_Rotation_script.PropellerSpeed / 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = speed * 2;
            plane_Propeller_Rotation_script.PropellerSpeed = plane_Propeller_Rotation_script.PropellerSpeed * 2;
        }


        if (verticalInput < 0)
        {
            transform.Rotate(-verticalInput * lateralSpeed * Time.deltaTime, 0, 0);

        }
        if (verticalInput > 0)
        {
            transform.Rotate(-verticalInput * lateralSpeed * Time.deltaTime, 0, 0);

        }

        if (horizontalInput < 0)
        {
            transform.Rotate(0, horizontalInput * lateralSpeed * Time.deltaTime, Time.deltaTime * (lateralSpeed / 2));

        }
        if (horizontalInput > 0)
        {
            transform.Rotate(0, horizontalInput * lateralSpeed * Time.deltaTime, Time.deltaTime * (-lateralSpeed / 2));

        }
    }
}

