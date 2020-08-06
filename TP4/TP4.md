## Instructions pour réaliser le TP
Je vous rappelle les règles. L’ordinateur nous calcule un nombre aléatoire et nous devons le deviner. 
À chaque saisie, il nous indique si le nombre saisi est plus grand ou plus petit que le nombre à trouver. 
Une fois trouvé, il nous indique en combien de coups nous avons réussi à trouver le nombre secret.

Pour ce TP, vous savez presque tout faire. Il ne vous manque que l’instruction pour obtenir un nombre aléatoire. 
La voici, cette instruction permet de renvoyer un nombre compris entre 0 et 100 (exclu). 
Ne vous attardez pas trop sur sa syntaxe, nous aurons l’occasion de comprendre exactement de quoi il s’agit dans le chapitre suivant :

```
int valeurATrouver = new Random().Next(0, 100);
```
Le principe est grosso modo le suivant : tant qu’on n’a pas trouvé la bonne valeur, nous devons en saisir une nouvelle. 
Dans ce cas, la console nous indique si la valeur est trop grande ou trop petite. 
Il faudra bien sur incrémenter un compteur de coups à chaque essai.

N’oubliez pas de gérer le cas où l’utilisateur saisit n’importe quoi. 
Nous ne voudrions pas que notre premier jeu ait un bug qui fasse planter l’application !

Allez, je vous en ai trop dit. C’est à vous de jouer. Bon courage.