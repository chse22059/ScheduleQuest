using UnityEngine;


[CreateAssetMenu]
public class StatusEnemySO : ScriptableObject
{
    [SerializeField] int hp;
    [SerializeField] string battleInfo;
    [SerializeField] int atk;
    [SerializeField] int killedCount;
    

    public int HP { get => hp; set => hp = value; }
    public string BattleInfo { get => battleInfo; set => battleInfo = value; }
    public int ATK { get => atk; set => atk = value; }
    public int KilledCount {get => killedCount; set => killedCount = value; }
}
