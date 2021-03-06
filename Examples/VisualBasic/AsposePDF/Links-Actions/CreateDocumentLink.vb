'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Pdf. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Pdf
Imports Aspose.Pdf.InteractiveFeatures.Annotations
Imports Aspose.Pdf.InteractiveFeatures

Namespace VisualBasic.AsposePdf.LinksActions
    Public Class CreateDocumentLink
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_AsposePdf_LinksActions()


            'open document
            Dim document As New Document(dataDir & "CreateDocumentLink.pdf")

            'create link
            Dim page As Page = document.Pages(1)
            Dim link As New LinkAnnotation(page, New Aspose.Pdf.Rectangle(100, 100, 300, 300))
            link.Color = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Green)
            link.Action = New GoToRemoteAction(dataDir & "blank.pdf", 1)
            page.Annotations.Add(link)

            'save updated document
            document.Save(dataDir & "CreateDocumentLink_out.pdf")

        End Sub
    End Class
End Namespace