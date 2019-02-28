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
    // Start is called before the first frame update
    void Start()
    {
        str.text = "15";
        intel.text = "15";
        agil.text = "15";
        characterProperty.isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        hpbar.fillAmount = characterProperty.characterHP;
        mpbar.fillAmount = characterProperty.characterMP;
        if (hpbar.fillAmount == 0f)
        {
            characterProperty.isDead = true;
        }
    }
}
