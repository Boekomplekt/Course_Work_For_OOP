using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float hp = 1;
    public float speed = 3f;
    public Scrollbar Scrollbarhp;
    [SerializeField] public GameObject Panel;
    [SerializeField] private int coins;
    [SerializeField] private Text CoinText;
    [SerializeField] private Score scoreScript;
    [SerializeField] private AudioSource coinAudio;
    [SerializeField] private AudioSource wrenchAudio;
    [SerializeField] private AudioSource crashAudio;
    [SerializeField] private AudioSource loseAudio;
    public GameObject pauseButton;
    void Start() 
    {
        
        Panel.SetActive(false);
        Scrollbarhp.size = hp;
        Time.timeScale = 1;
        coins = PlayerPrefs.GetInt("coins");
        CoinText.text = coins.ToString();
    }
    void Update()
    {   

        if(Input.touchCount > 0)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
        }


        float hor = Input.GetAxisRaw("Horizontal");

       Vector3 dir = new Vector3(hor, 0, 0);
       transform.Translate(dir.normalized*Time.deltaTime * speed);


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Car")
        {   crashAudio.Play();
            hp -= 0.2f;
            Scrollbarhp.size = hp;

            if (hp < 0.1f)
            {
                Panel.SetActive(true);
                int LastRunScore = int.Parse(scoreScript.scoreText.text.ToString());
                PlayerPrefs.SetInt("LastRunScore", LastRunScore);
                loseAudio.Play();
                Time.timeScale = 0;
                pauseButton.SetActive(false);


            }
        }
        if (other.gameObject.tag == "Coin")
        {   coinAudio.Play();
            coins = coins + 1;
            PlayerPrefs.SetInt("coins",coins);
            CoinText.text = coins.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "heal")
        {   wrenchAudio.Play(); 
            hp = 1;
            Scrollbarhp.size = hp;
            Destroy(other.gameObject);
        }

        

    }
    public void menu()
    {
        SceneManager.LoadScene(0);
    }

}
