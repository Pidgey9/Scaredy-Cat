using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Vector3 move;
    CharacterController characterController;
    Transform cameraTransform;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
        cameraTransform = Camera.main.GetComponent<Transform>();
    }
    private void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 direction = (cameraTransform.right * h) + (cameraTransform.forward * v);
        move = direction * speed * Time.deltaTime;
        characterController.Move(move);
    }
}
