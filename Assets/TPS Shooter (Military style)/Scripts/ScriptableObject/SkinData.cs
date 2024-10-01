using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SelectedSkinData", menuName = "Game Data/Selected Skin Data")]
public class SkinData : ScriptableObject
{
    public Material selectedSkin; // Store the selected material.
}
