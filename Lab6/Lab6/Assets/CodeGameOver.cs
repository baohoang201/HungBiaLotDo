using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CodeGameOver : MonoBehaviour
{
    public Text pointsText;
   public void Setup(int score)
    {
        gameObject.SetActive(true);
        //pointsText.text = score.ToString()+"Gloo";
    }
    public void RestertButton()
    {
        SceneManager.LoadScene("Game");
    }
}
