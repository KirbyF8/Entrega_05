using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane_Propeller_Rotation : MonoBehaviour
{

    public float PropellerSpeed = 25f;
    
    void Update()
    {
        transform.Rotate(0, 0, PropellerSpeed * PropellerSpeed * Time.deltaTime);

    }
}
