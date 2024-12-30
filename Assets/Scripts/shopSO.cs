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
    public int SUPERAEMOR { get => superArmor; set => superArmor = value; }
    public int RECOVERYPOTION { get => recoveryPotion; set => recoveryPotion = value; }
    public int POWERPOTION { get => powerPotion; set => powerPotion = value; }
    public int MAGICPOTION { get => magicPotion; set => magicPotion = value; }
    public int BOOK { get => book; set => book = value; }
}

