using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusWindowManager : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;

    [SerializeField] TextMeshProUGUI HPValue;
    [SerializeField] TextMeshProUGUI MPValue;
    [SerializeField] TextMeshProUGUI ATKValue;
    [SerializeField] TextMeshProUGUI EQUIPValue;
    [SerializeField] TextMeshProUGUI GOLDValue;

    void Start()
    {
        statusSO.LoadStatus();
    }

    void Update()
    {
        HPValue.GetComponent<TextMeshProUGUI>().text = statusSO.HP.ToString();
        MPValue.GetComponent<TextMeshProUGUI>().text = statusSO.MP.ToString();
        ATKValue.GetComponent<TextMeshProUGUI>().text = statusSO.ATK.ToString();
        EQUIPValue.GetComponent<TextMeshProUGUI>().text = statusSO.EQUIP.ToString();
        GOLDValue.GetComponent<TextMeshProUGUI>().text = statusSO.GOLD.ToString();
    }
}

