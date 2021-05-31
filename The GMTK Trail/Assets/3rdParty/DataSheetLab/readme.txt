# DataSheetLab ( 1.3a ) 

Subpage : https://github.com/geniikw/DataSheetLab-Info 
(guide, patchnote, quick start etc..)

This tool help to handles sheet data within the Unity3D Editor.

## Sheet
At first, you must first declare the sheet data.

```csharp
[Serializable]
public class UserData{
string name;
int power;
}
[CreateAssetMenu]
public UserSheet : Sheet<UserData>{}
```

Implemented sheets can also be found in the Example folder.

After open window [DataSheetLab/sheetEditor]
and select sheet.

You will see a blank sheet. Press the push button to create an item.

If you press rm button on the right side, the data of the corresponding row disappears.

## ReferSheet

ReferSheet is a class that helps you refer to items on other sheets.

Declare and use as shown below.

```csharp
[Serializable]
public class SkillReference : ReferSheet<SkillSheet, SKillData>{}

[Serializable]
public class CharacterData{
string name;
SkillReference skillSet;
}
```
Implemented refer can also be found in the Example folder.

* Cell Color Option

If you declare float or int, you can add color to the cell by adding the following attribute:

bigCheck changes the color if it is greater than the first argument. The default is red.
[BigCheck(float number, float r=1, float g=0, float b= 0)]

smallCheck changes the color if it is less than the first argument. The default is blue.
[SmallCheck(float number, float r=0, float g=0, float b= 1)]

# ingame
reference example scene.

If you have any questions or suggestions, please send e-mail.

geniikw@gmail.com
