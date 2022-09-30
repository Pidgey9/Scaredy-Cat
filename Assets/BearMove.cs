using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class BearMove : MonoBehaviour
{
    Vector3 dir;
    Transform playerTransform;
    Rigidbody rb;
    Animator animator;
    public float speed;
    public Quaternion orientation;
    public float dist;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerTransform = GameObject.Find("Player").transform;
    }
    private void Update()
    {
        dir = (playerTransform.position - transform.position).normalized;
        orientation = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, orientation, 360);
    }
    private void FixedUpdate()
    {
        rb.velocity = dir * speed * Time.fixedDeltaTime;
        if (rb.velocity == Vector3.zero)
        {
            animator.SetBool("Idle", true);
            animator.SetBool("Run Forward", false);
        }
        else
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Run Forward", true);
        }
    }
}
