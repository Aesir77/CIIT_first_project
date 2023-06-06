using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame : MonoBehaviour
{
    public TextMeshProUGUI storyTextMeshPro, HealthTextMeshPro, StaminaTextMeshPro;
    public string storyText;
    public int Hp, St;
    public GameObject Level_1_Choices,Level_2_Choices, In_Game, Main_Menu;
    // Start is called before the first frame update
    void Start()
    {
        In_Game.SetActive(false);
        Level_2_Choices.SetActive(false);
        storyText = "Generic Title";

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
    public void Next()
    {
        storyText = "You got woken up by strong winds, accompanied by wolf howls, and a voice calling out your\r\nname. You don't know if the voice was from the dream or if it was real, so you decide to try to go\r\nback to sleep when suddenly, you heard your name get called out again. Rising from the sleeping\r\nbag, you look around your surroundings and notice only the grass and trees moving and nothing\r\nelse. You decide to go back to your sleep, but then, you heard your voice get called again. You\r\nswiftly looked in the direction of the voice and saw a figure move quickly past the woods. You\r\ndecide to -";
    }
    public void start()
    {
        In_Game.SetActive(true);
        Main_Menu.SetActive(false);

    }

    public void Exit()
    {
        Application.Quit();
    }
    
}
