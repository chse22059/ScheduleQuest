using UnityEngine;

[CreateAssetMenu]
public class GlobalTimerDataSO: ScriptableObject
{
    public int totalEXP = 0;

    public void SaveEXP()
    {
        PlayerPrefs.SetInt("TotalEXP", totalEXP);
        PlayerPrefs.Save();
    }

    public void LoadEXP()
    {
        totalEXP = PlayerPrefs.GetInt("TotalEXP", totalEXP); // デフォルト値を設定
    }
}

