Projet d'initiation à VS .NET C#

## Les différents types

|   Type  	|                                                         Description                                                        	|
|:-------:	|:--------------------------------------------------------------------------------------------------------------------------:	|
|   byte  	|                                                      Entier de 0 à 255                                                     	|
|  short  	|                                                  Entier de -32768 à 32767                                                  	|
|   int   	|                                             Entier de -2147483648 à 2147483647                                             	|
|   long  	|                                    Entier de -9223372036854775808 à 9223372036854775807                                    	|
|  float  	|                                    Nombre simple précision de -3,402823e38 à 3,402823e38                                   	|
|  double 	|                           Nombre double précision de -1,79769313486232e308 à 1,79769313486232e308                          	|
| decimal 	| Nombre décimal convenant particulièrement aux calculs financiers (en raison de ses nombres significatifs après la virgule) 	|
|   char  	|                                                   Représente un caractère                                                  	|
|  string 	|                                                   Une chaine de caractère                                                  	|
|   bool  	|                                              Une valeur booléenne (vrai/faux)                                              	|

## Opérations et concaténation

Faire attention aux types lors de calculs.
Ex : Si l'on calcule des int -> le résultat sera un chiffre entier. 
Si l'on veut des décimaux il faudrait prévilégier les doubles. 
Et ajouter des .0, ou sinon il ne reconnaît pas que ce sont des doubles !
Si l'on fait des additions entre strings, une concaténation aura lieu.

## Caractères spéciaux

On utilise \ avant tout caractère spécial dans un string.
Retour à la ligne \n ou Environment.NewLine
Tabulation \t

## Opérateurs
|   Type  	| Description			|
|:-------:	|:---------------:		|
|   ==  	| Egalité				|
|  !=  		| Différence			|
|   >   	| Supérieur à			|
|   <  		| Inférieur à			|
|  >=  		| Supérieur ou égal à	|
|  <= 		| Inférieur ou égal à	|
| && 		| ET logique 			|
|   ||  	| OU logique			|
|  ! 		| Négation				|

