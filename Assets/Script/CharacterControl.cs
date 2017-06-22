using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
	float moveSpeed=5f;
	Rigidbody m_rigidbody;

	// Use this for initialization
	void Start ()
	{
		//gameObject.GetComponent<Animator> ().applyRootMotion = true;
		m_rigidbody=gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void Move (float h, float v, bool[] skillPress)
	{
		m_Move (h, v);
	}

	void m_Move (float h, float v)
	{
		Vector3 m_direct = Vector3.right * h + Vector3.forward * v;
		if (m_direct.magnitude > 1f) {
			m_direct = m_direct.normalized;
		}
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3 (moveSpeed * m_direct.x, gameObject.GetComponent<Rigidbody>().velocity.y, moveSpeed * m_direct.z);
	}
}
