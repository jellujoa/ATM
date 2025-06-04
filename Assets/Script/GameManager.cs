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
        userData.userNameText = userNameText;
        userData.cashText = cashText;
        userData.bankBalanceText = bankBalanceText;

         userData.RefreshUI();
        // UI 갱신

    }
    public void Update()
    {
        userData.RefreshUI();
    }

}
