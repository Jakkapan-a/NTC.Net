# NTC.Net - Name That Color
NTCNet is a color identifier library written in C# that converts color values between different color spaces, identifies colors by name, and determines the shade of colors. It uses the Name That Color library to identify the closest named color from the given hex color value.
# Features
1. **Hex to RGB**: Converts hexadecimal color values to their RGB counterparts.
2. **Hex to HSL**: Converts hexadecimal color values to their HSL counterparts.
3. **RGB to Hex**: Converts RGB color values to their hexadecimal counterparts.
4. **Color Name Identification**: Identifies the closest named color from the given hex color value.
5. **Shade Identification**: Identifies the shade of a given color.

# Methods 
Below is a brief overview of the main methods in the NTCNet class.

- **`NTCNet()`**: Constructor of the class that initializes color values.
- **`ValueToHex(int value)`**: Converts an integer value to a hexadecimal string.
RgbToHex(int r, int g, int b): Converts RGB color values to a hexadecimal string.
- **`Name(string color)`**: Identifies the closest named color from the given hex color value. Returns an array of values including the hexadecimal code, the color name, the RGB and HSL values.
- **`ShadeRGB(string color)`**: Identifies the shade of a given color.
- **`RGB(string color)`**: Converts hexadecimal color values to their RGB counterparts.
- **`HSL(string color)`**: Converts hexadecimal color values to their HSL counterparts. 

# How to Use
```csharp
using NTC.Net;

var ntcNet = new NTCNet();
var rgb = ntcNet.RGB("#FA8072");
var hex = ntcNet.RgbToHex(255, 160, 122);
var hsl = ntcNet.HSL("#FA8072");
var colorName = ntcNet.Name("#FA8072");
var shade = NTCNet.ShadeRGB("#FA8072");
```
# Installation
You can install the package via nuget:
```csharp
Install-Package NTC.Net
```
# Contributions
We welcome contributions to this project. Please feel free to submit issues and pull requests for consideration.
# Credits
This project is based on [Chirag Mehta's](http://chir.ag/projects/ntc/) work.
and [Name That Color](https://github.com/tajmone/name-that-color) repository.
# License
This project is licensed under the MIT License - see the [LICENSE](LICENSE.txt) file for details

