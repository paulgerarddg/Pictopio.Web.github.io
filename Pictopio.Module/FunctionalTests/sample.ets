;#DropDB PictopioEasyTest

#Application PictopioWin
#Application PictopioBlazor

*FillForm
 User Name = Admin
*Action Log In

#IfDef PictopioWin

*Action About...
 
*Action OK

#EndIf

#IfDef PictopioBlazor
*Action Navigation(My Details)
#EndIf
