% printing the numbers btween two number
print1(S,E):-
	pri(S,E).
pri(0,_).
pri(S,E):-
	S<E,
	pri(E,S).
pri(S,E):-
	S>E
	write(S),
	NS is S-1,
	pri(NS,E).