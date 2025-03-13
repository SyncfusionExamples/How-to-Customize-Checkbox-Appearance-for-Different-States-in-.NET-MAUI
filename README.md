# How-to-Customize-Checkbox-Appearance-for-Different-States-in-.NET-MAUI
This repository contains a sample explaining how to customize Checkbox appearance for different states in .NET MAUI.

**Customize Checkbox Appearance for Different States in .NET MAUI**

you can customize the visual states of a CheckBox using the VisualStateManager to control its appearance in different states, such as Normal, NormalNull, Hover, HoverNull, Pressed, PressedNull, Disabled and DisabledNull state.

The following code example illustrate how to customize the appearance of a CheckBox for different states in .NET MAUI.

**XAML**

```
<ContentPage.Resources>
    <ResourceDictionary>

        <Style TargetType="syncfusion:SfCheckBox">
            <Setter Property="VisualStateManager.VisualStateGroups">
                <VisualStateGroupList>
                    <VisualStateGroup x:Name="CommonStates">
                        <VisualState x:Name="Normal">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#4A90E2"/>
                                <!-- Normal Checked Color -->
                                <Setter Property="UncheckedColor" Value="#7B8D93"/>
                                <!-- Normal Unchecked Color -->
                                <Setter Property="TextColor" Value="#333333"/>
                                <!-- Normal Text Color -->
                                <Setter Property="TickColor" Value="#FFFFFF"/>
                                <!-- Normal Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="NormalNull">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#4A90E2"/>
                                <!-- NormalNull Checked Color -->
                                <Setter Property="TextColor" Value="#333333"/>
                                <!-- NormalNull Text Color -->
                                <Setter Property="TickColor" Value="#FFFFFF"/>
                                <!-- NormalNull Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="Hover">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#34C759"/>
                                <!-- Hover Checked Color -->
                                <Setter Property="UncheckedColor" Value="#1C1B1F"/>
                                <!-- Hover Unchecked Color -->
                                <Setter Property="TextColor" Value="#FF9500"/>
                                <!-- Hover Text Color -->
                                <Setter Property="TickColor" Value="#FFFFFF"/>
                                <!-- Hover Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="HoverNull">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#34C759"/>
                                <!-- HoverNull Checked Color -->
                                <Setter Property="TextColor" Value="#FF9500"/>
                                <!-- HoverNull Text Color -->
                                <Setter Property="TickColor" Value="#FFFFFF"/>
                                <!-- HoverNull Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="Pressed">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#FF3B30"/>
                                <!-- Pressed Checked Color -->
                                <Setter Property="UncheckedColor" Value="#FF2D55"/>
                                <!-- Pressed Unchecked Color -->
                                <Setter Property="TextColor" Value="#FFCC00"/>
                                <!-- Pressed Text Color -->
                                <Setter Property="TickColor" Value="#000000"/>
                                <!-- Pressed Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="PressedNull">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#FF3B30"/>
                                <!-- PressedNull Checked Color -->
                                <Setter Property="TextColor" Value="#FFCC00"/>
                                <!-- PressedNull Text Color -->
                                <Setter Property="TickColor" Value="#000000"/>
                                <!-- PressedNull Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="Disabled">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#8E8E93"/>
                                <!-- Disabled Checked Color -->
                                <Setter Property="UncheckedColor" Value="#C7C7CC"/>
                                <!-- Disabled Unchecked Color -->
                                <Setter Property="TextColor" Value="#AEAEB2"/>
                                <!-- Disabled Text Color -->
                                <Setter Property="TickColor" Value="#D1D1D6"/>
                                <!-- Disabled Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                        <VisualState x:Name="DisabledNull">
                            <VisualState.Setters>
                                <Setter Property="CheckedColor" Value="#8E8E93"/>
                                <!-- DisabledNull Checked Color -->
                                <Setter Property="UncheckedColor" Value="#C7C7CC"/>
                                <!-- DisabledNull Unchecked Color -->
                                <Setter Property="TextColor" Value="#AEAEB2"/>
                                <!-- DisabledNull Text Color -->
                                <Setter Property="TickColor" Value="#D1D1D6"/>
                                <!-- DisabledNull Tick Color -->
                            </VisualState.Setters>
                        </VisualState>
                    </VisualStateGroup>
                </VisualStateGroupList>
            </Setter>
        </Style>

    </ResourceDictionary>
</ContentPage.Resources>

<StackLayout Padding="20">
    <Label x:Name="label" Margin="10" Text="Pizza Toppings"/>
    <syncfusion:SfCheckBox x:Name="selectAll" Text="Select All" IsThreeState="True" IsChecked="{x:Null}" StateChanged="SelectAll_StateChanged"/>
    <syncfusion:SfCheckBox x:Name="pepperoni" Text="Pepperoni" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
    <syncfusion:SfCheckBox x:Name="beef" Text="Beef" IsChecked="True" StateChanged="CheckBox_StateChanged" Margin="30,0" IsEnabled="False"/>
    <syncfusion:SfCheckBox x:Name="mushroom" Text="Mushrooms" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
    <syncfusion:SfCheckBox x:Name="onion" Text="Onions" IsChecked="True" StateChanged="CheckBox_StateChanged" Margin="30,0"/>
</StackLayout>
```

**C#**

```
bool skip = false;
private void SelectAll_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
{
   if (!skip)
   {
      skip = true;
      pepperoni.IsChecked = beef.IsChecked = mushroom.IsChecked = onion.IsChecked = e.IsChecked;
      skip = false;
    }
}

private void CheckBox_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
{
   if (!skip)
   {
     skip = true;
     if (pepperoni.IsChecked.Value && beef.IsChecked.Value && mushroom.IsChecked.Value && onion.IsChecked.Value)
        selectAll.IsChecked = true;
     else if (!pepperoni.IsChecked.Value && !beef.IsChecked.Value && !mushroom.IsChecked.Value && !onion.IsChecked.Value)
	selectAll.IsChecked = false;
      else
         selectAll.IsChecked = null;
         skip = false;
    }
 }
```
