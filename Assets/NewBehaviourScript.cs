using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject player, firework;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Cube")
        {
            player.GetComponent<FirstPersonController>().slowSpeed();
            points += 10;
            GameObject fireworkObj = (GameObject)Instantiate(firework, collision.collider.transform.position, collision.collider.transform.rotation);
            fireworkObj.SetActive(true);
            Destroy(collision.collider.gameObject);
            new WaitForSeconds(3);
            Destroy(fireworkObj);
        }
        else { }
    }
}
