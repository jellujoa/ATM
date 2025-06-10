using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;   

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public UserData userData;

    public Text userNameText;
    public Text cashText;
    public Text bankBalanceText;

    public GameObject Error;

    private string filePath;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        string directoryPath = Application.persistentDataPath + "/Saves"; // Saves 폴더 경로
        if (!Directory.Exists(directoryPath)) // 폴더가 없으면 생성
        {
            Directory.CreateDirectory(directoryPath);
        }

        filePath = directoryPath + "/userData.json"; // 저장할 파일 경로
    }

    public void Start()
    {
        if (File.Exists(filePath))
        {
            LoadUserData();
        }
        else
        {
            userData = new UserData("이찬", 100000, 50000);
        }

       
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
    public void DepositToBank(int amount)
    {
        if(userData.cash >= amount)
        {
            userData.cash -= amount;
            userData.bankBalance += amount;
            RefreshUI();
            SaveUserData();
        }
        else
        {
            Error.SetActive(true); // 잔액 부족 시 에러 메시지 표시
        }
    }
    public void WithdrawFromBank(int amount)
    {
        if (userData.bankBalance >= amount)
        {
            userData.bankBalance -= amount;  // 은행 잔액 차감
            userData.cash += amount;  // 현금 추가
            RefreshUI();  // UI 갱신
            SaveUserData();
        }
        else
        {
            Error.SetActive(true); // 잔액 부족 시 에러 메시지 표시
        }
    }
    public void SaveUserData()
    {
        string json = JsonUtility.ToJson(userData);
        File.WriteAllText(filePath, json);
       
    }

    // JSON 파일에서 UserData를 불러오는 메서드
    public void LoadUserData()
    {
        string json = File.ReadAllText(filePath);
        userData = JsonUtility.FromJson<UserData>(json);
      
    }
}
