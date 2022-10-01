## Setup

* Add [this](https://www.nuget.org/packages/WPF-Icons) NuGet package to your project.
* Download the xaml files from the **Icons** folder and add the files in your project.
> **DISCLAIMER**: Be careful with the ammount of icons you add to your project, it can become really slow and even crash your editor.
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
## Add Icons

Import the ***Icons xaml*** files in a folder on the project.
```
.
├── ...
├── Resources
│   ├── home.xaml
│   ├── image.xaml
│   ├── heart.xaml
│   ├── computer.xaml
│   └── ...  
└── ...

```

## How To Use

Add the icons that you wanna use in the ***xaml Resources***.
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
      
      <Page.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resource/Icons/home.xaml" />
                <ResourceDictionary Source="Resource/Icons/image.xaml" />
                <ResourceDictionary Source="Resource/Icons/heart.xaml" />
                <ResourceDictionary Source="Resource/Icons/computer.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Page.Resources>
</Page>

```

## Display The Icons
First, add the ***Icon Control*** to the view, then set its style to the desired Icon.
```xaml
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
      
      <Page.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Resource/Icons/home.xaml" />
                <ResourceDictionary Source="Resource/Icons/image.xaml" />
                <ResourceDictionary Source="Resource/Icons/heart.xaml" />
                <ResourceDictionary Source="Resource/Icons/computer.xaml" />
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Page.Resources>
    
    <StackPanel Orientation="Horizontal">
      <i:Icon style="{StaticResource home}" />
      <i:Icon style="{StaticResource image}" />
      <i:Icon style="{StaticResource heart}" />
      <i:Icon style="{StaticResource computer}" />
    </StackPanel>
</Page>

```

## The Icon Control
The Icon Control has 4 main properties:
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