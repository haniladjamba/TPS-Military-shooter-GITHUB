using UnityEngine;
using UnityEngine.UI;

using LightDev;
using LightDev.UI;
using TMPro;

namespace TPSShooter.UI.Menu
{
  public class WeaponChoose : CanvasElement
  {
    [Header("References")]
    public Text infoText;

    [Header("Weapons")]
    public GameObject[] weapons;

    [Header("Skins")]
    public Material[] skins;

    [Header("Player")]
    public Renderer player;

    [Header("Skin Data")]
    public SkinData skinData;

    [Header("Skin Data")]
    public SkinInfo[] skinInfo;

    [Header("Description")]
    public TextMeshProUGUI SkinDescription;

    private int weaponIndex;
    private int skinIndex;
    private int skinInfoIndex;

    public override void Subscribe()
    {
      Events.RequestMenuWeapon += Show;
    }

    public override void Unsubscribe()
    {
      Events.RequestMenuWeapon -= Show;
    }

    protected override void OnStartShowing()
    {
      UpdateInfo();
    }

    public void OnBack()
    {
      Events.MenuClickSound.Call();
      Events.RequestMenu.Call();
      Hide();
    }

    public void OnPlay()
    {
      Events.MenuClickSound.Call();
      Events.RequestMenuLocation.Call();
      skinData.selectedSkin = skins[skinIndex];
      Hide();
    }

    public void OnNext()
    {
      //weaponIndex++;
      skinIndex++;
      skinInfoIndex++;

      //weaponIndex = (weaponIndex == weapons.Length) ? 0 : weaponIndex;
      skinIndex = (skinIndex== skins.Length) ? 0 : skinIndex;
      skinInfoIndex = (skinInfoIndex == skinInfo.Length) ? 0 : skinInfoIndex;
      UpdateInfo();
      Events.MenuClickSound.Call();
    }

    public void OnPrevious()
    {
      //weaponIndex--;
      skinIndex--;
      skinInfoIndex--;
      //weaponIndex = (weaponIndex == -1) ? weapons.Length - 1 : weaponIndex;
      skinIndex = (skinIndex == -1) ? skins.Length -1 : skinIndex;
      skinInfoIndex = (skinInfoIndex == -1) ? skinInfo.Length -1 : skinInfoIndex;
      UpdateInfo();
      Events.MenuClickSound.Call();
    }

    private void UpdateInfo()
    {
            infoText.text = skinInfo[skinInfoIndex].name;
            SkinDescription.text = skinInfo[skinInfoIndex].description;
            //SaveLoad.WeaponTag = weapons[weaponIndex].tag;
            for (int i = 0; i < skins.Length; i++)
            {
                //weapons[i].SetActive((i == weaponIndex) ? true : false);
                player.material = skins[skinIndex];
            }
    }
  }
}
