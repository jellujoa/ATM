using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UserData userData;

    public Text userNameText;
    public Text cashText;
    public Text bankBalanceText;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }
    public void Start()
    {
        userData = new UserData("이찬", 100000, 50000);
        userNameText.text = userData.userName;
        cashText.text = userData.cash.ToString("N0"); // 쉼표 포함
        bankBalanceText.text = userData.bankBalance.ToString("N0");

        RefreshUI();
        // UI 갱신

    }
    public void Update()
    {
        RefreshUI();// UI 갱신
    }
    public void RefreshUI()
    {
        if (userNameText != null)
            userNameText.text = userData.userName;
        if (cashText != null)
            cashText.text = userData.cash.ToString("N0"); // 쉼표 포함
        if (bankBalanceText != null)
            bankBalanceText.text = userData.bankBalance.ToString("N0");
    }
}
