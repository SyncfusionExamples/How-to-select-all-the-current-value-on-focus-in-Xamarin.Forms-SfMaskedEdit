# How-to-select-all-the-current-value-on-focus-in-Xamarin.Forms-SfMaskedEdit

This article explains how to select all the value in [Xamarin.Forms Syncfusion SfMaskedEdit](https://help.syncfusion.com/xamarin/masked-entry/getting-started) at focus state with  the following steps:
 
Step 1: Create a custom SfMaskedEdit control, since we do not have a direct support to achieve this requirement.
 
[C#]

```

    public class SfMaskedEditExt : SfMaskedEdit
    {
        public bool SelectOnFocus { get; set; }
    }

```

Step 2: Add the custom SfMaskedEdit control with the Mask and Value properties.
 
[XAML]

```

  …

<local:SfMaskedEditExt Mask="00000" Value="12345"  VerticalOptions="Center"/>

 …

```

Step 3: Create a custom renderer to select all the value at focus state using the platform specific code.
 
Android: CustomRenderer.cs
 
You can select all the value in focus state by calling the SetSelectAllOnFocus method.
 
[C#]

```

    protected override void OnElementChanged(ElementChangedEventArgs<SfMaskedEdit> e)
     {
        base.OnElementChanged(e);
        if(Control != null)
         {
           Control.SetSelectAllOnFocus(true);
         }
     }

```

iOS: CustomRenderer.cs
 
By calling the PerformSelector method to select all the value in iOS.
 
[C#]

```
 
  …

                Control.EditingDidBegin += Control_EditingDidBegin;

 …

        private void Control_EditingDidBegin(object sender, EventArgs e)
        {
            Control.PerformSelector(new ObjCRuntime.Selector("selectAll"), null, 0.0f);
        }

```

UWP: CustomRenderer.cs
 
In the Focused event of the SfMakedEditExt, call the SelectAll method to achieve this requirement in UWP.
 
[C#]

```

        protected override void  OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.MaskedEdit.SfMaskedEdit> e)
        {
            base.OnElementChanged(e);
            SfMaskedEditExt sfMaskedEditExt = e.NewElement as SfMaskedEditExt;
            sfMaskedEditExt.Focused += SfMaskedEditExt_Focused;
          
        }

        private void SfMaskedEditExt_Focused(object sender, Xamarin.Forms.FocusEventArgs e)
        {
            if (Control != null)
            {
                Control.SelectAll();
            }
        }

```

# Output: 

![Selected value of SfMaskedEdit ar focus state](Output.gif)

# See also

[What are mask types in SfMaskedEdit](https://help.syncfusion.com/xamarin/masked-entry/masktype)

[How to hide the prompt character](https://help.syncfusion.com/xamarin/masked-entry/hiding-prompt-characters)

[How to hide the clear button in SfMaskedEdit](https://help.syncfusion.com/xamarin/masked-entry/basic-features#clear-button-visibility)



