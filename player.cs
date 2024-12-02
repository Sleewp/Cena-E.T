using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class player : MonoBehaviour
{
    public float speed;
    public float lateralSpeed;
    public float maxSpeed;
    public float acceleration;
    private Quaternion defaultRotation;
    private Vector3 defaultPosition;
    public float speedReduction;

    // Start is called before the first frame update
    void Start()
    {
        defaultRotation = transform.rotation;
        defaultPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        increaseSpeed();
        movePlayer();
    }

    private void movePlayer()
    {
        // movimento para frente contínuo
        Vector3 forwardMovement = -Vector3.forward * speed * Time.deltaTime;

        float horizontalInput = Input.GetAxis("Horizontal");
        float adjustedLateralSpeed = lateralSpeed * (1 + speed / maxSpeed);
        Vector3 lateralMovement = -Vector3.right * horizontalInput * adjustedLateralSpeed * Time.deltaTime;

        transform.Translate(forwardMovement + lateralMovement);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Agent"))
        {
            resetPosition();
        }
    }

    public void resetPosition()
    {
        transform.position = defaultPosition; // A posição inicial do jogador
        transform.rotation = defaultRotation;         // A rotação original
        speed = 25;
    }

    private void increaseSpeed()
    {
        if (speed < maxSpeed)
        {
            speed += acceleration * Time.deltaTime;
        }
        else
        {
            speed = maxSpeed;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("bateu");
            reduceSpeed();
        }
    }
    private void reduceSpeed()
    {
        speed *= speedReduction;
    }
}
