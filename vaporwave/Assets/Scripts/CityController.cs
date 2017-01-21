using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityController : MonoBehaviour {

    [SerializeField]
    private int hp, maxHp;

    [SerializeField]
    private Sprite hp75, hp50, hp25, hp0;
    private SpriteRenderer sr;

    void Start() {
        maxHp = 100;
        hp = maxHp;
        sr = GetComponent<SpriteRenderer>();    
        }

    void ChangeCitySprite(Sprite citySprite) {
        sr.sprite = citySprite;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            hp--;
            print(hp + "\n");
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 75) {
            ChangeCitySprite(hp75);
        }
        if (hp <= 50) {
            ChangeCitySprite(hp50);
        }
        if (hp <= 25) {
            ChangeCitySprite(hp25);
        } 
        if (hp <= 0) {
            ChangeCitySprite(hp0);
        }
    }

}
