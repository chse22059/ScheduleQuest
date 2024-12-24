using UnityEngine;
using UnityEngine.UI;

public class AddStatusButton : MonoBehaviour
{   
    [SerializeField]
    private string statusName;
    public StatusSO status;
    public string StatusName=>statusName;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }
    
    void push() {
        if(StatusName=="hp") {
            status.HP+=1;
        } else if(StatusName=="mp"){
            status.MP+=1;
        } else if(StatusName=="atk"){
            status.ATK+=1;
        } else if(StatusName=="equip"){
            status.EQUIP+=1;
        } else if(StatusName=="gold"){
            status.GOLD+=1;
        } else {
            return;
        }
    } 

    // Update is called once per frame
    void Update()
    {
        
    }
}
