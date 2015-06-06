Attribute VB_Name = "SentryWrapper"
Global m_Sentry As ITCollaborate_BugSentryCOM.Sentry

 
Property Get Sentry() As ITCollaborate_BugSentryCOM.Sentry

Dim LicenseCode As String
Dim PublicKey As String
Dim ProjectName As String
Dim ProjectVersion As String

   If m_Sentry Is Nothing Then
        ProjectVersion = App.Major & "." & App.Minor & "." & App.Revision
        ProjectName = App.EXEName
        
        'Project will not complile without these.
        LicenseCode = Copy and paste your license code string from the Tools menu on the Developer client.
        PublicKey =  Copy and paste your public key string from the Tools menu on the Developer client.
        
        'instantiate the Sentry Object
        Set m_Sentry = New ITCollaborate_BugSentryCOM.Sentry
        
        'call Init becuase VB6 constructors can't take arguments.
        Call m_Sentry.Init(LicenseCode, PublicKey, ProjectName, ProjectVersion, CacheStorageTypes_Directory, "C:\Documents and Settings\All Users\Application Data\ItCollaborate.BugSentry.Issues")
    
    End If
    Set Sentry = m_Sentry

End Property



