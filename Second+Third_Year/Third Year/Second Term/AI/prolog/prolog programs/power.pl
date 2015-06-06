power(X,N):-
	pow(X,N,Z),
	write(Z),
	nl.
pow(X,N,Z):-
	N=0,
	Z is 1.
pow(X,N,Z):-
	M is N-1,
	pow(X,M,W),
	Z is W*X,
	nl.
	