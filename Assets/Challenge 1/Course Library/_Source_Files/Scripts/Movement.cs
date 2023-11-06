using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] private float speed = 9.5f;
    [SerializeField] private float lateralSpeed = 92.5f;
    private bool win;
    // [SerializeField] private Vector3 offset = new Vector3 (0, 4.1f, 0.6f);
    private float horizontalInput;
    private float verticalInput;
    
    // Update is called once per frame
    void Update()
    {
        



        if (transform.position.z > 250 && win)
        {
            win = false;

            Debug.Log("You Win");
            speed = 0; lateralSpeed = 0;

        }

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
       
        // camera.transform.position = transform.position + offset;

        transform.Translate(new Vector3(0, 0, ((speed * 2) * Time.deltaTime)));

        while (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = speed * 2;
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


