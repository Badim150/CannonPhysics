using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public Rigidbody ball;
	public Transform target;
    public GameObject cannon;

	public float h = 25;
	public float gravity = -18;

	public bool debugPath;
    private bool isShooting = false;

	void Start() {
		ball.useGravity = false;
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Space)) {
            isShooting = true;
			Launch ();
		}

		if (debugPath && !isShooting) {
			DrawPath ();
		}
	}

	void Launch() {
		Physics.gravity = Vector3.up * gravity;
		ball.useGravity = true;
		ball.velocity = CalculateLaunchData ().initialVelocity;
	}

	LaunchData CalculateLaunchData() {
		float displacementY = target.position.y - ball.position.y;
		Vector3 displacementXZ = new Vector3 (target.position.x - ball.position.x, 0, target.position.z - ball.position.z);
		float time = Mathf.Sqrt(-2*h/gravity) + Mathf.Sqrt(2*(displacementY - h)/gravity);
		Vector3 velocityY = Vector3.up * Mathf.Sqrt (-2 * gravity * h);
		Vector3 velocityXZ = displacementXZ / time;

		return new LaunchData(velocityXZ + velocityY * -Mathf.Sign(gravity), time);
	}

	void DrawPath() {
		LaunchData launchData = CalculateLaunchData ();
		Vector3 previousDrawPoint = ball.position;

        Vector3 firstPos = new Vector3();
		int resolution = 30;
		for (int i = 1; i <= resolution; i++) {
			float simulationTime = i / (float)resolution * launchData.timeToTarget;
			Vector3 displacement = launchData.initialVelocity * simulationTime + Vector3.up *gravity * simulationTime * simulationTime / 2f;
			Vector3 drawPoint = ball.position + displacement;
			Debug.DrawLine (previousDrawPoint, drawPoint, Color.green);
			previousDrawPoint = drawPoint;

            if (i == 2) firstPos = drawPoint;
            if (i == 5 && !isShooting)
            {
                Vector3 newVector = drawPoint - firstPos;

                var rotation = Quaternion.LookRotation(newVector); 
                cannon.transform.rotation = Quaternion.Slerp(cannon.transform.rotation, rotation, Time.deltaTime);
            }
		}
	}

	struct LaunchData {
		public readonly Vector3 initialVelocity;
		public readonly float timeToTarget;

		public LaunchData (Vector3 initialVelocity, float timeToTarget)
		{
			this.initialVelocity = initialVelocity;
			this.timeToTarget = timeToTarget;
		}
		
	}
}
	