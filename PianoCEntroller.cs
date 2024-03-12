using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PianoCEntroller : MonoBehaviour
{
    private AudioSource _do, _re, _fa, _mi, _sol, _si, _la;
    // Start is called before the first frame update
    void Start()
    {
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("Re").GetComponent<AudioSource>();
        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _sol = GameObject.FindWithTag("sol").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.D))
        {
            
            _do.Play();
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            
            _re.Play();
        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            
            _fa.Play();
        }
        if (Input.GetKeyUp(KeyCode.M))
        {
            
            _mi.Play();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            
            _sol.Play();
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            
            _si.Play();
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            
            _la.Play();
        }
    }
}
