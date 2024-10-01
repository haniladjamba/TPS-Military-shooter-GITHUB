using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkinLoader : MonoBehaviour
{
    [Header("Player")]
    public Renderer playerRenderer; // Reference to the player's renderer.

    [Header("Skin Data")]
    public SkinData skinData; // Reference to the ScriptableObject.

    void Start()
    {
        // Check if there is a selected skin
        if (skinData.selectedSkin != null)
        {
            // Apply the selected skin to the player
            playerRenderer.material = skinData.selectedSkin;
        }
    }
}
