using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch_movment : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
	public Animator ch_animator;

    // Update is called once per frame
    void Update()
    {
		ch_animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
		Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
		transform.position = transform.position + horizontal * Time.deltaTime;
		Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
		transform.position = transform.position + vertical * Time.deltaTime;
	}
}
