using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffOrOnObject : MonoBehaviour
{
    public GameObject Object3D;
    private void OnMouseDown()
    {
        if (Object3D.activeSelf == false)
            Object3D.SetActive(true);
        else
            Object3D.SetActive(false);
    }
}
