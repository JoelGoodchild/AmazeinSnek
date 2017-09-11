using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

//Class used to allow the player to move.  As the player is a ball, this class is called Roll.
public class Roll : MonoBehaviour
{
    void Awake(){} //DELIBERATLY LEFT EMPTY

    //Called every frame to check what the player has input, and how to update the players position.
    void Update()
    {
        //Gets the x transformation based on the players input on the horizontal axis on the given platform.
        var x = CrossPlatformInputManager.GetAxis("Horizontal") * Time.deltaTime * 20.0f;
        //Gets the z transformation based on the players input on the horizontal axis on the given platform.
        var z = CrossPlatformInputManager.GetAxis("Vertical") * Time.deltaTime * 20.0f;

        //Translates the players x axis, changing their vertical transformation.
        transform.Translate(0, 0, x);
        //Translates the players z axis, changing their vertical transformation.
        //Negative value used to mirror the direction input as positive will move the player in the opposite direction.
        transform.Translate(-z, 0, 0);
    }
}
