using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OnTriger : MonoBehaviour
{
    public Text text;
    public int Number = 20;
    private void Start()
    {
        text.text = Convert.ToString(Number);
    }
    private void OnTriggerEnter(Collider other)
    {
        Number--;
        text.text = Convert.ToString(Number);
    }
}
