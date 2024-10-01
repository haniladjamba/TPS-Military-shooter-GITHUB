using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotationControler : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    private Vector3 lastMousePosition;
    private bool isDragging = false;

    void Update()
    {
        //detect input
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastMousePosition = Input.mousePosition;
        }

        //detect if mouse is released
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            RotatePlayer();
        }
    }

    private void RotatePlayer()
    {
        //calculate the different between last and current mouse position
        Vector3 currentMousePositon = Input.mousePosition;
        float deltaX = currentMousePositon.x - lastMousePosition.x;

        //rotate the player on the Y axis based on the mouse drag;
        transform.Rotate(0, -deltaX * rotationSpeed * Time.deltaTime, 0);

        //update the last mouse positon for the next frame
        lastMousePosition = currentMousePositon;
    }
}
