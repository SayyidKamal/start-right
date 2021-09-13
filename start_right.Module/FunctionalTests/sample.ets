;#DropDB start rightEasyTest

#Application start rightWin
#Application start rightWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef start rightWin

*Action About...
 
*Action OK

#EndIf

#IfDef start rightWeb
*Action Navigation(My Details)
#EndIf
