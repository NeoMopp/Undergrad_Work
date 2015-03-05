%Question 1
average(L, X) :- 
		sum(L, Sum),
		length(L, Length),
		X is Sum / Length.

sum([],0).
sum([H|T], Sum):-
		sum(T, Temp),
		Sum is Temp + H.

length([], 0).
length([_|B], Ln):-
		length(B, Ln1),
		Ln is Ln1 + 1.

%Question 2		
delete_nth(1, [X|L1] , L1).
delete_nth(N, [H|L1], [H|L2]):-
		N1 is N-1,
		delete_nth(N1,L1,L2).
		

%Question 3		
instance(city, lincoln).
instance(city, london).
instance(town, boston).

subclass(building, cathedral).
subclass(building, townhall).
subclass(settlement, city).
subclass(settlement, town).

has(townhall, city).
has(townhall, town).
has(cathedral, city).

has(stmarys, lincoln).

		
has(X, Place):-
		instance(Y, Place),
		has(X, Y).

has(X, Place):-
		instance(Y, Place),
		subclass(X,T),
		has(T,Y).
			
