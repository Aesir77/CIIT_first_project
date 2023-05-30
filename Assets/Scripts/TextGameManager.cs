using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HealthTextMeshPro, StaminaTextMeshPro;
    public string storyText;
    public int Hp, St;
    public GameObject Level_1_Choices,Level_2_Choices;
    // Start is called before the first frame update
    void Start()
    {
        Level_2_Choices.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        storyTextMeshPro.text = storyText;
        HealthTextMeshPro.text = Hp.ToString();
        StaminaTextMeshPro.text = St.ToString();
    }
    public void Rebels()
        {
        storyText = "You chose the Light side of the Force \n You gain +5 Health";
        Hp += 5;
        Level_1_Choices.SetActive(false);
        Level_2_Choices.SetActive(true);
        }
    public void Republic()
    {
        storyText = "You chose the Republic? Really? \n You lose 1 Health";
        Hp -= 1;
        if (Hp == 0)
        {
            storyText = "Game Over";
            Level_1_Choices.SetActive(false);
        }
    }
    public void Empire()
    {
        storyText = "You chose the Dark side of the Force \n  You gain +5 Stamina ";
        St += 5;
    }
    
}
