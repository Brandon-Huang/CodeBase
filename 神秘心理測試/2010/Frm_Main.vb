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
	'**函 數 名：PicInit
	'**輸    入：無
	'**輸    出：無
	'**功能描述：用於初始化隨機圖片
	'**全局變量：
	'**調用模塊：
	'**作    者：mrlbb
	'**日    期：2009-07-02 10:29:58
	'**修 改 人：
	'**日    期：
	'**版    本：V1.0.0
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
	
	Private Sub Picture1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture1.Click '顯示圖標
		Image1.Image = Ige_PIC(9).Image
	End Sub
	
	Private Sub Picture2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture2.Click '再來一次
		Image1.Image = Nothing
		PicInit()
	End Sub
End Class