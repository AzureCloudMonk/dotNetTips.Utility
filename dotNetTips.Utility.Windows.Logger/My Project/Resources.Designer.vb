﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("dotNetTips.Utility.Windows.Logger.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Regular expression string is null or empty!.
        '''</summary>
        Friend ReadOnly Property EXCEPTION_EMPTY_OR_NULL_REGEXP() As String
            Get
                Return ResourceManager.GetString("EXCEPTION_EMPTY_OR_NULL_REGEXP", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Input string is null or empty!.
        '''</summary>
        Friend ReadOnly Property EXCEPTION_EMPTY_OR_NULL_STRING() As String
            Get
                Return ResourceManager.GetString("EXCEPTION_EMPTY_OR_NULL_STRING", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Exception Information Details:.
        '''</summary>
        Friend ReadOnly Property ExceptionDetails() As String
            Get
                Return ResourceManager.GetString("ExceptionDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to HEADER.
        '''</summary>
        Friend ReadOnly Property ExceptionFormatterHeader() As String
            Get
                Return ResourceManager.GetString("ExceptionFormatterHeader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to StackTrace Information Details:.
        '''</summary>
        Friend ReadOnly Property ExceptionStackTraceDetails() As String
            Get
                Return ResourceManager.GetString("ExceptionStackTraceDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Exception Summary for:.
        '''</summary>
        Friend ReadOnly Property ExceptionSummary() As String
            Get
                Return ResourceManager.GetString("ExceptionSummary", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Exception Type.
        '''</summary>
        Friend ReadOnly Property ExceptionType() As String
            Get
                Return ResourceManager.GetString("ExceptionType", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Inner Exception Information Details:.
        '''</summary>
        Friend ReadOnly Property InnerExceptionDetails() As String
            Get
                Return ResourceManager.GetString("InnerExceptionDetails", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unable to read intrinsic property.  Error message: {0}.
        '''</summary>
        Friend ReadOnly Property IntrinsicPropertyError() As String
            Get
                Return ResourceManager.GetString("IntrinsicPropertyError", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ======================================.
        '''</summary>
        Friend ReadOnly Property LineSeparator() As String
            Get
                Return ResourceManager.GetString("LineSeparator", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
