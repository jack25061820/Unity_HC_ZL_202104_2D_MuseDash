using UnityEngine;

public class Car : MonoBehaviour
{
    #region 欄位
    // 單行註解 KID 2021.04.28

    /*
     * 多行註解
     * 多行註解
     */

    // 欄位 Field：儲存遊戲的數值
    // 語法：
    // 修飾詞 類型 名稱 指定 預設值 結尾
    // 四個基本類型
    // 整　數：int 儲存正負數值
    // 浮點數：float 儲存正負有小數點的數值
    // 字　串：string 必須用雙引號包覆
    // 布林值：bool 兩種 true、false

    // 私人：不顯示 private (預設)
    // 公開：顯示 public

    // 欄位屬性：放在欄位的前面或上面
    // 語法：
    // [屬性名稱(值)]
    // 標題 Header(字串)
    // 提示 Tooltip(字串)
    // 範圍 Range(最小值，最大值) - 僅限於數值類型 int、float
    [Header("這是汽車的 CC 數")]
    [Tooltip("可以調整汽車 CC 數的多寡")]
    [Range(1000, 5000)]
    public int cc = 2000;
    [Header("汽車重量"), Range(1f, 5f)]
    public float weight = 3.5f;
    public string brand = "賓士";
    public bool openCold = false;

    // 其他類型
    // 顏色 Color
    public Color color;
    public Color red = Color.red;
    public Color yellow = Color.yellow;
    // Color(紅，綠，藍) - 值介於 0 - 1
    public Color color1 = new Color(0.5f, 0.6f, 0);
    // Color(紅，綠，藍，透明度) - 值介於 0 - 1
    public Color color2 = new Color(0, 0.5f, 0.9f, 0.5f);

    // 座標 Vector2 - 4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2my1 = new Vector2(3.5f, 9);

    public Vector3 v3;
    public Vector4 v4;

    // 輸入按鍵 KeyCode
    public KeyCode key;
    public KeyCode a = KeyCode.A;
    public KeyCode mouse = KeyCode.Mouse0;
    public KeyCode joy = KeyCode.Joystick2Button15;

    // 遊戲物件與元件
    public GameObject obj;

    public Transform tra;
    public Camera cam;
    public AudioListener aud;
    #endregion

    #region 方法
    // 欄位語法
    // 修飾詞 類型 名稱 指定 值；

    // 方法 Method - 儲存程式區塊或演算法
    // 語法：
    // 修飾詞 傳回類型 名稱 ( 參數 ) { 程式區塊或演算法 }
    // void 無傳回 - 沒有傳回資料
    // 方法必須被呼叫才會執行
    /// <summary>
    /// KID 05.05
    /// 這是一個會輸出訊息的測試方法
    /// </summary>
    private void Test()
    {
        // 輸出(任何資料)；
        print("我是測試方法");
    }
    // 速度 50、100、150
    // 加上音效
    // 維護性
    private void Drive50()
    {
        print("開車速度：" + 50);
        print("音效");
    }
    private void Drive100()
    {
        print("開車速度：" + 100);
        print("音效");
    }
    private void Drive150()
    {
        print("開車速度：" + 150);
        print("音效");
    }

    // 參數 Paramater 語法：類型 名稱 指定 預設值
    // 有預設值的參數必須寫在最右邊 (選填式參數)
    // 呼叫的時候可以決定參數的值
    // 類型 名稱，類型 名稱，....
    /// <summary>
    /// 開車方法
    /// </summary>
    /// <param name="speed">速度</param>
    /// <param name="sound">音效</param>
    /// <param name="effect">特效</param>
    private void Drive(int speed, string sound = "ㄎㄎㄎ", string effect = "雜質")
    {
        print("開車速度：" + speed);
        print("音效：" + sound);
        print("特效：" + effect);
    }
    #endregion

    #region 事件
    // 事件 Event - 在特定時間點會已指定次數執行 (程式的入口)
    // 開始事件：播放遊戲後會執行一次
    // 應用：初始值，500 塊初始金錢、三條生命等等..
    private void Start()
    {
        // 呼叫方法
        // 方法名稱()；
        Test();
        Drive50();
        // 有幾個參數就要輸入幾個
        Drive(99, "咻咻咻", "灰塵");
        Drive(777, "轟轟轟", "爆炸");

        Drive(10);
        Drive(20, "嘿嘿嘿");
    }
    #endregion
}
