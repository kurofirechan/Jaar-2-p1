using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float barHealth;
    public Slider slider;
    public GameObject endScreen;
    private void Start()
    {
        slider.minValue = 0;
        slider.maxValue = barHealth;
    }
    public void DoDamage()
    {
        barHealth -= 20;
        if(barHealth <= 0)
        {
            Time.timeScale = 0;
            endScreen.SetActive(true);
            Invoke("LoadMenu", 6.7f);
        }
    }
    void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        slider.value = barHealth;
    }
}
