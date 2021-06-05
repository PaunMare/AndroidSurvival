using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Audio;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    protected FixedJoystick joystick;
    protected Joybutton joybutton;
    public Rigidbody2D rb;
    public float moveSpeed;
    protected bool shoot;
    public Transform shootingPosition;
    public GameObject bulletPrefab;
    public static int score = 0;
    public AudioSource audioSource;
    public Text Enemy, timer;
    int currentHealth;
    public int maxHp = 5;
    public Image gameOver,victory;
    public Transform bar;
    GameObject[] enemies;
    private void Awake()
    {
        Screen.orientation = ScreenOrientation.Landscape;
    }
    private void Start()
    {
        currentHealth = maxHp;
        joystick = FindObjectOfType<FixedJoystick>();
        joybutton = FindObjectOfType<Joybutton>();
        gameOver.enabled = false;
        victory.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            currentHealth--;
            SetLocalScale(currentHealth/(float)maxHp);
        }
    }
    void Update()
    {
        if (currentHealth == 0)
        {
            gameOver.enabled = true;
            int enemies = int.Parse(Enemy.text);
            int time = int.Parse(timer.text);
            int score = enemies + time;
            PlayerPrefs.SetInt("score", score);
            Invoke("LoadScene", 2f);
        }
        InvokeRepeating("CheckForVictory", 210f, 10f);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(3);
    }
    public void SetLocalScale(float sizeNormalized)
    {
        if(currentHealth >= 0)
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }
    private void FixedUpdate()
    {
        
        rb.velocity = new Vector2(joystick.Horizontal * moveSpeed * Time.fixedDeltaTime, joystick.Vertical * moveSpeed * Time.fixedDeltaTime);
        Vector3 moveVector = (Vector3.up *joystick.Horizontal + Vector3.left * joystick.Vertical);
        if(!shoot && joybutton.pressed)
        {
            shoot = true;
            Shoot();
        }
        if(shoot && !joybutton.pressed)
        {
            shoot = false;
        }
        if(joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
        }
        void Shoot()
        {
            Instantiate(bulletPrefab, shootingPosition.position, shootingPosition.rotation);
            audioSource.Play();
        }
    }
    public void CheckForVictory()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if(enemies.Length == 0)
        {
            victory.enabled = true;
            int enemies = int.Parse(Enemy.text);
            int time = int.Parse(timer.text);
            int score = enemies + time;
            PlayerPrefs.SetInt("score", score);
            Invoke("LoadVictory", 2f);
        }
    }
    public void LoadVictory()
    {
        SceneManager.LoadScene(4);
    }
}
