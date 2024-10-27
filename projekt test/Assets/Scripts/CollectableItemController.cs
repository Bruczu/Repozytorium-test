using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectableItemController : MonoBehaviour
{
    public PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localEulerAngles.y = new Vector3(transform transform.localEulerAngles.y + 20 * Time.deltaTime;
    }
    //private void OnTriggerStay(Collider other)
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player");
        {
            
            //playerController.zebranePunkty = playerController.zebranePunkty + 1;
            playerController.zebranePunkty++;
            Debug.Log("Zebrane punkty: " + playerController.zebranePunkty);

            Destroy(this.gameObject);
        }
    }
}