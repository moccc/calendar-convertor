Imports System.Globalization
Public Class XDate
    Private mvarDay As Int16
    Private mvarMonth As Int16
    Private mvarYear As Int32

    Function SetDate(ByVal year As Int32, ByVal month As Int16, ByVal day As Int16) As XDate
        mvarYear = year
        mvarMonth = month
        mvarDay = day
        Return Me
    End Function

    Function SetMonth(ByVal month As Int16) As XDate
        mvarMonth = month
        Return Me
    End Function
    Property Day() As Int16
        Get
            Return mvarDay
        End Get
        Set(ByVal Value As Int16)
            mvarDay = Value
        End Set
    End Property

    Property Month() As Int16
        Get
            Return mvarMonth
        End Get
        Set(ByVal Value As Int16)
            mvarMonth = Value
        End Set
    End Property

    Property Year() As Int32
        Get
            Return mvarYear
        End Get
        Set(ByVal Value As Int32)
            mvarYear = Value
        End Set
    End Property

#Region "DaysInMonth"
    Function GetDaysInMothJalali() As Int16
        Dim r As Int16
        If Me.Month < 12 Then r = 30
        If Me.Month < 7 Then r = 31
        If Me.Month = 12 Then
            If (Me.Year - 1303) Mod 4 = 0 Then
                r = 30
            Else
                r = 29
            End If
        End If
        Return r
    End Function

    Function GetDaysInMothGregorian() As Int16
        Return Date.DaysInMonth(Me.Year, Me.Month)
    End Function

    Function GetDaysInMothHijri() As Int16
        Dim ghCal As New HijriCalendar
        ghCal.HijriAdjustment = -1

        Return ghCal.GetDaysInMonth(Me.Year, Me.Month)
    End Function
#End Region

