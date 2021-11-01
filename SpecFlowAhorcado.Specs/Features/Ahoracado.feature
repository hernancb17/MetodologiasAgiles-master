Feature: Ahorcado
	Para evitar errores voy a insertar caracteres invalidos

@ingresoCaracterInvalido
Scenario: Ingresar caracter invalido en un juego
	Given presiono jugar
	And tecleo el caracter @
	When presiono la tecla ENTER
	Then el sistema deberia decirme: Ingrese un caracter valido
