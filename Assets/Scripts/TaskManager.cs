using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    // UI要素を宣言
    public Text taskListText;       // タスク一覧を表示するテキスト
    public InputField taskInputField; // タスクを入力するフィールド
    public Button addTaskButton;   // タスク追加ボタン

    private string taskList = "";  // タスクのリストを保持する変数

    void Start()
    {
        // ボタンにクリックイベントを登録
        addTaskButton.onClick.AddListener(AddTask);
    }

    // タスクを追加するメソッド
    void AddTask()
    {
        string newTask = taskInputField.text; // 入力欄の内容を取得
        if (!string.IsNullOrEmpty(newTask))  // 入力が空でないか確認
        {
            taskList += newTask + "\n";      // タスクをリストに追加
            taskListText.text = taskList;   // テキストに反映
            taskInputField.text = "";       // 入力欄をクリア
        }
    }
}
