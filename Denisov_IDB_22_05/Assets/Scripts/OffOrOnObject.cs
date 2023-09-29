using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class OffOrOnObject : MonoBehaviour
{
    public GameObject Object3D;
    private void OnMouseDown()
    {
        Object3D.SetActive(!Object3D.activeSelf);
        GetComponentInChildren<Text>().text = Object3D.activeSelf ? "Выключить " + Object3D.name : "Включить " + Object3D.name;
    }
}
