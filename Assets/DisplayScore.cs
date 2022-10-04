using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public Var score;
    TextMeshProUGUI text;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        score.value = 0;
    }
    private void Update()
    {
        text.text = score.value.ToString() + "/8";
    }
}
