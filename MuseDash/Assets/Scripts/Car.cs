using UnityEngine;

public class Car : MonoBehaviour
{
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
}
