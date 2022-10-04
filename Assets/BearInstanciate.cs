using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class BearInstanciate : MonoBehaviour
{
    public Var score;
    public GameObject bear;
    public Var spawn;
    private void Awake()
    {
        spawn.value = 0;
    }
    private void Update()
    {
        Vector3 areaSpawn = new Vector3(1000 * Random.value, 2, 1000 * Random.value);
        if (spawn.value != 0)
        {
            Instantiate(bear, areaSpawn, Quaternion.identity);
            spawn.value = 0;
        }
    }
}
