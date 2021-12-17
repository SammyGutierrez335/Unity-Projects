Steps to creating a Unity VR Project
1- Install any needed Assets or packages from the Unity Asset Store
    - XR Integration Toolkit
2 - Replace standard camera for a XR Rig
    Action Based vs Device Based
        Device Based is great if you want to target only Quest or Quest 2 
        To take advantage of New input system package provides then you should use Action-based XR Rig.
        To take floor level into account, change XR Rig Tracking Origin Mode to Floor
    *XR Interaction Manager will also be created
        It serves as a bridge between Interactors and Interactables
        Ex of Interactors - Hands
        Ex of Interactables - Objects you grab touch (objects or UI)
3 - Set up default controller
    Samples > XR Interaction Toolkit > 1.0.0-pre.8 > Default Input Actions XRI Default Left (and Right) Controller then 'Add to ActionBasedController default
    You can add filters to these controllers under 'Edit > Project Settings > Preset Manager
    You will also need to delete and re add the XR Rig to update the references.
    In the XR Rig Inspector, update the Input Action Manager (script) Action Assets Size to 1 and Element 0 to XRI Default Input Actions (InputActionsAsset)

4 - Configuring/Building for Oculus Quest
    Configuring https://developer.oculus.com/documentation/unity/unity-conf-settings/
    Go to File > Build Settings and switch Platform to Android (for Oculus Quest and Quest 2).
    
    Installing APK
    developer.oculus.com/documentation/native/android/mobile-device-setup/

    install SDK Platform-Tools (Android Debug Bridge --installing apk's/Hard way)
    developer.android.com/studio/releases/platform-tools

    install SDK with Side Quest (easier way)
5 - Installing and Animating Hands
    Animator - The interface to control animation system. 
        Entry - Where animation starts
        Blend Trees allow us to use multiple animations at the same time (running and leaning in a direction) 
    Getting input from controller:
            Asset Menu > Samples > XR Interaction Toolkit > 1.0.0-pre.8 > Default Input Actions (This is where you bind actions with inputs from several devices to use in your game )    
    Create and Attach Script
        Scripts will be nested in Assets/Scripts
            Inside script you create a references
            Back in Unity you will see references in Objects and you can assign previously created InputActionReference
