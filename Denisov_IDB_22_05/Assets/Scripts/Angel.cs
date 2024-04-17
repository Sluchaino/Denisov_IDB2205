using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Angel : MonoBehaviour
{
    public Text score;
    public void FunkMaxAngel()
    {
        score.text = Convert.ToString(Convert.ToInt32(score.text) + 1);
    }

    public void FunkMinAngel()
    {
        score.text = Convert.ToString(Convert.ToInt32(score.text) + 1);
    }
}