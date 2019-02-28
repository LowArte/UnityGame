using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterBARS : MonoBehaviour
{
    public Image hpbar;
    public Image mpbar;
    public Text str;
    public Text intel;
    public Text agil;

    public PlayerProperty characterProperty;
    // Update is called once per frame
    public void BarDraw()
    {
        str.text = characterProperty.strength.ToString();
        intel.text = characterProperty.intelege.ToString();
        agil.text = characterProperty.agility.ToString();

        hpbar.fillAmount = characterProperty.characterHP;
        mpbar.fillAmount = characterProperty.characterMP;
        if (hpbar.fillAmount == 0f)
        {
            characterProperty.isDead = true;
        }
    }
}
