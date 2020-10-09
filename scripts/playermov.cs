using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;


public class playermov : MonoBehaviour
{

    protected Joystick joystick;    //ジョイスティック
    public GameObject pauseMenuUI2; // 一時停止・再開やメニュー インタフェース
    public GameObject pauseMenuUI3;
    public GameObject pauseMenuUI4;
    public GameObject pauseMenuUI5;

    public float speed;            //速度
    public Text countText;         //キューブ数テキスト
    public Text winText;           //勝テキスト
    public Text timer;             //タイマー テキスト
    public Button parar3;          //ブレーキ
    public Rigidbody rb;           //プレーヤー
    public int count;              //キューブ数

    float currentTime = 0f;        //タイマー
    float startingTime = 100f;     //初期タイマー
    public Text countdown;         //残りタイマー

    void Start()                   //パラメーター初期化
    {
        joystick = FindObjectOfType<Joystick>();   
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
        currentTime = startingTime;
    }

    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            parar();                                            //ブレーキ
        }

        currentTime -= 1 * Time.deltaTime;
        countdown.text = "TIME:" + currentTime.ToString("0.0"); //タイマー

        if (currentTime <= 0)
        {
            currentTime = 0;
        }

    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce(movement * speed);                          //移動
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))              //キューブ収集
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = " COUNT: " + count.ToString();  //キューブ数
        if (count >= 10)                                //勝条件
        {
            winText.text = "YOU WIN";                   //勝インタフェース
            pauseMenuUI2.SetActive(true);
            pauseMenuUI3.SetActive(false);
            pauseMenuUI4.SetActive(false);
            pauseMenuUI5.SetActive(true);
            Time.timeScale = 0f;

        }
    }

    public void parar()                                   //ブレーキ
    {
        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }

}