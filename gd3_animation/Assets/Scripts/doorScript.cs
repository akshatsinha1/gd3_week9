using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class doorScript : MonoBehaviour
{
    public Transform player;
    private Animator _anim;
    public GameObject tooltip;

    public float triggerDistance = 10;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Vector3.Distance(transform.position, player.position) < triggerDistance)
        {
            tooltip.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                _anim.SetBool("isDoorOpen", !_anim.GetBool("isDoorOpen"));

            }
        }
        else
        {
            tooltip.SetActive(true);

        }
    }
}


