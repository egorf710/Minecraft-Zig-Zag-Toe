using System;
using System.Collections;
using System.Collections.Generic;
using TunnelGame;
using Unity.VisualScripting;
using UnityEngine;
using YG;

public class CloudSave : MonoBehaviour
{
    public AudioSource audioSource;
    public GameManager gameManager;
    public YandexGame sdk;

    private void Start()
    {
        if(YandexGame.SDKEnabled)
        {

            LoadSaveCloud();
        }
    }
    public void OnEnable() => YandexGame.GetDataEvent += LoadSaveCloud;
    public void OnDisable() => YandexGame.GetDataEvent -= LoadSaveCloud;

    private void LoadSaveCloud()
    {
        gameManager.CurrentPlayerIndex = YandexGame.savesData.CurrentPlayerIndex;
        gameManager.HighScore = YandexGame.savesData.HighScore;
        gameManager.AverageScore = YandexGame.savesData.AverageScore;
        gameManager.TimesPlayed = YandexGame.savesData.TimesPlayed;
        gameManager.DropsCollected = YandexGame.savesData.DropsCollected;
        gameManager.UnlockedPlayerInfos = YandexGame.savesData.UnlockedPlayerInfos;
    }
    public void Save()
    {
        YandexGame.savesData.CurrentPlayerIndex = gameManager.CurrentPlayerIndex;
        YandexGame.savesData.HighScore = gameManager.HighScore;
        YandexGame.savesData.AverageScore = gameManager.AverageScore;
        YandexGame.savesData.TimesPlayed = gameManager.TimesPlayed;
        YandexGame.savesData.DropsCollected = gameManager.DropsCollected;
        YandexGame.savesData.UnlockedPlayerInfos = gameManager.UnlockedPlayerInfos;
        print("SAVE\n" + YandexGame.savesData.HighScore);
        YandexGame.SaveProgress();

    }
}
