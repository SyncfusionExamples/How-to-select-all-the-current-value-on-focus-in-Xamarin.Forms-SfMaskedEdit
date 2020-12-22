# How-to-select-all-the-current-value-on-focus-in-Xamarin.Forms-SfMaskedEdit

This article explains how to select all the text on focus in Syncfusion Xamarin.Forms SfMaskedEdit with the following steps.
  
**Step 1:** Create an SfMaskedEdit sample with all the necessary assemblies.
Refer to this Getting started documentation to create a simple SfImageEditor sample and configure it.
 
**Step 2:** By enabling the SelectAllOnFocus property of the SfMaskedEdit control to select all the value when focus on control as per in the below code sample.

[XAML]

```
   <maskedEdit:SfMaskedEdit Mask="00000" 
                           SelectAllOnFocus ="True"
                           Value="12345" 
                          />
```

# Output: 

![Selected value of SfMaskedEdit ar focus state](Output.gif)

# See also

[What are mask types in SfMaskedEdit](https://help.syncfusion.com/xamarin/masked-entry/masktype)

[How to hide the prompt character](https://help.syncfusion.com/xamarin/masked-entry/hiding-prompt-characters)

[How to hide the clear button in SfMaskedEdit](https://help.syncfusion.com/xamarin/masked-entry/basic-features#clear-button-visibility)



