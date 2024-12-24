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
}
