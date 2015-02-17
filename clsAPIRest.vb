Imports System.Xml

Public Class clsAPIRest

    Public Sub New()
        'Dim request As HttpWebRequest
        'request = RESTLibrary.REST.CreateRequest("http://192.168.1.147/SWAmivel/SWAmivel.svc/nuevoTicket/z+JRTV2uN2xbGrYpPRAP1URydPoIGVjWj7bPxPHG0O8=/9505/1/1.5/2.3/4.1/201501011423/AAAAA/fiat%20punto/1/", RESTLibrary.HttpMethods.POST, [String].Empty, "application/atom+xml", "", "")

        Dim xmlReader As XmlReader = xmlReader.Create("http://192.168.1.147/SWAmivel/SWAmivel.svc/nuevoTicket/z+JRTV2uN2xbGrYpPRAP1URydPoIGVjWj7bPxPHG0O8=/9505/1/1.5/2.3/4.1/201501011423/AAAAA/fiat%20punto/1/")
        ''Dim obj
        'obj = JsonConvert.DeserializeObject(Of Container)(xmlReader.ReadContentAsString)
        Dim xDoc As XDocument = XDocument.Load(xmlReader)
    End Sub

End Class
