using UnityEngine;
using System.Collections;

public class Papa : MonoBehaviour {

	public int salary = 2343; 
	protected int jadat = 10000;

	public Papa()
	{
		
		print("Mera bhi object bana"); 
	}

	public void PapaIncSalary()
	{
		this.salary++; 
	}
}

public class Beta: Papa
{
	public Beta(){
		print("Beta ke object bana"); 
	}
}
