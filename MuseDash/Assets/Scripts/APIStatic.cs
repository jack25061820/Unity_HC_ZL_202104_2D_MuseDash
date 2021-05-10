
using UnityEngine;

public class APIStatic : MonoBehaviour
{
    private void Start()
    {
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

    }
}
