using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public void ChangeShip()
    {
        PlayerScript pScript = FindObjectOfType<PlayerScript>();

        SpriteRenderer playerSprite = pScript.gameObject.GetComponent<SpriteRenderer>();
        playerSprite.sprite = Resources.Load("player_plane", typeof(Sprite)) as Sprite;
    }


    public void StartGame()
    {
        PlayerScript[] playerScripts = FindObjectsOfType<PlayerScript>();

        foreach(PlayerScript ps in playerScripts)
        {
            ps.setDifferentSprite();
        }

        // "Stage1" is the name of the first scene we created.
        Application.LoadLevel("Stage1");
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
