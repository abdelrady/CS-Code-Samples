dup([],[]).
dup([H|T],[H,H|X]):-
dup(T,X).