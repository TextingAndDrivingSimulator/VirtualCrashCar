using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectAlongWaypoints : MonoBehaviour {
	public GameObject objectToBeMoved;

	private Transform waypointToMoveGameObjectTo;	
	private Vector3 startPosition;
	private Quaternion startRotation;
	public bool paused = false;


	public Transform[] waypoints;

	public float delayInSeconds = 0;

	public Transform startAtWaypoint = null;

	public float speed = 1.0F;
	private float timeIntoJourney = 0;
	private float journeyLength;
	private int currentWaypointIndex = 0;
	private bool interpolating = false;
	void Start() {
		// If the start waypoint isn't null, search through the list for our start point and then skip to it!
		if (startAtWaypoint != null) {
			for (int i = 0; i != waypoints.Length; ++i) {
				if (startAtWaypoint ==  (waypoints [i])) {
					Debug.Log ("Found the waypoint!");
					currentWaypointIndex = i;
					break;
				}
			}
		}
		Invoke ("startNewInterpolation", delayInSeconds);
	}


	void Update() {
		if (interpolating) {
			updateCurrentInterpolation ();
			startNewInterpolationIfOldIsDone ();
		}

	}

	void startNewInterpolation() {
		interpolating = true;
		waypointToMoveGameObjectTo = waypoints [currentWaypointIndex];
		timeIntoJourney = 0;
		startPosition = objectToBeMoved.transform.position;
		startRotation = objectToBeMoved.transform.rotation;
		journeyLength = Vector3.Distance(objectToBeMoved.transform.position, waypointToMoveGameObjectTo.position);
	}

	float getFracJourney() {
		float distCovered = (timeIntoJourney) * speed;
		float fracJourney = distCovered / journeyLength;
		return fracJourney;
	}


	// Currently on check position, ignore rotation!
	public float moveToNextWayPointWhenThisClose;
	bool isInterpolationDone() {
		return ((objectToBeMoved.transform.position - waypointToMoveGameObjectTo.position).sqrMagnitude < moveToNextWayPointWhenThisClose);
	}

	void updateCurrentInterpolation() {
		if (!paused) {
			timeIntoJourney += Time.deltaTime;
		}
		float fracJourney = getFracJourney ();
		objectToBeMoved.transform.position = Vector3.Lerp(startPosition, waypointToMoveGameObjectTo.position, fracJourney);
		objectToBeMoved.transform.rotation = Quaternion.Lerp (startRotation, waypointToMoveGameObjectTo.rotation, fracJourney);
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
