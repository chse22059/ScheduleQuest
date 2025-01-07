using UnityEngine;

[CreateAssetMenu]
public class shopSO : ScriptableObject
{
    [SerializeField] int herb;
    [SerializeField] int ironSword;
    [SerializeField] int steelSword;
    [SerializeField] int legendSword;
    [SerializeField] int woodShield;
    [SerializeField] int ironShield;
    [SerializeField] int magicShield;
    [SerializeField] int leatherArmor;
    [SerializeField] int ironArmor;
    [SerializeField] int superArmor;
    [SerializeField] int recoveryPotion;
    [SerializeField] int powerPotion;
    [SerializeField] int magicPotion;
    [SerializeField] int book;

    public int HERB { get => herb; set => herb = value; }
    public int IRONSWORD { get => ironSword; set => ironSword = value; }
    public int STEELSWORD { get => steelSword; set => steelSword = value; }
    public int LEGENDSWORD { get => legendSword; set => legendSword = value; }
    public int WOODSHIELD { get => woodShield; set => woodShield = value; }
    public int IRONSHIELD { get => ironShield; set => ironShield = value; }
    public int MAGICSHIELD { get => magicShield; set => magicShield = value; }
    public int LEATHERARMOR{ get => leatherArmor; set => leatherArmor = value; }
    public int IRONARMOR { get => ironArmor; set => ironArmor = value; }
    public int SUPERARMOR { get => superArmor; set => superArmor = value; }
    public int RECOVERYPOTION { get => recoveryPotion; set => recoveryPotion = value; }
    public int POWERPOTION { get => powerPotion; set => powerPotion = value; }
    public int MAGICPOTION { get => magicPotion; set => magicPotion = value; }
    public int BOOK { get => book; set => book = value; }

    public void SaveStatus()
    {
        PlayerPrefs.SetInt("Herb", herb);
        PlayerPrefs.SetInt("ironSword", ironSword);
        PlayerPrefs.SetInt("steelSword", steelSword);
        PlayerPrefs.SetInt("legendSword", legendSword);
        PlayerPrefs.SetInt("woodShield", woodShield);
        PlayerPrefs.SetInt("ironShield", ironShield);
        PlayerPrefs.SetInt("magicShield", magicShield);
        PlayerPrefs.SetInt("leatherArmor", leatherArmor);
        PlayerPrefs.SetInt("ironArmor", ironArmor);
        PlayerPrefs.SetInt("superArmor", superArmor);
        PlayerPrefs.SetInt("recoveryPotion", recoveryPotion);
        PlayerPrefs.SetInt("powerPotion", powerPotion);
        PlayerPrefs.SetInt("magicPotion", magicPotion);
        PlayerPrefs.SetInt("book", book);
        // 他のアイテムも保存
        PlayerPrefs.Save();
    }

    public void LoadStatus()
    {
        herb = PlayerPrefs.GetInt("Herb", herb);
        ironSword = PlayerPrefs.GetInt("ironSword", ironSword);
        steelSword = PlayerPrefs.GetInt("steelSword", steelSword);
        legendSword = PlayerPrefs.GetInt("legendSword", legendSword);
        woodShield = PlayerPrefs.GetInt("woodShield", woodShield);
        ironShield = PlayerPrefs.GetInt("ironShield", ironShield);
        magicShield = PlayerPrefs.GetInt("magicShield", magicShield);
        leatherArmor = PlayerPrefs.GetInt("leatherArmor", leatherArmor);
        ironArmor = PlayerPrefs.GetInt("ironArmor", ironArmor);
        superArmor = PlayerPrefs.GetInt("superArmor", superArmor);
        recoveryPotion = PlayerPrefs.GetInt("recoveryPotion", recoveryPotion);
        powerPotion = PlayerPrefs.GetInt("powerPotion", powerPotion);
        magicPotion = PlayerPrefs.GetInt("magicPotion", magicPotion);
        book = PlayerPrefs.GetInt("book", book);
        // 他のアイテムも読み込み
    }
}

