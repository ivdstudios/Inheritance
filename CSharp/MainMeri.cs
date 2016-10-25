using UnityEngine;
using System.Collections;

public class MainMeri : MonoBehaviour {


	void Start()
	{
		Beta chotaBeta = new Beta();	

		Papa chotePapa = new Papa(); 
		Papa badePapa = new Papa(); 

		print("Chote papa ki salary " + chotePapa.salary); 
		print("Bade papa ki salary " + badePapa.salary); 

		badePapa.PapaIncSalary(); 
		print("Bade papa ki salary " + badePapa.salary); 

	}
}
