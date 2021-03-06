'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2014 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.Facades
Imports System.Drawing

Namespace VisualBasic.AsposePDFFacades.Annotations
    Public Class AddFreeTextAnnotation
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdfFacades_Annotations()
            'open document
            Dim contentEditor As New PdfContentEditor()
            contentEditor.BindPdf(dataDir & "AddFreeTextAnnotation.pdf")
            'crate rectangle
            Dim rect As New System.Drawing.Rectangle(50, 50, 100, 100)
            'create annotation
            contentEditor.CreateFreeText(rect, "Sample content", 1)
            'save updated PDF file
            contentEditor.Save(dataDir & "AddFreeTextAnnotation_out.pdf")


        End Sub
    End Class
End Namespace