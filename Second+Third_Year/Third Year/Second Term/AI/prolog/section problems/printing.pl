% printing the numbers btween two number
% need some modification
print1(S,E):-
	pri(S,E).
pri(1,_).
pri(S,E):-
	S>E,
	pri(E,S).
pri(S,E):-
	S<E,
	write(S),
	nl,
	NS is S+1,
	pri(NS,E).