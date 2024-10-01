using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInSelection : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed = 10f;

    void Update()
    {
        // Rotate the character around the Y-axis for a 360-degree view
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
