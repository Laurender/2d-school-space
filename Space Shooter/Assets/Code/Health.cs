using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceShooter
{
	public class Health : MonoBehaviour, IHealth 
	{
		private int currentHealth; //"backing field" of CurrentHealth
		public int CurrentHealth //The property CurrentHealth
		{
			get{return currentHealth;}
		}

		[SerializeField]
		private int startHealth; //starting health
		[SerializeField]
		private int minHealth; //minimum health
		[SerializeField]
		private int maxHealth; //maximum health

		private void Start()
		{
			currentHealth = startHealth; //at the creation of object, set health to defined start value
		}

		public void IncreaseHealth(int amount)
		{
			if ((currentHealth + amount) > maxHealth) //if new health would be more than the maximum
			{
				currentHealth = maxHealth; //set health to maximum
			} 
			else //else if new health would be less or equal to maximum
			{
				currentHealth += amount; //add amount to current health
			}
		}

		public void DecreaseHealth(int amount)
		{
			currentHealth -= amount; //lower current health by amount

			//if health now less than zero, die. not part of assingnment, so probably added in next class.
		}
	}
}