using UnityEngine;
using System;
using System.Xml.Serialization;

public class MouseWorld : MonoBehaviour
{
    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit hit);
        Debug.Log(hit.point);
    }
}

public class MoveObject : MonoBehaviour
{
    
}