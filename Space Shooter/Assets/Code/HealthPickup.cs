using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class HealthPickup : MonoBehaviour {

		[SerializeField]
		private int _healthHealed = 20;
		[SerializeField]
		private float _lifetime = 5.0f;
		[SerializeField]
		private float _speed;

		private Rigidbody2D _rigidbody;
		private Vector2 _direction;

		protected virtual void Awake () {
			
			_rigidbody = GetComponent<Rigidbody2D>();

			if (_rigidbody == null)
			{
				Debug.LogError("No Rigidbody2D component was found from the GameObject");
			}
		}
		
		// Update is called once per frame
		protected void Update () {
			
		}
	}
}