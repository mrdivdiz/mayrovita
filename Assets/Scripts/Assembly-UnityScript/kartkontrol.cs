using System;
using UnityEngine;

[Serializable]
public class kartkontrol : MonoBehaviour
{
	public float maxspeed;

	public float acceleration;

	public float rotationSpeed;

	[NonSerialized]
	public static bool AI;

	public Transform[] AIwaypoints;

	public int CurrentWaypoint;

	public float AIspeed;

	private int laps;

	public GameObject charactermodel;

	public Material mayro;

	public Material luggy;

	public Material joshy;

	public void Start()
	{
		if (GameVars.Player1Character == 0)
		{
			charactermodel.GetComponent<Renderer>().material = mayro;
		}
		if (GameVars.Player1Character == 1)
		{
			charactermodel.GetComponent<Renderer>().material = luggy;
		}
		if (GameVars.Player1Character == 2)
		{
			charactermodel.GetComponent<Renderer>().material = joshy;
		}
	}

	public void passing()
	{
		laps++;
		GameObject.Find("gamecontroller").SendMessage("passed", laps);
	}

	public void Update()
	{
		if (AI)
		{
			GetComponent<Rigidbody>().isKinematic = true;
			if (transform.position == AIwaypoints[CurrentWaypoint].position)
			{
				if (CurrentWaypoint < AIwaypoints.Length - 1)
				{
					CurrentWaypoint++;
				}
				else
				{
					CurrentWaypoint = 0;
				}
			}
			transform.LookAt(AIwaypoints[CurrentWaypoint]);
			transform.position = Vector3.MoveTowards(transform.position, AIwaypoints[CurrentWaypoint].position, AIspeed * Time.deltaTime);
		}
		GetComponent<AudioSource>().pitch = 0.01f * GetComponent<Rigidbody>().velocity.magnitude + 0.5f;
	}

	public void FixedUpdate()
	{
		if (Input.GetAxis("Vertical") != 0f)
		{
			GetComponent<Rigidbody>().AddForce(transform.forward * Input.GetAxis("Vertical") * acceleration);
		}
		float yAngle = Input.GetAxis("Horizontal") * rotationSpeed;
		transform.Rotate(0f, yAngle, 0f);
		if (Input.GetButton("Jump"))
		{
			GetComponent<Rigidbody>().velocity = Vector3.zero;
		}
	}
}
