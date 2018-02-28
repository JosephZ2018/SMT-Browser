



Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Web
Imports mshtml

Public Class Main

    Public WithEvents CurrentDocument As System.Windows.Forms.HtmlDocument
    Dim googleresultstats1, googleresultstats11, googleresultstats111, googleresultstats2, googleresultstats22, googleresultstats222 As String

    Dim translationresultgoogle_enzh, translationresultbaidu_enzh, translationresultgoogle_zhen, translationresultbaidu_zhen As String
    Dim Isautosave As Boolean
    Dim notURL As Boolean
    Dim whattoautosave As String
    Dim MousePoint As Point
    Dim Ele As HtmlElement
    Dim sourcestring As String

    Dim viewmode As String
    Dim notetype As String
    Dim readertype As String
    Dim MTresult1, MTresult2, MTresult3, MTresult4 As HtmlElement
    Dim rtbselect As String
    Dim MTpoint1, MTpoint2, MTpoint3, MTpoint4 As Integer

    Dim resulttext1, resulttext2， resulttext3， resulttext4 As String
    Dim keyword As String
    Dim Browser1_str, Browser11_str, Browser2_str, Browser22_str, Browser3_str, Browser33_str, Browser333_str, Browser4_str, Browser44_str, Browser444_str As String


    Function ConvertToUnicodeString(ByVal s As String) As String
        'Create a StringBuilder to create your string'
        Dim sb = New StringBuilder()

        'Iterate through each character'
        For Each c As Char In s
            'Determine if it falls into the normal ASCII range'
            If AscW(c) > 255 Then
                'Adds a hex-url encoding for each character'
                sb.Append(System.Web.HttpUtility.UrlEncode(c))
            Else
                'Otherwise append the character'
                sb.Append(c)
            End If
        Next

        'Return the string in question'
        Return sb.ToString()
    End Function



    Public Sub Searchnow(keyword As String)
        'bytes = Encoding.Unicode.GetBytes(Tbx_search.Text)
        'Tbx_search.Text = Encoding.Unicode.GetString(unicodebytes)



        'Dim unicodestring As String = Tbx_search.Text
        'Dim unicode As Encoding = Encoding.UTF8
        'Dim unicodebytes As Byte() = unicode.GetBytes(unicodestring)

        'keyword = Encoding.UTF8.GetString(unicodebytes)
        'Debuginfo.Text = ke670yword


        Setting.read_settings()

        If Setting.TabControl1.SelectedIndex = 0 Then


            Browser1_str = My.Settings.SearchEngine1.Replace("%s", keyword)
            Browser2_str = My.Settings.SearchEngine2.Replace("%s", keyword)
            Browser3_str = My.Settings.SearchEngine3.Replace("%s", keyword)
            Browser4_str = My.Settings.SearchEngine4.Replace("%s", keyword)
        ElseIf Setting.TabControl1.SelectedIndex = 1 Then
            Browser1_str = My.Settings.SearchEngine11.Replace("%s", keyword)
            Browser2_str = My.Settings.SearchEngine12.Replace("%s", keyword)
            Browser3_str = My.Settings.SearchEngine13.Replace("%s", keyword)
            Browser4_str = My.Settings.SearchEngine14.Replace("%s", keyword)
        ElseIf Setting.TabControl1.SelectedIndex = 2 Then
            Browser1_str = My.Settings.SearchEngine21.Replace("%s", keyword)
            Browser2_str = My.Settings.SearchEngine22.Replace("%s", keyword)
            Browser3_str = My.Settings.SearchEngine23.Replace("%s", keyword)
            Browser4_str = My.Settings.SearchEngine24.Replace("%s", keyword)
        ElseIf Setting.TabControl1.SelectedIndex = 3 Then
            Browser1_str = My.Settings.SearchEngine31.Replace("%s", keyword)
            Browser2_str = My.Settings.SearchEngine32.Replace("%s", keyword)
            Browser3_str = My.Settings.SearchEngine33.Replace("%s", keyword)
            Browser4_str = My.Settings.SearchEngine4.Replace("%s", keyword)
        End If

        WebBrowser1.Navigate(ConvertToUnicodeString(Browser1_str))

        WebBrowser2.Navigate(ConvertToUnicodeString(Browser2_str))
        WebBrowser3.Navigate(ConvertToUnicodeString(Browser3_str))
        WebBrowser4.Navigate(ConvertToUnicodeString(Browser4_str))



    End Sub


    Public Sub Resetbrowsers(notetype As String, viewmode As String, readertype As String)

        If notetype = "hide" Then
            If viewmode = "reader" Then
                If readertype = "html" Then
                    WebBrowser7.Visible = True
                    Tbx_url.Visible = True
                    WebBrowser1.Visible = True
                    WebBrowser2.Visible = True
                    WebBrowser3.Visible = True
                    WebBrowser4.Visible = True

                    WebBrowser6.Visible = False
                    WebBrowser5.Visible = False
                    Rtb_editor.Visible = False
                    Btn_openpdf.Visible = False
                    Gbx_editorbtns.Visible = False

                    With WebBrowser1
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With

                    With WebBrowser7
                        .Top = WebBrowser1.Top + 30
                        .Left = WebBrowser1.Left + WebBrowser1.Width
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - 60
                    End With

                    With WebBrowser2
                        .Top = WebBrowser1.Top
                        .Left = WebBrowser7.Left + WebBrowser7.Width
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With

                    With WebBrowser3
                        .Top = WebBrowser1.Top + WebBrowser1.Height
                        .Left = WebBrowser1.Left
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With

                    With WebBrowser4
                        .Top = WebBrowser1.Top + WebBrowser1.Height
                        .Left = WebBrowser7.Left + WebBrowser7.Width
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With



                    With Tbx_url
                        .Top = 0 + 30
                        .Left = WebBrowser7.Left
                        .Width = WebBrowser7.Width
                        .Height = 30

                    End With
                End If
            End If
        End If

        If notetype = "hide" Then
            If viewmode = "reader" Then
                If readertype = "pdf" Then
                    WebBrowser6.Visible = True
                    Btn_openpdf.Visible = True
                    WebBrowser1.Visible = True
                    WebBrowser2.Visible = True
                    WebBrowser3.Visible = True
                    WebBrowser4.Visible = True
                    Tbx_url.Visible = False
                    WebBrowser7.Visible = False
                    WebBrowser5.Visible = False
                    Rtb_editor.Visible = False
                    Gbx_editorbtns.Visible = False

                    With WebBrowser1
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With

                    With WebBrowser6
                        .Top = WebBrowser1.Top + 30
                        .Left = WebBrowser1.Left + WebBrowser1.Width
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - 60
                    End With

                    With WebBrowser2
                        .Top = WebBrowser1.Top
                        .Left = WebBrowser6.Left + WebBrowser6.Width
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With

                    With WebBrowser3
                        .Top = WebBrowser1.Top + WebBrowser1.Height
                        .Left = WebBrowser1.Left
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With

                    With WebBrowser4
                        .Top = WebBrowser1.Top + WebBrowser1.Height
                        .Left = WebBrowser6.Left + WebBrowser6.Width
                        .Width = Me.Width * 0.3
                        .Height = Me.Height * 0.5 - 30
                    End With



                    With Btn_openpdf
                        .Top = 0 + 30
                        .Left = WebBrowser6.Left
                        .Height = 30

                    End With
                End If
            End If
        End If

        If notetype = "local" Then
            If viewmode = "reader" Then
                If readertype = "pdf" Then
                    WebBrowser6.Visible = True
                    Btn_openpdf.Visible = True
                    Rtb_editor.Visible = True
                    Gbx_editorbtns.Visible = True

                    WebBrowser7.Visible = False
                    WebBrowser1.Visible = False
                    WebBrowser2.Visible = False
                    WebBrowser3.Visible = False
                    WebBrowser4.Visible = False
                    WebBrowser5.Visible = False
                    Tbx_url.Visible = False



                    With Rtb_editor
                        .Top = 0 + 30 + 30
                        .Left = 0
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - Rtb_editor.Top
                    End With
                    With WebBrowser6
                        .Top = 0 + 30 + 30
                        .Left = 0 + Rtb_editor.Width
                        .Width = Me.Width - Rtb_editor.Width
                        .Height = Me.Height - 30
                    End With
                    With Btn_open
                        .Left = WebBrowser6.Left
                        .Top = WebBrowser6.Top - 30
                    End With
                End If
            End If
        End If

        If notetype = "local" Then
            If viewmode = "reader" Then
                If readertype = "html" Then
                    WebBrowser7.Visible = True
                    Tbx_url.Visible = True
                    Rtb_editor.Visible = True
                    Gbx_editorbtns.Visible = True

                    WebBrowser6.Visible = False
                    WebBrowser1.Visible = False
                    WebBrowser2.Visible = False
                    WebBrowser3.Visible = False
                    WebBrowser4.Visible = False
                    WebBrowser5.Visible = False

                    Btn_openpdf.Visible = False
                    With Rtb_editor
                        .Top = 0 + 30 + 30
                        .Left = 0
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - Rtb_editor.Top
                    End With
                    With WebBrowser7
                        .Top = 0 + 30 + 30
                        .Left = 0 + Rtb_editor.Width
                        .Width = Me.Width - Rtb_editor.Width
                        .Height = Me.Height - 30
                    End With
                    With Tbx_url
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.5
                    End With
                End If
            End If
        End If

        If notetype = "onenote" Then
            If viewmode = "reader" Then
                If readertype = "html" Then
                    WebBrowser7.Visible = True
                    Tbx_url.Visible = True
                    WebBrowser5.Visible = True
                    WebBrowser6.Visible = False
                    WebBrowser1.Visible = False
                    WebBrowser2.Visible = False
                    WebBrowser3.Visible = False
                    WebBrowser4.Visible = False
                    Rtb_editor.Visible = False
                    Btn_openpdf.Visible = False
                    Gbx_editorbtns.Visible = False
                    With WebBrowser5
                        .Top = 0 + 30 + 30
                        .Left = 0
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - 80
                    End With
                    With WebBrowser7
                        .Top = 0 + 30 + 30
                        .Left = 0 + WebBrowser5.Width
                        .Width = Me.Width - WebBrowser5.Width
                        .Height = WebBrowser5.Height

                    End With
                    With Tbx_url
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.5
                    End With
                End If
            End If
        End If


        If notetype = "onenote" Then
            If viewmode = "reader" Then
                If readertype = "pdf" Then
                    WebBrowser6.Visible = True
                    Btn_openpdf.Visible = True
                    WebBrowser5.Visible = True

                    WebBrowser7.Visible = False
                    WebBrowser1.Visible = False
                    WebBrowser2.Visible = False
                    WebBrowser3.Visible = False
                    WebBrowser4.Visible = False
                    Rtb_editor.Visible = False
                    Tbx_url.Visible = False
                    Gbx_editorbtns.Visible = False
                    With WebBrowser5
                        .Top = 0 + 30 + 30
                        .Left = 0
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - 30
                    End With
                    With WebBrowser6
                        .Top = 0 + 30 + 30
                        .Left = 0 + WebBrowser5.Width
                        .Width = Me.Width - WebBrowser5.Width
                        .Height = Me.Height - 30
                    End With
                    With Btn_open
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.5
                    End With
                End If
            End If
        End If

        If notetype = "googledoc" Then
            If viewmode = "reader" Then
                If readertype = "html" Then
                    WebBrowser7.Visible = True
                    Tbx_url.Visible = True
                    WebBrowser5.Visible = True
                    WebBrowser6.Visible = False
                    WebBrowser1.Visible = False
                    WebBrowser2.Visible = False
                    WebBrowser3.Visible = False
                    WebBrowser4.Visible = False
                    Rtb_editor.Visible = False
                    Btn_openpdf.Visible = False
                    Gbx_editorbtns.Visible = False
                    With WebBrowser5
                        .Top = 0 + 30 + 30
                        .Left = 0
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - 30
                    End With
                    With WebBrowser7
                        .Top = 0 + 30 + 30
                        .Left = 0 + WebBrowser5.Width
                        .Width = Me.Width - WebBrowser5.Width
                        .Height = Me.Height - 30
                    End With
                    With Tbx_url
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.5
                    End With
                End If
            End If
        End If

        If notetype = "googledoc" Then
            If viewmode = "reader" Then
                If readertype = "pdf" Then
                    WebBrowser6.Visible = True
                    Btn_openpdf.Visible = True
                    WebBrowser5.Visible = True

                    WebBrowser7.Visible = False
                    WebBrowser1.Visible = False
                    WebBrowser2.Visible = False
                    WebBrowser3.Visible = False
                    WebBrowser4.Visible = False
                    Rtb_editor.Visible = False
                    Tbx_url.Visible = False
                    Gbx_editorbtns.Visible = False
                    With WebBrowser5
                        .Top = 0 + 30 + 30
                        .Left = 0
                        .Width = Me.Width * 0.4
                        .Height = Me.Height - 30
                    End With
                    With WebBrowser6
                        .Top = 0 + 30 + 30
                        .Left = 0 + WebBrowser5.Width
                        .Width = Me.Width - WebBrowser5.Width
                        .Height = Me.Height - 30
                    End With
                    With Btn_open
                        .Top = 0 + 30
                        .Left = 0
                        .Width = Me.Width * 0.5
                    End With
                End If
            End If
        End If
        ' translator mode!!!!!!!!!!!


        If notetype = "hide" Then
            If viewmode = "translator" Then



                WebBrowser1.Visible = True
                WebBrowser2.Visible = True
                WebBrowser3.Visible = True
                WebBrowser4.Visible = True

                WebBrowser5.Visible = False
                Rtb_editor.Visible = False
                Btn_openpdf.Visible = False
                WebBrowser7.Visible = False
                Tbx_url.Visible = False
                WebBrowser6.Visible = False
                Gbx_editorbtns.Visible = False

                With WebBrowser1
                    .Top = 0 + 30
                    .Left = 0
                    .Width = Me.Width * 0.5
                    .Height = Me.Height * 0.5
                End With

                With WebBrowser2
                    .Top = WebBrowser1.Top
                    .Left = WebBrowser1.Left + WebBrowser1.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

                With WebBrowser3
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With


                With WebBrowser4
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left + WebBrowser1.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

            End If
        End If

        If notetype = "onenote" Then
            If viewmode = "translator" Then



                WebBrowser1.Visible = True
                WebBrowser2.Visible = True
                WebBrowser3.Visible = True
                WebBrowser4.Visible = True
                WebBrowser5.Visible = True

                Btn_openpdf.Visible = False
                WebBrowser7.Visible = False
                Tbx_url.Visible = False
                WebBrowser6.Visible = False
                Rtb_editor.Visible = False
                Gbx_editorbtns.Visible = False

                With WebBrowser1
                    .Top = 0 + 30
                    .Left = 0
                    .Width = Me.Width * 0.3
                    .Height = Me.Height * 0.5
                End With

                With WebBrowser5
                    .Left = WebBrowser1.Left + WebBrowser1.Width
                    .Top = WebBrowser1.Top
                    .Width = Me.Width - WebBrowser1.Width * 2
                    .Height = Me.Height

                End With

                With WebBrowser2
                    .Top = WebBrowser1.Top
                    .Left = WebBrowser1.Left + WebBrowser1.Width + WebBrowser5.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

                With WebBrowser3
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With


                With WebBrowser4
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left + WebBrowser1.Width + WebBrowser5.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

            End If
        End If


        If notetype = "googledoc" Then
            If viewmode = "translator" Then



                WebBrowser1.Visible = True
                WebBrowser2.Visible = True
                WebBrowser3.Visible = True
                WebBrowser4.Visible = True
                WebBrowser5.Visible = True

                Btn_openpdf.Visible = False
                WebBrowser7.Visible = False
                Tbx_url.Visible = False
                WebBrowser6.Visible = False
                Rtb_editor.Visible = False
                Gbx_editorbtns.Visible = False

                With WebBrowser1
                    .Top = 0 + 30
                    .Left = 0
                    .Width = Me.Width * 0.3
                    .Height = Me.Height * 0.5
                End With

                With WebBrowser5
                    .Left = WebBrowser1.Left + WebBrowser1.Width
                    .Top = WebBrowser1.Top
                    .Width = Me.Width - WebBrowser1.Width * 2
                    .Height = Me.Height

                End With

                With WebBrowser2
                    .Top = WebBrowser1.Top
                    .Left = WebBrowser1.Left + WebBrowser1.Width + WebBrowser5.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

                With WebBrowser3
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With


                With WebBrowser4
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left + WebBrowser1.Width + WebBrowser5.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

            End If
        End If

        If notetype = "local" Then
            If viewmode = "translator" Then



                WebBrowser1.Visible = True
                WebBrowser2.Visible = True
                WebBrowser3.Visible = True
                WebBrowser4.Visible = True
                Gbx_editorbtns.Visible = True
                Rtb_editor.Visible = True

                Btn_openpdf.Visible = False
                WebBrowser7.Visible = False
                Tbx_url.Visible = False
                WebBrowser6.Visible = False
                WebBrowser5.Visible = False


                With WebBrowser1
                    .Top = 0 + 30
                    .Left = 0
                    .Width = Me.Width * 0.3
                    .Height = Me.Height * 0.5
                End With

                With Rtb_editor
                    .Left = WebBrowser1.Left + WebBrowser1.Width
                    .Top = WebBrowser1.Top
                    .Width = Me.Width - WebBrowser1.Width * 2
                    .Height = Me.Height - Rtb_editor.Top

                End With

                With WebBrowser2
                    .Top = WebBrowser1.Top
                    .Left = WebBrowser1.Left + WebBrowser1.Width + Rtb_editor.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

                With WebBrowser3
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With


                With WebBrowser4
                    .Top = WebBrowser1.Top + WebBrowser1.Height
                    .Left = WebBrowser1.Left + WebBrowser1.Width + Rtb_editor.Width
                    .Width = WebBrowser1.Width
                    .Height = WebBrowser1.Height
                End With

            End If
        End If

    End Sub




    Private Sub Btn_set_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_set.Click
        Setting.Show()
    End Sub

    Private Sub Btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_exit.Click
        End
    End Sub

    Private Sub Btn_search_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_search.Click




    End Sub




    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.Text = “张浩波的浏览器--专业版V1.9.1”
        ' Dim today As String
        ' Today = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        ' Me.Text = today
        ''If Mid(today, 1, 10) = "2018/02/07" Then
        'Me.Text = Me.Text & "祝JosephZ 生日快乐！"
        'End If
        'Rbtn_notehide.Checked = True
        'notetype = "hide"
        ' viewmode = "reader"
        'readertype = "html"

        Rbtn_translator.Checked = True
        Rbtn_notelocal.Checked = True



        Timer1.Stop()


        InitializeMyContextMenu()
        'WebBrowser1.ObjectForScripting = True


        With Me
            .Top = Screen.PrimaryScreen.WorkingArea.Top
            .Left = Screen.PrimaryScreen.WorkingArea.Left
            .Width = Screen.PrimaryScreen.WorkingArea.Width
            .Height = Screen.PrimaryScreen.WorkingArea.Height

        End With
        'Debuginfo1.Text = Str(Me.Top) & Str(Me.Left)

        Resetbrowsers(notetype, viewmode, readertype)
        opennewfile()





    End Sub
    Private Sub Btn_bold_Click_1(sender As Object, e As EventArgs) Handles Btn_bold.Click
        On Error Resume Next
        If Rtb_editor.SelectionFont.Bold = True Then
            If Rtb_editor.SelectionFont.Italic = True Then
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, CType((FontStyle.Regular + FontStyle.Italic), FontStyle))

            Else
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, FontStyle.Regular)
            End If

        ElseIf Rtb_editor.SelectionFont.Bold = False Then
            If Rtb_editor.SelectionFont.Italic = True Then
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, CType((FontStyle.Bold + FontStyle.Italic), FontStyle))
            Else
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, FontStyle.Bold)
            End If
        End If
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_italic_Click_1(sender As Object, e As EventArgs) Handles Btn_italic.Click
        On Error Resume Next

        If Rtb_editor.SelectionFont.Italic = True Then
            If Rtb_editor.SelectionFont.Bold = True Then
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, CType((FontStyle.Regular + FontStyle.Bold), FontStyle))
            Else
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, FontStyle.Regular)
            End If

        ElseIf Rtb_editor.SelectionFont.Italic = False Then
            If Rtb_editor.SelectionFont.Bold = True Then
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, CType((FontStyle.Italic + FontStyle.Bold), FontStyle))
            Else
                Rtb_editor.SelectionFont = New Font(Me.Rtb_editor.SelectionFont, FontStyle.Italic)
            End If
        End If
        Rtb_editor.Focus()
    End Sub

    Public Sub InitializeMyContextMenu()
        Dim contextmenu1, contextmenu2 As New ContextMenu()
        Dim menuItem1 As New MenuItem("&Cut")
        AddHandler menuItem1.Click, AddressOf Btn_cut_Click_1
        Dim menuItem2 As New MenuItem("&Copy")
        AddHandler menuItem2.Click, AddressOf Btn_copy_Click_1
        Dim menuItem3 As New MenuItem("&Paste")
        AddHandler menuItem3.Click, AddressOf Btn_paste_Click
        Dim menuItem4 As New MenuItem("翻译为英文")
        AddHandler menuItem4.Click, AddressOf Btn_MTen_Click
        Dim menuItem5 As New MenuItem("翻译为中文")
        AddHandler menuItem5.Click, AddressOf Btn_MTzh_Click
        Dim menuItem6 As New MenuItem("双语文本检索in GoogleYahooBingBaidu")
        AddHandler menuItem6.Click, AddressOf Btn_SEctxt_Click
        Dim menuItem7 As New MenuItem("Copy Current URL")
        AddHandler menuItem7.Click, AddressOf Btn_CPurl_Click


        Dim menuItem8 As New MenuItem("双语文本检索in GoogleYahooBingBaidu")
        AddHandler menuItem8.Click, AddressOf Btn_html_SE_Click


        ' Use the MenuItems property to call the Add method
        ' to add the MenuItem to the MainMenu menu item collection. 
        contextmenu1.MenuItems.Add(menuItem7)
        contextmenu1.MenuItems.Add(menuItem1)
        contextmenu1.MenuItems.Add(menuItem2)
        contextmenu1.MenuItems.Add(menuItem3)
        contextmenu1.MenuItems.Add(menuItem4)
        contextmenu1.MenuItems.Add(menuItem5)
        contextmenu1.MenuItems.Add(menuItem6)
        Rtb_editor.ContextMenu = contextmenu1
        'WebBrowser6.IsWebBrowserContextMenuEnabled = False
        'WebBrowser7.IsWebBrowserContextMenuEnabled = False

        WebBrowser6.ContextMenu = contextmenu2
        WebBrowser7.ContextMenu = contextmenu2




    End Sub

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Resetbrowsers(notetype, viewmode, readertype)
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Debug.Click
    ' Debuginfo.Text = Browser1_str
    '  Browser1_str = My.Settings.SearchEngine1.Replace("%s", keyword)
    '  Debuginfo.Text = Browser1_str & " Webbrowser1 left: " & WebBrowser1.Left & " Webbrowser1 top: " & WebBrowser1.Top & " ME left: " & Me.Left & " ME top: " & Me.Top
    ' End Sub


    Private Sub Tbx_search_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Tbx_search.KeyDown


        If e.KeyCode = Keys.Enter Then
            Searchnow(Tbx_search.Text)
        End If


    End Sub


    Private Sub Rbtn1_learner_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_notelocal.CheckedChanged
        If Rbtn_notelocal.Checked = True Then
            notetype = "local"
            Resetbrowsers(notetype, viewmode, readertype)
        End If

    End Sub

    Private Sub Rbtn2_simple_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_notehide.CheckedChanged
        If Rbtn_notehide.Checked = True Then
            notetype = "hide"
            Resetbrowsers(notetype, viewmode, readertype)
        End If

    End Sub












    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click

        If notetype = "hide" Then
            MsgBox("You need to change to learner's mode")
            Exit Sub
        End If
        Dim SaveFileDialog1 As New SaveFileDialog
        SaveFileDialog1.InitialDirectory = Application.ExecutablePath
        SaveFileDialog1.DefaultExt = "rtf"
        SaveFileDialog1.FileName = "NewFile"
        SaveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*) | *.*"
        SaveFileDialog1.ShowDialog()
        Rtb_editor.SaveFile(SaveFileDialog1.FileName)
    End Sub

    Private Sub Btn_undo_Click_1(sender As Object, e As EventArgs) Handles Btn_undo.Click
        Rtb_editor.Undo()
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_redo_Click_1(sender As Object, e As EventArgs) Handles Btn_redo.Click
        Rtb_editor.Redo()
        Rtb_editor.Focus()
    End Sub



    Private Sub Btn_font_Click_1(sender As Object, e As EventArgs) Handles Btn_font.Click
        Dim fontDialod As New FontDialog
        fontDialod.Font = Rtb_editor.SelectionFont
        fontDialod.ShowDialog()
        Rtb_editor.SelectionFont = fontDialod.Font
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_alignmid_Click(sender As Object, e As EventArgs) Handles Btn_alignmid.Click
        Rtb_editor.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub Btn_alignright_Click(sender As Object, e As EventArgs) Handles Btn_alignright.Click
        Rtb_editor.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub Btn_copy_Click_1(sender As Object, e As EventArgs) Handles Btn_copy.Click
        My.Computer.Clipboard.Clear()
        Try
            Clipboard.SetText(Rtb_editor.SelectedText)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_paste_Click(sender As Object, e As EventArgs) Handles Btn_paste.Click
        If My.Computer.Clipboard.ContainsText Then
            Rtb_editor.Paste()
        End If
    End Sub

    Private Sub Btn_cut_Click_1(sender As Object, e As EventArgs) Handles Btn_cut.Click
        My.Computer.Clipboard.Clear()
        Try
            Clipboard.SetText(Rtb_editor.SelectedText)
            Rtb_editor.SelectedText = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If Setting.TabControl1.SelectedIndex = 0 Then

            WebBrowser1.Document.Window.ScrollTo(CInt(My.Settings.ScrollX1), CInt(My.Settings.ScrollY1))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale1)), WebBrowser1)
        ElseIf Setting.TabControl1.SelectedIndex = 1 Then
            WebBrowser1.Document.Window.ScrollTo(CInt(My.Settings.ScrollX11), CInt(My.Settings.ScrollY11))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale11)), WebBrowser1)
        ElseIf Setting.TabControl1.SelectedIndex = 2 Then
            WebBrowser1.Document.Window.ScrollTo(CInt(My.Settings.ScrollX21), CInt(My.Settings.ScrollY21))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale21)), WebBrowser1)

        ElseIf Setting.TabControl1.SelectedIndex = 3 Then
            WebBrowser1.Document.Window.ScrollTo(CInt(My.Settings.ScrollX31), CInt(My.Settings.ScrollY31))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale31)), WebBrowser1)
        End If




    End Sub

    Private Sub Btn_sizeup_Click_1(sender As Object, e As EventArgs) Handles Btn_sizeup.Click
        Try
            Rtb_editor.SelectionFont = New Font(Rtb_editor.SelectionFont.FontFamily, Int(Rtb_editor.SelectionFont.SizeInPoints + 5))
        Catch ex As Exception
        End Try
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_bgcolor_Click(sender As Object, e As EventArgs) Handles Btn_bgcolor.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = Rtb_editor.BackColor
        colorDialog.ShowDialog()
        Rtb_editor.BackColor = colorDialog.Color
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_alignleft_Click_1(sender As Object, e As EventArgs) Handles Btn_alignleft.Click
        Rtb_editor.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Btn_sizedown_Click_1(sender As Object, e As EventArgs) Handles Btn_sizedown.Click
        Try
            Rtb_editor.SelectionFont = New Font(Rtb_editor.SelectionFont.FontFamily, Int(Rtb_editor.SelectionFont.SizeInPoints - 5))
        Catch ex As Exception
        End Try
        Rtb_editor.Focus()
    End Sub






    Private Sub Btn_SEctxt_Click(sender As Object, e As EventArgs) Handles Btn_SEctxt.Click


        If Rtb_editor.SelectedText = "" Then
            Exit Sub
        End If

        rtbselect = Rtb_editor.SelectedText
        sourcestring = Rtb_editor.SelectedText


        Browser1_str = "https://www.google.com/search?q=" & ConvertToUnicodeString(sourcestring)
        On Error Resume Next
        WebBrowser1.Navigate(Browser1_str)


        Browser2_str = "https://www.bing.com/search?q=" & ConvertToUnicodeString(sourcestring)
        On Error Resume Next
        WebBrowser2.Navigate(Browser2_str)


        Browser3_str = "https://search.yahoo.com/search?p=" & ConvertToUnicodeString(sourcestring)
        On Error Resume Next
        WebBrowser3.Navigate(Browser3_str)
        Debuginfo1.Text = Browser3_str

        Browser4_str = "https://www.baidu.com/s?wd=" & ConvertToUnicodeString(sourcestring)
        On Error Resume Next
        WebBrowser4.Navigate(Browser4_str)

    End Sub


    Private Sub Btn_hightlight_Click_1(sender As Object, e As EventArgs) Handles Btn_hightlight.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = Rtb_editor.SelectionBackColor
        colorDialog.ShowDialog()
        Rtb_editor.SelectionBackColor = colorDialog.Color
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_fontcolor_Click_1(sender As Object, e As EventArgs) Handles Btn_fontcolor.Click
        Dim colorDialog As New ColorDialog
        colorDialog.Color = Rtb_editor.SelectionColor
        colorDialog.ShowDialog()
        Rtb_editor.SelectionColor = colorDialog.Color
        Rtb_editor.Focus()
    End Sub

    Private Sub Btn_open_Click_1(sender As Object, e As EventArgs) Handles Btn_open.Click

        opennewfile()

    End Sub
    Public Sub opennewfile()
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.InitialDirectory = Application.ExecutablePath
        OpenFileDialog1.DefaultExt = "rtf"
        OpenFileDialog1.FileName = "NewFile"
        OpenFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*) | *.*"

        If OpenFileDialog1.ShowDialog(Me) <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If

        If OpenFileDialog1.FileName IsNot Nothing Or OpenFileDialog1.FileName <> "" Then
            Rtb_editor.LoadFile(OpenFileDialog1.FileName)
        End If

    End Sub
    Public Sub openrecentfile()
        If My.Settings.Autosave = True Then
            Rtb_editor.LoadFile(My.Settings.Autofilename)
        End If

    End Sub







    Private Sub Rbt3_onenote_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_noteonenote.CheckedChanged
        If Rbtn_noteonenote.Checked = True Then

            notetype = "onenote"
            Resetbrowsers(notetype, viewmode, readertype)
            On Error Resume Next

            If WebBrowser5.ReadyState = WebBrowserReadyState.Uninitialized Then
                WebBrowser5.Navigate("https://www.onenote.com/")
            ElseIf WebBrowser5.Url.ToString IsNot "" Then

                If WebBrowser5.Url.ToString.Contains("one") = False Then

                    WebBrowser5.Navigate("https://www.onenote.com/")
                End If
            End If
        End If




    End Sub


    Private Sub ZoomWebBrowser(ByVal factor As Single, targetBrowser As WebBrowser)
        Dim factorStr As String = ((factor * 100).ToString + "%")
        targetBrowser.Document.Body.Style = (targetBrowser.Document.Body.Style + (";zoom:" + factorStr))

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim modetext As String
        modetext = viewmode & notetype & readertype

        If My.Settings.Autosave = True Then

            Rtb_editor.SaveFile(My.Settings.Autofilename)
            Dim myfile As New FileInfo(My.Settings.Autofilename)
            Me.Text = modetext & " Note is saved as " & My.Settings.Autofilename & " in " & DateTime.Now.ToString & " File Size: " & myfile.Length.ToString


        End If


    End Sub


    Private Sub WebBrowser2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted


        If Setting.TabControl1.SelectedIndex = 0 Then

            WebBrowser2.Document.Window.ScrollTo(CInt(My.Settings.ScrollX2), CInt(My.Settings.ScrollY2))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale2)), WebBrowser2)
        ElseIf Setting.TabControl1.SelectedIndex = 1 Then
            WebBrowser2.Document.Window.ScrollTo(CInt(My.Settings.ScrollX12), CInt(My.Settings.ScrollY12))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale12)), WebBrowser2)
        ElseIf Setting.TabControl1.SelectedIndex = 2 Then
            WebBrowser2.Document.Window.ScrollTo(CInt(My.Settings.ScrollX22), CInt(My.Settings.ScrollY22))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale22)), WebBrowser2)

        ElseIf Setting.TabControl1.SelectedIndex = 3 Then
            WebBrowser2.Document.Window.ScrollTo(CInt(My.Settings.ScrollX32), CInt(My.Settings.ScrollY32))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale32)), WebBrowser2)
        End If





    End Sub

    Private Sub Rtb_reading_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_readerhtml.CheckedChanged
        If Rbtn_readerhtml.Checked = True Then
            viewmode = "reader"
            readertype = "html"
            Resetbrowsers(notetype, viewmode, readertype)
        End If
    End Sub

    Private Sub WebBrowser6_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser6.DocumentCompleted
        If notURL = False Then
            Tbx_url.Text = WebBrowser6.Document.Url.ToString
        End If

    End Sub

    Private Sub Tbx_readbrowse_TextChanged(sender As Object, e As EventArgs) Handles Tbx_url.TextChanged

    End Sub

    Private Sub Tbx_search_TextChanged(sender As Object, e As EventArgs) Handles Tbx_search.TextChanged

    End Sub

    Private Sub WebBrowser3_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser3.DocumentCompleted


        If Setting.TabControl1.SelectedIndex = 0 Then

            WebBrowser3.Document.Window.ScrollTo(CInt(My.Settings.ScrollX3), CInt(My.Settings.ScrollY3))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale3)), WebBrowser3)
        ElseIf Setting.TabControl1.SelectedIndex = 1 Then
            WebBrowser3.Document.Window.ScrollTo(CInt(My.Settings.ScrollX13), CInt(My.Settings.ScrollY13))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale13)), WebBrowser3)
        ElseIf Setting.TabControl1.SelectedIndex = 2 Then
            WebBrowser3.Document.Window.ScrollTo(CInt(My.Settings.ScrollX23), CInt(My.Settings.ScrollY23))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale23)), WebBrowser3)

        ElseIf Setting.TabControl1.SelectedIndex = 3 Then
            WebBrowser3.Document.Window.ScrollTo(CInt(My.Settings.ScrollX33), CInt(My.Settings.ScrollY33))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale33)), WebBrowser3)
        End If


    End Sub

    Private Sub WebBrowser4_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser4.DocumentCompleted

        If Setting.TabControl1.SelectedIndex = 0 Then

            WebBrowser4.Document.Window.ScrollTo(CInt(My.Settings.ScrollX4), CInt(My.Settings.ScrollY4))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale4)), WebBrowser4)
        ElseIf Setting.TabControl1.SelectedIndex = 1 Then
            WebBrowser4.Document.Window.ScrollTo(CInt(My.Settings.ScrollX14), CInt(My.Settings.ScrollY14))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale14)), WebBrowser4)
        ElseIf Setting.TabControl1.SelectedIndex = 2 Then
            WebBrowser4.Document.Window.ScrollTo(CInt(My.Settings.ScrollX24), CInt(My.Settings.ScrollY24))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale24)), WebBrowser4)

        ElseIf Setting.TabControl1.SelectedIndex = 3 Then
            WebBrowser4.Document.Window.ScrollTo(CInt(My.Settings.ScrollX34), CInt(My.Settings.ScrollY34))
            ZoomWebBrowser(CSng(Val(My.Settings.Scale34)), WebBrowser4)
        End If

    End Sub

    Private Sub Btn_CPurl_Click(sender As Object, e As EventArgs) Handles Btn_CPurl.Click
        My.Computer.Clipboard.Clear()
        Try
            Clipboard.SetText(Tbx_url.Text)
        Catch ex As Exception
        End Try

        If My.Computer.Clipboard.ContainsText Then
            Rtb_editor.Paste()
        End If
    End Sub

    Private Sub Btn_PDF_Click(sender As Object, e As EventArgs) Handles Btn_openpdf.Click
        notURL = True
        Dim OFD As New OpenFileDialog
        OFD.Title = ".PDF files"
        OFD.Multiselect = False
        OFD.Filter = ".PDF files (*.PDF)|*.PDF"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            WebBrowser6.Navigate(OFD.FileName)
        End If
        OFD.Dispose()

    End Sub

    Private Sub Rtb_editor_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_readerpdf.CheckedChanged
        If Rbtn_readerpdf.Checked = True Then
            viewmode = "reader"
            readertype = "pdf"
            Resetbrowsers(notetype, viewmode, readertype)
        End If
    End Sub

    Private Sub Rbtn_translator_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_translator.CheckedChanged
        If Rbtn_translator.Checked = True Then
            viewmode = "translator"
            Resetbrowsers(notetype, viewmode, readertype)
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles Gbx_notetype.Enter

    End Sub

    Private Sub Debuginfo1_TextChanged(sender As Object, e As EventArgs) Handles Debuginfo1.TextChanged

    End Sub

    Private Sub Rbtn4_gdoc_CheckedChanged(sender As Object, e As EventArgs) Handles Rbtn_notegoogle.CheckedChanged
        If Rbtn_notegoogle.Checked = True Then
            notetype = "googledoc"
            Resetbrowsers(notetype, viewmode, readertype)


            If WebBrowser5.ReadyState = WebBrowserReadyState.Uninitialized Then
                WebBrowser5.Navigate("https://docs.google.com/document")
            ElseIf WebBrowser5.Url.ToString IsNot "" Then

                If WebBrowser5.Url.ToString.Contains("google") = True Then
                    Exit Sub
                Else
                    WebBrowser5.Navigate("https://docs.google.com/document")
                End If
            End If
        End If
    End Sub

    Private Sub Tmr_getMTpairhits_enzh3_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairhits_enzh3.Tick

        If WebBrowser3.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser4.ReadyState <> WebBrowserReadyState.Complete Then
            If WebBrowser3.IsBusy = True Or WebBrowser4.IsBusy = True Then
                Exit Sub
            End If
        End If



        On Error Resume Next

        googleresultstats111 = WebBrowser3.Document.GetElementById("resultStats").InnerText
        googleresultstats222 = WebBrowser4.Document.GetElementById("resultStats").InnerText

        'Rtb_editor.AppendText(vbNewLine & "WB3_topstufftxtlength is: " & Str(WebBrowser3.Document.GetElementById("topstuff").InnerText.Length)）
        'Rtb_editor.AppendText(vbNewLine & "WB4_topstufftxtlength is: " & Str(WebBrowser4.Document.GetElementById("topstuff").InnerText.Length)）


        If WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser3.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats111 = “0"
            End If
        End If

        If WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser4.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats222 = “0"
            End If
        End If

        googleresultstats111 = Mid(googleresultstats111, 1, googleresultstats111.IndexOf("r"))
        googleresultstats222 = Mid(googleresultstats222, 1, googleresultstats222.IndexOf("r"))



        Rtb_editor.SelectionStart = Rtb_editor.TextLength
        Rtb_editor.ScrollToCaret()


        If Num(googleresultstats11) > Num(googleresultstats22) Then
            Rtb_editor.AppendText(vbNewLine & "MT译文选举结果：GoogleMT译文最佳"）
        End If

        If Num(googleresultstats11) < Num(googleresultstats22) Then
            Rtb_editor.AppendText(vbNewLine & "MT译文选举结果：BaiduMT译文最佳"）
        End If

        If Num(googleresultstats11) > 0 And Num(googleresultstats22) > 0 And Num(googleresultstats11) = Num(googleresultstats22) Then
            Rtb_editor.AppendText(vbNewLine & "最佳MT译文：BaiduMT与GoogleMT并列最佳译文"）
        End If

        If Num(googleresultstats11) = 0 And Num(googleresultstats22) = 0 Then
            Rtb_editor.AppendText(vbNewLine & "MT译文选举结果：无理想MT译文"）
            If Num(googleresultstats111) > Num(googleresultstats222) Then
                Rtb_editor.AppendText("，尽管GoogleMT的译文使用率更高"）
            ElseIf Num(googleresultstats111) < Num(googleresultstats222) Then
                Rtb_editor.AppendText("，尽管BaiduMT的译文使用率更高"）
            ElseIf Num(googleresultstats111) = 0 And Num(googleresultstats222) = 0 Then
                Rtb_editor.AppendText("，并查无译文的任何使用个例"）
            ElseIf Num(googleresultstats111) = Num(googleresultstats222) Then
                Rtb_editor.AppendText("，Google与Baidu的译文使用率相等"）
            End If
        End If

        Rtb_editor.AppendText(vbNewLine & "GoogleMT: " & translationresultgoogle_enzh)
        Rtb_editor.AppendText(" GB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats1)), Browser3_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats11)), Browser33_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PT hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats111)), Browser333_str.Replace(" ", "+"))


        Rtb_editor.AppendText(vbNewLine & "BaiduMT: " & translationresultbaidu_enzh)
        Rtb_editor.AppendText(" GB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats2)), Browser4_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats22)), Browser44_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PT hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats222)), Browser444_str.Replace(" ", "+"))
        Rtb_editor.AppendText(vbNewLine)



        googleresultstats1 = ""
        googleresultstats2 = ""
        googleresultstats11 = ""
        googleresultstats22 = ""
        googleresultstats111 = ""
        googleresultstats222 = ""
        Browser1_str = ""
        Browser2_str = ""
        Browser3_str = ""
        Browser4_str = ""
        Browser33_str = ""
        Browser44_str = ""
        Browser333_str = ""
        Browser444_str = ""

        translationresultbaidu_zhen = ""
        translationresultbaidu_enzh = ""
        translationresultgoogle_zhen = ""
        translationresultgoogle_enzh = ""

        Tmr_getMTpairs_enzh.Stop()
        Tmr_getMTpairhits_enzh.Stop()
        Tmr_getMTpairhits_enzh2.Stop()
        Tmr_getMTpairhits_enzh3.Stop()
        Tmr_DefaultWBready_enzh.Stop()



    End Sub

    Private Sub Tmr_DefaultWBready_zhen_Tick(sender As Object, e As EventArgs) Handles Tmr_DefaultWBready_zhen.Tick

        If WebBrowser1.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser2.ReadyState <> WebBrowserReadyState.Complete Then
            Exit Sub
        End If

        Browser1_str = "https://translate.google.com/#auto/en/" & sourcestring
        WebBrowser1.Navigate(Browser1_str)


        Browser2_str = "http://fanyi.baidu.com/#auto/en/" & sourcestring
        WebBrowser2.Navigate(Browser2_str)

        Tmr_DefaultWBready_zhen.Stop()
        Tmr_getMTpairs_zhen.Start()
    End Sub

    Private Sub Tmr_getMTpairhits_zhen2_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairhits_zhen2.Tick


        If WebBrowser3.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser4.ReadyState <> WebBrowserReadyState.Complete Then
            If WebBrowser3.IsBusy = True Or WebBrowser4.IsBusy = True Then
                Exit Sub
            End If
        End If



        On Error Resume Next

        googleresultstats11 = WebBrowser3.Document.GetElementById("resultStats").InnerText
        googleresultstats22 = WebBrowser4.Document.GetElementById("resultStats").InnerText



        'Rtb_editor.AppendText(vbNewLine & "WB3_topstufftxtlength is: " & Str(WebBrowser3.Document.GetElementById("topstuff").InnerText.Length)）
        'Rtb_editor.AppendText(vbNewLine & "WB4_topstufftxtlength is: " & Str(WebBrowser4.Document.GetElementById("topstuff").InnerText.Length)）


        If WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser3.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats11 = “0"
            End If
        End If

        If WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser4.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats22 = “0"
            End If
        End If



        googleresultstats11 = Mid(googleresultstats11, 1, googleresultstats11.IndexOf("r"))
        googleresultstats22 = Mid(googleresultstats22, 1, googleresultstats22.IndexOf("r"))


        Browser333_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & translationresultgoogle_zhen & "%22")



        Browser444_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & translationresultbaidu_zhen & "%22")

        If Browser333_str Is Nothing Or Browser33_str = "" Or Browser444_str Is Nothing Or Browser44_str = "" Then
            Exit Sub
        End If


        WebBrowser3.Navigate(Browser333_str)
        WebBrowser4.Navigate(Browser444_str)




        Tmr_getMTpairhits_zhen2.Stop()
        Tmr_getMTpairhits_zhen3.Start()

    End Sub

    Private Sub Tmr_getMTpairhits_zhen3_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairhits_zhen3.Tick

        If WebBrowser3.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser4.ReadyState <> WebBrowserReadyState.Complete Then
            If WebBrowser3.IsBusy = True Or WebBrowser4.IsBusy = True Then
                Exit Sub
            End If
        End If



        On Error Resume Next

        googleresultstats111 = WebBrowser3.Document.GetElementById("resultStats").InnerText
        googleresultstats222 = WebBrowser4.Document.GetElementById("resultStats").InnerText

        'Rtb_editor.AppendText(vbNewLine & "WB3_topstufftxtlength is: " & Str(WebBrowser3.Document.GetElementById("topstuff").InnerText.Length)）
        'Rtb_editor.AppendText(vbNewLine & "WB4_topstufftxtlength is: " & Str(WebBrowser4.Document.GetElementById("topstuff").InnerText.Length)）


        If WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser3.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats111 = “0"
            End If
        End If

        If WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser4.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats222 = “0"
            End If
        End If


        googleresultstats111 = Mid(googleresultstats111, 1, googleresultstats111.IndexOf("r"))
        googleresultstats222 = Mid(googleresultstats222, 1, googleresultstats222.IndexOf("r"))


        Rtb_editor.SelectionStart = Rtb_editor.TextLength
        Rtb_editor.ScrollToCaret()


        If Num(googleresultstats11) > Num(googleresultstats22) Then
            Rtb_editor.AppendText(vbNewLine & "MT译文选举结果：GoogleMT译文最佳"）
        End If

        If Num(googleresultstats11) < Num(googleresultstats22) Then
            Rtb_editor.AppendText(vbNewLine & "MT译文选举结果：BaiduMT译文最佳"）
        End If

        If Num(googleresultstats11) > 0 And Num(googleresultstats22) > 0 And Num(googleresultstats11) = Num(googleresultstats22) Then
            Rtb_editor.AppendText(vbNewLine & "最佳MT译文：BaiduMT与GoogleMT并列最佳译文"）
        End If

        If Num(googleresultstats11) = 0 And Num(googleresultstats22) = 0 Then
            Rtb_editor.AppendText(vbNewLine & "MT译文选举结果：无理想MT译文"）
            If Num(googleresultstats111) > Num(googleresultstats222) Then
                Rtb_editor.AppendText("，尽管GoogleMT的译文使用率更高"）
            ElseIf Num(googleresultstats111) < Num(googleresultstats222) Then
                Rtb_editor.AppendText("，尽管BaiduMT的译文使用率更高"）
            ElseIf Num(googleresultstats111) = 0 And Num(googleresultstats222) = 0 Then
                Rtb_editor.AppendText("，并查无译文的任何使用个例"）
            ElseIf Num(googleresultstats111) = Num(googleresultstats222) Then
                Rtb_editor.AppendText("，Google与Baidu的译文使用率相等"）
            End If
        End If



        Rtb_editor.AppendText(vbNewLine & "GoogleMT: " & translationresultgoogle_zhen & vbNewLine)
        Rtb_editor.AppendText(" GB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats1)), Browser3_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats11)), Browser33_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PT hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats111)), Browser333_str.Replace(" ", "+"))


        Rtb_editor.AppendText(vbNewLine & "BaiduMT: " & translationresultbaidu_zhen & vbNewLine)
        Rtb_editor.AppendText(" GB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats2)), Browser4_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PB hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats22)), Browser44_str.Replace(" ", "+"))
        Rtb_editor.AppendText(" PT hits:")
        Rtb_editor.InsertLink(Str(Num(googleresultstats222)), Browser444_str.Replace(" ", "+"))
        Rtb_editor.AppendText(vbNewLine)


        googleresultstats1 = ""
        googleresultstats2 = ""
        googleresultstats11 = ""
        googleresultstats22 = ""
        googleresultstats111 = ""
        googleresultstats222 = ""
        Browser1_str = ""
        Browser2_str = ""
        Browser3_str = ""
        Browser4_str = ""
        Browser33_str = ""
        Browser44_str = ""
        Browser333_str = ""
        Browser444_str = ""

        translationresultbaidu_zhen = ""
        translationresultbaidu_enzh = ""
        translationresultgoogle_zhen = ""
        translationresultgoogle_enzh = ""


        Tmr_DefaultWBready_zhen.Stop()
        Tmr_getMTpairs_zhen.Stop()
        Tmr_getMTpairhits_zhen.Stop()
        Tmr_getMTpairhits_zhen2.Stop()
        Tmr_getMTpairhits_zhen3.Stop()

    End Sub

    Private Sub Btn_cpwb_Click(sender As Object, e As EventArgs) Handles Btn_cpwb.Click

    End Sub

    Private Sub Tmr_DefaultWBready_Tick(sender As Object, e As EventArgs) Handles Tmr_DefaultWBready_enzh.Tick

        If WebBrowser1.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser2.ReadyState <> WebBrowserReadyState.Complete Then
            Exit Sub
        End If

        Browser1_str = "https://translate.google.com/#auto/zh-CN/" & sourcestring
        WebBrowser1.Navigate(Browser1_str)


        Browser2_str = "http://fanyi.baidu.com/#auto/zh/" & sourcestring
        WebBrowser2.Navigate(Browser2_str)

        Tmr_DefaultWBready_enzh.Stop()
        Tmr_getMTpairs_enzh.Start()
    End Sub

    Private Sub Btn_MTzh_Click(sender As Object, e As EventArgs) Handles Btn_MTzh.Click





        googleresultstats1 = ""
        googleresultstats2 = ""
        googleresultstats11 = ""
        googleresultstats22 = ""
        googleresultstats111 = ""
        googleresultstats222 = ""
        Browser1_str = ""
        Browser2_str = ""
        Browser3_str = ""
        Browser4_str = ""
        Browser33_str = ""
        Browser44_str = ""
        Browser333_str = ""
        Browser444_str = ""

        translationresultbaidu_zhen = ""
        translationresultbaidu_enzh = ""
        translationresultgoogle_zhen = ""
        translationresultgoogle_enzh = ""

        Tmr_getMTpairs_enzh.Stop()
        Tmr_getMTpairhits_enzh.Stop()
        Tmr_getMTpairhits_enzh2.Stop()
        Tmr_getMTpairhits_enzh3.Stop()


        If Rtb_editor.SelectedText = "" Then
            Exit Sub
        End If

        sourcestring = Rtb_editor.SelectedText
        WebBrowser1.Navigate("about:blank")
        WebBrowser2.Navigate("about:blank")
        WebBrowser3.Navigate("about:blank")
        WebBrowser4.Navigate("about:blank")

        Tmr_DefaultWBready_enzh.Start()





    End Sub

    Private Sub WebBrowser7_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser7.DocumentCompleted
        Tbx_url.Text = WebBrowser7.Url.ToString
        WebBrowser7.ScrollBarsEnabled = True



    End Sub



    Private Sub Menu_readerhtml_Opening(sender As Object, e As CancelEventArgs)

    End Sub

    Private Sub Tmr_getMTpairhits_enzh2_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairhits_enzh2.Tick


        If WebBrowser3.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser4.ReadyState <> WebBrowserReadyState.Complete Then
            If WebBrowser3.IsBusy = True Or WebBrowser4.IsBusy = True Then
                Exit Sub
            End If
        End If



        On Error Resume Next

        googleresultstats11 = WebBrowser3.Document.GetElementById("resultStats").InnerText
        googleresultstats22 = WebBrowser4.Document.GetElementById("resultStats").InnerText


        ' Rtb_editor.AppendText(vbNewLine & "WB3_topstufftxtlength is: " & Str(WebBrowser3.Document.GetElementById("topstuff").InnerText.Length)）
        'Rtb_editor.AppendText(vbNewLine & "WB4_topstufftxtlength is: " & Str(WebBrowser4.Document.GetElementById("topstuff").InnerText.Length)）


        If WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser3.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser3.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats11 = “0"
            End If
        End If

        If WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot Nothing And WebBrowser4.Document.GetElementById("topstuff").InnerText IsNot "" Then
            If WebBrowser4.Document.GetElementById("topstuff").InnerText.Length > 10 Then
                googleresultstats22 = “0"
            End If
        End If






        googleresultstats11 = Mid(googleresultstats11, 1, googleresultstats11.IndexOf("r"))
        googleresultstats22 = Mid(googleresultstats22, 1, googleresultstats22.IndexOf("r"))


        Browser333_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & translationresultgoogle_enzh & "%22")



        Browser444_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & translationresultbaidu_enzh & "%22")

        If Browser333_str Is Nothing Or Browser33_str = "" Or Browser444_str Is Nothing Or Browser44_str = "" Then
            Exit Sub
        End If


        WebBrowser3.Navigate(Browser333_str)
        WebBrowser4.Navigate(Browser444_str)




        Tmr_getMTpairhits_enzh2.Stop()
        Tmr_getMTpairhits_enzh3.Start()



    End Sub

    Private Sub Btn_MTen_Click(sender As Object, e As EventArgs) Handles Btn_MTen.Click


        googleresultstats1 = ""
        googleresultstats2 = ""
        googleresultstats11 = ""
        googleresultstats22 = ""
        googleresultstats111 = ""
        googleresultstats222 = ""
        Browser1_str = ""
        Browser2_str = ""
        Browser3_str = ""
        Browser4_str = ""
        Browser33_str = ""
        Browser44_str = ""
        Browser333_str = ""
        Browser444_str = ""

        translationresultbaidu_zhen = ""
        translationresultbaidu_enzh = ""
        translationresultgoogle_zhen = ""
        translationresultgoogle_enzh = ""

        Tmr_getMTpairs_zhen.Stop()
        Tmr_getMTpairhits_zhen.Stop()
        Tmr_getMTpairhits_zhen2.Stop()
        Tmr_getMTpairhits_zhen3.Stop()

        If Rtb_editor.SelectedText = "" Then
            Exit Sub
        End If

        sourcestring = Rtb_editor.SelectedText
        WebBrowser1.Navigate("about:blank")
        WebBrowser2.Navigate("about:blank")
        WebBrowser3.Navigate("about:blank")
        WebBrowser4.Navigate("about:blank")

        Tmr_DefaultWBready_zhen.Start()




    End Sub

    Public Sub getMTpairs_zhen()
        If Rtb_editor.SelectedText = "" Then
            Exit Sub
        End If


        sourcestring = Rtb_editor.SelectedText


        Browser1_str = "https://translate.google.com/#auto/en/" & sourcestring
        On Error Resume Next
        WebBrowser1.Navigate(Browser1_str)


        Browser2_str = "http://fanyi.baidu.com/#auto/en/" & sourcestring
        On Error Resume Next
        WebBrowser2.Navigate(Browser2_str)


        Browser3_str = "http://www.iciba.com/" & sourcestring
        On Error Resume Next
        WebBrowser3.Navigate(Browser3_str)
        Debuginfo1.Text = Browser3_str

        Browser4_str = "http://dict.youdao.com/w/" & sourcestring
        On Error Resume Next
        WebBrowser4.Navigate(Browser4_str)



    End Sub

    Private Sub Tmr_getMTpairs_zhen_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairs_zhen.Tick
        If WebBrowser1.ReadyState <> WebBrowserReadyState.Interactive Or WebBrowser2.ReadyState <> WebBrowserReadyState.Interactive Then
            If WebBrowser1.IsBusy = True Or WebBrowser2.IsBusy = True Then
                Exit Sub
            End If

        End If



        On Error Resume Next

        'get google and baidu translation result 
        translationresultgoogle_zhen = WebBrowser1.Document.GetElementById("result_box").InnerText

        Dim baidutargetelement As HtmlElement
        For Each baidutargetelement In WebBrowser2.Document.GetElementsByTagName("p")
            If baidutargetelement.OuterHtml.Contains("ordinary-output target-output clearfix") Then ' Here is a workaround.
                translationresultbaidu_zhen = baidutargetelement.GetAttribute("InnerText")
            End If
        Next

        If translationresultgoogle_zhen = "" Or translationresultbaidu_zhen = "" Then
            Exit Sub
        End If

        If Mid(translationresultgoogle_zhen, 1, 10).Contains("Translat") = True Or Mid(translationresultgoogle_zhen, 1, 10).Contains("正在翻译") = True Then
            Exit Sub
        End If

        If Mid(translationresultbaidu_zhen, 1, 10).Contains("Translat") = True Or Mid(translationresultbaidu_zhen, 1, 10).Contains("正在翻译") = True Then
            Exit Sub
        End If







        Browser3_str = "https://www.google.com/search?q=" & ConvertToUnicodeString(sourcestring & " " & translationresultgoogle_zhen)
        WebBrowser3.Navigate(Browser3_str)


        Browser4_str = "https://www.google.com/search?q=" & ConvertToUnicodeString(sourcestring & " " & translationresultbaidu_zhen)
        WebBrowser4.Navigate(Browser4_str)







        Tmr_getMTpairs_zhen.Stop()
        Tmr_getMTpairhits_zhen.Start()



    End Sub



    Private Sub Tmr_getMTpairhits_zhen_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairhits_zhen.Tick


        If WebBrowser3.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser4.ReadyState <> WebBrowserReadyState.Complete Then
            If WebBrowser3.IsBusy = True Or WebBrowser4.IsBusy = True Then
                Exit Sub
            End If
        End If



        On Error Resume Next
        googleresultstats1 = WebBrowser3.Document.GetElementById("resultStats").InnerText
        googleresultstats2 = WebBrowser4.Document.GetElementById("resultStats").InnerText

        If googleresultstats1 = "" Or googleresultstats2 = "" Then
            Exit Sub
        End If

        googleresultstats1 = Mid(googleresultstats1, 1, googleresultstats1.IndexOf("result"))
        googleresultstats2 = Mid(googleresultstats2, 1, googleresultstats2.IndexOf("result"))






        Browser33_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & sourcestring & "%22" & "+" & "%22" & translationresultgoogle_zhen & "%22")



        Browser44_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & sourcestring & "%22" & "+" & "%22" & translationresultbaidu_zhen & "%22")

        If Browser33_str Is Nothing Or Browser33_str = "" Or Browser44_str Is Nothing Or Browser44_str = "" Then
            Exit Sub
        End If


        WebBrowser3.Navigate(Browser33_str)
        WebBrowser4.Navigate(Browser44_str)




        Tmr_getMTpairhits_zhen.Stop()
        Tmr_getMTpairhits_zhen2.Start()




    End Sub

    Private Sub Btn_html_SE_Click(sender As Object, e As EventArgs) Handles Btn_html_SE.Click, Lookitup.Click



        If WebBrowser7.ReadyState <> WebBrowserReadyState.Complete Then
            Exit Sub

        End If
        Dim domDocument As IHTMLDocument2 = DirectCast(WebBrowser7.Document.DomDocument, IHTMLDocument2)
        Dim selection As IHTMLSelectionObject = domDocument.selection
        If selection IsNot Nothing Then
            Dim range As IHTMLTxtRange = DirectCast(selection.createRange, IHTMLTxtRange)
            If range IsNot Nothing Then
                sourcestring = range.text
            End If
        End If
        If sourcestring = "" Then
            Exit Sub
        End If
        Tbx_search.Text = sourcestring
        keyword = sourcestring

        Searchnow(sourcestring)


    End Sub

    Public Shared Function Num(ByVal value As String) As Integer
        Dim returnVal As String = String.Empty
        Dim collection As MatchCollection = Regex.Matches(value, "\d+")
        For Each m As Match In collection
            returnVal += m.ToString()
        Next
        Return returnVal
    End Function

    Private Sub Tmr_googletranslating_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairhits_enzh.Tick

        If WebBrowser3.ReadyState <> WebBrowserReadyState.Complete Or WebBrowser4.ReadyState <> WebBrowserReadyState.Complete Then
            If WebBrowser3.IsBusy = True Or WebBrowser4.IsBusy = True Then
                Exit Sub
            End If
        End If



        On Error Resume Next
        googleresultstats1 = WebBrowser3.Document.GetElementById("resultStats").InnerText
        googleresultstats2 = WebBrowser4.Document.GetElementById("resultStats").InnerText

        If googleresultstats1 = "" Or googleresultstats2 = "" Then
            Exit Sub
        End If

        googleresultstats1 = Mid(googleresultstats1, 1, googleresultstats1.IndexOf("result"))
        googleresultstats2 = Mid(googleresultstats2, 1, googleresultstats2.IndexOf("result"))






        Browser33_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & sourcestring & "%22" & "+" & "%22" & translationresultgoogle_enzh & "%22")



        Browser44_str = "https://www.google.com/search?q=" & ConvertToUnicodeString("%22" & sourcestring & "%22" & "+" & "%22" & translationresultbaidu_enzh & "%22")

        If Browser33_str Is Nothing Or Browser33_str = "" Or Browser44_str Is Nothing Or Browser44_str = "" Then
            Exit Sub
        End If


        WebBrowser3.Navigate(Browser33_str)
        WebBrowser4.Navigate(Browser44_str)




        Tmr_getMTpairhits_enzh.Stop()
        Tmr_getMTpairhits_enzh2.Start()



    End Sub

    Private Sub Tmr_translate_search_Tick(sender As Object, e As EventArgs) Handles Tmr_getMTpairs_enzh.Tick
        If WebBrowser1.ReadyState <> WebBrowserReadyState.Interactive Or WebBrowser2.ReadyState <> WebBrowserReadyState.Interactive Then
            If WebBrowser1.IsBusy = True Or WebBrowser2.IsBusy = True Then
                Exit Sub
            End If

        End If



        On Error Resume Next

        'get google and baidu translation result 
        translationresultgoogle_enzh = WebBrowser1.Document.GetElementById("result_box").InnerText

        Dim baidutargetelement As HtmlElement
        For Each baidutargetelement In WebBrowser2.Document.GetElementsByTagName("p")
            If baidutargetelement.OuterHtml.Contains("ordinary-output target-output clearfix") Then ' Here is a workaround.
                translationresultbaidu_enzh = baidutargetelement.GetAttribute("InnerText")
            End If
        Next

        If translationresultgoogle_enzh = "" Or translationresultbaidu_enzh = "" Then
            Exit Sub
        End If

        If Mid(translationresultgoogle_enzh, 1, 10).Contains("Translat") = True Or Mid(translationresultgoogle_enzh, 1, 10).Contains("正在翻译") = True Then
            Exit Sub
        End If

        If Mid(translationresultbaidu_enzh, 1, 10).Contains("Translat") = True Or Mid(translationresultbaidu_enzh, 1, 10).Contains("正在翻译") = True Then
            Exit Sub
        End If







        Browser3_str = "https://www.google.com/search?q=" & ConvertToUnicodeString(sourcestring & " " & translationresultgoogle_enzh)
        WebBrowser3.Navigate(Browser3_str)


        Browser4_str = "https://www.google.com/search?q=" & ConvertToUnicodeString(sourcestring & " " & translationresultbaidu_enzh)
        WebBrowser4.Navigate(Browser4_str)







        Tmr_getMTpairs_enzh.Stop()
        Tmr_getMTpairhits_enzh.Start()


    End Sub

    Private Sub Debug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Debuginfo1.Text = WebBrowser4.Url.ToString

        'Debuginfo1.Text = ConvertToUnicodeString(Browser2_str)
        ' Debuginfo2.Text = System.Web.HttpUtility.UrlEncode(Browser2_str)












    End Sub



    Private Sub WebBrowser1_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser1.NewWindow
        e.Cancel = True
        WebBrowser1.Navigate(WebBrowser1.StatusText)

    End Sub

    Private Sub WebBrowser2_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser2.NewWindow
        e.Cancel = True
        WebBrowser2.Navigate(WebBrowser2.StatusText)

    End Sub

    Private Sub WebBrowser3_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser3.NewWindow
        e.Cancel = True
        WebBrowser3.Navigate(WebBrowser3.StatusText)

    End Sub

    Private Sub WebBrowser4_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser4.NewWindow
        e.Cancel = True
        WebBrowser4.Navigate(WebBrowser4.StatusText)

    End Sub

    Private Sub WebBrowser5_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser5.NewWindow
        If readertype = "html" Then
            e.Cancel = True
            WebBrowser7.Navigate(WebBrowser5.StatusText)
        End If

    End Sub

    Private Sub WebBrowser6_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser6.NewWindow
        e.Cancel = True
        WebBrowser6.Navigate(WebBrowser6.StatusText)

    End Sub

    Private Sub WebBrowser7_NewWindow(sender As Object, e As CancelEventArgs) Handles WebBrowser7.NewWindow
        e.Cancel = True
        WebBrowser7.Navigate(WebBrowser7.StatusText)

    End Sub



    Private Sub Tbx_readbrowse_KeyDown(sender As Object, e As KeyEventArgs) Handles Tbx_url.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser7.Navigate(Tbx_url.Text)
            notURL = False

        End If
    End Sub

    Private Sub Tbx_search_DockChanged(sender As Object, e As EventArgs) Handles Tbx_search.DockChanged

    End Sub

    Private Sub Menu_readerhtml_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Rtb_editor_LinkClicked(sender As Object, e As LinkClickedEventArgs) Handles Rtb_editor.LinkClicked


        Dim UrlLink = Split(e.LinkText, "#")
        If UrlLink.Length > 1 Then
            WebBrowser7.Navigate(UrlLink(1))
            notURL = False
        End If
        Me.Text = UrlLink(1)

    End Sub
End Class
