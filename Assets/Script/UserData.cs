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


    public UserData(string userName, int cash, int bankBalance)
    {
        this.userName = userName;
        this.cash = cash;
        this.bankBalance = bankBalance;
    }

  
}
