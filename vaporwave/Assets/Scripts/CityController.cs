using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CityController : MonoBehaviour {
	
    //[SerializeField]
	//public int currentHp, maxHp;

	public HealthBar hpBar;
	public GameObject player;
    public SoundGroup Music;


    [SerializeField]
    private Sprite hp75, hp50, hp25, hp0;
    private SpriteRenderer sr;

    void Start() {
        hpBar.maxHp = 100.0f;
		hpBar.currentHp = hpBar.maxHp;	
        sr = GetComponent<SpriteRenderer>();    
	}

    void ChangeCitySprite(Sprite citySprite) {
        sr.sprite = citySprite;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "wave")
        {
			hpBar = hpBar.GetComponent<HealthBar> ();
			hpBar.TakeDamage ();
            Destroy(other.gameObject);
			print (hpBar.currentHp);
			print (hpBar.maxHp);
        }
    }

    // Update is called once per frame
    void Update()
    {
		float hp = hpBar.currentHp;
        if (hp <= 75f) {
            ChangeCitySprite(hp75);
        }
        if (hp <= 50f) {
            ChangeCitySprite(hp50);
        }
        if (hp <= 25f) {
            ChangeCitySprite(hp25);
        } 
        if (hp <= 0f) {
            Music.ForceStop();
            SceneManager.LoadScene("pre-outro");
        }
    }

}
