Namespace App.Contracts
    Public Interface IController(Of T)
        Function Insert(ByVal value As T) As Long
        Function Update(ByVal value As T) As Boolean
        Function Delete(ByVal value As T) As Boolean
        Function DeleteAll() As Boolean
        Function GetAll() As IEnumerable(Of T)
        Function [Get](Of TIdentity)(ByVal id As TIdentity) As T
    End Interface
End NameSpace