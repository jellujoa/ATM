using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    public Button Deposit;
    public Button Withdraw;
    public Button Back;
    public Button Back2;
    
    public GameObject ATM;
    public GameObject DepositUI;  
    public GameObject WithdrawUI;
    
    public void Start()
    {      
        Back.onClick.AddListener(OnBackButtonClick);
        Back2.onClick.AddListener(OnBackButtonClick);
        Deposit.onClick.AddListener(OnDepositButtonClick);
        Withdraw.onClick.AddListener(OnWithdrawButtonClick);
    }
    public void OnDepositButtonClick()
    {
       ATM.SetActive(false);
       DepositUI.SetActive(true);
    }
    public void OnWithdrawButtonClick()
    {
        ATM.SetActive(false);
        WithdrawUI.SetActive(true);
    }
    public void OnBackButtonClick()
    {
        ATM.SetActive(true);
        DepositUI.SetActive(false);
        WithdrawUI.SetActive(false);
    }
    public void OnBack2ButtonClick()
    {
        ATM.SetActive(true);
        DepositUI.SetActive(false);
        WithdrawUI.SetActive(false);
    }
    
}
