﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Drawing;
using System.Windows.Forms.TestUtilities;
using Windows.Win32.UI.Accessibility;
using static Interop;
using static System.Windows.Forms.ScrollBar;

namespace System.Windows.Forms.Tests;

public class HScrollBar_ScrollBarFirstPageButtonAccessibleObjectTests
{
    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_GetChild_ReturnNull(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Null(accessibleObject.GetChild(-1));
        Assert.Null(accessibleObject.GetChild(0));
        Assert.Null(accessibleObject.GetChild(1));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_GetChildCount_ReturnMinusOne(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(-1, accessibleObject.GetChildCount());
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Bounds_ReturnEmptyRectangle_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(Rectangle.Empty, accessibleObject.Bounds);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_FirstPageButtonIsHidden_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Bounds_ReturnEmptyRectangle_FirstPageButtonIsHidden(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(Rectangle.Empty, accessibleObject.Bounds);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_DefaultAction_ReturnNotNull_HandleIsCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.NotEmpty(accessibleObject.DefaultAction);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_DefaultAction_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Null(accessibleObject.DefaultAction);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Description_ReturnNotNull_HandleIsCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.NotEmpty(accessibleObject.Description);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Description_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Null(accessibleObject.Description);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Name_ReturnNotNull_HandleIsCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.NotEmpty(accessibleObject.Name);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Name_ReturnNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Null(accessibleObject.Name);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Role_ReturnNotNull(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);
        AccessibleRole expectedRole = createControl ? AccessibleRole.PushButton : AccessibleRole.None;

        Assert.Equal(expectedRole, accessibleObject.Role);
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_State_ReturnNone_IfHandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(AccessibleStates.None, accessibleObject.State);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_InvokePattern_Supported(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(createControl, accessibleObject.IsPatternSupported(UIA_PATTERN_ID.UIA_InvokePatternId));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_FirstPageButtonIsDisplayed_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_FragmentNavigate_ReturnsExpected_ButtonIsDisplayed(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        var scrollBarAccessibleObject = (ScrollBar.ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        AccessibleObject thumb = scrollBarAccessibleObject.ThumbAccessibleObject;
        AccessibleObject lineButton = scrollBarAccessibleObject.FirstLineButtonAccessibleObject;
        Assert.Equal(scrollBarAccessibleObject, accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.Parent));
        Assert.Equal(thumb, accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.NextSibling));
        Assert.Equal(lineButton, accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.LastChild));
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_FirstPageButtonIsHidden_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_FragmentNavigate_ReturnsExpected_ButtonIsHidden(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        var scrollBarAccessibleObject = (ScrollBar.ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(scrollBarAccessibleObject, accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.Parent));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.LastChild));
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_MinimumEqualsMaximum_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_FragmentNavigate_ReturnsExpected_MinimumEqualsMaximum(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        var scrollBarAccessibleObject = (ScrollBar.ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(scrollBarAccessibleObject, accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.Parent));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.LastChild));
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_FragmentNavigate_ReturnsNull_HandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.Parent));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.NextSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.PreviousSibling));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.FirstChild));
        Assert.Null(accessibleObject.FragmentNavigate(UiaCore.NavigateDirection.LastChild));
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsFact]
    public void HScrollBarFirstPageButtonAccessibleObject_Invoke_IncreaseValue()
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, RightToLeft.Yes, minimum: 0, maximum: 100, value: 50);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(50, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(52, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(54, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsFact]
    public void HScrollBarFirstPageButtonAccessibleObject_Invoke_DecreaseValue()
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, RightToLeft.No, minimum: 0, maximum: 100, value: 50);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(50, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(48, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(46, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [InlineData(RightToLeft.No, 0, 100)]
    [InlineData(RightToLeft.No, 0, 0)]
    [InlineData(RightToLeft.Yes, 99, 100)]
    [InlineData(RightToLeft.Yes, 0, 0)]
    public void HScrollBarFirstPageButtonAccessibleObject_Invoke_DoesNotWork_OutOfRange(RightToLeft rightToLeft, int value, int maximum)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum: 0, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_WithoutCreateControl_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Invoke_DoesNotWork_IfHandleIsNotCreated(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_MinimumEqualsMaximum_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Invoke_DoesNotWork_MinimumEqualsMaximum(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_FirstPageButtonIsHidden_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_Invoke_DoesNotWork_FirstPageButtonIsHidden(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: true, rightToLeft, minimum, maximum, value);
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.Equal(value, scrollBar.Value);

        accessibleObject.Invoke();

        Assert.Equal(value, scrollBar.Value);
        Assert.True(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_GetPropertyValue_IsEnabledProperty_ReturnsTrue_OwnerEnabled(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        scrollBar.Enabled = true;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.True((bool)accessibleObject.GetPropertyValue(UIA_PROPERTY_ID.UIA_IsEnabledPropertyId));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.ScrollBarAccessibleObject_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_GetPropertyValue_IsEnabledProperty_ReturnsFalse_OwnerDisabled(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl, rightToLeft, minimum, maximum, value);
        scrollBar.Enabled = false;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.False((bool)accessibleObject.GetPropertyValue(UIA_PROPERTY_ID.UIA_IsEnabledPropertyId));
        Assert.Equal(createControl, scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_FirstPageButtonIsDisplayed_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_IsDisplayed_ReturnsTrue_OwnerVisible(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        scrollBar.Visible = true;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.True(accessibleObject.IsDisplayed);
        Assert.False(scrollBar.IsHandleCreated);
    }

    [WinFormsTheory]
    [CommonMemberData(typeof(ScrollBarTestHelper), nameof(ScrollBarTestHelper.HScrollBarAccessibleObject_FirstPageButtonIsDisplayed_TestData))]
    public void HScrollBarFirstPageButtonAccessibleObject_IsDisplayed_ReturnsFalse_OwnerInvisible(RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        using HScrollBar scrollBar = GetHScrollBar(createControl: false, rightToLeft, minimum, maximum, value);
        scrollBar.Visible = false;
        ScrollBarFirstPageButtonAccessibleObject accessibleObject = GetFirstPageButton(scrollBar);

        Assert.False(accessibleObject.IsDisplayed);
        Assert.False(scrollBar.IsHandleCreated);
    }

    private HScrollBar GetHScrollBar(bool createControl, RightToLeft rightToLeft, int minimum, int maximum, int value)
    {
        HScrollBar hScrollBar = new()
        {
            RightToLeft = rightToLeft,
            Value = value,
            Minimum = minimum,
            Maximum = maximum,
            Size = new Size(200, 50),
            LargeChange = 2,
            SmallChange = 1
        };

        if (createControl)
        {
            hScrollBar.CreateControl();
        }

        return hScrollBar;
    }

    private ScrollBarFirstPageButtonAccessibleObject GetFirstPageButton(ScrollBar scrollBar)
    {
        var accessibleObject = (ScrollBar.ScrollBarAccessibleObject)scrollBar.AccessibilityObject;
        return accessibleObject.FirstPageButtonAccessibleObject;
    }
}
