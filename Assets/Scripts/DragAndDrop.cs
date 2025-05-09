using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    Vector3 mousePosition;

    private Vector3 GetMousePos(){
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown(){
        GetComponent<AudioSource>().Play();
        mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag(){
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
}