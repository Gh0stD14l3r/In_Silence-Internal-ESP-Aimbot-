In Silence - C# DLL Source [Base]

Note: This mod works with Wemod loaded aswell.
This is a basic mod menu created in C#. It is a base which you can add your own items to it or modifications. Currently it has the following.

 - ESP (Players, Items, Creature (Bones), Alerting items, Vehicle, Armory)
 - Lobby Host Switcher
 - Press and hold Numpad 2 to repair the car
 Note: This will allow you to get in and leave. Everyone else must go through the gate
 - Round information (Car parts required, Armory Code)
 - Aimbot (Will lock on to both AI Creature and Player Creature)
 Note: For Aimbot, just equip the rifleand hold right mouse click (ADS) and move towards the enemy. It will snap to their head
 
Insert Key - Show/Hide Menu 
End Key - Unload DLL File safely

To compile..

    Download & Open Sln file for Visual Studio
    Compile in Debug or Release (Doesn't matter)

To Inject..

    Use a Mono injector (Possibly MonoSharpInjector)
    Select Process and browse to the assembly to inject (In_Silence.dll)
    Use the following settings.. -- Namespace: In_Silence -- Class name: Loader -- Method name: init
    Press inject
