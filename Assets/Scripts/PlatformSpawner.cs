//using UnityEngine;

//public class PlatformSpawner : MonoBehaviour
//{
//    public GameObject platformPrefab; // The prefab for your platforms (cylinders)
//    public float radius = 2f; // Radius of the circle where the platforms will be positioned
//    public int numPlatformsPerLevel = 12; // Number of platforms on each level
//    public int numLevels = 5; // Number of descending levels of platforms
//    public float platformWidth = 0.5f; // Width of each platform (cylinder's X scale)
//    public float platformHeight = 0.03f; // Height of each platform (cylinder's Y scale)
//    public float levelHeight = 1f; // Height between each level of platforms
//    public float rotationSpeed = 100f; // Speed of rotation for the base

//    private float currentRotation = 0f; // Current rotation of the base

//    // Update is called once per frame
//    void Update()
//    {
//        // Rotate base based on arrow key input
//        if (Input.GetKey(KeyCode.LeftArrow))
//        {
//            RotateBase(-rotationSpeed * Time.deltaTime);
//        }
//        else if (Input.GetKey(KeyCode.RightArrow))
//        {
//            RotateBase(rotationSpeed * Time.deltaTime);
//        }
//    }

//    // Start is called before the first frame update
//    void Start()
//    {
//        // Spawn platforms at different levels
//        SpawnPlatforms();
//    }

//    // Method to spawn platforms at different levels
//    void SpawnPlatforms()
//    {
//        for (int level = 0; level < numLevels; level++)
//        {
//            // Calculate the Y position for this level
//            float yPosition = level * levelHeight;

//            // Randomize the positions of platforms around the base for each level
//            for (int i = 0; i < numPlatformsPerLevel; i++)
//            {
//                // Calculate the angle for each platform
//                float angle = Random.Range(0f, 2f * Mathf.PI); // Random angle for each platform

//                // Calculate the position on the circle (X, Y, Z)
//                float x = Mathf.Cos(angle) * radius;
//                float z = Mathf.Sin(angle) * radius;

//                // Instantiate the platform at the calculated position
//                GameObject platform = Instantiate(platformPrefab, new Vector3(x, yPosition, z), Quaternion.identity);

//                // Optionally, rotate the platform to face outward
//                platform.transform.rotation = Quaternion.LookRotation(new Vector3(x, 0, z));

//                // Scale the platform to fit the desired size
//                platform.transform.localScale = new Vector3(platformWidth, platformHeight, platformWidth);
//            }
//        }
//    }

//    // Method to rotate the base
//    void RotateBase(float amount)
//    {
//        currentRotation += amount;
//        transform.rotation = Quaternion.Euler(0f, currentRotation, 0f); // Rotate around the Y-axis
//    }
//}
