using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class UserData 
{
    
    public string userName;
    public int cash;
    public int bankBalance;

    [HideInInspector]
    public Text userNameText;
    [HideInInspector]
    public Text cashText;
    [HideInInspector]
    public Text bankBalanceText;

    public UserData(string userName, int cash, int bankBalance)
    {
        this.userName = userName;
        this.cash = cash;
        this.bankBalance = bankBalance;
    }

    public void RefreshUI() 
    {
        if (userNameText != null)
            userNameText.text =  userName;
        if (cashText != null)
            cashText.text = cash.ToString("N0"); // 쉼표 포함
        if (bankBalanceText != null)
            bankBalanceText.text = bankBalance.ToString("N0");
    }
}
