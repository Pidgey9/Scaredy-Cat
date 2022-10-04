using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButton("Fire1")) SceneManager.LoadScene(1);
    }
}
