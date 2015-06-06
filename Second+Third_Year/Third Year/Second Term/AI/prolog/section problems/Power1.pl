power(X,N):-
	pow(X,N,Y),
	write(Y).
%--------------------------------------
pow(X,0,1).
pow(X,N,Y):-
	Z  is N-1,%N>0,
	pow(X,Z,NY),
	Y is X*NY.