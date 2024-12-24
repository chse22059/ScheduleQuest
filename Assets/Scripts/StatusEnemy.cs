using UnityEngine;


[CreateAssetMenu]
public class StatusEnemy : ScriptableObject
{
    [SerializeField] int hp;
    //[SerializeField] int atk;
    

    public int HP { get => hp; set => hp = value; }
    //public int ATK { get => atk; set => atk = value; }

}