#Region "Converts"
    Function GregorianToHijri() As XDate
        Dim ghCal As New HijriCalendar
        ghCal.HijriAdjustment = -1
        Dim cd As New DateTime(Me.Year, Me.Month, Me.Day)
        Dim r As New XDate
        r.Day = ghCal.GetDayOfMonth(cd)
        r.Month = ghCal.GetMonth(cd)
        r.Year = ghCal.GetYear(cd)
        Return r
    End Function

    Function HijriToGregorian() As XDate
        Dim myCal As New HijriCalendar
        myCal.HijriAdjustment = -1
        Dim myDT As New DateTime(Me.Year, Me.Month, Me.Day, myCal)
        Dim r As New XDate(myDT.Year, myDT.Month, myDT.Day)
        Return r
    End Function

    Function HijriToJalali() As XDate
        Return Me.HijriToGregorian.GregorianToJalali
    End Function

    Function JalaliToHijri() As XDate
        Return Me.JalaliToGregorian.GregorianToHijri
    End Function

    Function GregorianToJalali() As XDate
        Dim MDayMonth(12) As Int16, SDayMonth(12) As Int16
        Dim MYear As Int32, MMonth As Int16, MDay As Int16
        Dim gYear As Int32, gMonth As Int16, gDay As Int16
        Dim SYear As Int32, SMonth As Int16, SDay As Int16
        Dim YearBuf, MonthBuf, DayBuf
        Dim MDate, SDate
        Dim DayCount, Deference
        Dim i
        Dim StrDate As String = Me.Year & "/" & Me.Month & "/" & Me.Day
        Dim GetShamsiDate As String
        Dim Result As String

        Deference = 79
        DayCount = 0
        SMonth = 1
        YearBuf = ""
        MonthBuf = ""
        DayBuf = ""

        For i = 1 To 6
            SDayMonth(i) = 31
        Next
        For i = 7 To 11
            SDayMonth(i) = 30
        Next
        SDayMonth(12) = 29

        MDayMonth(1) = 31
        MDayMonth(2) = 28
        MDayMonth(3) = 31
        MDayMonth(4) = 30
        MDayMonth(5) = 31
        MDayMonth(6) = 30
        MDayMonth(7) = 31
        MDayMonth(8) = 31
        MDayMonth(9) = 30
        MDayMonth(10) = 31
        MDayMonth(11) = 30
        MDayMonth(12) = 31


        StrDate = Left(StrDate, 10)
        MDate = CDate(StrDate)
        MYear = DatePart("YYYY", MDate)
        MMonth = DatePart("m", MDate)
        MDay = DatePart("d", MDate)

        gYear = MYear
        gMonth = MMonth
        gDay = MDay

        If Math.Abs(MYear - 1996) Mod 4 = 0 And MMonth > 2 Then MDay = MDay + 1
        If Math.Abs(MYear - 1997) Mod 4 = 0 And MMonth < 4 Then
            If MMonth < 3 Then
                MDay = MDay + 1
            Else
                If MDay < 20 Then MDay = MDay + 1
            End If
        End If
        DayCount = MDay

        Do While MMonth > 0
            MMonth = MMonth - 1
            If (MMonth = 0) And (DayCount < Deference) Then
                MMonth = 12
                MYear = MYear - 1
            End If
            If MMonth > 0 Then DayCount = DayCount + MDayMonth(MMonth)
        Loop

        DayCount = DayCount - Deference
        Do While (SMonth < 12) And (DayCount > SDayMonth(SMonth))
            DayCount = DayCount - SDayMonth(SMonth)
            SMonth = SMonth + 1
        Loop
        SDay = DayCount
        SYear = MYear - 621
        If SDay = "0" And SMonth = 1 Then
            SDay = "30"
            SMonth = "12"
            SYear = SYear - 1
        End If
        If SDay < 10 Then DayBuf = "0"
        If SMonth < 10 Then MonthBuf = "0"

        If Math.Abs(gYear - 1995) Mod 4 = 0 And gMonth = 3 And gDay = 20 Then
            Result = Trim(gYear - 622) & ".12.29"
            GetShamsiDate = Trim(Result)
        ElseIf Math.Abs(gYear - 1997) Mod 4 = 0 And gMonth = 3 And gDay = 19 Then
            Result = Trim(gYear - 622) & ".12.29"
            GetShamsiDate = Trim(Result)
        ElseIf Math.Abs(gYear - 1996) Mod 4 = 0 And gMonth = 3 And gDay = 19 Then
            Result = Trim(gYear - 622) & ".12.29"
            GetShamsiDate = Trim(Result)
        ElseIf Math.Abs(gYear - 1998) Mod 4 = 0 And gMonth = 3 And gDay = 20 Then
            Result = Trim(gYear - 622) & ".12.29"
            GetShamsiDate = Trim(Result)
        Else
            Result = CStr(SYear) + "." + MonthBuf + CStr(SMonth) + "." + DayBuf + CStr(SDay)
            GetShamsiDate = Trim(Result)
        End If
        Dim d As New XDate
        Dim dd() As String = GetShamsiDate.Split(".")
        d.Day = dd(2)
        d.Month = dd(1)
        d.Year = dd(0)
        Return d
    End Function

    Function JalaliToGregorian() As XDate
        Dim iyear As Int32 = Me.Year
        Dim imonth As Int16 = Me.Month
        Dim iday As Int16 = Me.Day
        Dim epbase As Int64, epyear As Int64, mdays As Int16, jdn As Int64
        Dim l As Int64, k As Int64, n As Int64, ii As Int64, j As Int64

        If iyear >= 0 Then
            epbase = iyear - 474
        Else
            epbase = iyear - 473
        End If

        epyear = 474 + (epbase Mod 2820)
        If imonth <= 7 Then
            mdays = (CLng(imonth) - 1) * 31
        Else
            mdays = (CLng(imonth) - 1) * 30 + 6
        End If
        jdn = CLng(iday) + mdays + Fix(((epyear * 682) - 110) / 2816) _
                + (epyear - 1) * 365 _
                + Fix(epbase / 2820) * 1029983 _
                + (1948321 - 1)

        l = 0 : k = 0 : n = 0 : ii = 0 : j = 0

        If (jdn > 2299160) Then
            l = jdn + 68569
            n = ((4 * l) \ 146097)
            l = l - ((146097 * n + 3) \ 4)
            ii = ((4000 * (l + 1)) \ 1461001)
            l = l - ((1461 * ii) \ 4) + 31
            j = ((80 * l) \ 2447)
            iday = l - ((2447 * j) \ 80)
            l = (j \ 11)
            imonth = j + 2 - 12 * l
            iyear = 100 * (n - 49) + ii + l
        Else
            l = 0 : k = 0 : n = 0 : ii = 0 : j = 0
            j = jdn + 1402
            k = ((j - 1) \ 1461)
            l = j - 1461 * k
            n = ((l - 1) \ 365) - (l \ 1461)
            ii = l - 365 * n + 30
            j = ((80 * ii) \ 2447)
            iday = ii - ((2447 * j) \ 80)
            ii = (j \ 11)
            imonth = j + 2 - 12 * ii
            iyear = 4 * k + n + ii - 4716
        End If
        Dim d As New XDate
        d.Year = iyear
        d.Month = imonth
        d.Day = iday
        Return (d)
    End Function
#End Region


    Public Sub New()

    End Sub
    Public Sub New(ByVal year As Int64, ByVal month As Int16, ByVal day As Int16)
        Me.Year = year
        Me.Month = month
        Me.Day = day
    End Sub

End Class
