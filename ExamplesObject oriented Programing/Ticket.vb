Public Class Ticket

    Private _Issue As String
    Private _Reporter As String
    Private _dateReported As Date
    Private _severity As Integer
    Private _dateResolved As Date
    Private _resolutionDescription As String
    Private _ticketIDCounter As Integer

    Public Property ticketIDCounter() As Integer
        Get
            Return _ticketIDCounter + 1

        End Get
        Set(value As Integer)
            _ticketIDCounter = value
        End Set

    End Property

    Sub New(issued As String, reppported As String, seriousnesssOfthematter As Integer, ticknumber As Integer)
        Issue = issued
        Reporter = reppported
        severity = seriousnesssOfthematter
        ticketIDCounter = ticknumber
        ' TODO: Complete member initialization 
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub



    Public Property Issue() As String
        Get
            Return _Issue

        End Get
        Set(value As String)
            _Issue = value

        End Set
    End Property

    Public Property Reporter() As String
        Get
            Return _Reporter

        End Get
        Set(value As String)
            _Reporter = value

        End Set
    End Property

    Public Property dateReported() As Date
        Get
            Return _dateReported

        End Get
        Set(value As Date)
            _dateReported = value


        End Set
    End Property
    Public Property severity() As Integer

        Get
            Return _severity

        End Get
        Set(value As Integer)
            _severity = value
        End Set
    End Property

    Public Property Resolution As String
        Get
            Return _resolutionDescription
        End Get
        Set(value As String)
            _resolutionDescription = value

        End Set
    End Property

    Public Property DateResolved As Date
        Get
            Return _dateResolved

        End Get
        Set(value As Date)
            _dateResolved = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return dateReported.ToString + " Issue = " + Issue + " Reported by " + Reporter + " Date: " + " Severity " + severity.ToString + vbCrLf


    End Function
    'Sub New(issued As String, reppported As String, seriousnesssOfthematter As Integer)
    '    Issue = issued
    '    Reporter = reppported
    '    severity = seriousnesssOfthematter


    'End Sub


End Class
