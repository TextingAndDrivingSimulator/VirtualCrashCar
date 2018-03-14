using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAlongWaypoints : MonoBehaviour {
	public GameObject objectToBeMoved;

	private Transform waypointToMoveGameObjectTo;	

	public Transform[] waypoints;

	public float speed = 1.0F;
	private float startTime;
	private float journeyLength;
	private int currentWaypointIndex = 0;
	void Start() {
		startNewInterpolation ();
	}

	void Update() {
		updateCurrentInterpolation ();
		startNewInterpolationIfOldIsDone ();
	}

	void startNewInterpolation() {
		waypointToMoveGameObjectTo = waypoints [currentWaypointIndex];
		startTime = Time.time;
		journeyLength = Vector3.Distance(objectToBeMoved.transform.position, waypointToMoveGameObjectTo.position);
	}

	float getFracJourney() {
		float distCovered = (Time.time - startTime) * speed;
		float fracJourney = distCovered / journeyLength;
		return fracJourney;
	}


	// Currently on check position, ignore rotation!
	public float moveToNextWayPointWhenThisClose;
	bool isInterpolationDone() {
		return ((objectToBeMoved.transform.position - waypointToMoveGameObjectTo.position).sqrMagnitude < moveToNextWayPointWhenThisClose);
	}

	void updateCurrentInterpolation() {
	
		float fracJourney = getFracJourney ();
		objectToBeMoved.transform.position = Vector3.Lerp(objectToBeMoved.transform.position, waypointToMoveGameObjectTo.position, fracJourney);
		objectToBeMoved.transform.rotation = Quaternion.Lerp (objectToBeMoved.transform.rotation, waypointToMoveGameObjectTo.rotation, fracJourney);
	}

	void startNewInterpolationIfOldIsDone () {
		if (isInterpolationDone()) {
			// use .99 to handle float rounding errors.
			// Then set the current waypoint to be the next on the list, and start a new interpolation!
			++currentWaypointIndex;
			currentWaypointIndex %= waypoints.Length;
			startNewInterpolation();

		}
			
	}
}
