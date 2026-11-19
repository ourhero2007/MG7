using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
// Be a Component attached to the Tree GameObject.
// Contain an ARRAY of all of the Sparrow GameObjects in the Scene (except Sparrow_Start), tunable in the inspector.
// Contain a variable to represent the ‘interaction distance’ of the birds and the player.
// Every frame, loop through the array of birds. Check to see which birds are within the interaction distance, and set their GameObjects to ACTIVE. 

public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private float _interactionDistance;
    [SerializeField] private Bird[] _birds;
    [SerializeField] private Transform _playerTransform;

    private void Update()
    {
        for(int i = 0; i < _birds.Length; i++)
        {
            Bird bird = _birds[i];
            if (Vector3.Distance(bird.transform.position, _playerTransform.position) <= _interactionDistance)
            {
                bird.gameObject.SetActive(true);
                Debug.Log("I am a bird");
            }

        }

    }

}
