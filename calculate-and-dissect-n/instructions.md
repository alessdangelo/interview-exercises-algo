## Languages
> [Français](#français)   
> [English](#english)

## Français
### Votre programme doit calculer :
1. _N_, le plus petit nombre **supérieur** ou **égal** à _100’000’000_ qui soit multiple de _3, 5, 7 et 9_ votre programme doit afficher N sur la première ligne, par exemple “`N = 100004123`” (ceci n’est pas le résultat correct, uniquement un exemple illustratif)
   exemple : `S = 100004123`
2. L, la liste des chiffres du nombre N
   votre programme doit afficher L sur la deuxième ligne, par exemple “`L = 1, 0, 0, 0, 0, 4, 1, 2, 3`”
   exemple : si `S = 100004123`, alors `L = 1, 0, 0, 0, 0, 4, 1, 2, 3`
   note: vous pouvez afficher les éléments entre [] ou non, séparés par un espace, une virgule, ou n’importe quel autre caractère ; l’affichage n’est pas un critère de jugement
3. L’, une liste “encodant” L qui, pour chaque élément de L, contient :
- soit la lettre E suivie de l’élément, si cet élément apparaît pour la première fois
- soit la lettre R suivie de la position de la première apparition de l’élément, si c’est
  une répétition d’élément
- exemple : si `L = 1, 0, 0, 0, 0, 4, 1, 2, 3` alors `L’ = E1, E0, R2, R2, R2, E4, R1, E2, E3`
  - le 1e élément de L’ est E1 car c’est la première fois que “1” apparait dans L
  - le 2e élément de L’ est E0 car c’est la première fois que “0” apparait dans L
  - le 3e élément de L’ est R2 car “0” est une répétition de l’élément en position 2
    dans L
  - le 4e élément de L’ est R2 car “0” est une répétition de l’élément en position 2
    dans L
  - le 5e élément de L’ est R2 car “0” est une répétition de l’élément en position 2
    dans L
  - le 6e élément de L’ est E4 car c’est la première fois que “4” apparait dans L
  - le 7e élément de L’ est R1 car “1” est une répétition de l’élément en position 1
    dans L
  - le 8e élément de L’ est E2 car c’est la première fois que “2” apparait dans L
  - le 9e élément de L’ est E3 car c’est la première fois que “3” apparait dans L
    note : la position commence à 1, et non à 0 comme les index en informatique ; c’est pour cela que vous voyez par exemple R2 dans l’exemple ci-dessus, pour référencer le premier “0” de la liste, qui est en deuxième position.

## English
### Your program must calculate:
1. _N_, the smallest number **greater than or equal to** _100,000,000_ which is a multiple of _3, 5, 7, and 9_. Your program should display N on the first line, for example, "`N = 100004123`" (this is not the correct result, only an illustrative example).
   Example: `S = 100004123`
2. L, the list of digits of the number N.
   Your program should display L on the second line, for example, "`L = 1, 0, 0, 0, 0, 4, 1, 2, 3`".
   Example: `if S = 100004123`, then `L = 1, 0, 0, 0, 0, 4, 1, 2, 3`.
   Note: you can display the elements within [] or not, separated by a space, a comma, or any other character; the display is not a judgment criterion.
3. L', a list "encoding" L which, for each element of L, contains:
- either the letter E followed by the element, if this element appears for the first time
- or the letter R followed by the position of the first appearance of the element, if it is a repetition of the element.
- Example: `if L = 1, 0, 0, 0, 0, 4, 1, 2, 3` then `L' = E1, E0, R2, R2, R2, E4, R1, E2, E3`.
    - the 1st element of L' is E1 because it is the first time "1" appears in L.
    - the 2nd element of L' is E0 because it is the first time "0" appears in L.
    - the 3rd element of L' is R2 because "0" is a repetition of the element in position 2 in L.
    - the 4th element of L' is R2 because "0" is a repetition of the element in position 2 in L.
    - the 5th element of L' is R2 because "0" is a repetition of the element in position 2 in L.
    - the 6th element of L' is E4 because it is the first time "4" appears in L.
    - the 7th element of L' is R1 because "1" is a repetition of the element in position 1 in L.
    - the 8th element of L' is E2 because it is the first time "2" appears in L.
    - the 9th element of L' is E3 because it is the first time "3" appears in L.
      Note: the position starts at 1, not 0 as in computer indexing; that's why you see, for example, R2 in the example above, to reference the first "0" in the list, which is in the second position.