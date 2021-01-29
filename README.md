
colorconverter
==============
Converter to convert between various color systems such as RGB, CIELAB, CMYK, HEX, RGB, and XYZ

![Build Status](https://mindpowered.dev/assets/images/github-badges/build-passing.svg)

Contents
========

* [Source Code and Documentation](#source-code-and-documentation)
* [Licensing](#licensing)
* [About](#about)
* [Requirements](#requirements)
* [Installation](#installation)
* [Usage](#usage)
* [Support](#support)

# Source Code and Documentation
- Source Code: [https://github.com/mindpowered/color-converter-csharp](https://github.com/mindpowered/color-converter-csharp)
- Documentation: [https://mindpowered.github.io/color-converter-csharp](https://mindpowered.github.io/color-converter-csharp)

# Licensing
To obtain a version of this package under the MIT License, follow the instructions to [get a license][purchase]. The MIT License has no restrictions on commercial use and permits reuse within proprietary software.

# About
Defining a color is difficult. The first challenge is finding a way to describe a color. One way is to describe color based on constituent colors. We can describe constituent colors by adding them, like in RGB, or subtracting them, like in CMYK. Gamut is the range of all colors that are representable in a color system. RGB trades a limited gamut for performance. LAB trades performance for the full gamut of visible colors. CMYK represents the gamut used in color printing.

The second challenge to defining a color is that it depends on the observer. Viewing the same color will look different when:
- printed on paper or displayed on a screen
- seen in daylight or under fluorescent lighting
- positioned at a close or far distance
Standard references such as the Pantone Matching System refer to specific colors. We lose information when converting from a reference color to a color system. Printing or rendering an RGB or CMYK color equivalent to a reference color may not match. We can avoid information loss during conversion by using an unlimited gamut such as LAB. We must also take into account the effect of the observer and illumination.

This package aims to provide tools to perform:
- Color conversion between color systems
- A way of searching for similar standardized reference colors

# Requirements
## To import pre-compiled library
- nuget

## To build from source
- Visual Studio Build Tools
- Haxe 4.1.1
- Neko
- hxcs Haxelib
- nuget


Third-party dependencies may have additional requirements.

# Installation

## MSBuild

Add the following entry to your .csproj file:

```
<PackageReference Include="mindpowered.colorconverter" Version="0.0.5" />
```


# Usage
```csharp
global::mindpowered.colorconverter.ColorConverter cc = new global::mindpowered.colorconverter.ColorConverter();
object[] = cc.FromHEX("#336699");
```


# Support
We are here to support using this package. If it doesn't do what you're looking for, isn't working, or you just need help, please [Contact us][contact].

There is also a public [Issue Tracker][bugs] available for this package.



[bugs]: https://github.com/mindpowered/color-converter-csharp/issues
[contact]: https://mindpowered.dev/support.html?ref=color-converter-csharp/
[docs]: https://mindpowered.github.io/color-converter-csharp/
[licensing]: https://mindpowered.dev/?ref=color-converter-csharp
[purchase]: https://mindpowered.dev/purchase/
