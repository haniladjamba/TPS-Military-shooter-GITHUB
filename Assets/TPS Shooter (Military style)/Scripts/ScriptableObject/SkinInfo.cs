using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SelectedSkinData", menuName = "Game Data/Selected Skin Data/Skin information")]
public class SkinInfo : ScriptableObject
{
    public string name;

    [TextArea(16,4)]
    public string description;
}
