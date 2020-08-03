Le but de ce TP va �tre de cr�er 3 m�thodes.

La premi�re va servir � calculer la sommes d'entiers cons�cutifs. 
Si par exemple je veux calculer la somme des entiers de 1 � 10, 
c'est � dire 1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10, je vais appeler cette 
m�thode en lui passant en param�tres 1 et 10, c'est-�-dire les bornes des 
entiers dont il faut faire la somme.

Quelque chose du genre :

```
Console.WriteLine(CalculSommeEntiers(1, 10));
Console.WriteLine(CalculSommeEntiers(1, 100));
```
Sachant que le premier r�sultat de cet exemple vaut 55 
(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 = 55) et le deuxi�me 5050.

La deuxi�me m�thode acceptera une liste de double en param�tres et 
devra renvoyer la moyenne des doubles de la liste. Par exemple :

```
List<double> liste = new List<double> { 1.0, 5.5, 9.9, 2.8, 9.6};
Console.WriteLine(CalculMoyenne(liste));
```
Le r�sultat de cet exemple vaut 5.76.

Enfin, la derni�re m�thode devra dans un premier temps construire 
une liste d�entiers de 1 � 100 qui sont des multiples de 3 (3, 6, 9, 12, �). 
Dans un second temps, construire une autre liste d�entiers de 1 � 100 
qui sont des multiples de 5 (5, 10, 15, 20, �). Et dans un dernier temps, 
il faudra calculer la somme des entiers qui sont communs aux deux listes � 
vous devez bien sur trouver 630 comme r�sultat :)
