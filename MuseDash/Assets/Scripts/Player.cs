using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("跳躍高度"), Range(0, 3000)]
    public int jump = 100;
    [Header("血量"), Range(0, 2000)]
    public float hp = 500;
    [Header("是否在地板上")]
    public bool isGround = false;

    private int score;
    private AudioClip sound1;
    private AudioClip sound2;
    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;
}
