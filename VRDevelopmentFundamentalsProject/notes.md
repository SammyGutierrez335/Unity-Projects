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