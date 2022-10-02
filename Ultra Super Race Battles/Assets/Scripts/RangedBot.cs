using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedBot : MonoBehaviour
{
    [SerializeField]
    public int healthMax = 3;
    public int attack = 1;
    public GameObject healthBar;

    private int healthCur;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.Slider.MaxValue = healthMax;
        healthCur = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthCur <= 0)
        {
            Destroy(this);
        }
    }

}
