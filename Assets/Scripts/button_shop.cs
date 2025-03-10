using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonShop : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI consoleTxt;
    [SerializeField] private TextMeshProUGUI goldTxt;
    public shopSO shop;
    public StatusSO status;
    public Button herb, ironSword, steelSword, legendSword, woodShield, ironShield, magicShield, leatherArmor, ironArmor, superArmor, recoveryPotion, powerPotion, magicPotion, book;

    [System.Serializable]
    public class ShopItem
    {
        public Button button;   // ボタン
        public int price;       // 価格
        public string itemName; // アイテム名
        public System.Action purchaseAction; // 購入時のアクション
    }

    public ShopItem[] shopItems;

    void Start()
    {
        // ステータスをロード
        shop.LoadStatus();
        LoadStatus();
        
        // 所持金テキストを初期化
        UpdateGoldText();

        // ショップアイテムの初期化
        shopItems = new ShopItem[]
        {
            new ShopItem { button = herb, price = 50, itemName = "やくそう", purchaseAction = () => shop.HERB++ },
            new ShopItem { button = ironSword, price = 150, itemName = "鉄の剣", purchaseAction = () => shop.IRONSWORD++ },
            new ShopItem { button = steelSword, price = 500, itemName = "鋼の剣", purchaseAction = () => shop.STEELSWORD++ },
            new ShopItem { button = legendSword, price = 1000, itemName = "伝説の剣", purchaseAction = () => shop.LEGENDSWORD++ },
            new ShopItem { button = woodShield, price = 250, itemName = "木の盾", purchaseAction = () => shop.WOODSHIELD++ },
            new ShopItem { button = ironShield, price = 700, itemName = "鉄の盾", purchaseAction = () => shop.IRONSHIELD++ },
            new ShopItem { button = magicShield, price = 1200, itemName = "マジックシールド", purchaseAction = () => shop.MAGICSHIELD++ },
            new ShopItem { button = leatherArmor, price = 400, itemName = "皮の防具", purchaseAction = () => shop.LEATHERARMOR++ },
            new ShopItem { button = ironArmor, price = 1000, itemName = "鉄の防具", purchaseAction = () => shop.IRONARMOR++ },
            new ShopItem { button = superArmor, price = 3500, itemName = "スーパーアーマー", purchaseAction = () => shop.SUPERARMOR++ },
            new ShopItem { button = recoveryPotion, price = 300, itemName = "回復のポーション", purchaseAction = () => shop.RECOVERYPOTION++ },
            new ShopItem { button = powerPotion, price = 300, itemName = "力のポーション", purchaseAction = () => shop.POWERPOTION++ },
            new ShopItem { button = magicPotion, price = 300, itemName = "魔法のポーション", purchaseAction = () => shop.MAGICPOTION++ },
            new ShopItem { button = book, price = 2000, itemName = "古代の指南書", purchaseAction = () => shop.BOOK++ },
        };

        foreach (var item in shopItems)
        {
            item.button.onClick.AddListener(() => PurchaseItem(item));
        }
    }

    private void PurchaseItem(ShopItem item)
    {
        if (status.GOLD >= item.price)
        {
            status.GOLD -= item.price;
            item.purchaseAction?.Invoke();
            consoleTxt.text = $"{item.itemName} を購入しました！";
            
            // 所持金テキストを更新
            UpdateGoldText();

            // ステータスを保存
            shop.SaveStatus();
            SaveStatus();
        }
        else
        {
            consoleTxt.text = "お金が足りません！";
        }
    }
    
    private void UpdateGoldText()
    {
        goldTxt.text = $"所持金: {status.GOLD}G";
    }
    private void SaveStatus(){
        PlayerPrefs.SetInt("Gold", status.GOLD);
        PlayerPrefs.Save();
    }

    private void LoadStatus(){
        status.GOLD = PlayerPrefs.GetInt("Gold", status.GOLD);
    }
}


