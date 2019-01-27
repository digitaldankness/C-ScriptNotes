
//this file won't make sence this is my study guide
//this is more for me to have a copy and paste for referance
//guide for my future use.
//the #regions uses notepad++ to minimise the tabs
//in each tab there is a sample code to refer to 

 
#region namespace
//namespace region: decleration of codes to referance
using UnityEngine;
using System.Collections;

public class whatC#scriptdose : MonoBehaviour

#end region	
#region decleration of variables	
	//public variables can use anywhere
	public int intname = 5;
	//int is a whole number
	public float floatname = 5.5f; //the f needs to be at the end of the number
	//float is any number that has a decimal point for precission
	public bool boolname = false;
	//bools can only be true or false default is true
	
	
	//public GameObject gameObjectName;
	//game object referance to game
	
	//public OutsideClassName newClassName;
	//use this for getting outside variables
	//outsidesideClassName.Getcomponent<functions>().functionToRun();
	
	//private variables only available in this script
	private string name = "name";
	
	char charName = 'a'; //only one letter
	double doubleName = 8907237409.09; //not as precise as decimal
	decimal decimalName = 3204908.90302894039048; //most precise
	
#endregion		
#region awake	
	//willcall even if script isnt running, starts this when game starts
	void awake()
	{
		
		
	}
#endregion
#region start script	
	//calls this only once when the script starts
	void start()
	{
		outsideGameObjectToRefference = GameObject.FindGameObjectWithTag('ObjectInGameWorld");
		//brings in outside referances at start
	}
	
#endregion	
#region update script	
	//calls this once perframe
	void update()
	{
	}		

#endregion
#region ontrigger
	void OnTriggerEnter(enterName)
	{
		//this is for entering a trigger point
		
		)

	void OnTriggerExit(exitName)
	{
		//on exit of trigger point
		
	}
	
	Void OnTriggerStay(stayName)
	{
		//if you stay in trigger point
		
	}
#endregion
#endregion
#region if statements		
		//check variables
		if ()
		{
			
			//nesting codes within, to only run when all peramiters are met
			if ()
			{	
			}
			
		}
		
		//need more variables
		else if ()
		{
		}	

		// if nothing else matches those peramiters run this
		else  ()
		{	
		}
#endreigon	
#region input
		if (input.GetKeyDown(KeyCode.A)) { 
		//cant change just for defined input 
		}
		
		if (Input.GetButtonDown("buttonName")){
		//when the button is all the way down, only once
		}
		if (Input.GetButton("buttonName")){}
		//this is when the key is toggled for extended periods of time
		
		If (Input.GetButtonUp("buttonName")){}
		//when button is all the way up , only once

		//button input style needs to go to edit, project settings, input
		//and make key controls match
		
	
#endregion
#region realplayercontrols
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	//speed = player.speed //signification into getting this info from player class
	int speed = XXX; // speed variable needs to be defined where xxx is
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
#endregion
#region triggerEventGameObject

public GameObject objectInGameRefrenceName;

void OnTriggerEnter(Colider other)
{
	if (other.CompareTag(player"))
	{
		//set game object active when player touches it
		objectInGameReferenceName.SetActive(false);
		//this.gameObject.SetActive(false);second way to write it
		//This make it so when you hit a trigger you can bring it back cause you dont 
		//destroy the object.
		
	}
	
}



#endregion
#region methods
variableToChange.method(); // this allows access to all the preset methods 
	string.length(); //will give the number of spaces in string container
	string.Contains("whatItNeedsToContain"); //checks to see if it contains a value, will return true or false
	string[index#];
	string.IndexOf(); //checks for a value and will return the index number
		//test
		// stringName.Contains("level3") will return if level 3 exsists
		//string.IndexOf("level3" tells us where level 3 index starts
		//if i have this right then you would add the letter numbers contained in level3
		// and then your next lines could be what info u need
		//later im sure i will find out how to use between braces after that line 
		//to get longer lines of code
		
	string.Substring();	
	
#endregion
#region array
// stores large chunks of data in on folder to be acessed
//they seperate the data with commas and the index number is based
// on each comma not each space



#endregion
#region math methods
Math.Method //it uses known math methods without having 
//to write out each line of code to exicute the code




#endregion
#region return
static int()
{
	
	return // this will return a value when the function was called
}




#endregion
#region switch statements
switch(variableToCheck)
{
	case 0: //checks if this is in the variable
	ChangeableVariable = newChangeDesired //since this variable
	//exsists do this
	break; //breaks out of the method we are running
	case 1: //next option to check
	ChangeableVariable = newChangeDesired //if this is right run this
	break; //breaks out but you dont need this if you want it to keep 
	//gong through multiple things but once done with the statement you must break
}

#endregion
#region while loops
float health = 0;//declairing the variable health for this to function
do //this will finction before the while loop
{
	Console.WriteLine(health); //displays health
	//satandard while loop
}while (health < 100)  //while health is lower then 100 run this
{
	health ++ .1 //add .1 health to health for the simple health 
	//regeneration code

}

#endregion
#region for loops
for(declare the counter; condition that needs to be met to acomidate the counter to stop; how much to modify the variable each loop)
{
	//run this code
	//similar to while loops
}






#endregion

	}
}


//again this is just for reffrence and notes not for use
//Daniel McConnell