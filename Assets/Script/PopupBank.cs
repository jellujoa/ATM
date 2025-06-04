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
    public Button error;  // 에러 메시지 버튼

    public Button deposit10000;
    public Button deposit30000;
    public Button deposit50000;

    public InputField depositInputField;  // 입금 InputField
    public Button depositCustomAmountButton;  // 커스텀 입금 버튼

    public Button withdraw10000;
    public Button withdraw30000;
    public Button withdraw50000;

    public InputField withdrawInputField;  // 출금 InputField
    public Button withdrawCustomAmountButton;  // 커스텀 출금 버튼 


    public GameObject ATM;
    public GameObject DepositUI;  
    public GameObject WithdrawUI;
    public GameObject Error;  // 에러 메시지 UI

    public GameManager gameManager;
    public void Start()
    {
        deposit10000.onClick.AddListener(() => OnDepositButtonClicked(10000));
        deposit30000.onClick.AddListener(() => OnDepositButtonClicked(30000));        // 입금 금액 
        deposit50000.onClick.AddListener(() => OnDepositButtonClicked(50000));

        depositCustomAmountButton.onClick.AddListener(OnDepositCustomAmountClicked);  // 커스텀 입금 버튼 클릭시

        withdraw10000.onClick.AddListener(() => OnWithdrawButtonClicked(10000));
        withdraw30000.onClick.AddListener(() => OnWithdrawButtonClicked(30000));      // 출금
        withdraw50000.onClick.AddListener(() => OnWithdrawButtonClicked(50000));

        withdrawCustomAmountButton.onClick.AddListener(OnWithdrawCustomAmountClicked); // 커스텀 출금 버튼 

        error.onClick.AddListener(OnerrorButtonClick);
        Back.onClick.AddListener(OnBackButtonClick);
        Back2.onClick.AddListener(OnBackButtonClick);
        Deposit.onClick.AddListener(OnDepositButtonClick);
        Withdraw.onClick.AddListener(OnWithdrawButtonClick);
    }
    public void OnDepositCustomAmountClicked()
    {
        // 입력된 금액을 가져옴
        string inputText = depositInputField.text;

        // 숫자가 아니면!
        if (!int.TryParse(inputText ,out int amount))
        {
            
                Debug.LogError("유효하지 않은 금액입니다.");
                
                return;
          
        }

        // 입금 처리
        gameManager.DepositToBank(amount);

        // 입금 후 UI 갱신
        depositInputField.text = "";  // 입력 필드 초기화
    }
    public void OnDepositButtonClicked(int amount)
    {
        gameManager.DepositToBank(amount);  // 입금 처리
    }
    public void OnWithdrawButtonClicked(int amount)
    {
        gameManager.WithdrawFromBank(amount);  // 출금 처리
    }

    // 사용자 입력 금액 출금
    public void OnWithdrawCustomAmountClicked()
    {
        string inputText = withdrawInputField.text;

        
        if (!int.TryParse(inputText, out int amount))
        {
            Debug.LogError("유효하지 않은 금액입니다.");
           
            return;
        }       
        // 출금 처리
        gameManager.WithdrawFromBank(amount);

        withdrawInputField.text = "";  // 입력 필드 초기화
    }
    public void OnerrorButtonClick()
    {
        Error.SetActive(false); // 에러 메시지 숨김
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
