factorial(N):-
	fact(N,M),
	write(M),
	nl.
fact(N,M):-
	N= 0,
	M is 1.
fact(N,M):-
	Y is N-1,
	fact(Y,S),
	M is N*S.
	