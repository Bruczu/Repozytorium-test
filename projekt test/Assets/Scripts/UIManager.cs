using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public PlayerController playerController;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //text.text = playerController.zebranePunkty + "/" + playerController.maxPunkty;
        text.text = playerController.zebranePunkty.ToString();
        
    }
}
