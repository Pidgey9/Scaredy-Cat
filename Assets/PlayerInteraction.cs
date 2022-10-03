using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public float maxDistance;
    IUsable target;
    public Transform cameraTransform;
    public Image crossHair;
    bool colorChange;
    private void Awake()
    {
        crossHair = GameObject.Find("CrossHair").GetComponent<Image>();
        colorChange = false;
    }
    private void Update()
    {
        FindTarget();
        if (Input.GetButtonDown("Fire1") && target != null) UseTarget();
        ChangeCrossHairState();
    }
    void FindTarget()
    {
        RaycastHit hit;
        Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, maxDistance);
        if (hit.collider != null && hit.collider.gameObject.TryGetComponent(out IUsable iinterface) == true)
        {
            target = iinterface;
            //Debug.Log(hit.collider.gameObject + " hi");
        }
        else target = null;
    }
    public void UseTarget()
    {
        target.Use();
        colorChange = true;
    }
    void ChangeCrossHairState()
    {
        if (colorChange) crossHair.color = Color.red;
    }
}
