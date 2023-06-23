Namespace App.Utils
    
    Public Module Messages
        Public Function Sure() As DialogResult
            Return MessageBox.Show(My.Resources.are_you_sure, My.Resources.alert, MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        End Function
    End Module

End NameSpace