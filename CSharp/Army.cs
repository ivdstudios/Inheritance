using UnityEngine;
using System.Collections;

public class Army : MonoBehaviour {

	public class Attackers
	{
		protected int health;
	}


	public class Barbarian: Attackers
	{
		public Barbarian()
		{
			health = 3; 
		}
	}


	public class Gaint: Attackers
	{
		public Gaint()
		{
			health = 10; 
		}
	}

	public class Dragon: Attackers
	{
		public Dragon()
		{
			health = 9; 
		}
	}


}
