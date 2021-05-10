
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    private void Start()
    {   //開始事件
        //使用靜態API
        //屬性
        //可以取得Get、可以設定Set
        //如果看到 Read Only只能取得
        //1.取得靜待的屬性
        //語法:類別.靜態屬性
        print("隨機:" + Random.value);
        // 2.設定靜態的屬性
        //語法:類別.靜態屬性 指定 直;
        Cursor.visible = false;
        //方法
        //3. 使用靜態的方法
        //語法:類別.靜態方法(對應的參數);
        int r = Random.Range(50, 150);
        print("隨機攻擊力:" + r);

        print("所有攝影機數量" + Camera.allCamerasCount);
        print("2D的重力大小" + Physics2D.gravity);

        Physics2D.gravity = new Vector2(0, -20);
        print("2D" + Physics2D.gravity);



    }
    private void Update()
    {
        print("是否輸入任意鍵" + Input.anyKeyDown);
        //print("遊戲時間" + Time.timeSinceLevelLoad);

    }
}
