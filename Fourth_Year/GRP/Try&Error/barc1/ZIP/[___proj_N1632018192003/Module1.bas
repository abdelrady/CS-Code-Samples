Attribute VB_Name = "Module1"
Type recordstructure
    plotNo    As String * 5
    weight(9) As String * 10
End Type

Global datarecord As recordstructure

Global seqfile As String
Global FileInfo As Integer
Global usrCrop As String
Global usrYear As String
Global usrReg As String
Global usrTrial As String
Global usrMan As String
Global usrCutNum As String
  Global Firstplot
  Global Reps
  Global NoVar
  Global NoSubBlocks
  Global Design
  Global PlotLen
  Global NoFactors
Global randfile As String
