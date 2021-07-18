using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game;
using TMPro; 

namespace VolcanicPig.Mobile.Ui
{
    public class StartMenu : Menu
    {
        [SerializeField]  private TextMeshProUGUI titleText; 
        
        public void StartGamePressed()
        {
            GameManager.Instance.StartGame();
        }

        public override void OnMenuOpened()
        {
            base.OnMenuOpened();
            if(titleText) titleText.text = $"Level {GameManager.Instance.Level}"; 
        }
    }
}
