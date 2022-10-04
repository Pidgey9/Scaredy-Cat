using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    public Var score;
    private void Update()
    {
        if (score.value >= 8) SceneManager.LoadScene(3);
    }
}
