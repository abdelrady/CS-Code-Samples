factorial(N):-
	fact(N,F),
	write(F).
fact(0,1).
fact(N,F):-
	M is N-1,
	fact(M,NF),
	F is N*NF.