using UnityEngine;
using TMPro;

public class TotalEXPDisplay : MonoBehaviour
{
    public GlobalTimerDataSO GTD;
    public TMP_Text totalCountText;  

    void Update()
    {
        totalCountText.text = GTD.totalEXP.ToString();
    }
}
