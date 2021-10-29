using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Text text;
    public GameObject menu;
    public int maxUpgrade;
    public TowerShoot[] gunnos;
    public float damagePerUpgrade;
    public float curentTurrentDamage;
    private bool togled;
    private int amountOfUpgrades;
    public int money;
    public TextMeshProUGUI moneyText, towerText, towerUpgradeCostText;
    public int moneyAddAmountPerUpgrade;
    private int currentUpgradeCost;
    private void Start()
    {
        currentUpgradeCost = moneyAddAmountPerUpgrade;
        moneyText.text = "Money : " + money.ToString();
        towerText.text = "Tower damage : " + curentTurrentDamage.ToString();
        towerUpgradeCostText.text = "Tower upgrade cost : " + currentUpgradeCost.ToString();
    }
    public void TogleMenu()
    {
        togled =! togled;

        menu.SetActive(togled);
    }
    public void UpgradeTowers()
    {
        if (currentUpgradeCost <= money)
        {
            money -= currentUpgradeCost;
            curentTurrentDamage += damagePerUpgrade;
            currentUpgradeCost += moneyAddAmountPerUpgrade;
            moneyText.text = "Money : " + money.ToString();
            towerText.text = "Tower damage : " + curentTurrentDamage.ToString();
            towerUpgradeCostText.text = "Tower upgrade cost : " + currentUpgradeCost.ToString();
            for (int i = 0; i < gunnos.Length; i++)
            {
                gunnos[i].damage = curentTurrentDamage;
            }
            
        }
    }
    public void CloseThis()
    {
        menu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TogleMenu();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(0);
        }
    }
    public void AddMoney(int add)
    {
        money += add;
        moneyText.text = "Money : " + money.ToString();
    }
}
