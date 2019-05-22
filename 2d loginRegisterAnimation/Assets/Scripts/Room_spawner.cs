using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_spawner : MonoBehaviour
{
	public int openingDirection;
	


	private RoomTemplates templates;
	private int rand;
	public bool spawned = false;
	

	void Start()
	{
		templates = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomTemplates>();
		Invoke("Spawn",1.0f);
	}

	void Spawn()
	{
		if (spawned == false)
		{
			if (openingDirection == 1)
			{
				rand = Random.Range(0, templates.bottonRooms.Length);
				Instantiate(templates.bottonRooms[rand], transform.position, templates.bottonRooms[rand].transform.rotation);
			}
			else if (openingDirection == 2)
			{
				rand = Random.Range(0, templates.topRooms.Length);
				Instantiate(templates.topRooms[rand], transform.position, templates.topRooms[rand].transform.rotation);
			}
			else if (openingDirection == 3)
			{
				rand = Random.Range(0, templates.leftRooms.Length);
				Instantiate(templates.leftRooms[rand], transform.position, templates.leftRooms[rand].transform.rotation);
			}
			else if (openingDirection == 4)
			{
				rand = Random.Range(0, templates.rightRooms.Length);
				Instantiate(templates.rightRooms[rand], transform.position, templates.rightRooms[rand].transform.rotation);
			}
			spawned = true;
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.CompareTag("SpawnPoint")&& other.GetComponent<Room_spawner>().spawned ==true)
		{
			//Destroy(gameObject);
		}
	}
	


}
