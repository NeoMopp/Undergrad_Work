% Fact section. Do not modify, add or delete facts. 
female(lora).
female(amanda).
female(carolyn).
female(sara).
female(aileen).
female(emily).
male(david).
male(andrew).
male(tom).
male(adam).
male(shaun).
parent(lora, amanda).
parent(lora, tom).
parent(lora, carolyn).
parent(david, amanda).
parent(david, tom).
parent(andrew, carolyn).
parent(amanda, sara).
parent(amanda, adam).
parent(tom, shaun).
parent(tom, aileen).
parent(carolyn, emily).

% Predicate section. Please complete the following code.
mother(X, Y) :- 
	parent(X,Y), 
	female(X).

father(X, Y) :-
	parent(X,Y), 
	male(X).

child(X, Y) :-
	parent(Y,X).

daughter(X, Y) :-
	child(X,Y), 
	female(X).

son(X, Y) :-
	child(X,Y), 
	male(X).

sister(X, Y) :-
	sibling(X,Y),
	female(X).

brother(X, Y) :-
	sibling(X,Y),
	male(X).

sibling(X, Y) :-
	(mother(Z,X),
	mother(T,Y),
	Z=T, 
	X\==Y);
	(father(Z,X),
	father(T,Y),
	Z=T, 
	X\==Y).

uncle(X, Y):-
	(mother(Z,Y),
	brother(X,Z));
	(father(Z,Y),
	brother(X,Z)).

aunt(X, Y):-
	(mother(Z,Y),
	sister(X,Z));
	(father(Z,Y),
	sister(X,Z)).

cousin(X, Y):-
	(mother(Z,X),
	aunt(Z,Y));
	(father(Z,X),
	uncle(Z,Y)).
	
% Question 4 starts here.
relative(X,Y):-
	(parent(X,Y);
	sibling(X,Y);
	child(X,Y);
	cousin(X,Y)),
	X \= Y.

relative(X,Y):-
	(parent(Z,X),
	relative(Z,Y)).
	
% Question 5 starts here.

divide_by(X, D, 0, X):- 
			X < D.

divide_by(X, D, I, R):-
			X >= D,
			X1 is X - D,
			divide_by(X1, D, I1, R),
			I is I1 + 1.
