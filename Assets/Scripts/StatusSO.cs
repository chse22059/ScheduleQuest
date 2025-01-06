using UnityEngine;

[CreateAssetMenu]
public class StatusSO : ScriptableObject
{
    [SerializeField] int hp;
    [SerializeField] int mp;
    [SerializeField] int atk;
    [SerializeField] int equip;
    [SerializeField] int gold;

    public int HP { get => hp; set => hp = value; }
    public int MP { get => mp; set => mp = value; }
    public int ATK { get => atk; set => atk = value; }
    public int EQUIP { get => equip; set => equip = value; }
    public int GOLD { get => gold; set => gold = value; }

    // ó‘Ô‚ğ•Û‘¶
    public void SaveStatus()
    {
        PlayerPrefs.SetInt("HP", hp);
        PlayerPrefs.SetInt("MP", mp);
        PlayerPrefs.SetInt("ATK", atk);
        PlayerPrefs.SetInt("EQUIP", equip);
        PlayerPrefs.SetInt("Gold", gold);
        PlayerPrefs.Save();
    }

    // ó‘Ô‚ğƒ[ƒh
    public void LoadStatus()
    {
        hp = PlayerPrefs.GetInt("HP", hp);
        mp = PlayerPrefs.GetInt("MP", mp);
        atk = PlayerPrefs.GetInt("ATK", atk);
        equip = PlayerPrefs.GetInt("EQUIP", equip);
        gold = PlayerPrefs.GetInt("Gold", gold);
    }
}
