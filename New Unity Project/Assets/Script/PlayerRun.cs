using UnityEngine;

public class PlayerRun : MonoBehaviour
{
    #region (欄位設定)
    //欄位field(變數)
    //欄位類型 欄位名稱<~~隨意命名   (指定  值)結束
    [Header ("跳躍次數"),Range(1,10)]
    public int jumpcount = 2;
    [Header("跳越高度"),Range(10,200)]
    public int jump = 100;
    [Header("跑速"),Range(1,8)]
    public float speed = 5.5f;
    [Header("是否在地板"),Tooltip("判定角色是否在地上")]
    public bool isground =true;  // true/false;
    [Header("角色名稱")]
    public string dogname = "Cat";

    public Transform cat, cam;
    #endregion


    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
}
