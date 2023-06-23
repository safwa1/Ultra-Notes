
Imports System.Runtime.CompilerServices
Imports System.Text.RegularExpressions
Imports SafwanUiKit.Controls

Namespace App.Extensions

    Friend Module GlobalExtensions

        <Extension()>
        Public Function IsBlank(s As String) As Boolean
            Return IsNothing(s) OrElse s.Trim().Length = 0
        End Function

        <Extension()>
        Public Function IsBlank(tb As TextBox) As Boolean
            Return tb.Text.IsBlank()
        End Function

        <Extension()>
        Public Function IsBlank(tb As STextBox) As Boolean
            Return tb.Value.IsBlank()
        End Function
        
        <Extension()>
        Public Sub Print(aString As String)
            Console.WriteLine(aString)
        End Sub

        <Extension()>
        Public Function IsValidEmail(str As String) As Boolean
            Dim result = Regex.IsMatch(str, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
            Return result
        End Function
        
        <Extension()>
        Public Function AsString(d As Date) As String
            Return DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss")
        End Function

    End Module
End NameSpace