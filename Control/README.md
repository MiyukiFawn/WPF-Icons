
## Setup

* Add [this](https://www.nuget.org/packages/WPF-Icons) NuGet package to your project.
## Import NuGet Package

Add a ***xmlns:i="clr-namespace:WPF_Icons;assembly=WPF-Icons"*** tag of the NuGet Package on your xaml.

```xml
<Page xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
      xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
      xmlns:local="clr-namespace:WPF.MainWindow"
      xmlns:i="clr-namespace:WPF_Icons;assembly=WPF-Icons"
      x:Class="WPF.MainWindow"
      mc:Ignorable="d"
      d:DesignHeight="750"
      d:DesignWidth="800"
      Title="Main Window">
</Page>

```

## The Icons

**WPF Icons** provides over 2,500 different symbols from Google
> You can list all of them [here](https://fonts.google.com/icons)

## The Icon Control

The Icon Control has 5 main properties:

### Kind

Defines the icon's symbol
> **DISCLAIMER**: All the options stars with the prefix ***icon_***

### Color

Defines the icon's color (duh).

### Size

Defines the **width** and **height** of the **Icon Control**.
> **DISCLAIMER**: The Controller add a padding of 2 on all directions, so in a 48 x 48 Icon, the drawing size is actually 44 x 44.

### Rounded

Defines if the corners of the drawing are **Sharp** or **Rounded**.
> **DISCLAIMER**: Not all the icons support Rounded or Sharp corners.

### Filled

Defines if the icon is a **Filled** or a **Outline** icon.
> **DISCLAIMER**: Not all the icons have a Filled or Outline variant.

---

I hope that this collection can help.
Feel free to use it on watever project you wanna use.

Have fun!

> GitHub [@Miyuki](https://github.com/GEYWYD)
