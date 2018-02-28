Option Strict Off
Public Class Setting



    Public Sub read_settings()
        'Retrieve user-defined settings including configured search strings and customized engine names from the application.
        Lbl_filename.Text = “File name not defined"
        Cbx_autosave.Checked = False

        Tbx_scrX1.Text = My.Settings.ScrollX1
        Tbx_scrX2.Text = My.Settings.ScrollX2
        Tbx_scrX3.Text = My.Settings.ScrollX3
        Tbx_scrX4.Text = My.Settings.ScrollX4

        Tbx_scrX11.Text = My.Settings.ScrollX11
        Tbx_scrX12.Text = My.Settings.ScrollX12
        Tbx_scrX13.Text = My.Settings.ScrollX13
        Tbx_scrX14.Text = My.Settings.ScrollX14

        Tbx_scrX21.Text = My.Settings.ScrollX21
        Tbx_scrX22.Text = My.Settings.ScrollX22
        Tbx_scrX23.Text = My.Settings.ScrollX23
        Tbx_scrX24.Text = My.Settings.ScrollX24

        Tbx_scrX31.Text = My.Settings.ScrollX31
        Tbx_scrX32.Text = My.Settings.ScrollX32
        Tbx_scrX33.Text = My.Settings.ScrollX33
        Tbx_scrX34.Text = My.Settings.ScrollX34

        Tbx_scrY1.Text = My.Settings.ScrollY1
        Tbx_scrY2.Text = My.Settings.ScrollY2
        Tbx_scrY3.Text = My.Settings.ScrollY3
        Tbx_scrY4.Text = My.Settings.ScrollY4

        Tbx_scrY11.Text = My.Settings.ScrollY11
        Tbx_scrY12.Text = My.Settings.ScrollY12
        Tbx_scrY13.Text = My.Settings.ScrollY13
        Tbx_scrY14.Text = My.Settings.ScrollY14

        Tbx_scrY21.Text = My.Settings.ScrollY21
        Tbx_scrY22.Text = My.Settings.ScrollY22
        Tbx_scrY23.Text = My.Settings.ScrollY23
        Tbx_scrY24.Text = My.Settings.ScrollY24

        Tbx_scrY31.Text = My.Settings.ScrollY31
        Tbx_scrY32.Text = My.Settings.ScrollY32
        Tbx_scrY33.Text = My.Settings.ScrollY33
        Tbx_scrY34.Text = My.Settings.ScrollY34

        Tbx_scale1.Text = My.Settings.Scale1
        Tbx_scale2.Text = My.Settings.Scale2
        Tbx_scale3.Text = My.Settings.Scale3
        Tbx_scale4.Text = My.Settings.Scale4

        Tbx_scale11.Text = My.Settings.Scale11
        Tbx_scale12.Text = My.Settings.Scale12
        Tbx_scale13.Text = My.Settings.Scale13
        Tbx_scale14.Text = My.Settings.Scale14

        Tbx_scale21.Text = My.Settings.Scale21
        Tbx_scale22.Text = My.Settings.Scale22
        Tbx_scale23.Text = My.Settings.Scale23
        Tbx_scale24.Text = My.Settings.Scale24

        Tbx_scale31.Text = My.Settings.Scale31
        Tbx_scale32.Text = My.Settings.Scale32
        Tbx_scale33.Text = My.Settings.Scale33
        Tbx_scale34.Text = My.Settings.Scale34



        TabControl1.SelectedIndex = My.Settings.SetTabID

        TabControl1.TabPages(0).Text = My.Settings.SEtab1
        TabControl1.TabPages(1).Text = My.Settings.SEtab2
        TabControl1.TabPages(2).Text = My.Settings.SEtab3
        TabControl1.TabPages(3).Text = My.Settings.SEtab4

        TabControl1.TabPages(0).Text = My.Settings.SEtab1
        TabControl1.TabPages(1).Text = My.Settings.SEtab2
        TabControl1.TabPages(2).Text = My.Settings.SEtab3
        TabControl1.TabPages(3).Text = My.Settings.SEtab4

        Tbx_se1name.Text = My.Settings.SEname1
        Tbx_se2name.Text = My.Settings.SEname2
        Tbx_se3name.Text = My.Settings.SEname3
        Tbx_se4name.Text = My.Settings.SEname4

        Tbx_se1.Text = My.Settings.SearchEngine1
        Tbx_se2.Text = My.Settings.SearchEngine2
        Tbx_se3.Text = My.Settings.SearchEngine3
        Tbx_se4.Text = My.Settings.SearchEngine4

        Tbx_se11name.Text = My.Settings.SEname11
        Tbx_se12name.Text = My.Settings.SEname12
        Tbx_se13name.Text = My.Settings.SEname13
        Tbx_se14name.Text = My.Settings.SEname14

        Tbx_se11.Text = My.Settings.SearchEngine11
        Tbx_se12.Text = My.Settings.SearchEngine12
        Tbx_se13.Text = My.Settings.SearchEngine13
        Tbx_se14.Text = My.Settings.SearchEngine14

        Tbx_se21name.Text = My.Settings.SEname21
        Tbx_se22name.Text = My.Settings.SEname22
        Tbx_se23name.Text = My.Settings.SEname23
        Tbx_se24name.Text = My.Settings.SEname24

        Tbx_se21.Text = My.Settings.SearchEngine21
        Tbx_se22.Text = My.Settings.SearchEngine22
        Tbx_se23.Text = My.Settings.SearchEngine23
        Tbx_se24.Text = My.Settings.SearchEngine24

        Tbx_se31name.Text = My.Settings.SEname31
        Tbx_se32name.Text = My.Settings.SEname32
        Tbx_se33name.Text = My.Settings.SEname33
        Tbx_se34name.Text = My.Settings.SEname34

        Tbx_se31.Text = My.Settings.SearchEngine31
        Tbx_se32.Text = My.Settings.SearchEngine32
        Tbx_se33.Text = My.Settings.SearchEngine33
        Tbx_se34.Text = My.Settings.SearchEngine34



    End Sub
    Public Sub save_settings()
        'Save user-defined settings including configured search strings and customized engine names to the application.




        My.Settings.ScrollX1 = Tbx_scrX1.Text
        My.Settings.ScrollX2 = Tbx_scrX2.Text
        My.Settings.ScrollX3 = Tbx_scrX3.Text
        My.Settings.ScrollX4 = Tbx_scrX4.Text

        My.Settings.ScrollX11 = Tbx_scrX11.Text
        My.Settings.ScrollX12 = Tbx_scrX12.Text
        My.Settings.ScrollX13 = Tbx_scrX13.Text
        My.Settings.ScrollX14 = Tbx_scrX14.Text

        My.Settings.ScrollX21 = Tbx_scrX21.Text
        My.Settings.ScrollX22 = Tbx_scrX22.Text
        My.Settings.ScrollX23 = Tbx_scrX23.Text
        My.Settings.ScrollX24 = Tbx_scrX24.Text

        My.Settings.ScrollX31 = Tbx_scrX31.Text
        My.Settings.ScrollX32 = Tbx_scrX32.Text
        My.Settings.ScrollX33 = Tbx_scrX33.Text
        My.Settings.ScrollX34 = Tbx_scrX34.Text

        My.Settings.ScrollY1 = Tbx_scrY1.Text
        My.Settings.ScrollY2 = Tbx_scrY2.Text
        My.Settings.ScrollY3 = Tbx_scrY3.Text
        My.Settings.ScrollY4 = Tbx_scrY4.Text

        My.Settings.ScrollY11 = Tbx_scrY11.Text
        My.Settings.ScrollY12 = Tbx_scrY12.Text
        My.Settings.ScrollY13 = Tbx_scrY13.Text
        My.Settings.ScrollY14 = Tbx_scrY14.Text

        My.Settings.ScrollY21 = Tbx_scrY21.Text
        My.Settings.ScrollY22 = Tbx_scrY22.Text
        My.Settings.ScrollY23 = Tbx_scrY23.Text
        My.Settings.ScrollY24 = Tbx_scrY24.Text

        My.Settings.ScrollY31 = Tbx_scrY31.Text
        My.Settings.ScrollY32 = Tbx_scrY32.Text
        My.Settings.ScrollY33 = Tbx_scrY33.Text
        My.Settings.ScrollY34 = Tbx_scrY34.Text

        My.Settings.Scale1 = Tbx_scale1.Text
        My.Settings.Scale2 = Tbx_scale2.Text
        My.Settings.Scale3 = Tbx_scale3.Text
        My.Settings.Scale4 = Tbx_scale4.Text

        My.Settings.Scale11 = Tbx_scale11.Text
        My.Settings.Scale12 = Tbx_scale12.Text
        My.Settings.Scale13 = Tbx_scale13.Text
        My.Settings.Scale14 = Tbx_scale14.Text

        My.Settings.Scale21 = Tbx_scale21.Text
        My.Settings.Scale22 = Tbx_scale22.Text
        My.Settings.Scale23 = Tbx_scale23.Text
        My.Settings.Scale24 = Tbx_scale24.Text

        My.Settings.Scale31 = Tbx_scale31.Text
        My.Settings.Scale32 = Tbx_scale32.Text
        My.Settings.Scale33 = Tbx_scale33.Text
        My.Settings.Scale34 = Tbx_scale34.Text


        My.Settings.SetTabID = TabControl1.SelectedIndex
        My.Settings.SEtab1 = TabControl1.TabPages(0).Text
        My.Settings.SEtab2 = TabControl1.TabPages(1).Text
        My.Settings.SEtab3 = TabControl1.TabPages(2).Text
        My.Settings.SEtab4 = TabControl1.TabPages(3).Text

        My.Settings.SEname1 = Tbx_se1name.Text
        My.Settings.SEname2 = Tbx_se2name.Text
        My.Settings.SEname3 = Tbx_se3name.Text
        My.Settings.SEname4 = Tbx_se4name.Text

        My.Settings.SearchEngine1 = Tbx_se1.Text
        My.Settings.SearchEngine2 = Tbx_se2.Text
        My.Settings.SearchEngine3 = Tbx_se3.Text
        My.Settings.SearchEngine4 = Tbx_se4.Text

        My.Settings.SEname11 = Tbx_se11name.Text
        My.Settings.SEname12 = Tbx_se12name.Text
        My.Settings.SEname13 = Tbx_se13name.Text
        My.Settings.SEname14 = Tbx_se14name.Text

        My.Settings.SearchEngine11 = Tbx_se11.Text
        My.Settings.SearchEngine12 = Tbx_se12.Text
        My.Settings.SearchEngine13 = Tbx_se13.Text
        My.Settings.SearchEngine14 = Tbx_se14.Text

        My.Settings.SEname21 = Tbx_se21name.Text
        My.Settings.SEname22 = Tbx_se22name.Text
        My.Settings.SEname23 = Tbx_se23name.Text
        My.Settings.SEname24 = Tbx_se24name.Text

        My.Settings.SearchEngine21 = Tbx_se21.Text
        My.Settings.SearchEngine22 = Tbx_se22.Text
        My.Settings.SearchEngine23 = Tbx_se23.Text
        My.Settings.SearchEngine24 = Tbx_se24.Text

        My.Settings.SEname31 = Tbx_se31name.Text
        My.Settings.SEname32 = Tbx_se32name.Text
        My.Settings.SEname33 = Tbx_se33name.Text
        My.Settings.SEname34 = Tbx_se34name.Text

        My.Settings.SearchEngine31 = Tbx_se31.Text
        My.Settings.SearchEngine32 = Tbx_se32.Text
        My.Settings.SearchEngine33 = Tbx_se33.Text
        My.Settings.SearchEngine34 = Tbx_se34.Text



        My.Settings.Save()
    End Sub


    Private Sub Setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        read_settings()


    End Sub

    Private Sub Btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_save.Click
        save_settings()
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub Setting_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        read_settings()


        Cbx_autosave.Checked = True
    End Sub

    Private Sub Btn_apply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_apply.Click
        save_settings()
    End Sub

    Private Sub Btn_applysearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_applysearch.Click
        save_settings()
        Main.Searchnow(Main.Tbx_search.Text)
    End Sub

    Private Sub Btn_changetabname_Click(sender As Object, e As EventArgs) Handles Btn_changetabname.Click

        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty

        Dim answer As Object
        ' Set prompt.
        prompt = "Pleae enter the Tab Name"
        ' Set title.
        title = "Set the current Tab Name"
        ' Set default value.
        defaultResponse = "TabName"

        ' Display prompt, title, and default value.
        answer = InputBox(prompt, title, defaultResponse)

        ' Say something to the user
        If answer = "" Then
            Exit Sub
        Else
            TabControl1.SelectedTab.Text = answer
        End If


    End Sub





    Private Sub Cbx_autosave_CheckedChanged(sender As Object, e As EventArgs) Handles Cbx_autosave.CheckedChanged
        autosave()

    End Sub
    Public Sub autosave()
        If Cbx_autosave.Checked = True Then

            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.InitialDirectory = Application.ExecutablePath
            SaveFileDialog1.DefaultExt = "rtf"
            SaveFileDialog1.FileName = ""
            SaveFileDialog1.Filter = "Rich Text Files (*.rtf)|*.rtf|All Files (*.*) | *.*"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                Main.Timer1.Stop()
                Lbl_filename.Text = "File Name Not Defined"
                Cbx_autosave.Checked = False
                My.Settings.Autofilename = Lbl_filename.Text
                My.Settings.Autosave = Cbx_autosave.Checked
            Else
                Main.Timer1.Start()
                Main.Rtb_editor.SaveFile(SaveFileDialog1.FileName)
                Lbl_filename.Text = SaveFileDialog1.FileName
                My.Settings.Autofilename = Lbl_filename.Text
                My.Settings.Autosave = True
            End If
        Else
            Main.Timer1.Stop()
            Lbl_filename.Text = "File Name Not Defined"
            Cbx_autosave.Checked = False
            My.Settings.Autofilename = Lbl_filename.Text
            My.Settings.Autosave = Cbx_autosave.Checked

        End If
    End Sub
End Class