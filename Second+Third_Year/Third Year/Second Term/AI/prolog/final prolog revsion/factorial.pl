factorial(N):-
	fact(N,M),
	write(M),nl.
fact(0,1).
fact(N,M):-
	Y is N-1,
	fact(Y,Z),
	M is Z*N.