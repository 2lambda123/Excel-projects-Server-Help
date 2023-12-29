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



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"),  _
 Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
Partial Friend NotInheritable Class MySettings
    Inherits Global.System.Configuration.ApplicationSettingsBase

    Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)

#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(ByVal sender As Global.System.Object, ByVal e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region

    Public Shared ReadOnly Property [Default]() As MySettings
        Get

#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
            Return defaultInstance
        End Get
    End Property

    <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Anthony Duguid")>  _
    Public ReadOnly Property App_Author() As String
        Get
            Return CType(Me("App_Author"),String)
        End Get
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("https://github.com/Excel-projects/Server-Help/blob/master/README.md")>  _
    Public Property App_PathReadMe() As String
        Get
            Return CType(Me("App_PathReadMe"),String)
        End Get
        Set
            Me("App_PathReadMe") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("dNSHostname")>  _
    Public Property Ping_ServerName() As String
        Get
            Return CType(Me("Ping_ServerName"),String)
        End Get
        Set
            Me("Ping_ServerName") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Results")>  _
    Public Property Ping_Results() As String
        Get
            Return CType(Me("Ping_Results"),String)
        End Get
        Set
            Me("Ping_Results") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("dNSHostname")>  _
    Public Property Rdg_ServerName() As String
        Get
            Return CType(Me("Rdg_ServerName"),String)
        End Get
        Set
            Me("Rdg_ServerName") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("CN")>  _
    Public Property Rdg_Description() As String
        Get
            Return CType(Me("Rdg_Description"),String)
        End Get
        Set
            Me("Rdg_Description") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("C:\Temp\Test.rdg")>  _
    Public Property Rdg_FileName() As String
        Get
            Return CType(Me("Rdg_FileName"),String)
        End Get
        Set
            Me("Rdg_FileName") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("https://github.com/Excel-projects/Server-Help/issues/new")>  _
    Public Property App_PathNewIssue() As String
        Get
            Return CType(Me("App_PathNewIssue"),String)
        End Get
        Set
            Me("App_PathNewIssue") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("11/02/2018 12:00:00")>  _
    Public Property App_ReleaseDate() As Date
        Get
            Return CType(Me("App_ReleaseDate"),Date)
        End Get
        Set
            Me("App_ReleaseDate") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("OperatingSystem")>  _
    Public Property Rdg_Comment() As String
        Get
            Return CType(Me("Rdg_Comment"),String)
        End Get
        Set
            Me("Rdg_Comment") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("LDAP://OU=Servers,...")>  _
    Public Property Rdg_LdapPath() As String
        Get
            Return CType(Me("Rdg_LdapPath"),String)
        End Get
        Set
            Me("Rdg_LdapPath") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("SELECT whenCreated, whenChanged, distinguishedName, OperatingSystem, OperatingSys"& _
        "temVersion, dNSHostname, Name, CN FROM '[Rdg.LdapPath]' WHERE objectClass = 'com"& _
        "puter'")>  _
    Public Property Rdg_LdapQry() As String
        Get
            Return CType(Me("Rdg_LdapQry"),String)
        End Get
        Set
            Me("Rdg_LdapQry") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("ServerType")>  _
    Public Property Rdg_ServerGroup() As String
        Get
            Return CType(Me("Rdg_ServerGroup"),String)
        End Get
        Set
            Me("Rdg_ServerGroup") = value
        End Set
    End Property

    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("Servers")>  _
    Public Property Rdg_SheetName() As String
        Get
            Return CType(Me("Rdg_SheetName"),String)
        End Get
        Set
            Me("Rdg_SheetName") = value
        End Set
    End Property
End Class

Namespace My

    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty

        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.ServerActions.MySettings
            Get
                Return Global.ServerActions.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
