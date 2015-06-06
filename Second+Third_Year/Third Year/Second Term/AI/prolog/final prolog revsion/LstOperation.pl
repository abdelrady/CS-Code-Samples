%printing the list elements.
print1([]).
print1([H|T]):-
	write(H),nl,
	print1(T).
%------------------------------------
%multiplication alist with element.
mul(E,[],[]).
mul(E,[H|T],[M|NT]):-
	M is E*H,
	mul(E,T,NT).
%------------------------------------
member(X,[X|_]).
member(X,[H|T]):-
	member(X,T).
%------------------------------------
subset([],_).
subset([H|T],L):-
	member(H,L),
	subset(T,L).