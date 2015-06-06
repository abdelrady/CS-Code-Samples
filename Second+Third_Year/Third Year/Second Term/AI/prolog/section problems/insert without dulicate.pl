member(X,[X|T]):- !.
member(X,[_|T]):-
	member(X,T).
insert(X,L,L):-
	member(X,L),!.
insert(X,L,[X|L]).
