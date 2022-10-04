using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour, IUsable
{
    public Var score;
    public Var trigger;
    public void Use()
    {
        Destroy(gameObject);
        score.value++;
        trigger.value++;
    }
}
