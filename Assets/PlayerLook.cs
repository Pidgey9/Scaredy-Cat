using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class PlayerLook : MonoBehaviour
{
    public Vector2 mouseSensitivity, padSensitivity, mouseYLimit;
    float h, v;
    public Transform cameraTransform;
    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity.x * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity.y * Time.deltaTime;
        //float gamepadX = Input.GetAxis("RightHorizontal") * padSensitivity.x * Time.deltaTime;
        //float gamepadY = Input.GetAxis("RightVertical") * padSensitivity.y * Time.deltaTime;
        h += mouseX;
        v += mouseY;
        v = Mathf.Clamp(v, mouseYLimit.x, mouseYLimit.y);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, h, transform.eulerAngles.z);
        cameraTransform.eulerAngles = new Vector3(v, cameraTransform.eulerAngles.y, cameraTransform.eulerAngles.z);
    }
}
