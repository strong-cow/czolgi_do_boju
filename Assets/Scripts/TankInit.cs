using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankInit : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite blueSprite;
    public Sprite redSprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetColor(string color)
    {
        print("Setting color to " + color);

        switch (color)
        {
            case "Blue":
                spriteRenderer.sprite = blueSprite;
                break;
            case "Red":
                spriteRenderer.sprite = redSprite;
                break;
            default:
                print("Color " + color + " is not allowed error!");
                break;
        }
        
    }
}
