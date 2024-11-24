using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    public float speed;
    public float lateralSpeed;
    public float maxSpeed;
    public float Acceleration;
    public Vector3 position;
    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    private void movePlayer()
    {
        // movimento para frente contínuo
        Vector3 forwardMovement = -Vector3.forward * speed * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 lateralMovement = -Vector3.right * horizontalInput * lateralSpeed * Time.deltaTime;

        transform.Translate(forwardMovement + lateralMovement);
    }

    private void resetPosition()
    {

    }
}
