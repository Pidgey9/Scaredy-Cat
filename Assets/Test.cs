using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour, IUsable
{
    public void Use()
    {
        Destroy(gameObject);
    }
}
