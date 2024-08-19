Option Strict Off
Option Explicit On
Friend Class Frm_Main
	Inherits System.Windows.Forms.Form
	
	Private Sub Command1_Click()
		Image1.Image = Nothing
		Image1.Image = Ige_PIC(9).Image
	End Sub
	
	Private Sub Frm_Main_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        PicInit()
	End Sub
	
	
	'*************************************************************************
	'**�� �� �W�GPicInit
	'**��    �J�G�L
	'**��    �X�G�L
	'**�\��y�z�G�Ω��l���H���Ϥ�
	'**�����ܶq�G
	'**�եμҶ��G
	'**�@    �̡Gmrlbb
	'**��    ���G2009-07-02 10:29:58
	'**�� �� �H�G
	'**��    ���G
	'**��    ���GV1.0.0
	'*************************************************************************
	Private Sub PicInit()
		Dim i As Short
		Dim iPicNum As Short
		For i = 0 To 99
			Randomize()
			iPicNum = Rnd() * 19
			Ige_PIC(i).Image = Frm_Temp.Ige(iPicNum).Image
		Next i
		Randomize()
		iPicNum = Rnd() * 19
		For i = 9 To 81 Step 9
			Ige_PIC(i).Image = Frm_Temp.Ige(iPicNum).Image
		Next i
	End Sub
	
	Private Sub Frm_Main_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		End
	End Sub
	
	Private Sub Picture1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture1.Click '��ܹϼ�
		Image1.Image = Ige_PIC(9).Image
	End Sub
	
	Private Sub Picture2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture2.Click '�A�Ӥ@��
		Image1.Image = Nothing
		PicInit()
	End Sub
End Class