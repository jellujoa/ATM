using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupBank : MonoBehaviour
{
    public Button Deposit;
    public Button Withdraw;
    
    public void Start()
    {
        // 버튼 클릭 이벤트 등록
        Deposit.onClick.AddListener(OnDepositButtonClick);
        Withdraw.onClick.AddListener(OnWithdrawButtonClick);
    }
    public void OnDepositButtonClick()
    {
       
    }
    public void OnWithdrawButtonClick()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
