using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using TunnelGame;
using UnityEngine;
using YG;
using YG.Example;

public class AdsReward : MonoBehaviour
{
    public YandexGame sdk;

    // ������������� �� ������� �������� ������� � OnEnable
    private void OnEnable()
    {
        YandexGame.RewardVideoEvent += Reward;
    }

    // ������������ �� ������� �������� ������� � OnDisable
    private void OnDisable()
    {
        YandexGame.RewardVideoEvent -= Reward;
    }

    public void AdButton()
    {
        YandexGame.RewVideoShow(0);
    }
    public void OpenFullScrAd()
    {
        sdk._FullscreenShow();
    }
    public void Reward(int i)
    {
        if (i == 0)
        {
            GameManager.Instance.DropsCollected += 11;
        }
    }
}
