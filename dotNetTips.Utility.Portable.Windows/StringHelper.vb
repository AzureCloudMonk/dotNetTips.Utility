' ***********************************************************************
' Assembly         : dotNetTips.Utility.Portable
' Author           : David McCarter
' Created          : 12-04-2013
'
' Last Modified By : David McCarter
' Last Modified On : 06-26-2017
' ***********************************************************************
' <copyright file="StringHelper.vb" company="David McCarter Consulting">
'     David McCarter Consulting. All rights reserved.
' </copyright>
' <summary></summary>
' *************************************************************************
Imports dotNetTips.Utility.Portable.OOP
Imports System.Text.RegularExpressions

''' <summary>
''' Text helper class.
''' </summary>
Public Module StringHelper

    ''' <summary>
    ''' Correctly compares two strings.
    ''' </summary>
    ''' <param name="original">First string to compare.</param>
    ''' <param name="compareTo">Second string to compare.</param>
    ''' <returns>True if strings are the same.</returns>
    Public Function Compare(ByVal original As String, ByVal compareTo As String) As Boolean
        Encapsulation.TryValidateParam(Of ArgumentNullException)(String.IsNullOrEmpty(original) = False)
        Encapsulation.TryValidateParam(Of ArgumentNullException)(String.IsNullOrEmpty(compareTo) = False)

        If original.Length <> compareTo.Length Then
            Return False
        End If

        Return If(String.CompareOrdinal(original, compareTo) >= 0, True, False)

    End Function

    ''' <summary>
    ''' Creates a Guid
    ''' </summary>
    ''' <returns>Guid as text</returns>
    Public Function CreateGuid() As String

        Return Guid.NewGuid.ToString

    End Function

    ''' <summary>
    ''' Removes unprintable characters.
    ''' </summary>
    ''' <param name="input">The input string.</param>
    ''' <returns>System.String.</returns>
    Public Function PrintableOnly(ByVal input As String) As String

        Return If(String.IsNullOrEmpty(input), String.Empty, New Regex("[^ -~" & vbTab & vbCr & vbLf & "]").Replace(input, String.Empty))

    End Function

    ''' <summary>
    ''' Removes the character.
    ''' </summary>
    ''' <param name="input">The input.</param>
    ''' <param name="character">The character.</param>
    ''' <returns>System.String.</returns>
    Public Function RemoveCharacter(input As String, character As Char) As String
        Encapsulation.TryValidateParam(Of ArgumentNullException)(input IsNot Nothing)
        Encapsulation.TryValidateParam(Of ArgumentNullException)(String.IsNullOrWhiteSpace(character.ToString) = False)

        Return input.Replace(character, String.Empty)

    End Function

    ''' <summary>
    ''' Removes the spaces.
    ''' </summary>
    ''' <param name="input">The input.</param>
    ''' <returns>System.String.</returns>
    Public Function RemoveSpaces(input As String) As String
        Encapsulation.TryValidateParam(Of ArgumentNullException)(input IsNot Nothing)

        Return input.Replace(ControlChars.Space, String.Empty)

    End Function

    ''' <summary>
    ''' Spaces the specified number.
    ''' </summary>
    ''' <param name="number">The number.</param>
    ''' <returns>System.String.</returns>
    Public Function Space(ByVal number As Integer) As String
        Encapsulation.TryValidateParam(Of ArgumentNullException)(number >= 0)

        Return New String(ControlChars.Space, number)

    End Function

    ''' <summary>
    ''' Fixes string for input into SQL.
    ''' </summary>
    ''' <param name="input">Text to fix.</param>
    ''' <returns>Fixed string.</returns>
    ''' <remarks>Replaces single quote with double quote.</remarks>
    Public Function SqlEncode(ByVal input As String) As String

        If String.IsNullOrEmpty(input) Then
            Return String.Empty
        End If

        Return PrintableOnly(input).Replace(ControlChars.SingleQuote, ControlChars.DoubleQuote)

    End Function

End Module