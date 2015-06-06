power(X,Y):-
 	pow(X,Y,1).
pow(X,0,N):-
	write(N).
pow(X,Y,N):-
	T is N*X,
	K is Y-1,
	pow(X,K,T).
	
