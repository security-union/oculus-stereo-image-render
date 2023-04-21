# oculus-stereo-image-render

## TLDR
Using two cameras, one attached to each eye, and using layers to filter what each eye can see is another way to achieve the same result of displaying different images on each eye in an Oculus XR Unity app. 

### Left Eye Camera
![Screen Shot 2023-04-21 at 3 10 10 PM](https://user-images.githubusercontent.com/1176339/233716152-a1860f51-9f67-4cc8-bc15-d1be54126c72.png)

### Right Eye Camera
![Screen Shot 2023-04-21 at 3 10 13 PM](https://user-images.githubusercontent.com/1176339/233716138-656d00b3-8bf1-42d4-8560-8f2af9c58b43.png)

Here's how you can do it:

 
## What I built

1. Add two cameras to the scene, one for the left eye and one for the right eye. You can do this by creating two game objects and attaching a Camera component to each of them.
2. Set the "Target Eye" property of each camera to "Left" and "Right", respectively.
3. Create two render textures (one for each eye) by going to Assets > Create > Render Texture.
4. Attach the left eye render texture to the left eye camera by adding it to the camera's "Target Texture" field.
5. Attach the right eye render texture to the right eye camera by adding it to the camera's "Target Texture" field.
6. Create two game objects and attach a material with the image you want to display on each eye to each of them.
7. Assign a layer to each of the game objects by going to the Inspector window, selecting the game object, and setting the "Layer" property to the desired layer.
8. Create two new cameras (one for each eye) and set their "Culling Mask" property to the layer that corresponds to the image you want to display on that eye.
9. Position the two new cameras in front of each eye, so that they can see the game objects with the corresponding layer.
10. Build and run the app on your Oculus device to see the images displayed on each eye.

With these steps, you should be able to create an Oculus XR Unity app that displays different images on each eye using two cameras and layers.

## License
This project is licensed under the MIT License. See the LICENSE file for details.

## Acknowledgments
This project was inspired by the Oculus XR SDK documentation and the Unity documentation. Special thanks to the creators of these resources for providing valuable guidance and insights.
