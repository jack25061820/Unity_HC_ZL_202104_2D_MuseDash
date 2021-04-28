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
    public int cc = 2000;
    public float weight = 3.5f;
    public string brand = "賓士";
    public bool openCold = false;
}
