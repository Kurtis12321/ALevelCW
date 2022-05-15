Public Class Form_PayrollManagement

    Private netpay As Double
    Private grosspay As Double
    Private week, hour, weekend, weekendhour As Double
    Private dec, tax As Double

    'Calculate the payroll
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        week = Convert.ToDouble(txtWeekDaysWorked.Text) * 125
        weekend = Convert.ToDouble(txtWeekendsWorked.Text) * 160
        hour = Convert.ToDouble(txtWeekDayWage.Text) * 180
        weekendhour = Convert.ToDouble(txtWeekendWage.Text) * 145

        grosspay = (week + hour + weekend + weekendhour)
        dec = grosspay * (10 / 100)
        tax = grosspay * (15 / 100)
        netpay = grosspay - tax - dec

        txtGross.Text = grosspay
        txtDec.Text = dec
        txtTax.Text = tax
        txtNetpay.Text = netpay
    End Sub

    Private Sub Form_PayrollManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaffTableAdapter.Fill(Me.Database_POSSystemDataSet.Staff) 'fill the employee information with data from the database
    End Sub

    'Move to the previous record
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Me.StaffBindingSource.MovePrevious()
    End Sub

    'move to next record
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.StaffBindingSource.MoveNext()
    End Sub
End Class