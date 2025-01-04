using UnityEngine;


[CreateAssetMenu]
public class StatusEnemySO : ScriptableObject
{
    [SerializeField] int hp;
    [SerializeField] string battleInfo;
    [SerializeField] int atk;
    [SerializeField] int killedCount;
    [SerializeField] string stage;
    [SerializeField] int monsterId;
    [SerializeField] int atkPlayerTemp;
    [SerializeField] int equipPlayerTemp;
    

    public int HP { get => hp; set => hp = value; }
    public string BattleInfo { get => battleInfo; set => battleInfo = value; }
    public int ATK { get => atk; set => atk = value; }
    public int KilledCount {get => killedCount; set => killedCount = value; }
    public string STAGE {get => stage; set => stage = value; }
    public int MonsterId { get => monsterId; set => monsterId = value; }
    public int ATKPlayerTemp {get => atkPlayerTemp; set => atkPlayerTemp = value; }
    public int EquipPlayerTemp {get => equipPlayerTemp; set => equipPlayerTemp = value; }
}
