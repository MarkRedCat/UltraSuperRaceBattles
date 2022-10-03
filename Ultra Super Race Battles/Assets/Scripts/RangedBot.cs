using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangedBot : MonoBehaviour
{
    [SerializeField]
    public int healthMax = 3;
    public int attackMin = 1;
    public int attackMax = 2;
    public int healthCur;
    public Slider healthBar;


    // Start is called before the first frame update
    void Start()
    {
        //healthBar.MaxValue = healthMax;
        healthCur = healthMax;
        healthBar.maxValue = healthMax;
        //healthBar.Transform.Position(-1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (healthCur <= 0)
        {
            Destroy(this);
        }

        if(Input.GetKeyDown( KeyCode.Space))
        {
          this.RecieveDamage(1);
        }
    }

    public void RecieveDamage( int damage )
    {
        healthCur -= damage;
        healthBar.value = healthCur;
    }
}
