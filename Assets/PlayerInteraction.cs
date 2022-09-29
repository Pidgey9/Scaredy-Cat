using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour, IUsable
{
    public float maxDistance;
    IUsable target;
    public Transform cameraTransform;
    public Image crossHair;
    private void Awake()
    {
        crossHair = GameObject.Find("CrossHair").GetComponent<Image>();
    }
    private void Update()
    {
        FindTarget();
        UseTarget();
        ChangeCrossHairState();
    }
    void FindTarget()
    {
        RaycastHit hit;
        if (Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit, maxDistance))
        {
            //target;
            //Debug.Log(hit.collider.gameObject + " hi");
        }
        else target = null;
    }
    public void UseTarget()
    {
        
    }
    public void Use()
    {

    }
    void ChangeCrossHairState()
    {
        crossHair.color = Color.yellow;
    }
}
