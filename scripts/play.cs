using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public GameObject game;
    public GameObject menu;
    public GameObject buttoons;
   public void plaay()
    {

        game.SetActive(true);
        menu.SetActive(false);
        buttoons.SetActive(true);

    }
}
