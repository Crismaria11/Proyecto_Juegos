using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reloj : MonoBehaviour
{
    public string nivel2;
    public Text TxtReloj;
    private float countdown = 10;

    // Start is called before the first frame update
    void Start()
    {
        TxtReloj = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        TxtReloj.text = countdown.ToString("Faltan " + "0");
        if (countdown <= 0)
        {
            SceneManager.LoadSceneAsync("MainMenu");
        }
    }




}
