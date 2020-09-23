using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private float speed = 15.0f;
    private float rotationSpeed = 45.0f;
    private float verticalInput;
    private float horizontalInput;

    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        // Tryingsomething out here
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * horizontalInput * Time.deltaTime);

       
    }
}
//Examples of the car
//transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
//transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * verticalInput);