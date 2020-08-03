Projet d'initiation � VS .NET C#

## Les diff�rents types

|   Type  	|                                                         Description                                                        	|
|:-------:	|:--------------------------------------------------------------------------------------------------------------------------:	|
|   byte  	|                                                      Entier de 0 � 255                                                     	|
|  short  	|                                                  Entier de -32768 � 32767                                                  	|
|   int   	|                                             Entier de -2147483648 � 2147483647                                             	|
|   long  	|                                    Entier de -9223372036854775808 � 9223372036854775807                                    	|
|  float  	|                                    Nombre simple pr�cision de -3,402823e38 � 3,402823e38                                   	|
|  double 	|                           Nombre double pr�cision de -1,79769313486232e308 � 1,79769313486232e308                          	|
| decimal 	| Nombre d�cimal convenant particuli�rement aux calculs financiers (en raison de ses nombres significatifs apr�s la virgule) 	|
|   char  	|                                                   Repr�sente un caract�re                                                  	|
|  string 	|                                                   Une chaine de caract�re                                                  	|
|   bool  	|                                              Une valeur bool�enne (vrai/faux)                                              	|

## Op�rations et concat�nation

Faire attention aux types lors de calculs.
Ex : Si l'on calcule des int -> le r�sultat sera un chiffre entier. 
Si l'on veut des d�cimaux il faudrait pr�vil�gier les doubles. 
Et ajouter des .0, ou sinon il ne reconna�t pas que ce sont des doubles !
Si l'on fait des additions entre strings, une concat�nation aura lieu.

## Caract�res sp�ciaux

On utilise \ avant tout caract�re sp�cial dans un string.
Retour � la ligne \n ou Environment.NewLine
Tabulation \t

## Op�rateurs
|   Type  	| Description			|
|:-------:	|:---------------:		|
|   ==  	| Egalit�				|
|  !=  		| Diff�rence			|
|   >   	| Sup�rieur �			|
|   <  		| Inf�rieur �			|
|  >=  		| Sup�rieur ou �gal �	|
|  <= 		| Inf�rieur ou �gal �	|
| && 		| ET logique 			|
|   ||  	| OU logique			|
|  ! 		| N�gation				|

